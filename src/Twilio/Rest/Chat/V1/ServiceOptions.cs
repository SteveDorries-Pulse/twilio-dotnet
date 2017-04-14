using System;
using System.Collections.Generic;
using System.Linq;
using Twilio.Base;

namespace Twilio.Rest.Chat.V1 
{

    /// <summary>
    /// FetchServiceOptions
    /// </summary>
    public class FetchServiceOptions : IOptions<ServiceResource> 
    {
        /// <summary>
        /// The sid
        /// </summary>
        public string PathSid { get; }

        /// <summary>
        /// Construct a new FetchServiceOptions
        /// </summary>
        ///
        /// <param name="pathSid"> The sid </param>
        public FetchServiceOptions(string pathSid)
        {
            PathSid = pathSid;
        }

        /// <summary>
        /// Generate the necessary parameters
        /// </summary>
        public List<KeyValuePair<string, string>> GetParams()
        {
            var p = new List<KeyValuePair<string, string>>();
            return p;
        }
    }

    /// <summary>
    /// DeleteServiceOptions
    /// </summary>
    public class DeleteServiceOptions : IOptions<ServiceResource> 
    {
        /// <summary>
        /// The sid
        /// </summary>
        public string PathSid { get; }

        /// <summary>
        /// Construct a new DeleteServiceOptions
        /// </summary>
        ///
        /// <param name="pathSid"> The sid </param>
        public DeleteServiceOptions(string pathSid)
        {
            PathSid = pathSid;
        }

        /// <summary>
        /// Generate the necessary parameters
        /// </summary>
        public List<KeyValuePair<string, string>> GetParams()
        {
            var p = new List<KeyValuePair<string, string>>();
            return p;
        }
    }

    /// <summary>
    /// CreateServiceOptions
    /// </summary>
    public class CreateServiceOptions : IOptions<ServiceResource> 
    {
        /// <summary>
        /// The friendly_name
        /// </summary>
        public string FriendlyName { get; }

        /// <summary>
        /// Construct a new CreateServiceOptions
        /// </summary>
        ///
        /// <param name="friendlyName"> The friendly_name </param>
        public CreateServiceOptions(string friendlyName)
        {
            FriendlyName = friendlyName;
        }

        /// <summary>
        /// Generate the necessary parameters
        /// </summary>
        public List<KeyValuePair<string, string>> GetParams()
        {
            var p = new List<KeyValuePair<string, string>>();
            if (FriendlyName != null)
            {
                p.Add(new KeyValuePair<string, string>("FriendlyName", FriendlyName));
            }

            return p;
        }
    }

    /// <summary>
    /// ReadServiceOptions
    /// </summary>
    public class ReadServiceOptions : ReadOptions<ServiceResource> 
    {
        /// <summary>
        /// Generate the necessary parameters
        /// </summary>
        public override List<KeyValuePair<string, string>> GetParams()
        {
            var p = new List<KeyValuePair<string, string>>();
            if (PageSize != null)
            {
                p.Add(new KeyValuePair<string, string>("PageSize", PageSize.ToString()));
            }

            return p;
        }
    }

