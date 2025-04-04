/*
 * This code was generated by
 * ___ _ _ _ _ _    _ ____    ____ ____ _    ____ ____ _  _ ____ ____ ____ ___ __   __
 *  |  | | | | |    | |  | __ |  | |__| | __ | __ |___ |\ | |___ |__/ |__|  | |  | |__/
 *  |  |_|_| | |___ | |__|    |__| |  | |    |__] |___ | \| |___ |  \ |  |  | |__| |  \
 *
 * Twilio - Taskrouter
 * This is the public Twilio REST API.
 *
 * NOTE: This class is auto generated by OpenAPI Generator.
 * https://openapi-generator.tech
 * Do not edit the class manually.
 */


using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using Twilio.Base;
using Twilio.Clients;
using Twilio.Constant;
using Twilio.Converters;
using Twilio.Exceptions;
using Twilio.Http;



namespace Twilio.Rest.Taskrouter.V1.Workspace
{
    public class WorkflowResource : Resource
    {
    

    

        
        private static Request BuildCreateRequest(CreateWorkflowOptions options, ITwilioRestClient client)
        {
            
            string path = "/v1/Workspaces/{WorkspaceSid}/Workflows";

            string PathWorkspaceSid = options.PathWorkspaceSid;
            path = path.Replace("{"+"WorkspaceSid"+"}", PathWorkspaceSid);

            return new Request(
                HttpMethod.Post,
                Rest.Domain.Taskrouter,
                path,
                contentType: EnumConstants.ContentTypeEnum.FORM_URLENCODED,
                postParams: options.GetParams(),
                headerParams: null
            );
        }

        /// <summary> create </summary>
        /// <param name="options"> Create Workflow parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of Workflow </returns>
        public static WorkflowResource Create(CreateWorkflowOptions options, ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = client.Request(BuildCreateRequest(options, client));
            return FromJson(response.Content);
        }

        #if !NET35
        /// <summary> create </summary>
        /// <param name="options"> Create Workflow parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of Workflow </returns>
        public static async System.Threading.Tasks.Task<WorkflowResource> CreateAsync(CreateWorkflowOptions options, ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = await client.RequestAsync(BuildCreateRequest(options, client));
            return FromJson(response.Content);
        }
        #endif

        /// <summary> create </summary>
        /// <param name="pathWorkspaceSid"> The SID of the Workspace that the new Workflow to create belongs to. </param>
        /// <param name="friendlyName"> A descriptive string that you create to describe the Workflow resource. For example, `Inbound Call Workflow` or `2014 Outbound Campaign`. </param>
        /// <param name="configuration"> A JSON string that contains the rules to apply to the Workflow. See [Configuring Workflows](https://www.twilio.com/docs/taskrouter/workflow-configuration) for more information. </param>
        /// <param name="assignmentCallbackUrl"> The URL from your application that will process task assignment events. See [Handling Task Assignment Callback](https://www.twilio.com/docs/taskrouter/handle-assignment-callbacks) for more details. </param>
        /// <param name="fallbackAssignmentCallbackUrl"> The URL that we should call when a call to the `assignment_callback_url` fails. </param>
        /// <param name="taskReservationTimeout"> How long TaskRouter will wait for a confirmation response from your application after it assigns a Task to a Worker. Can be up to `86,400` (24 hours) and the default is `120`. </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of Workflow </returns>
        public static WorkflowResource Create(
                                          string pathWorkspaceSid,
                                          string friendlyName,
                                          string configuration,
                                          Uri assignmentCallbackUrl = null,
                                          Uri fallbackAssignmentCallbackUrl = null,
                                          int? taskReservationTimeout = null,
                                            ITwilioRestClient client = null)
        {
            var options = new CreateWorkflowOptions(pathWorkspaceSid, friendlyName, configuration){  AssignmentCallbackUrl = assignmentCallbackUrl, FallbackAssignmentCallbackUrl = fallbackAssignmentCallbackUrl, TaskReservationTimeout = taskReservationTimeout };
            return Create(options, client);
        }

