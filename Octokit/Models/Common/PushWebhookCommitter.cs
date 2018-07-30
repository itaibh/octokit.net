using System;
using System.Diagnostics;
using System.Globalization;

namespace Octokit
{
    /// <summary>
    /// Represents the author or committer to a Git commit. This is the information stored in Git and should not be
    /// confused with GitHub account information.
    /// </summary>
    [DebuggerDisplay("{DebuggerDisplay,nq}")]
    public class PushWebhookCommitter : Committer
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PushWebhookCommitter"/> class.
        /// </summary>
        public PushWebhookCommitter() { }

        /// <summary>
        /// Initializes a new instance of the <see cref="PushWebhookCommitter"/> class.
        /// </summary>
        /// <param name="name">The full name of the author or committer.</param>
        /// <param name="email">The email.</param>
        /// <param name="date">The date.</param>
        public PushWebhookCommitter(string name, string email, DateTimeOffset date) : base(name, email, date) { }

        /// <summary>
        /// Initializes a new instance of the <see cref="PushWebhookCommitter"/> class.
        /// </summary>
        /// <param name="nodeId">The GraphQL Node Id</param>
        /// <param name="name">The full name of the author or committer.</param>
        /// <param name="email">The email.</param>
        /// <param name="date">The date.</param>
        public PushWebhookCommitter(string nodeId, string name, string email, DateTimeOffset date) : base(nodeId, name, email, date) { }

        /// <summary>
        /// Initializes a new instance of the <see cref="PushWebhookCommitter"/> class.
        /// </summary>
        /// <param name="nodeId">The GraphQL Node Id</param>
        /// <param name="name">The full name of the author or committer.</param>
        /// <param name="email">The email.</param>
        /// <param name="date">The date.</param>
        /// <param name="username">The committer username.</param>
        public PushWebhookCommitter(string nodeId, string name, string email, DateTimeOffset date, string username) : base(nodeId, name, email, date)
        {
            Username = username;
        }

        /// <summary>
        /// Gets the username of the author or committer.
        /// </summary>
        /// <value>
        /// The username.
        /// </value>
        public string Username { get; protected set; }

        internal override string DebuggerDisplay
        {
            get { return string.Format(CultureInfo.InvariantCulture, "Name: {0} Email: {1} Date: {2}; Username: {3}", Name, Email, Date, Username); }
        }
    }
}