    /// <summary>
    /// UpdateServiceOptions
    /// </summary>
    public class UpdateServiceOptions : IOptions<ServiceResource> 
    {
        /// <summary>
        /// The sid
        /// </summary>
        public string PathSid { get; }
        /// <summary>
        /// The friendly_name
        /// </summary>
        public string FriendlyName { get; set; }
        /// <summary>
        /// The default_service_role_sid
        /// </summary>
        public string DefaultServiceRoleSid { get; set; }
        /// <summary>
        /// The default_channel_role_sid
        /// </summary>
        public string DefaultChannelRoleSid { get; set; }
        /// <summary>
        /// The default_channel_creator_role_sid
        /// </summary>
        public string DefaultChannelCreatorRoleSid { get; set; }
        /// <summary>
        /// The read_status_enabled
        /// </summary>
        public bool? ReadStatusEnabled { get; set; }
        /// <summary>
        /// The reachability_enabled
        /// </summary>
        public bool? ReachabilityEnabled { get; set; }
        /// <summary>
        /// The typing_indicator_timeout
        /// </summary>
        public int? TypingIndicatorTimeout { get; set; }
        /// <summary>
        /// The consumption_report_interval
        /// </summary>
        public int? ConsumptionReportInterval { get; set; }
        /// <summary>
        /// The notifications.new_message.enabled
        /// </summary>
        public bool? NotificationsNewMessageEnabled { get; set; }
        /// <summary>
        /// The notifications.new_message.template
        /// </summary>
        public string NotificationsNewMessageTemplate { get; set; }
        /// <summary>
        /// The notifications.added_to_channel.enabled
        /// </summary>
        public bool? NotificationsAddedToChannelEnabled { get; set; }
        /// <summary>
        /// The notifications.added_to_channel.template
        /// </summary>
        public string NotificationsAddedToChannelTemplate { get; set; }
        /// <summary>
        /// The notifications.removed_from_channel.enabled
        /// </summary>
        public bool? NotificationsRemovedFromChannelEnabled { get; set; }
        /// <summary>
        /// The notifications.removed_from_channel.template
        /// </summary>
        public string NotificationsRemovedFromChannelTemplate { get; set; }
        /// <summary>
        /// The notifications.invited_to_channel.enabled
        /// </summary>
        public bool? NotificationsInvitedToChannelEnabled { get; set; }
        /// <summary>
        /// The notifications.invited_to_channel.template
        /// </summary>
        public string NotificationsInvitedToChannelTemplate { get; set; }
        /// <summary>
        /// The pre_webhook_url
        /// </summary>
        public Uri PreWebhookUrl { get; set; }
        /// <summary>
        /// The post_webhook_url
        /// </summary>
        public Uri PostWebhookUrl { get; set; }
        /// <summary>
        /// The webhook_method
        /// </summary>
        public Twilio.Http.HttpMethod WebhookMethod { get; set; }
        /// <summary>
        /// The webhook_filters
        /// </summary>
        public List<string> WebhookFilters { get; set; }
        /// <summary>
        /// The webhooks.on_message_send.url
        /// </summary>
        public Uri WebhooksOnMessageSendUrl { get; set; }
        /// <summary>
        /// The webhooks.on_message_send.method
        /// </summary>
        public Twilio.Http.HttpMethod WebhooksOnMessageSendMethod { get; set; }
        /// <summary>
        /// The webhooks.on_message_send.format
        /// </summary>
        public string WebhooksOnMessageSendFormat { get; set; }
        /// <summary>
        /// The webhooks.on_message_update.url
        /// </summary>
        public Uri WebhooksOnMessageUpdateUrl { get; set; }
        /// <summary>
        /// The webhooks.on_message_update.method
        /// </summary>
        public Twilio.Http.HttpMethod WebhooksOnMessageUpdateMethod { get; set; }
        /// <summary>
        /// The webhooks.on_message_update.format
        /// </summary>
        public string WebhooksOnMessageUpdateFormat { get; set; }
        /// <summary>
        /// The webhooks.on_message_remove.url
        /// </summary>
        public Uri WebhooksOnMessageRemoveUrl { get; set; }
        /// <summary>
        /// The webhooks.on_message_remove.method
        /// </summary>
        public Twilio.Http.HttpMethod WebhooksOnMessageRemoveMethod { get; set; }
        /// <summary>
        /// The webhooks.on_message_remove.format
        /// </summary>
        public string WebhooksOnMessageRemoveFormat { get; set; }
        /// <summary>
        /// The webhooks.on_channel_add.url
        /// </summary>
        public Uri WebhooksOnChannelAddUrl { get; set; }
        /// <summary>
        /// The webhooks.on_channel_add.method
        /// </summary>
        public Twilio.Http.HttpMethod WebhooksOnChannelAddMethod { get; set; }
        /// <summary>
        /// The webhooks.on_channel_add.format
        /// </summary>
        public string WebhooksOnChannelAddFormat { get; set; }
        /// <summary>
        /// The webhooks.on_channel_destroy.url
        /// </summary>
        public Uri WebhooksOnChannelDestroyUrl { get; set; }
        /// <summary>
        /// The webhooks.on_channel_destroy.method
        /// </summary>
        public Twilio.Http.HttpMethod WebhooksOnChannelDestroyMethod { get; set; }
        /// <summary>
        /// The webhooks.on_channel_destroy.format
        /// </summary>
        public string WebhooksOnChannelDestroyFormat { get; set; }
        /// <summary>
        /// The webhooks.on_channel_update.url
        /// </summary>
        public Uri WebhooksOnChannelUpdateUrl { get; set; }
        /// <summary>
        /// The webhooks.on_channel_update.method
        /// </summary>
        public Twilio.Http.HttpMethod WebhooksOnChannelUpdateMethod { get; set; }
        /// <summary>
        /// The webhooks.on_channel_update.format
        /// </summary>
        public string WebhooksOnChannelUpdateFormat { get; set; }
        /// <summary>
        /// The webhooks.on_member_add.url
        /// </summary>
        public Uri WebhooksOnMemberAddUrl { get; set; }
        /// <summary>
        /// The webhooks.on_member_add.method
        /// </summary>
        public Twilio.Http.HttpMethod WebhooksOnMemberAddMethod { get; set; }
        /// <summary>
        /// The webhooks.on_member_add.format
        /// </summary>
        public string WebhooksOnMemberAddFormat { get; set; }
        /// <summary>
        /// The webhooks.on_member_remove.url
        /// </summary>
        public Uri WebhooksOnMemberRemoveUrl { get; set; }
        /// <summary>
        /// The webhooks.on_member_remove.method
        /// </summary>
        public Twilio.Http.HttpMethod WebhooksOnMemberRemoveMethod { get; set; }
        /// <summary>
        /// The webhooks.on_member_remove.format
        /// </summary>
        public string WebhooksOnMemberRemoveFormat { get; set; }
        /// <summary>
        /// The webhooks.on_message_sent.url
        /// </summary>
        public Uri WebhooksOnMessageSentUrl { get; set; }
        /// <summary>
        /// The webhooks.on_message_sent.method
        /// </summary>
        public Twilio.Http.HttpMethod WebhooksOnMessageSentMethod { get; set; }
        /// <summary>
        /// The webhooks.on_message_sent.format
        /// </summary>
        public string WebhooksOnMessageSentFormat { get; set; }
        /// <summary>
        /// The webhooks.on_message_updated.url
        /// </summary>
        public Uri WebhooksOnMessageUpdatedUrl { get; set; }
        /// <summary>
        /// The webhooks.on_message_updated.method
        /// </summary>
        public Twilio.Http.HttpMethod WebhooksOnMessageUpdatedMethod { get; set; }
        /// <summary>
        /// The webhooks.on_message_updated.format
        /// </summary>
        public string WebhooksOnMessageUpdatedFormat { get; set; }
        /// <summary>
        /// The webhooks.on_message_removed.url
        /// </summary>
        public Uri WebhooksOnMessageRemovedUrl { get; set; }
        /// <summary>
        /// The webhooks.on_message_removed.method
        /// </summary>
        public Twilio.Http.HttpMethod WebhooksOnMessageRemovedMethod { get; set; }
        /// <summary>
        /// The webhooks.on_message_removed.format
        /// </summary>
        public string WebhooksOnMessageRemovedFormat { get; set; }
        /// <summary>
        /// The webhooks.on_channel_added.url
        /// </summary>
        public Uri WebhooksOnChannelAddedUrl { get; set; }
        /// <summary>
        /// The webhooks.on_channel_added.method
        /// </summary>
        public Twilio.Http.HttpMethod WebhooksOnChannelAddedMethod { get; set; }
        /// <summary>
        /// The webhooks.on_channel_added.format
        /// </summary>
        public string WebhooksOnChannelAddedFormat { get; set; }
        /// <summary>
        /// The webhooks.on_channel_destroyed.url
        /// </summary>
        public Uri WebhooksOnChannelDestroyedUrl { get; set; }
        /// <summary>
        /// The webhooks.on_channel_destroyed.method
        /// </summary>
        public Twilio.Http.HttpMethod WebhooksOnChannelDestroyedMethod { get; set; }
        /// <summary>
        /// The webhooks.on_channel_destroyed.format
        /// </summary>
        public string WebhooksOnChannelDestroyedFormat { get; set; }
        /// <summary>
        /// The webhooks.on_channel_updated.url
        /// </summary>
        public Uri WebhooksOnChannelUpdatedUrl { get; set; }
        /// <summary>
        /// The webhooks.on_channel_updated.method
        /// </summary>
        public Twilio.Http.HttpMethod WebhooksOnChannelUpdatedMethod { get; set; }
        /// <summary>
        /// The webhooks.on_channel_updated.format
        /// </summary>
        public string WebhooksOnChannelUpdatedFormat { get; set; }
        /// <summary>
        /// The webhooks.on_member_added.url
        /// </summary>
        public Uri WebhooksOnMemberAddedUrl { get; set; }
        /// <summary>
        /// The webhooks.on_member_added.method
        /// </summary>
        public Twilio.Http.HttpMethod WebhooksOnMemberAddedMethod { get; set; }
        /// <summary>
        /// The webhooks.on_member_added.format
        /// </summary>
        public string WebhooksOnMemberAddedFormat { get; set; }
        /// <summary>
        /// The webhooks.on_member_removed.url
        /// </summary>
        public Uri WebhooksOnMemberRemovedUrl { get; set; }
        /// <summary>
        /// The webhooks.on_member_removed.method
        /// </summary>
        public Twilio.Http.HttpMethod WebhooksOnMemberRemovedMethod { get; set; }
        /// <summary>
        /// The webhooks.on_member_removed.format
        /// </summary>
        public string WebhooksOnMemberRemovedFormat { get; set; }
        /// <summary>
        /// The limits.channel_members
        /// </summary>
        public int? LimitsChannelMembers { get; set; }
        /// <summary>
        /// The limits.user_channels
        /// </summary>
        public int? LimitsUserChannels { get; set; }