        #if !NET35
        /// <summary> create </summary>
        /// <param name="pathWorkspaceSid"> The SID of the Workspace that the new Workflow to create belongs to. </param>
        /// <param name="friendlyName"> A descriptive string that you create to describe the Workflow resource. For example, `Inbound Call Workflow` or `2014 Outbound Campaign`. </param>
        /// <param name="configuration"> A JSON string that contains the rules to apply to the Workflow. See [Configuring Workflows](https://www.twilio.com/docs/taskrouter/workflow-configuration) for more information. </param>
        /// <param name="assignmentCallbackUrl"> The URL from your application that will process task assignment events. See [Handling Task Assignment Callback](https://www.twilio.com/docs/taskrouter/handle-assignment-callbacks) for more details. </param>
        /// <param name="fallbackAssignmentCallbackUrl"> The URL that we should call when a call to the `assignment_callback_url` fails. </param>
        /// <param name="taskReservationTimeout"> How long TaskRouter will wait for a confirmation response from your application after it assigns a Task to a Worker. Can be up to `86,400` (24 hours) and the default is `120`. </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of Workflow </returns>
        public static async System.Threading.Tasks.Task<WorkflowResource> CreateAsync(
                                                                                  string pathWorkspaceSid,
                                                                                  string friendlyName,
                                                                                  string configuration,
                                                                                  Uri assignmentCallbackUrl = null,
                                                                                  Uri fallbackAssignmentCallbackUrl = null,
                                                                                  int? taskReservationTimeout = null,
                                                                                    ITwilioRestClient client = null)
        {
        var options = new CreateWorkflowOptions(pathWorkspaceSid, friendlyName, configuration){  AssignmentCallbackUrl = assignmentCallbackUrl, FallbackAssignmentCallbackUrl = fallbackAssignmentCallbackUrl, TaskReservationTimeout = taskReservationTimeout };
            return await CreateAsync(options, client);
        }
        #endif
        
        /// <summary> delete </summary>
        /// <param name="options"> Delete Workflow parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of Workflow </returns>
        private static Request BuildDeleteRequest(DeleteWorkflowOptions options, ITwilioRestClient client)
        {
            
            string path = "/v1/Workspaces/{WorkspaceSid}/Workflows/{Sid}";

            string PathWorkspaceSid = options.PathWorkspaceSid;
            path = path.Replace("{"+"WorkspaceSid"+"}", PathWorkspaceSid);
            string PathSid = options.PathSid;
            path = path.Replace("{"+"Sid"+"}", PathSid);

            return new Request(
                HttpMethod.Delete,
                Rest.Domain.Taskrouter,
                path,
                queryParams: options.GetParams(),
                headerParams: null
            );
        }

        /// <summary> delete </summary>
        /// <param name="options"> Delete Workflow parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of Workflow </returns>
        public static bool Delete(DeleteWorkflowOptions options, ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = client.Request(BuildDeleteRequest(options, client));
            return response.StatusCode == System.Net.HttpStatusCode.NoContent;
        }

        #if !NET35
        /// <summary> delete </summary>
        /// <param name="options"> Delete Workflow parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of Workflow </returns>
        public static async System.Threading.Tasks.Task<bool> DeleteAsync(DeleteWorkflowOptions options,
                                                                        ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = await client.RequestAsync(BuildDeleteRequest(options, client));
            return response.StatusCode == System.Net.HttpStatusCode.NoContent;
        }
        #endif

        /// <summary> delete </summary>
        /// <param name="pathWorkspaceSid"> The SID of the Workspace with the Workflow to delete. </param>
        /// <param name="pathSid"> The SID of the Workflow resource to delete. </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of Workflow </returns>
        public static bool Delete(string pathWorkspaceSid, string pathSid, ITwilioRestClient client = null)
        {
            var options = new DeleteWorkflowOptions(pathWorkspaceSid, pathSid)        ;
            return Delete(options, client);
        }

        #if !NET35
        /// <summary> delete </summary>
        /// <param name="pathWorkspaceSid"> The SID of the Workspace with the Workflow to delete. </param>
        /// <param name="pathSid"> The SID of the Workflow resource to delete. </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of Workflow </returns>
        public static async System.Threading.Tasks.Task<bool> DeleteAsync(string pathWorkspaceSid, string pathSid, ITwilioRestClient client = null)
        {
            var options = new DeleteWorkflowOptions(pathWorkspaceSid, pathSid) ;
            return await DeleteAsync(options, client);
        }
        #endif
        
