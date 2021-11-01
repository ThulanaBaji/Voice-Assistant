using System.Speech.Recognition;
using System.Speech.Synthesis;

namespace Voice_Assistant
{
    public class Command
    {
        public enum VoiceCommandType
        {
            Application,
            WebBroswer,
            TerminalCommand
        };

        public Command(string commandString, VoiceCommandType commandType, bool commandVerification, string voiceCommand, string assistantReply)
        {
            this.VoiceCommand = voiceCommand; 
            this.CommandType = commandType;
            this.CommandString = commandString;
            this.CommandVerification = commandVerification;   
            this.AssistantReply = assistantReply;
        }

        public string VoiceCommand { get; set; }

        public VoiceCommandType CommandType { get; set; }

        public string CommandString { get; set; } 
        
        public bool CommandVerification  { get; set; }

        public string AssistantReply { get; set; }

        //public void Execute(ref SpeechRecognitionEngine CurrentSRE)
        //{
        //    CurrentSRE.RecognizeAsyncStop();

        //    switch (CommandType)
        //    {
        //        case VoiceCommandType.Application:
                    
        //            break;

        //        case VoiceCommandType.WebBroswer:
        //            break;
        //        case VoiceCommandType.TerminalCommand:
        //            break;
        //        default:
        //            break;
        //    }

        //    var ss = new SpeechSynthesizer();
        //    ss.Speak(AssistantReply);

        //}
    }
}
