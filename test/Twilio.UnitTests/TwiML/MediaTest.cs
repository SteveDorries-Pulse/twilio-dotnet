/// This code was generated by
/// \ / _    _  _|   _  _
///  | (_)\/(_)(_|\/| |(/_  v1.0.0
///       /       /


using System;
using Twilio.Converters;
using Twilio.TwiML.Messaging;

namespace Twilio.UnitTests.TwiML
{

    
    public class MediaTest : TwilioTest
    {
        [Fact]
        public void TestEmptyElement()
        {
            var elem = new Media();

            Assert.Equal(
                "<?xml version=\"1.0\" encoding=\"utf-8\"?>" + Environment.NewLine +
                "<Media></Media>",
                elem.ToString()
            );
        }

        [Fact]
        public void TestElementWithParams()
        {
            var elem = new Media(new Uri("https://example.com"));
            Assert.Equal(
                "<?xml version=\"1.0\" encoding=\"utf-8\"?>" + Environment.NewLine +
                "<Media>https://example.com</Media>",
                elem.ToString()
            );
        }

        [Fact]
        public void TestElementWithExtraAttributes()
        {
            var elem = new Media();
            elem.SetOption("newParam1", "value");
            elem.SetOption("newParam2", 1);

            Assert.Equal(
                "<?xml version=\"1.0\" encoding=\"utf-8\"?>" + Environment.NewLine +
                "<Media newParam1=\"value\" newParam2=\"1\"></Media>",
                elem.ToString()
            );
        }

        [Fact]
        public void TestElementWithTextNode()
        {
            var elem = new Media();

            elem.AddText("Here is the content");

            Assert.Equal(
                "<?xml version=\"1.0\" encoding=\"utf-8\"?>" + Environment.NewLine +
                "<Media>Here is the content</Media>",
                elem.ToString()
            );
        }

        [Fact]
        public void TestAllowGenericChildNodes()
        {
            var elem = new Media();
            elem.AddChild("generic-tag").AddText("Content").SetOption("tag", true);

            Assert.Equal(
                "<?xml version=\"1.0\" encoding=\"utf-8\"?>" + Environment.NewLine +
                "<Media>" + Environment.NewLine +
                "  <generic-tag tag=\"True\">Content</generic-tag>" + Environment.NewLine +
                "</Media>",
                elem.ToString()
            );
        }

        [Fact]
        public void TestMixedContent()
        {
            var elem = new Media();
            elem.AddText("before")
                .AddChild("Child").AddText("content");
            elem.AddText("after");

            Assert.Equal(
                "<?xml version=\"1.0\" encoding=\"utf-8\"?>" + Environment.NewLine +
                "<Media>before<Child>content</Child>after</Media>",
                elem.ToString()
            );
        }
    }

}