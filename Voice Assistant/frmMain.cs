using System;
using System.Drawing;
using System.Windows.Forms;

using System.Speech.Recognition;
using System.Speech.Synthesis;

using System.Diagnostics;

using System.Data.SqlClient;
using System.Data;
using System.Collections.Generic;

using Voice_Assistant.Properties;

namespace Voice_Assistant
{
    public partial class frmMain : Form
    {
        private string connectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\\Commands.mdf;Integrated Security=True";

        private DataTable dt = new DataTable();
        private Command currentCommand;
        private List<Command> Commands = new List<Command>();
        private List<string> VoiceCommands = new List<string>();

        private SpeechRecognitionEngine sre = new SpeechRecognitionEngine();
        private SpeechRecognitionEngine activate = new SpeechRecognitionEngine();
        private SpeechRecognitionEngine verification = new SpeechRecognitionEngine();
        public  SpeechSynthesizer ss = new SpeechSynthesizer();

        public frmMain()
        {
            InitializeComponent();

            Location = new Point(Screen.PrimaryScreen.WorkingArea.Width - Width - 20, Screen.PrimaryScreen.WorkingArea.Height - Height - 20);

            soundWave.SizeMode = PictureBoxSizeMode.Zoom;

            //setting the voice
            ss.SelectVoice("Microsoft Zira Desktop");

            //Commmand speech recognition engine
            sre.SpeechRecognized += sre_SpeechRecognized;

            activate.LoadGrammar(new Grammar(new GrammarBuilder(new Choices(new string[] { "Hey Assistant" }))));
            activate.SpeechRecognized += activate_SpeechRecognized;

            verification.LoadGrammar(new Grammar(new GrammarBuilder(new Choices(new string[] { "yes", "no" }))));
            verification.SpeechRecognized += verification_SpeechRecognized;
        }

        //==========================
        //Speech Recognition Engines
        //==========================

        //verification_speechRecEng for the verification process
        void verification_SpeechRecognized(object sender, SpeechRecognizedEventArgs e)
        {
            lblMic.Text = e.Result.Text;

            switch (e.Result.Text)
            {
                case "yes":

                    if (currentCommand.AssistantReply != null && currentCommand.AssistantReply != "")
                        ss.SpeakAsync(currentCommand.AssistantReply);

                    lblVoice.Text = currentCommand.CommandString;

                    switch (currentCommand.CommandType)
                    {
                        case Command.VoiceCommandType.TerminalCommand:
                            Process.Start("CMD.exe", "/c " + currentCommand.CommandString);
                            picIconVoice.BackgroundImage = Resources.console_48px;

                            break;

                        case Command.VoiceCommandType.Application:
                            Process.Start(currentCommand.CommandString);
                            picIconVoice.BackgroundImage = Resources.web_48px;

                            break;

                        case Command.VoiceCommandType.WebBroswer:
                            Process.Start(currentCommand.CommandString);
                            picIconVoice.BackgroundImage = Resources.globe_48px;

                            break;
                    }

                    break;

                case "no":
                    ss.Speak("Ok, Aborted");

                    picIconVoice.BackgroundImage = Resources.unavailable_60px;
                    lblVoice.Text = "/Aborted";

                    break;
            }
            
            sre.RecognizeAsync(RecognizeMode.Single);
            timerReset.Enabled = true;  
        }

        //
        private void activate_SpeechRecognized(object sender, SpeechRecognizedEventArgs e)
        {
            ss.Speak("Hello there, what can I do for you");

            btnMic.Checked = true;

            sre.SetInputToDefaultAudioDevice();
            sre.RecognizeAsync(RecognizeMode.Single);

            picIconVoice.BackgroundImage = Resources.listening_48px;
            lblVoice.Text = "I'm listening . . .";
        }

        //======================================
        //main SpeechRecognitionEngine Functions
        //======================================

