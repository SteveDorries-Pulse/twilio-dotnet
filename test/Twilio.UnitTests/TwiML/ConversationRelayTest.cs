/// This code was generated by
/// \ / _    _  _|   _  _
///  | (_)\/(_)(_|\/| |(/_  v1.0.0
///       /       /


using System;
using Twilio.Converters;
using Twilio.TwiML.Voice;

namespace Twilio.UnitTests.TwiML
{

    
    public class ConversationRelayTest : TwilioTest
    {
        [Fact]
        public void TestEmptyElement()
        {
            var elem = new ConversationRelay();

            Assert.Equal(
                "<?xml version=\"1.0\" encoding=\"utf-8\"?>" + Environment.NewLine +
                "<ConversationRelay></ConversationRelay>",
                elem.ToString()
            );
        }

        [Fact]
        public void TestElementWithParams()
        {
            var elem = new ConversationRelay(
                "url",
                "language",
                "tts_language",
                "transcription_language",
                "tts_provider",
                "voice",
                "transcription_provider",
                "speech_model",
                true,
                true,
                "welcome_greeting",
                true,
                true,
                true,
                true,
                true
            );
            Assert.Equal(
                "<?xml version=\"1.0\" encoding=\"utf-8\"?>" + Environment.NewLine +
                "<ConversationRelay url=\"url\" language=\"language\" ttsLanguage=\"tts_language\" transcriptionLanguage=\"transcription_language\" ttsProvider=\"tts_provider\" voice=\"voice\" transcriptionProvider=\"transcription_provider\" speechModel=\"speech_model\" profanityFilter=\"true\" dtmfDetection=\"true\" welcomeGreeting=\"welcome_greeting\" partialPrompts=\"true\" interruptible=\"true\" interruptByDtmf=\"true\" welcomeGreetingInterruptible=\"true\" debug=\"true\"></ConversationRelay>",
                elem.ToString()
            );
        }

        [Fact]
        public void TestElementWithExtraAttributes()
        {
            var elem = new ConversationRelay();
            elem.SetOption("newParam1", "value");
            elem.SetOption("newParam2", 1);

            Assert.Equal(
                "<?xml version=\"1.0\" encoding=\"utf-8\"?>" + Environment.NewLine +
                "<ConversationRelay newParam1=\"value\" newParam2=\"1\"></ConversationRelay>",
                elem.ToString()
            );
        }

        [Fact]
        public void TestElementWithChildren()
        {
            var elem = new ConversationRelay();

            elem.Language("code", "tts_provider", "voice", "transcription_provider", "speech_model");

            elem.Parameter("name", "value");

            Assert.Equal(
                "<?xml version=\"1.0\" encoding=\"utf-8\"?>" + Environment.NewLine +
                "<ConversationRelay>" + Environment.NewLine +
                "  <Language code=\"code\" ttsProvider=\"tts_provider\" voice=\"voice\" transcriptionProvider=\"transcription_provider\" speechModel=\"speech_model\"></Language>" + Environment.NewLine +
                "  <Parameter name=\"name\" value=\"value\"></Parameter>" + Environment.NewLine +
                "</ConversationRelay>",
                elem.ToString()
            );
        }

        [Fact]
        public void TestElementWithTextNode()
        {
            var elem = new ConversationRelay();

            elem.AddText("Here is the content");

            Assert.Equal(
                "<?xml version=\"1.0\" encoding=\"utf-8\"?>" + Environment.NewLine +
                "<ConversationRelay>Here is the content</ConversationRelay>",
                elem.ToString()
            );
        }

        [Fact]
        public void TestAllowGenericChildNodes()
        {
            var elem = new ConversationRelay();
            elem.AddChild("generic-tag").AddText("Content").SetOption("tag", true);

            Assert.Equal(
                "<?xml version=\"1.0\" encoding=\"utf-8\"?>" + Environment.NewLine +
                "<ConversationRelay>" + Environment.NewLine +
                "  <generic-tag tag=\"True\">Content</generic-tag>" + Environment.NewLine +
                "</ConversationRelay>",
                elem.ToString()
            );
        }

        [Fact]
        public void TestAllowGenericChildrenOfChildNodes()
        {
            var elem = new ConversationRelay();
            var child = new Language();
            elem.Nest(child).AddChild("generic-tag").SetOption("tag", true).AddText("Content");

            Assert.Equal(
                "<?xml version=\"1.0\" encoding=\"utf-8\"?>" + Environment.NewLine +
                "<ConversationRelay>" + Environment.NewLine +
                "  <Language>" + Environment.NewLine +
                "    <generic-tag tag=\"True\">Content</generic-tag>" + Environment.NewLine +
                "  </Language>" + Environment.NewLine +
                "</ConversationRelay>",
                elem.ToString()
            );
        }

        [Fact]
        public void TestMixedContent()
        {
            var elem = new ConversationRelay();
            elem.AddText("before")
                .AddChild("Child").AddText("content");
            elem.AddText("after");

            Assert.Equal(
                "<?xml version=\"1.0\" encoding=\"utf-8\"?>" + Environment.NewLine +
                "<ConversationRelay>before<Child>content</Child>after</ConversationRelay>",
                elem.ToString()
            );
        }
    }

}