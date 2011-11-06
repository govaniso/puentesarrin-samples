using System;
using System.Collections.Generic;
using System.Text;
using Google.GData;
using Google.GData.Client;
using Google.GData.Extensions;
using Google.Contacts;
using System.IO;

namespace sample_gdata
{
    class Program
    {
        static void Main(string[] args)
        {
            RequestSettings rs = new RequestSettings("prueba", "usuario", "contraseña");
            rs.AutoPaging = true;
            ContactsRequest cr = new ContactsRequest(rs);

            Feed<Contact> f = cr.GetContacts();
            foreach (Contact e in f.Entries)
            {
                foreach (EMail email in e.Emails)
                {
                    Console.WriteLine(email.Address);
                }
                foreach (IMAddress im in e.IMs)
                {
                    Console.WriteLine(im.Address);
                }
            }
            Console.Read();
        }
    }
}
