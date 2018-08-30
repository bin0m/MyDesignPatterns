using System;

namespace MyDesignPatterns.SingleResponsibilityPrinciple
{
    public struct Customer
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string Adress { get; set; }
    }

    public class EmailSenderBefore
    {
        public void SendEmail(string customerID,
                             string emailNotificationType)
        {
            //STEP1: load customer details
            //STEP2: get email content
            //STEP3: send email (using SmtpClient class)
        }

        public string GetEmailContent(Customer customer,
                       string emailNotificationType)
        {
            // Build the email notification content
            throw new NotImplementedException();
        }
    }

    /*
The EmailSender class can go under changes because any of the below reasons:
1. Changes in the way, you are loading customer details.
2. Changes to the email content because of requirement enhancements / changes.
3. If there any change in the way you are sending the email instead of using SmtpClient class or something like that.
     */
}
