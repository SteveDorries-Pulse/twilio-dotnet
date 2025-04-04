/// This code was generated by
/// \ / _    _  _|   _  _
///  | (_)\/(_)(_|\/| |(/_  v1.0.0
///       /       /


using System;
using Twilio.Converters;
using Twilio.TwiML.Voice;

namespace Twilio.UnitTests.TwiML
{

    
    public class SsmlSayAsTest : TwilioTest
    {
        [Fact]
        public void TestEmptyElement()
        {
            var elem = new SsmlSayAs();

            Assert.Equal(
                "<?xml version=\"1.0\" encoding=\"utf-8\"?>" + Environment.NewLine +
                "<say-as></say-as>",
                elem.ToString()
            );
        }

        [Fact]
        public void TestElementWithParams()
        {
            var elem = new SsmlSayAs("words", SsmlSayAs.InterpretAsEnum.Characters, SsmlSayAs.FormatEnum.Mdy);
            Assert.Equal(
                "<?xml version=\"1.0\" encoding=\"utf-8\"?>" + Environment.NewLine +
                "<say-as interpret-as=\"characters\" format=\"mdy\">words</say-as>",
                elem.ToString()
            );
        }

        [Fact]
        public void TestElementWithExtraAttributes()
        {
            var elem = new SsmlSayAs();
            elem.SetOption("newParam1", "value");
            elem.SetOption("newParam2", 1);

            Assert.Equal(
                "<?xml version=\"1.0\" encoding=\"utf-8\"?>" + Environment.NewLine +
                "<say-as newParam1=\"value\" newParam2=\"1\"></say-as>",
                elem.ToString()
            );
        }

        [Fact]
        public void TestElementWithTextNode()
        {
            var elem = new SsmlSayAs();

            elem.AddText("Here is the content");

            Assert.Equal(
                "<?xml version=\"1.0\" encoding=\"utf-8\"?>" + Environment.NewLine +
                "<say-as>Here is the content</say-as>",
                elem.ToString()
            );
        }

        [Fact]
        public void TestAllowGenericChildNodes()
        {
            var elem = new SsmlSayAs();
            elem.AddChild("generic-tag").AddText("Content").SetOption("tag", true);

            Assert.Equal(
                "<?xml version=\"1.0\" encoding=\"utf-8\"?>" + Environment.NewLine +
                "<say-as>" + Environment.NewLine +
                "  <generic-tag tag=\"True\">Content</generic-tag>" + Environment.NewLine +
                "</say-as>",
                elem.ToString()
            );
        }

        [Fact]
        public void TestMixedContent()
        {
            var elem = new SsmlSayAs();
            elem.AddText("before")
                .AddChild("Child").AddText("content");
            elem.AddText("after");

            Assert.Equal(
                "<?xml version=\"1.0\" encoding=\"utf-8\"?>" + Environment.NewLine +
                "<say-as>before<Child>content</Child>after</say-as>",
                elem.ToString()
            );
        }
    }

}