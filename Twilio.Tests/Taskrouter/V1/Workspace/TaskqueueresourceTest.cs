using NUnit.Framework;
using NUnit.Mocks;
using System;
using Twilio;
using Twilio.Clients;
using Twilio.Converters;
using Twilio.Exceptions;
using Twilio.Http;

namespace Twilio.Tests.Taskrouter.V1.Workspace {

    [TestFixture]
    public class TaskQueueTest : TwilioTest {
        private DynamicMock twilioRestClient;
    
        [SetUp]
        public void SetUp() {
            TwilioClient.init("AC123", "AUTH TOKEN");
            twilioRestClient = new DynamicMock(typeof(ITwilioRestClient));
        }
    
        [TestCase]
        public void TestFetchRequest() {
            ITwilioRestClient client = (ITwilioRestClient) twilioRestClient;
            Request request = new Request(System.Net.Http.HttpMethod.Get,
                                          Domains.TASKROUTER,
                                          "/v1/Workspaces/WSaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa/TaskQueues/WQaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa");
            
            
            twilioRestClient.ExpectAndReturn("Request", new Response(System.Net.HttpStatusCode.OK, null), request);
            client.Request(request);
        }
    
        [TestCase]
        public void TestUpdateRequest() {
            ITwilioRestClient client = (ITwilioRestClient) twilioRestClient;
            Request request = new Request(System.Net.Http.HttpMethod.Post,
                                          Domains.TASKROUTER,
                                          "/v1/Workspaces/WSaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa/TaskQueues/WQaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa");
            
            
            twilioRestClient.ExpectAndReturn("Request", new Response(System.Net.HttpStatusCode.OK, null), request);
            client.Request(request);
        }
    
        [TestCase]
        public void TestReadRequest() {
            ITwilioRestClient client = (ITwilioRestClient) twilioRestClient;
            Request request = new Request(System.Net.Http.HttpMethod.Get,
                                          Domains.TASKROUTER,
                                          "/v1/Workspaces/WSaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa/TaskQueues");
            
            request.AddQueryParam("PageSize", "50");
            twilioRestClient.ExpectAndReturn("Request", new Response(System.Net.HttpStatusCode.OK, null), request);
            client.Request(request);
        }
    
        [TestCase]
        public void TestCreateRequest() {
                        ITwilioRestClient client = (ITwilioRestClient) twilioRestClient;
                        Request request = new Request(System.Net.Http.HttpMethod.Post,
                                                      Domains.TASKROUTER,
                                                      "/v1/Workspaces/WSaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa/TaskQueues");
                        request.AddPostParam("FriendlyName", Serialize("friendlyName"));
            request.AddPostParam("ReservationActivitySid", Serialize("WAaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa"));
            request.AddPostParam("AssignmentActivitySid", Serialize("WAaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa"));
                        
                        twilioRestClient.ExpectAndReturn("Request", new Response(System.Net.HttpStatusCode.OK, null), request);
                        client.Request(request);
        }
    
        [TestCase]
        public void TestDeleteRequest() {
            ITwilioRestClient client = (ITwilioRestClient) twilioRestClient;
            Request request = new Request(System.Net.Http.HttpMethod.Delete,
                                          Domains.TASKROUTER,
                                          "/v1/Workspaces/WSaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa/TaskQueues/WQaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa");
            
            
            twilioRestClient.ExpectAndReturn("Request", new Response(System.Net.HttpStatusCode.OK, null), request);
            client.Request(request);
        }
    }
}