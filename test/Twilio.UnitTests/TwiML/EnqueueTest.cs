/// This code was generated by
/// \ / _    _  _|   _  _
///  | (_)\/(_)(_|\/| |(/_  v1.0.0
///       /       /


using System;
using Twilio.Converters;
using Twilio.TwiML.Voice;
using Task = Twilio.TwiML.Voice.Task;

namespace Twilio.UnitTests.TwiML
{

    
    public class EnqueueTest : TwilioTest
    {
        [Fact]
        public void TestEmptyElement()
        {
            var elem = new Enqueue();

            Assert.Equal(
                "<?xml version=\"1.0\" encoding=\"utf-8\"?>" + Environment.NewLine +
                "<Enqueue></Enqueue>",
                elem.ToString()
            );
        }

        [Fact]
        public void TestElementWithParams()
        {
            var elem = new Enqueue(
                "name",
                new Uri("https://example.com"),
                1,
                Twilio.Http.HttpMethod.Get,
                new Uri("https://example.com"),
                Twilio.Http.HttpMethod.Get,
                "workflow_sid"
            );
            Assert.Equal(
                "<?xml version=\"1.0\" encoding=\"utf-8\"?>" + Environment.NewLine +
                "<Enqueue action=\"https://example.com\" maxQueueSize=\"1\" method=\"GET\" waitUrl=\"https://example.com\" waitUrlMethod=\"GET\" workflowSid=\"workflow_sid\">name</Enqueue>",
                elem.ToString()
            );
        }

        [Fact]
        public void TestElementWithExtraAttributes()
        {
            var elem = new Enqueue();
            elem.SetOption("newParam1", "value");
            elem.SetOption("newParam2", 1);

            Assert.Equal(
                "<?xml version=\"1.0\" encoding=\"utf-8\"?>" + Environment.NewLine +
                "<Enqueue newParam1=\"value\" newParam2=\"1\"></Enqueue>",
                elem.ToString()
            );
        }

        [Fact]
        public void TestElementWithChildren()
        {
            var elem = new Enqueue();

            elem.Task("body", 1, 1);

            Assert.Equal(
                "<?xml version=\"1.0\" encoding=\"utf-8\"?>" + Environment.NewLine +
                "<Enqueue>" + Environment.NewLine +
                "  <Task priority=\"1\" timeout=\"1\">body</Task>" + Environment.NewLine +
                "</Enqueue>",
                elem.ToString()
            );
        }

        [Fact]
        public void TestElementWithTextNode()
        {
            var elem = new Enqueue();

            elem.AddText("Here is the content");

            Assert.Equal(
                "<?xml version=\"1.0\" encoding=\"utf-8\"?>" + Environment.NewLine +
                "<Enqueue>Here is the content</Enqueue>",
                elem.ToString()
            );
        }

        [Fact]
        public void TestAllowGenericChildNodes()
        {
            var elem = new Enqueue();
            elem.AddChild("generic-tag").AddText("Content").SetOption("tag", true);

            Assert.Equal(
                "<?xml version=\"1.0\" encoding=\"utf-8\"?>" + Environment.NewLine +
                "<Enqueue>" + Environment.NewLine +
                "  <generic-tag tag=\"True\">Content</generic-tag>" + Environment.NewLine +
                "</Enqueue>",
                elem.ToString()
            );
        }

        [Fact]
        public void TestAllowGenericChildrenOfChildNodes()
        {
            var elem = new Enqueue();
            var child = new Task();
            elem.Nest(child).AddChild("generic-tag").SetOption("tag", true).AddText("Content");

            Assert.Equal(
                "<?xml version=\"1.0\" encoding=\"utf-8\"?>" + Environment.NewLine +
                "<Enqueue>" + Environment.NewLine +
                "  <Task>" + Environment.NewLine +
                "    <generic-tag tag=\"True\">Content</generic-tag>" + Environment.NewLine +
                "  </Task>" + Environment.NewLine +
                "</Enqueue>",
                elem.ToString()
            );
        }

        [Fact]
        public void TestMixedContent()
        {
            var elem = new Enqueue();
            elem.AddText("before")
                .AddChild("Child").AddText("content");
            elem.AddText("after");

            Assert.Equal(
                "<?xml version=\"1.0\" encoding=\"utf-8\"?>" + Environment.NewLine +
                "<Enqueue>before<Child>content</Child>after</Enqueue>",
                elem.ToString()
            );
        }
    }

}