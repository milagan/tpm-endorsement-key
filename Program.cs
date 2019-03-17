using System;
using System.Text;
using Microsoft.Azure.Devices.Provisioning.Security;
using Microsoft.Azure.Devices.Shared;

namespace tpm_endorsement_key
{
    class Program
    {
        private const string RegistrationId = "testtpmregistration1";
        static void Main(string[] args)
        {
            Console.WriteLine("Extracting endorsement key...");
            var tpmProvider = new SecurityProviderTpmHsm(RegistrationId);
            string base64EK = Convert.ToBase64String(tpmProvider.GetEndorsementKey());

            Console.WriteLine(base64EK);
        }
    }
}