        void sre_SpeechRecognized(object sender, SpeechRecognizedEventArgs e)
        {
            lblMic.Text = e.Result.Text;

            if(e.Result.Text == "stop talking")
            {
                btnMic.PerformClick();
                ss.Speak("Ok, I will stay quitely");
                return;
            }

            int index = VoiceCommands.IndexOf(lblMic.Text);
            var command = Commands[index];
            

            if (command.CommandVerification)
            {
                verification.SetInputToDefaultAudioDevice();
                
                ss.Speak("Are you sure you want to do this");

                currentCommand = command;
                verification.RecognizeAsync(RecognizeMode.Single);
                return;
            }

            lblVoice.Text = command.CommandString;

            if (command.AssistantReply != null && command.AssistantReply != "")
                ss.SpeakAsync(command.AssistantReply);

            switch (command.CommandType)
            {
                case Command.VoiceCommandType.TerminalCommand:
                    Process.Start("CMD.exe", "/c " + command.CommandString);
                    picIconVoice.BackgroundImage = Resources.console_48px;

                    break;

                case Command.VoiceCommandType.Application:
                    Process.Start(command.CommandString);
                    picIconVoice.BackgroundImage = Resources.web_48px;

                    break;

                case Command.VoiceCommandType.WebBroswer:
                    Process.Start(command.CommandString);
                    picIconVoice.BackgroundImage = Resources.globe_48px;

                    break;
            }

            sre.RecognizeAsyncCancel();
            sre.RecognizeAsync(RecognizeMode.Single);

            timerReset.Enabled = true;
        }


        private void frmMain_Load(object sender, EventArgs e)
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();
                SqlCommand command = new SqlCommand("SELECT * FROM Commands", con);

                using(SqlDataAdapter sda = new SqlDataAdapter(command))
                    sda.Fill(dt);
            }

            foreach(DataRow row in dt.Rows)
            {
                char type = row[2].ToString()[0];

                var voiceCommand = new Command(
                    row[1].ToString(),
                    type == 'A' ? Command.VoiceCommandType.Application : (type == 'W' ? Command.VoiceCommandType.WebBroswer : Command.VoiceCommandType.TerminalCommand),
                    row[3].ToString()[0] == 'T' ? true : false,
                    row[4].ToString(),
                    row[5].ToString());

                Commands.Add(voiceCommand);
                VoiceCommands.Add(voiceCommand.VoiceCommand);
            }

            Choices cmd = new Choices(VoiceCommands.ToArray());
            cmd.Add(new string[] { "stop talking" });

            sre.LoadGrammar(new Grammar(new GrammarBuilder(cmd)));

            try
            {
                activate.SetInputToDefaultAudioDevice();
                activate.RecognizeAsync(RecognizeMode.Single);
            }
            catch(Exception ex)
            {
                MessageBox.Show("Please connect a microphone");
            }
        }


        public void AddCommand(Command newCommand)
        {
            Commands.Add(newCommand);
            VoiceCommands.Add(newCommand.VoiceCommand);

            sre.LoadGrammar(new Grammar(new GrammarBuilder(new Choices(VoiceCommands.ToArray()))));
        }

        private void btnPin_Click(object sender, EventArgs e)
        {
            btnPin.Checked = !btnPin.Checked;
            TopMost = btnPin.Checked;
        }

        private void btnSettings_Click(object sender, EventArgs e)
        {
            btnSettings.Checked = !btnSettings.Checked;

            if (btnSettings.Checked)
            {
                frmSettings frmSettingObj = new frmSettings();
                frmSettingObj.ShowDialog();
            }
        }


        private void btnMic_Click(object sender, EventArgs e)
        {
            if (btnMic.Checked)
            {
                activate.RecognizeAsyncCancel();
                sre.SetInputToDefaultAudioDevice();
                sre.RecognizeAsync(RecognizeMode.Single);

                picIconVoice.BackgroundImage = Resources.listening_48px;
                lblVoice.Text = "I'm listening . . .";
            }
            else
            {
                sre.RecognizeAsyncCancel();
                activate.SetInputToDefaultAudioDevice();
                activate.RecognizeAsync(RecognizeMode.Single);

                picIconVoice.BackgroundImage = Resources.so_so_48px;
                lblVoice.Text = "Hello there";
            }
        }

        private void btnMic_CheckedChanged(object sender, EventArgs e)
        {
            soundWave.Visible = btnMic.Checked;
        }


        private void timerReset_Tick(object sender, EventArgs e)
        {
            lblVoice.Text = lblMic.Text = "";

            if (btnMic.Checked && lblVoice.Text != "I'm listening . . .")
            {
                picIconVoice.BackgroundImage = Resources.listening_48px;
                lblVoice.Text = "I'm listening . . .";
            }
            else if(!btnMic.Checked && lblVoice.Text != "Hello there")
            {
                picIconVoice.BackgroundImage = Resources.so_so_48px;
                lblVoice.Text = "Hello there";
            }

            timerReset.Enabled = false;
        }

        private void lblVoice_TextChanged(object sender, EventArgs e)
        {
            timerReset.Enabled = false;
            timerReset.Enabled = true;
        }
    }
}