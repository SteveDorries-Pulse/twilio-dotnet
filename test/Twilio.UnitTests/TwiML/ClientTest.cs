/// This code was generated by
/// \ / _    _  _|   _  _
///  | (_)\/(_)(_|\/| |(/_  v1.0.0
///       /       /


using System;
using Twilio.Converters;
using Twilio.TwiML.Voice;

namespace Twilio.UnitTests.TwiML
{

    
    public class ClientTest : TwilioTest
    {
        [Fact]
        public void TestEmptyElement()
        {
            var elem = new Client();

            Assert.Equal(
                "<?xml version=\"1.0\" encoding=\"utf-8\"?>" + Environment.NewLine +
                "<Client></Client>",
                elem.ToString()
            );
        }

        [Fact]
        public void TestElementWithParams()
        {
            var elem = new Client(
                "identity",
                new Uri("https://example.com"),
                Twilio.Http.HttpMethod.Get,
                new[] {Client.EventEnum.Initiated},
                new Uri("https://example.com"),
                Twilio.Http.HttpMethod.Get
            );
            Assert.Equal(
                "<?xml version=\"1.0\" encoding=\"utf-8\"?>" + Environment.NewLine +
                "<Client url=\"https://example.com\" method=\"GET\" statusCallbackEvent=\"initiated\" statusCallback=\"https://example.com\" statusCallbackMethod=\"GET\">identity</Client>",
                elem.ToString()
            );
        }

        [Fact]
        public void TestElementWithExtraAttributes()
        {
            var elem = new Client();
            elem.SetOption("newParam1", "value");
            elem.SetOption("newParam2", 1);

            Assert.Equal(
                "<?xml version=\"1.0\" encoding=\"utf-8\"?>" + Environment.NewLine +
                "<Client newParam1=\"value\" newParam2=\"1\"></Client>",
                elem.ToString()
            );
        }

        [Fact]
        public void TestElementWithChildren()
        {
            var elem = new Client();

            elem.Identity("client_identity");

            elem.Parameter("name", "value");

            Assert.Equal(
                "<?xml version=\"1.0\" encoding=\"utf-8\"?>" + Environment.NewLine +
                "<Client>" + Environment.NewLine +
                "  <Identity>client_identity</Identity>" + Environment.NewLine +
                "  <Parameter name=\"name\" value=\"value\"></Parameter>" + Environment.NewLine +
                "</Client>",
                elem.ToString()
            );
        }

        [Fact]
        public void TestElementWithTextNode()
        {
            var elem = new Client();

            elem.AddText("Here is the content");

            Assert.Equal(
                "<?xml version=\"1.0\" encoding=\"utf-8\"?>" + Environment.NewLine +
                "<Client>Here is the content</Client>",
                elem.ToString()
            );
        }

        [Fact]
        public void TestAllowGenericChildNodes()
        {
            var elem = new Client();
            elem.AddChild("generic-tag").AddText("Content").SetOption("tag", true);

            Assert.Equal(
                "<?xml version=\"1.0\" encoding=\"utf-8\"?>" + Environment.NewLine +
                "<Client>" + Environment.NewLine +
                "  <generic-tag tag=\"True\">Content</generic-tag>" + Environment.NewLine +
                "</Client>",
                elem.ToString()
            );
        }

        [Fact]
        public void TestAllowGenericChildrenOfChildNodes()
        {
            var elem = new Client();
            var child = new Identity();
            elem.Nest(child).AddChild("generic-tag").SetOption("tag", true).AddText("Content");

            Assert.Equal(
                "<?xml version=\"1.0\" encoding=\"utf-8\"?>" + Environment.NewLine +
                "<Client>" + Environment.NewLine +
                "  <Identity>" + Environment.NewLine +
                "    <generic-tag tag=\"True\">Content</generic-tag>" + Environment.NewLine +
                "  </Identity>" + Environment.NewLine +
                "</Client>",
                elem.ToString()
            );
        }

        [Fact]
        public void TestMixedContent()
        {
            var elem = new Client();
            elem.AddText("before")
                .AddChild("Child").AddText("content");
            elem.AddText("after");

            Assert.Equal(
                "<?xml version=\"1.0\" encoding=\"utf-8\"?>" + Environment.NewLine +
                "<Client>before<Child>content</Child>after</Client>",
                elem.ToString()
            );
        }
    }

}