        private static Request BuildFetchRequest(FetchWorkflowOptions options, ITwilioRestClient client)
        {
            
            string path = "/v1/Workspaces/{WorkspaceSid}/Workflows/{Sid}";

            string PathWorkspaceSid = options.PathWorkspaceSid;
            path = path.Replace("{"+"WorkspaceSid"+"}", PathWorkspaceSid);
            string PathSid = options.PathSid;
            path = path.Replace("{"+"Sid"+"}", PathSid);

            return new Request(
                HttpMethod.Get,
                Rest.Domain.Taskrouter,
                path,
                queryParams: options.GetParams(),
                headerParams: null
            );
        }

        /// <summary> fetch </summary>
        /// <param name="options"> Fetch Workflow parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of Workflow </returns>
        public static WorkflowResource Fetch(FetchWorkflowOptions options, ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = client.Request(BuildFetchRequest(options, client));
            return FromJson(response.Content);
        }

        #if !NET35
        /// <summary> fetch </summary>
        /// <param name="options"> Fetch Workflow parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of Workflow </returns>
        public static async System.Threading.Tasks.Task<WorkflowResource> FetchAsync(FetchWorkflowOptions options, ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = await client.RequestAsync(BuildFetchRequest(options, client));
            return FromJson(response.Content);
        }
        #endif
        /// <summary> fetch </summary>
        /// <param name="pathWorkspaceSid"> The SID of the Workspace with the Workflow to fetch. </param>
        /// <param name="pathSid"> The SID of the Workflow resource to fetch. </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of Workflow </returns>
        public static WorkflowResource Fetch(
                                         string pathWorkspaceSid, 
                                         string pathSid, 
                                        ITwilioRestClient client = null)
        {
            var options = new FetchWorkflowOptions(pathWorkspaceSid, pathSid){  };
            return Fetch(options, client);
        }

        #if !NET35
        /// <summary> fetch </summary>
        /// <param name="pathWorkspaceSid"> The SID of the Workspace with the Workflow to fetch. </param>
        /// <param name="pathSid"> The SID of the Workflow resource to fetch. </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of Workflow </returns>
        public static async System.Threading.Tasks.Task<WorkflowResource> FetchAsync(string pathWorkspaceSid, string pathSid, ITwilioRestClient client = null)
        {
            var options = new FetchWorkflowOptions(pathWorkspaceSid, pathSid){  };
            return await FetchAsync(options, client);
        }
        #endif
        
        private static Request BuildReadRequest(ReadWorkflowOptions options, ITwilioRestClient client)
        {
            
            string path = "/v1/Workspaces/{WorkspaceSid}/Workflows";

            string PathWorkspaceSid = options.PathWorkspaceSid;
            path = path.Replace("{"+"WorkspaceSid"+"}", PathWorkspaceSid);

            return new Request(
                HttpMethod.Get,
                Rest.Domain.Taskrouter,
                path,
                queryParams: options.GetParams(),
                headerParams: null
            );
        }
        /// <summary> read </summary>
        /// <param name="options"> Read Workflow parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of Workflow </returns>
        public static ResourceSet<WorkflowResource> Read(ReadWorkflowOptions options, ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = client.Request(BuildReadRequest(options, client));
            var page = Page<WorkflowResource>.FromJson("workflows", response.Content);
            return new ResourceSet<WorkflowResource>(page, options, client);
        }

        #if !NET35
        /// <summary> read </summary>
        /// <param name="options"> Read Workflow parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of Workflow </returns>
        public static async System.Threading.Tasks.Task<ResourceSet<WorkflowResource>> ReadAsync(ReadWorkflowOptions options, ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = await client.RequestAsync(BuildReadRequest(options, client));

            var page = Page<WorkflowResource>.FromJson("workflows", response.Content);
            return new ResourceSet<WorkflowResource>(page, options, client);
        }
        #endif
        /// <summary> read </summary>
        /// <param name="pathWorkspaceSid"> The SID of the Workspace with the Workflow to read. </param>
        /// <param name="friendlyName"> The `friendly_name` of the Workflow resources to read. </param>
        /// <param name="pageSize"> How many resources to return in each list page. The default is 50, and the maximum is 1000. </param>
        /// <param name="limit"> Record limit </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of Workflow </returns>
        public static ResourceSet<WorkflowResource> Read(
                                                     string pathWorkspaceSid,
                                                     string friendlyName = null,
                                                     int? pageSize = null,
                                                     long? limit = null,
                                                    ITwilioRestClient client = null)
        {
            var options = new ReadWorkflowOptions(pathWorkspaceSid){ FriendlyName = friendlyName, PageSize = pageSize, Limit = limit};
            return Read(options, client);
        }

