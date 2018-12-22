﻿namespace HomeAutio.Mqtt.GoogleHome.Models.GoogleHomeGraph
{
    /// <summary>
    /// Request envelope.
    /// </summary>
    public class RequestSyncRequest
    {
        /// <summary>
        /// Agent user id.
        /// </summary>
        public string AgentUserId { get; set; }

        /// <summary>
        /// Optional. If set, the request will be added to a queue and a response will be returned immediately. The queue allows for de-duplication of simultaneous requests.
        /// </summary>
        public bool Async { get; set; }
    }
}