        /// <summary>
        /// Construct a new UpdateServiceOptions
        /// </summary>
        ///
        /// <param name="pathSid"> The sid </param>
        public UpdateServiceOptions(string pathSid)
        {
            PathSid = pathSid;
            WebhookFilters = new List<string>();
        }

        /// <summary>
        /// Generate the necessary parameters
        /// </summary>
        public List<KeyValuePair<string, string>> GetParams()
        {
            var p = new List<KeyValuePair<string, string>>();
            if (FriendlyName != null)
            {
                p.Add(new KeyValuePair<string, string>("FriendlyName", FriendlyName));
            }

            if (DefaultServiceRoleSid != null)
            {
                p.Add(new KeyValuePair<string, string>("DefaultServiceRoleSid", DefaultServiceRoleSid.ToString()));
            }

            if (DefaultChannelRoleSid != null)
            {
                p.Add(new KeyValuePair<string, string>("DefaultChannelRoleSid", DefaultChannelRoleSid.ToString()));
            }

            if (DefaultChannelCreatorRoleSid != null)
            {
                p.Add(new KeyValuePair<string, string>("DefaultChannelCreatorRoleSid", DefaultChannelCreatorRoleSid.ToString()));
            }

            if (ReadStatusEnabled != null)
            {
                p.Add(new KeyValuePair<string, string>("ReadStatusEnabled", ReadStatusEnabled.Value.ToString()));
            }

            if (ReachabilityEnabled != null)
            {
                p.Add(new KeyValuePair<string, string>("ReachabilityEnabled", ReachabilityEnabled.Value.ToString()));
            }

            if (TypingIndicatorTimeout != null)
            {
                p.Add(new KeyValuePair<string, string>("TypingIndicatorTimeout", TypingIndicatorTimeout.Value.ToString()));
            }

            if (ConsumptionReportInterval != null)
            {
                p.Add(new KeyValuePair<string, string>("ConsumptionReportInterval", ConsumptionReportInterval.Value.ToString()));
            }

            if (NotificationsNewMessageEnabled != null)
            {
                p.Add(new KeyValuePair<string, string>("Notifications.NewMessage.Enabled", NotificationsNewMessageEnabled.Value.ToString()));
            }

            if (NotificationsNewMessageTemplate != null)
            {
                p.Add(new KeyValuePair<string, string>("Notifications.NewMessage.Template", NotificationsNewMessageTemplate));
            }

            if (NotificationsAddedToChannelEnabled != null)
            {
                p.Add(new KeyValuePair<string, string>("Notifications.AddedToChannel.Enabled", NotificationsAddedToChannelEnabled.Value.ToString()));
            }

            if (NotificationsAddedToChannelTemplate != null)
            {
                p.Add(new KeyValuePair<string, string>("Notifications.AddedToChannel.Template", NotificationsAddedToChannelTemplate));
            }

            if (NotificationsRemovedFromChannelEnabled != null)
            {
                p.Add(new KeyValuePair<string, string>("Notifications.RemovedFromChannel.Enabled", NotificationsRemovedFromChannelEnabled.Value.ToString()));
            }

            if (NotificationsRemovedFromChannelTemplate != null)
            {
                p.Add(new KeyValuePair<string, string>("Notifications.RemovedFromChannel.Template", NotificationsRemovedFromChannelTemplate));
            }

            if (NotificationsInvitedToChannelEnabled != null)
            {
                p.Add(new KeyValuePair<string, string>("Notifications.InvitedToChannel.Enabled", NotificationsInvitedToChannelEnabled.Value.ToString()));
            }

            if (NotificationsInvitedToChannelTemplate != null)
            {
                p.Add(new KeyValuePair<string, string>("Notifications.InvitedToChannel.Template", NotificationsInvitedToChannelTemplate));
            }

            if (PreWebhookUrl != null)
            {
                p.Add(new KeyValuePair<string, string>("PreWebhookUrl", PreWebhookUrl.ToString()));
            }

            if (PostWebhookUrl != null)
            {
                p.Add(new KeyValuePair<string, string>("PostWebhookUrl", PostWebhookUrl.ToString()));
            }

            if (WebhookMethod != null)
            {
                p.Add(new KeyValuePair<string, string>("WebhookMethod", WebhookMethod.ToString()));
            }

            if (WebhookFilters != null)
            {
                p.AddRange(WebhookFilters.Select(prop => new KeyValuePair<string, string>("WebhookFilters", prop)));
            }

            if (WebhooksOnMessageSendUrl != null)
            {
                p.Add(new KeyValuePair<string, string>("Webhooks.OnMessageSend.Url", WebhooksOnMessageSendUrl.ToString()));
            }

            if (WebhooksOnMessageSendMethod != null)
            {
                p.Add(new KeyValuePair<string, string>("Webhooks.OnMessageSend.Method", WebhooksOnMessageSendMethod.ToString()));
            }

            if (WebhooksOnMessageSendFormat != null)
            {
                p.Add(new KeyValuePair<string, string>("Webhooks.OnMessageSend.Format", WebhooksOnMessageSendFormat));
            }

            if (WebhooksOnMessageUpdateUrl != null)
            {
                p.Add(new KeyValuePair<string, string>("Webhooks.OnMessageUpdate.Url", WebhooksOnMessageUpdateUrl.ToString()));
            }

            if (WebhooksOnMessageUpdateMethod != null)
            {
                p.Add(new KeyValuePair<string, string>("Webhooks.OnMessageUpdate.Method", WebhooksOnMessageUpdateMethod.ToString()));
            }

            if (WebhooksOnMessageUpdateFormat != null)
            {
                p.Add(new KeyValuePair<string, string>("Webhooks.OnMessageUpdate.Format", WebhooksOnMessageUpdateFormat));
            }

            if (WebhooksOnMessageRemoveUrl != null)
            {
                p.Add(new KeyValuePair<string, string>("Webhooks.OnMessageRemove.Url", WebhooksOnMessageRemoveUrl.ToString()));
            }

            if (WebhooksOnMessageRemoveMethod != null)
            {
                p.Add(new KeyValuePair<string, string>("Webhooks.OnMessageRemove.Method", WebhooksOnMessageRemoveMethod.ToString()));
            }

            if (WebhooksOnMessageRemoveFormat != null)
            {
                p.Add(new KeyValuePair<string, string>("Webhooks.OnMessageRemove.Format", WebhooksOnMessageRemoveFormat));
            }

            if (WebhooksOnChannelAddUrl != null)
            {
                p.Add(new KeyValuePair<string, string>("Webhooks.OnChannelAdd.Url", WebhooksOnChannelAddUrl.ToString()));
            }

            if (WebhooksOnChannelAddMethod != null)
            {
                p.Add(new KeyValuePair<string, string>("Webhooks.OnChannelAdd.Method", WebhooksOnChannelAddMethod.ToString()));
            }

            if (WebhooksOnChannelAddFormat != null)
            {
                p.Add(new KeyValuePair<string, string>("Webhooks.OnChannelAdd.Format", WebhooksOnChannelAddFormat));
            }

            if (WebhooksOnChannelDestroyUrl != null)
            {
                p.Add(new KeyValuePair<string, string>("Webhooks.OnChannelDestroy.Url", WebhooksOnChannelDestroyUrl.ToString()));
            }

            if (WebhooksOnChannelDestroyMethod != null)
            {
                p.Add(new KeyValuePair<string, string>("Webhooks.OnChannelDestroy.Method", WebhooksOnChannelDestroyMethod.ToString()));
            }

            if (WebhooksOnChannelDestroyFormat != null)
            {
                p.Add(new KeyValuePair<string, string>("Webhooks.OnChannelDestroy.Format", WebhooksOnChannelDestroyFormat));
            }

            if (WebhooksOnChannelUpdateUrl != null)
            {
                p.Add(new KeyValuePair<string, string>("Webhooks.OnChannelUpdate.Url", WebhooksOnChannelUpdateUrl.ToString()));
            }

            if (WebhooksOnChannelUpdateMethod != null)
            {
                p.Add(new KeyValuePair<string, string>("Webhooks.OnChannelUpdate.Method", WebhooksOnChannelUpdateMethod.ToString()));
            }

            if (WebhooksOnChannelUpdateFormat != null)
            {
                p.Add(new KeyValuePair<string, string>("Webhooks.OnChannelUpdate.Format", WebhooksOnChannelUpdateFormat));
            }

            if (WebhooksOnMemberAddUrl != null)
            {
                p.Add(new KeyValuePair<string, string>("Webhooks.OnMemberAdd.Url", WebhooksOnMemberAddUrl.ToString()));
            }

            if (WebhooksOnMemberAddMethod != null)
            {
                p.Add(new KeyValuePair<string, string>("Webhooks.OnMemberAdd.Method", WebhooksOnMemberAddMethod.ToString()));
            }

            if (WebhooksOnMemberAddFormat != null)
            {
                p.Add(new KeyValuePair<string, string>("Webhooks.OnMemberAdd.Format", WebhooksOnMemberAddFormat));
            }

            if (WebhooksOnMemberRemoveUrl != null)
            {
                p.Add(new KeyValuePair<string, string>("Webhooks.OnMemberRemove.Url", WebhooksOnMemberRemoveUrl.ToString()));
            }

            if (WebhooksOnMemberRemoveMethod != null)
            {
                p.Add(new KeyValuePair<string, string>("Webhooks.OnMemberRemove.Method", WebhooksOnMemberRemoveMethod.ToString()));
            }

            if (WebhooksOnMemberRemoveFormat != null)
            {
                p.Add(new KeyValuePair<string, string>("Webhooks.OnMemberRemove.Format", WebhooksOnMemberRemoveFormat));
            }

            if (WebhooksOnMessageSentUrl != null)
            {
                p.Add(new KeyValuePair<string, string>("Webhooks.OnMessageSent.Url", WebhooksOnMessageSentUrl.ToString()));
            }

            if (WebhooksOnMessageSentMethod != null)
            {
                p.Add(new KeyValuePair<string, string>("Webhooks.OnMessageSent.Method", WebhooksOnMessageSentMethod.ToString()));
            }

            if (WebhooksOnMessageSentFormat != null)
            {
                p.Add(new KeyValuePair<string, string>("Webhooks.OnMessageSent.Format", WebhooksOnMessageSentFormat));
            }

            if (WebhooksOnMessageUpdatedUrl != null)
            {
                p.Add(new KeyValuePair<string, string>("Webhooks.OnMessageUpdated.Url", WebhooksOnMessageUpdatedUrl.ToString()));
            }

            if (WebhooksOnMessageUpdatedMethod != null)
            {
                p.Add(new KeyValuePair<string, string>("Webhooks.OnMessageUpdated.Method", WebhooksOnMessageUpdatedMethod.ToString()));
            }

            if (WebhooksOnMessageUpdatedFormat != null)
            {
                p.Add(new KeyValuePair<string, string>("Webhooks.OnMessageUpdated.Format", WebhooksOnMessageUpdatedFormat));
            }

            if (WebhooksOnMessageRemovedUrl != null)
            {
                p.Add(new KeyValuePair<string, string>("Webhooks.OnMessageRemoved.Url", WebhooksOnMessageRemovedUrl.ToString()));
            }

            if (WebhooksOnMessageRemovedMethod != null)
            {
                p.Add(new KeyValuePair<string, string>("Webhooks.OnMessageRemoved.Method", WebhooksOnMessageRemovedMethod.ToString()));
            }

            if (WebhooksOnMessageRemovedFormat != null)
            {
                p.Add(new KeyValuePair<string, string>("Webhooks.OnMessageRemoved.Format", WebhooksOnMessageRemovedFormat));
            }

            if (WebhooksOnChannelAddedUrl != null)
            {
                p.Add(new KeyValuePair<string, string>("Webhooks.OnChannelAdded.Url", WebhooksOnChannelAddedUrl.ToString()));
            }

            if (WebhooksOnChannelAddedMethod != null)
            {
                p.Add(new KeyValuePair<string, string>("Webhooks.OnChannelAdded.Method", WebhooksOnChannelAddedMethod.ToString()));
            }

            if (WebhooksOnChannelAddedFormat != null)
            {
                p.Add(new KeyValuePair<string, string>("Webhooks.OnChannelAdded.Format", WebhooksOnChannelAddedFormat));
            }

            if (WebhooksOnChannelDestroyedUrl != null)
            {
                p.Add(new KeyValuePair<string, string>("Webhooks.OnChannelDestroyed.Url", WebhooksOnChannelDestroyedUrl.ToString()));
            }

            if (WebhooksOnChannelDestroyedMethod != null)
            {
                p.Add(new KeyValuePair<string, string>("Webhooks.OnChannelDestroyed.Method", WebhooksOnChannelDestroyedMethod.ToString()));
            }

            if (WebhooksOnChannelDestroyedFormat != null)
            {
                p.Add(new KeyValuePair<string, string>("Webhooks.OnChannelDestroyed.Format", WebhooksOnChannelDestroyedFormat));
            }

            if (WebhooksOnChannelUpdatedUrl != null)
            {
                p.Add(new KeyValuePair<string, string>("Webhooks.OnChannelUpdated.Url", WebhooksOnChannelUpdatedUrl.ToString()));
            }

            if (WebhooksOnChannelUpdatedMethod != null)
            {
                p.Add(new KeyValuePair<string, string>("Webhooks.OnChannelUpdated.Method", WebhooksOnChannelUpdatedMethod.ToString()));
            }

            if (WebhooksOnChannelUpdatedFormat != null)
            {
                p.Add(new KeyValuePair<string, string>("Webhooks.OnChannelUpdated.Format", WebhooksOnChannelUpdatedFormat));
            }

            if (WebhooksOnMemberAddedUrl != null)
            {
                p.Add(new KeyValuePair<string, string>("Webhooks.OnMemberAdded.Url", WebhooksOnMemberAddedUrl.ToString()));
            }

            if (WebhooksOnMemberAddedMethod != null)
            {
                p.Add(new KeyValuePair<string, string>("Webhooks.OnMemberAdded.Method", WebhooksOnMemberAddedMethod.ToString()));
            }

            if (WebhooksOnMemberAddedFormat != null)
            {
                p.Add(new KeyValuePair<string, string>("Webhooks.OnMemberAdded.Format", WebhooksOnMemberAddedFormat));
            }

            if (WebhooksOnMemberRemovedUrl != null)
            {
                p.Add(new KeyValuePair<string, string>("Webhooks.OnMemberRemoved.Url", WebhooksOnMemberRemovedUrl.ToString()));
            }

            if (WebhooksOnMemberRemovedMethod != null)
            {
                p.Add(new KeyValuePair<string, string>("Webhooks.OnMemberRemoved.Method", WebhooksOnMemberRemovedMethod.ToString()));
            }

            if (WebhooksOnMemberRemovedFormat != null)
            {
                p.Add(new KeyValuePair<string, string>("Webhooks.OnMemberRemoved.Format", WebhooksOnMemberRemovedFormat));
            }

            if (LimitsChannelMembers != null)
            {
                p.Add(new KeyValuePair<string, string>("Limits.ChannelMembers", LimitsChannelMembers.Value.ToString()));
            }

            if (LimitsUserChannels != null)
            {
                p.Add(new KeyValuePair<string, string>("Limits.UserChannels", LimitsUserChannels.Value.ToString()));
            }

            return p;
        }
    }

}