        #if !NET35
        /// <summary> read </summary>
        /// <param name="pathWorkspaceSid"> The SID of the Workspace with the Workflow to read. </param>
        /// <param name="friendlyName"> The `friendly_name` of the Workflow resources to read. </param>
        /// <param name="pageSize"> How many resources to return in each list page. The default is 50, and the maximum is 1000. </param>
        /// <param name="limit"> Record limit </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of Workflow </returns>
        public static async System.Threading.Tasks.Task<ResourceSet<WorkflowResource>> ReadAsync(
                                                                                             string pathWorkspaceSid,
                                                                                             string friendlyName = null,
                                                                                             int? pageSize = null,
                                                                                             long? limit = null,
                                                                                            ITwilioRestClient client = null)
        {
            var options = new ReadWorkflowOptions(pathWorkspaceSid){ FriendlyName = friendlyName, PageSize = pageSize, Limit = limit};
            return await ReadAsync(options, client);
        }
        #endif

        
        /// <summary> Fetch the target page of records </summary>
        /// <param name="targetUrl"> API-generated URL for the requested results page </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> The target page of records </returns>
        public static Page<WorkflowResource> GetPage(string targetUrl, ITwilioRestClient client)
        {
            client = client ?? TwilioClient.GetRestClient();

            var request = new Request(
                HttpMethod.Get,
                targetUrl
            );

            var response = client.Request(request);
            return Page<WorkflowResource>.FromJson("workflows", response.Content);
        }

        /// <summary> Fetch the next page of records </summary>
        /// <param name="page"> current page of records </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> The next page of records </returns>
        public static Page<WorkflowResource> NextPage(Page<WorkflowResource> page, ITwilioRestClient client)
        {
            var request = new Request(
                HttpMethod.Get,
                page.GetNextPageUrl(Rest.Domain.Api)
            );

            var response = client.Request(request);
            return Page<WorkflowResource>.FromJson("workflows", response.Content);
        }

        /// <summary> Fetch the previous page of records </summary>
        /// <param name="page"> current page of records </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> The previous page of records </returns>
        public static Page<WorkflowResource> PreviousPage(Page<WorkflowResource> page, ITwilioRestClient client)
        {
            var request = new Request(
                HttpMethod.Get,
                page.GetPreviousPageUrl(Rest.Domain.Api)
            );

            var response = client.Request(request);
            return Page<WorkflowResource>.FromJson("workflows", response.Content);
        }

        
        private static Request BuildUpdateRequest(UpdateWorkflowOptions options, ITwilioRestClient client)
        {
            
            string path = "/v1/Workspaces/{WorkspaceSid}/Workflows/{Sid}";

            string PathWorkspaceSid = options.PathWorkspaceSid;
            path = path.Replace("{"+"WorkspaceSid"+"}", PathWorkspaceSid);
            string PathSid = options.PathSid;
            path = path.Replace("{"+"Sid"+"}", PathSid);

            return new Request(
                HttpMethod.Post,
                Rest.Domain.Taskrouter,
                path,
                contentType: EnumConstants.ContentTypeEnum.FORM_URLENCODED,
                postParams: options.GetParams(),
                headerParams: null
            );
        }

        /// <summary> update </summary>
        /// <param name="options"> Update Workflow parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of Workflow </returns>
        public static WorkflowResource Update(UpdateWorkflowOptions options, ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = client.Request(BuildUpdateRequest(options, client));
            return FromJson(response.Content);
        }

