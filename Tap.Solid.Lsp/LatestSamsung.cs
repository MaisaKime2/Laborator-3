namespace Tap.Solid.Lsp
{
    internal class LatestSamsung : MobilePhone
    {
        internal override void BrowseWeb(string webAddress)
        {
            //browse web
        }

        internal override void MakePhoneCall(string phoneNumber)
        {
            //make phone call
        }

        internal override void SendMessage(string address, string message)
        {
            if (IsValidPhoneNumber(address))
            {
                SendSms(address, message);
            }
            else if (IsValidEmailAddress(address))
            {
                SendEmail(address, message);
            }
            else
            {
                throw new ArgumentException("Invalid recipient address.");
            }
        }

        private bool IsValidPhoneNumber(string phoneNumber)
        {
            // check if phone number is valid
            return true;
        }

        private bool IsValidEmailAddress(string emailAddress)
        {
            // check if email address is valid
            return true;
        }

        private void SendSms(string phoneNumber, string message)
        {
            // send SMS
        }

        private void SendEmail(string emailAddress, string message)
        {
            // send email
        }
    }
}