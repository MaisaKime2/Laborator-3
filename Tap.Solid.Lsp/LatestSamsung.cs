namespace Tap.Solid.Lsp
{
    internal abstract class MobilePhone
    {
        internal abstract void MakePhoneCall(string phoneNumber);
        internal abstract void SendSms(string phoneNumber);
    }

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

        internal override void SendEmail(string emailAddress)
        {
            //send email
        }

        internal override void SendSms(string phoneNumber)
        {
            //send SMS
        }
    }
}