        /// <summary> update </summary>
        /// <param name="options"> Update Workflow parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of Workflow </returns>
        #if !NET35
        public static async System.Threading.Tasks.Task<WorkflowResource> UpdateAsync(UpdateWorkflowOptions options,
                                                                                                    ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = await client.RequestAsync(BuildUpdateRequest(options, client));
            return FromJson(response.Content);
        }
        #endif

        /// <summary> update </summary>
        /// <param name="pathWorkspaceSid"> The SID of the Workspace with the Workflow to update. </param>
        /// <param name="pathSid"> The SID of the Workflow resource to update. </param>
        /// <param name="friendlyName"> A descriptive string that you create to describe the Workflow resource. For example, `Inbound Call Workflow` or `2014 Outbound Campaign`. </param>
        /// <param name="assignmentCallbackUrl"> The URL from your application that will process task assignment events. See [Handling Task Assignment Callback](https://www.twilio.com/docs/taskrouter/handle-assignment-callbacks) for more details. </param>
        /// <param name="fallbackAssignmentCallbackUrl"> The URL that we should call when a call to the `assignment_callback_url` fails. </param>
        /// <param name="configuration"> A JSON string that contains the rules to apply to the Workflow. See [Configuring Workflows](https://www.twilio.com/docs/taskrouter/workflow-configuration) for more information. </param>
        /// <param name="taskReservationTimeout"> How long TaskRouter will wait for a confirmation response from your application after it assigns a Task to a Worker. Can be up to `86,400` (24 hours) and the default is `120`. </param>
        /// <param name="reEvaluateTasks"> Whether or not to re-evaluate Tasks. The default is `false`, which means Tasks in the Workflow will not be processed through the assignment loop again. </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of Workflow </returns>
        public static WorkflowResource Update(
                                          string pathWorkspaceSid,
                                          string pathSid,
                                          string friendlyName = null,
                                          Uri assignmentCallbackUrl = null,
                                          Uri fallbackAssignmentCallbackUrl = null,
                                          string configuration = null,
                                          int? taskReservationTimeout = null,
                                          string reEvaluateTasks = null,
                                            ITwilioRestClient client = null)
        {
            var options = new UpdateWorkflowOptions(pathWorkspaceSid, pathSid){ FriendlyName = friendlyName, AssignmentCallbackUrl = assignmentCallbackUrl, FallbackAssignmentCallbackUrl = fallbackAssignmentCallbackUrl, Configuration = configuration, TaskReservationTimeout = taskReservationTimeout, ReEvaluateTasks = reEvaluateTasks };
            return Update(options, client);
        }

        #if !NET35
        /// <summary> update </summary>
        /// <param name="pathWorkspaceSid"> The SID of the Workspace with the Workflow to update. </param>
        /// <param name="pathSid"> The SID of the Workflow resource to update. </param>
        /// <param name="friendlyName"> A descriptive string that you create to describe the Workflow resource. For example, `Inbound Call Workflow` or `2014 Outbound Campaign`. </param>
        /// <param name="assignmentCallbackUrl"> The URL from your application that will process task assignment events. See [Handling Task Assignment Callback](https://www.twilio.com/docs/taskrouter/handle-assignment-callbacks) for more details. </param>
        /// <param name="fallbackAssignmentCallbackUrl"> The URL that we should call when a call to the `assignment_callback_url` fails. </param>
        /// <param name="configuration"> A JSON string that contains the rules to apply to the Workflow. See [Configuring Workflows](https://www.twilio.com/docs/taskrouter/workflow-configuration) for more information. </param>
        /// <param name="taskReservationTimeout"> How long TaskRouter will wait for a confirmation response from your application after it assigns a Task to a Worker. Can be up to `86,400` (24 hours) and the default is `120`. </param>
        /// <param name="reEvaluateTasks"> Whether or not to re-evaluate Tasks. The default is `false`, which means Tasks in the Workflow will not be processed through the assignment loop again. </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of Workflow </returns>
        public static async System.Threading.Tasks.Task<WorkflowResource> UpdateAsync(
                                                                              string pathWorkspaceSid,
                                                                              string pathSid,
                                                                              string friendlyName = null,
                                                                              Uri assignmentCallbackUrl = null,
                                                                              Uri fallbackAssignmentCallbackUrl = null,
                                                                              string configuration = null,
                                                                              int? taskReservationTimeout = null,
                                                                              string reEvaluateTasks = null,
                                                                                ITwilioRestClient client = null)
        {
            var options = new UpdateWorkflowOptions(pathWorkspaceSid, pathSid){ FriendlyName = friendlyName, AssignmentCallbackUrl = assignmentCallbackUrl, FallbackAssignmentCallbackUrl = fallbackAssignmentCallbackUrl, Configuration = configuration, TaskReservationTimeout = taskReservationTimeout, ReEvaluateTasks = reEvaluateTasks };
            return await UpdateAsync(options, client);
        }
        #endif
    
