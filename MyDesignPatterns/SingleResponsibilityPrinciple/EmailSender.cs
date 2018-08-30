using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyDesignPatterns.SingleResponsibilityPrinciple
{
    interface IEmailSender
    {
        void SendEmail(string emailAdress, string subject, string content);
    }

    public class EmailSender : IEmailSender
    {
        public void SendEmail(string emailAdress, string subject, string content)
        {
            // Sends email
        }
    }

    public class CustomerRepository
    {
        public Customer GetCustomer(string id)
        {
            // logic load customer from Database
            throw new NotImplementedException();
        }
    }

    public class EmailContentBuilder
    {
        public string GetEmailContent(Customer customerDetails)
        {
            // logic to build email content
            throw new NotImplementedException();
        }
    }   
}
