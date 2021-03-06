﻿using cloudscribe.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace cloudscribe.Core.Web.Components.Messaging
{
    /// <summary>
    /// this is just temporary while we wait for MailKit/MimeKit to be released for rc2
    /// </summary>
    public class FakeSiteEmailSender : ISiteMessageEmailSender
    {

        public Task SendAccountConfirmationEmailAsync(
            ISiteSettings siteSettings,
            string toAddress,
            string subject,
            string confirmationUrl)
        {
            return Task.FromResult(0);
        }

        public Task SendSecurityCodeEmailAsync(
            ISiteSettings siteSettings,
            string toAddress,
            string subject,
            string securityCode)
        {
            return Task.FromResult(0);
        }

        public Task SendPasswordResetEmailAsync(
            ISiteSettings siteSettings,
            string toAddress,
            string subject,
            string resetUrl)
        {
            return Task.FromResult(0);
        }

        public Task AccountPendingApprovalAdminNotification(
            ISiteSettings siteSettings,
            ISiteUser user)
        {
            return Task.FromResult(0);
        }

        public Task SendAccountApprovalNotificationAsync(
            ISiteSettings siteSettings,
            string toAddress,
            string subject,
            string loginUrl)
        {
            return Task.FromResult(0);
        }

    }
}
