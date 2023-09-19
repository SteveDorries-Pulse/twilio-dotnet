/*
 * This code was generated by
 * ___ _ _ _ _ _    _ ____    ____ ____ _    ____ ____ _  _ ____ ____ ____ ___ __   __
 *  |  | | | | |    | |  | __ |  | |__| | __ | __ |___ |\ | |___ |__/ |__|  | |  | |__/
 *  |  |_|_| | |___ | |__|    |__| |  | |    |__] |___ | \| |___ |  \ |  |  | |__| |  \
 *
 * Twilio - Conversations
 * This is the public Twilio REST API.
 *
 * NOTE: This class is auto generated by OpenAPI Generator.
 * https://openapi-generator.tech
 * Do not edit the class manually.
 */


using System;
using System.Collections.Generic;
using Twilio.Base;
using Twilio.Converters;




namespace Twilio.Rest.Conversations.V1.User
{
    /// <summary> Delete a specific User Conversation. </summary>
    public class DeleteUserConversationOptions : IOptions<UserConversationResource>
    {
        
        ///<summary> The unique SID identifier of the [User resource](https://www.twilio.com/docs/conversations/api/user-resource). This value can be either the `sid` or the `identity` of the User resource. </summary> 
        public string PathUserSid { get; }

        ///<summary> The unique SID identifier of the Conversation. This value can be either the `sid` or the `unique_name` of the [Conversation resource](https://www.twilio.com/docs/conversations/api/conversation-resource). </summary> 
        public string PathConversationSid { get; }



        /// <summary> Construct a new DeleteUserConversationOptions </summary>
        /// <param name="pathUserSid"> The unique SID identifier of the [User resource](https://www.twilio.com/docs/conversations/api/user-resource). This value can be either the `sid` or the `identity` of the User resource. </param>
        /// <param name="pathConversationSid"> The unique SID identifier of the Conversation. This value can be either the `sid` or the `unique_name` of the [Conversation resource](https://www.twilio.com/docs/conversations/api/conversation-resource). </param>
        public DeleteUserConversationOptions(string pathUserSid, string pathConversationSid)
        {
            PathUserSid = pathUserSid;
            PathConversationSid = pathConversationSid;
        }

        
        /// <summary> Generate the necessary parameters </summary>
        public List<KeyValuePair<string, string>> GetParams()
        {
            var p = new List<KeyValuePair<string, string>>();

            return p;
        }
        

    }


    /// <summary> Fetch a specific User Conversation. </summary>
    public class FetchUserConversationOptions : IOptions<UserConversationResource>
    {
    
        ///<summary> The unique SID identifier of the [User resource](https://www.twilio.com/docs/conversations/api/user-resource). This value can be either the `sid` or the `identity` of the User resource. </summary> 
        public string PathUserSid { get; }

        ///<summary> The unique SID identifier of the Conversation. This value can be either the `sid` or the `unique_name` of the [Conversation resource](https://www.twilio.com/docs/conversations/api/conversation-resource). </summary> 
        public string PathConversationSid { get; }



        /// <summary> Construct a new FetchUserConversationOptions </summary>
        /// <param name="pathUserSid"> The unique SID identifier of the [User resource](https://www.twilio.com/docs/conversations/api/user-resource). This value can be either the `sid` or the `identity` of the User resource. </param>
        /// <param name="pathConversationSid"> The unique SID identifier of the Conversation. This value can be either the `sid` or the `unique_name` of the [Conversation resource](https://www.twilio.com/docs/conversations/api/conversation-resource). </param>
        public FetchUserConversationOptions(string pathUserSid, string pathConversationSid)
        {
            PathUserSid = pathUserSid;
            PathConversationSid = pathConversationSid;
        }

        
        /// <summary> Generate the necessary parameters </summary>
        public List<KeyValuePair<string, string>> GetParams()
        {
            var p = new List<KeyValuePair<string, string>>();

            return p;
        }
        

    }


    /// <summary> Retrieve a list of all User Conversations for the User. </summary>
    public class ReadUserConversationOptions : ReadOptions<UserConversationResource>
    {
    
        ///<summary> The unique SID identifier of the [User resource](https://www.twilio.com/docs/conversations/api/user-resource). This value can be either the `sid` or the `identity` of the User resource. </summary> 
        public string PathUserSid { get; }



        /// <summary> Construct a new ListUserConversationOptions </summary>
        /// <param name="pathUserSid"> The unique SID identifier of the [User resource](https://www.twilio.com/docs/conversations/api/user-resource). This value can be either the `sid` or the `identity` of the User resource. </param>
        public ReadUserConversationOptions(string pathUserSid)
        {
            PathUserSid = pathUserSid;
        }

        
        /// <summary> Generate the necessary parameters </summary>
        public List<KeyValuePair<string, string>> GetParams()
        {
            var p = new List<KeyValuePair<string, string>>();

            if (PageSize != null)
            {
                p.Add(new KeyValuePair<string, string>("PageSize", PageSize.ToString()));
            }
            return p;
        }
        

    }

    /// <summary> Update a specific User Conversation. </summary>
    public class UpdateUserConversationOptions : IOptions<UserConversationResource>
    {
    
        ///<summary> The unique SID identifier of the [User resource](https://www.twilio.com/docs/conversations/api/user-resource). This value can be either the `sid` or the `identity` of the User resource. </summary> 
        public string PathUserSid { get; }

        ///<summary> The unique SID identifier of the Conversation. This value can be either the `sid` or the `unique_name` of the [Conversation resource](https://www.twilio.com/docs/conversations/api/conversation-resource). </summary> 
        public string PathConversationSid { get; }

        
        public UserConversationResource.NotificationLevelEnum NotificationLevel { get; set; }

        ///<summary> The date of the last message read in conversation by the user, given in ISO 8601 format. </summary> 
        public DateTime? LastReadTimestamp { get; set; }

        ///<summary> The index of the last Message in the Conversation that the Participant has read. </summary> 
        public int? LastReadMessageIndex { get; set; }



        /// <summary> Construct a new UpdateUserConversationOptions </summary>
        /// <param name="pathUserSid"> The unique SID identifier of the [User resource](https://www.twilio.com/docs/conversations/api/user-resource). This value can be either the `sid` or the `identity` of the User resource. </param>
        /// <param name="pathConversationSid"> The unique SID identifier of the Conversation. This value can be either the `sid` or the `unique_name` of the [Conversation resource](https://www.twilio.com/docs/conversations/api/conversation-resource). </param>
        public UpdateUserConversationOptions(string pathUserSid, string pathConversationSid)
        {
            PathUserSid = pathUserSid;
            PathConversationSid = pathConversationSid;
        }

        
        /// <summary> Generate the necessary parameters </summary>
        public List<KeyValuePair<string, string>> GetParams()
        {
            var p = new List<KeyValuePair<string, string>>();

            if (NotificationLevel != null)
            {
                p.Add(new KeyValuePair<string, string>("NotificationLevel", NotificationLevel.ToString()));
            }
            if (LastReadTimestamp != null)
            {
                p.Add(new KeyValuePair<string, string>("LastReadTimestamp", Serializers.DateTimeIso8601(LastReadTimestamp)));
            }
            if (LastReadMessageIndex != null)
            {
                p.Add(new KeyValuePair<string, string>("LastReadMessageIndex", LastReadMessageIndex.ToString()));
            }
            return p;
        }
        

    }


}