        /// <summary>
        /// Converts a JSON string into a WorkflowResource object
        /// </summary>
        /// <param name="json"> Raw JSON string </param>
        /// <returns> WorkflowResource object represented by the provided JSON </returns>
        public static WorkflowResource FromJson(string json)
        {
            try
            {
                return JsonConvert.DeserializeObject<WorkflowResource>(json);
            }
            catch (JsonException e)
            {
                throw new ApiException(e.Message, e);
            }
        }
        /// <summary>
    /// Converts an object into a json string
    /// </summary>
    /// <param name="model"> C# model </param>
    /// <returns> JSON string </returns>
    public static string ToJson(object model)
    {
        try
        {
            return JsonConvert.SerializeObject(model);
        }
        catch (JsonException e)
        {
            throw new ApiException(e.Message, e);
        }
    }

    
        ///<summary> The SID of the [Account](https://www.twilio.com/docs/iam/api/account) that created the Workflow resource. </summary> 
        [JsonProperty("account_sid")]
        public string AccountSid { get; private set; }

        ///<summary> The URL that we call when a task managed by the Workflow is assigned to a Worker. See Assignment Callback URL for more information. </summary> 
        [JsonProperty("assignment_callback_url")]
        public Uri AssignmentCallbackUrl { get; private set; }

        ///<summary> A JSON string that contains the Workflow's configuration. See [Configuring Workflows](https://www.twilio.com/docs/taskrouter/workflow-configuration) for more information. </summary> 
        [JsonProperty("configuration")]
        public string Configuration { get; private set; }

        ///<summary> The date and time in GMT when the resource was created specified in [RFC 2822](https://www.ietf.org/rfc/rfc2822.txt) format. </summary> 
        [JsonProperty("date_created")]
        public DateTime? DateCreated { get; private set; }

        ///<summary> The date and time in GMT when the resource was last updated specified in [RFC 2822](https://www.ietf.org/rfc/rfc2822.txt) format. </summary> 
        [JsonProperty("date_updated")]
        public DateTime? DateUpdated { get; private set; }

        ///<summary> The MIME type of the document. </summary> 
        [JsonProperty("document_content_type")]
        public string DocumentContentType { get; private set; }

        ///<summary> The URL that we call when a call to the `assignment_callback_url` fails. </summary> 
        [JsonProperty("fallback_assignment_callback_url")]
        public Uri FallbackAssignmentCallbackUrl { get; private set; }

        ///<summary> The string that you assigned to describe the Workflow resource. For example, `Customer Support` or `2014 Election Campaign`. </summary> 
        [JsonProperty("friendly_name")]
        public string FriendlyName { get; private set; }

        ///<summary> The unique string that we created to identify the Workflow resource. </summary> 
        [JsonProperty("sid")]
        public string Sid { get; private set; }

        ///<summary> How long TaskRouter will wait for a confirmation response from your application after it assigns a Task to a Worker. Can be up to `86,400` (24 hours) and the default is `120`. </summary> 
        [JsonProperty("task_reservation_timeout")]
        public int? TaskReservationTimeout { get; private set; }

        ///<summary> The SID of the Workspace that contains the Workflow. </summary> 
        [JsonProperty("workspace_sid")]
        public string WorkspaceSid { get; private set; }

        ///<summary> The absolute URL of the Workflow resource. </summary> 
        [JsonProperty("url")]
        public Uri Url { get; private set; }

        ///<summary> The URLs of related resources. </summary> 
        [JsonProperty("links")]
        public Dictionary<string, string> Links { get; private set; }



        private WorkflowResource() {

        }
    }
}

