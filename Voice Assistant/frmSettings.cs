using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Speech.Synthesis;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Voice_Assistant.Properties;
using static Voice_Assistant.Command;

namespace Voice_Assistant
{
    public partial class frmSettings : Form
    {
        private string connectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=\"|DataDirectory|\\Commands.mdf\";Integrated Security=True";
        private SpeechSynthesizer ss = new SpeechSynthesizer();
        private System.Collections.ObjectModel.ReadOnlyCollection<InstalledVoice> voices;
        private List<VoiceCommandType> CommandTypes = new List<VoiceCommandType>() { VoiceCommandType.Application, VoiceCommandType.WebBroswer, VoiceCommandType.TerminalCommand };

        private bool onOpen = true;

        public frmSettings()
        {
            InitializeComponent();
        }

        private void frmSettings_Load(object sender, EventArgs e)
        {
            voices = ss.GetInstalledVoices();

            foreach (InstalledVoice voice in voices)
                comboVoice.Items.Add(voice.VoiceInfo.Name);

            trackTransparency.Value = (int) Application.OpenForms["frmMain"].Opacity * 255;
            trackSound.Value = (Application.OpenForms["frmMain"] as frmMain).ss.Volume;
            comboVoice.SelectedText = (Application.OpenForms["frmMain"] as frmMain).ss.Voice.Name;

            //I know the redundancy lmao, v ve 2,4,8,16 gb rams, y not wasting :)

            onOpen = false;
        }

        private void comboCommandType_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtCommandString.PlaceholderText = comboCommandType.SelectedIndex == 0 ? "Browse the Application Location" : (comboCommandType.SelectedIndex == 1 ? "Enter the web url" : "Enter the terminal command");
            btnBrowse.Visible = comboCommandType.SelectedIndex == 0;            
        }

        private void ComboVoice_SelectedIndexChanged(object sender, EventArgs e)
        {
            picAssistantIcon.BackgroundImage = voices[comboVoice.SelectedIndex].VoiceInfo.Gender == VoiceGender.Female ? Resources.technical_support_48px : Resources.online_support_48px;
            
            if(!onOpen)
                (Application.OpenForms["frmMain"] as frmMain).ss.SelectVoice(comboVoice.Text);
        }

        private void trackSound_ValueChanged(object sender, EventArgs e)
        {
            if (trackSound.Value > 66)
                picSoundIcon.BackgroundImage = Resources.sound_48px_3;
            else if (trackSound.Value > 33)
                picSoundIcon.BackgroundImage = Resources.sound_48px_2;
            else if (trackSound.Value > 1)
                picSoundIcon.BackgroundImage = Resources.sound_48px_1;
            else
                picSoundIcon.BackgroundImage = Resources.sound_48px_0;

            if (!onOpen)
                (Application.OpenForms["frmMain"] as frmMain).ss.Volume = trackSound.Value;
        }

        private void trackTransparency_ValueChanged(object sender, EventArgs e)
        {
            var clr = pnlTransparency.FillColor;
            pnlTransparency.FillColor = Color.FromArgb(trackTransparency.Value, clr.R, clr.G, clr.B);
            
            if (!onOpen)
                Application.OpenForms["frmMain"].Opacity = trackTransparency.Value / 255.00;
        }

        private void btnAddCommand_Click(object sender, EventArgs e)
        {
            var commandString = txtCommandString.Text;
            var commandType = CommandTypes[comboCommandType.SelectedIndex];
            var verification = checkVerification.Checked;
            var voiceCommand = txtVoiceCommand.Text;
            var asstReply = txtAssistantReply.Text;

            if (commandType == VoiceCommandType.WebBroswer)
            {
                //got it from stackoverflow :)
                Uri uriResult;
                bool result = Uri.TryCreate(commandString, UriKind.Absolute, out uriResult)
                    && (uriResult.Scheme == Uri.UriSchemeHttp || uriResult.Scheme == Uri.UriSchemeHttps);

                if (!result)
                {
                    MessageBox.Show("Enter a valid URL!");
                    return;
                }
            }
            else if(commandType == VoiceCommandType.Application)
            {
                if (!File.Exists(commandString))
                {
                    MessageBox.Show("cant find the application specified...");
                    return;
                }
            }

            try
            {
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    con.Open();

                    SqlCommand cmd = new SqlCommand($"INSERT INTO Commands (CommandString, CommandType, CommandVerification, VoiceCommand, AssistantReply) VALUES (\'{commandString}\', \'{commandType}\', \'{verification}\', \'{voiceCommand}\', \'{asstReply}\')", con);
                    cmd.ExecuteNonQuery();
                }
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

             (Application.OpenForms["frmMain"] as frmMain).AddCommand(new Command(commandString, commandType, verification, voiceCommand, asstReply));
        }

        private void frmSettings_FormClosing(object sender, FormClosingEventArgs e)
        {
            (Application.OpenForms["frmMain"].Controls["btnSettings"] as Guna.UI2.WinForms.Guna2Button).PerformClick();
        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            if(ofd.ShowDialog() == DialogResult.OK)
                txtCommandString.Text = ofd.FileName;
        }
    }
}