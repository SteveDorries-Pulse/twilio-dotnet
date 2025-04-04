/// This code was generated by
/// \ / _    _  _|   _  _
///  | (_)\/(_)(_|\/| |(/_  v1.0.0
///       /       /


using System;
using Twilio.Converters;
using Twilio.TwiML.Voice;

namespace Twilio.UnitTests.TwiML
{

    
    public class ConfigTest : TwilioTest
    {
        [Fact]
        public void TestEmptyElement()
        {
            var elem = new Config();

            Assert.Equal(
                "<?xml version=\"1.0\" encoding=\"utf-8\"?>" + Environment.NewLine +
                "<Config></Config>",
                elem.ToString()
            );
        }

        [Fact]
        public void TestElementWithParams()
        {
            var elem = new Config("name", "value");
            Assert.Equal(
                "<?xml version=\"1.0\" encoding=\"utf-8\"?>" + Environment.NewLine +
                "<Config name=\"name\" value=\"value\"></Config>",
                elem.ToString()
            );
        }

        [Fact]
        public void TestElementWithExtraAttributes()
        {
            var elem = new Config();
            elem.SetOption("newParam1", "value");
            elem.SetOption("newParam2", 1);

            Assert.Equal(
                "<?xml version=\"1.0\" encoding=\"utf-8\"?>" + Environment.NewLine +
                "<Config newParam1=\"value\" newParam2=\"1\"></Config>",
                elem.ToString()
            );
        }

        [Fact]
        public void TestElementWithTextNode()
        {
            var elem = new Config();

            elem.AddText("Here is the content");

            Assert.Equal(
                "<?xml version=\"1.0\" encoding=\"utf-8\"?>" + Environment.NewLine +
                "<Config>Here is the content</Config>",
                elem.ToString()
            );
        }

        [Fact]
        public void TestAllowGenericChildNodes()
        {
            var elem = new Config();
            elem.AddChild("generic-tag").AddText("Content").SetOption("tag", true);

            Assert.Equal(
                "<?xml version=\"1.0\" encoding=\"utf-8\"?>" + Environment.NewLine +
                "<Config>" + Environment.NewLine +
                "  <generic-tag tag=\"True\">Content</generic-tag>" + Environment.NewLine +
                "</Config>",
                elem.ToString()
            );
        }

        [Fact]
        public void TestMixedContent()
        {
            var elem = new Config();
            elem.AddText("before")
                .AddChild("Child").AddText("content");
            elem.AddText("after");

            Assert.Equal(
                "<?xml version=\"1.0\" encoding=\"utf-8\"?>" + Environment.NewLine +
                "<Config>before<Child>content</Child>after</Config>",
                elem.ToString()
            );
        }
    }

}