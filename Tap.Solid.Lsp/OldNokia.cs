internal abstract class MobilePhone
{
    internal abstract void MakePhoneCall(string phoneNumber);
    internal abstract void SendSms(string phoneNumber);
}

internal class OldNokia : MobilePhone
{
    internal override void SendSms(string phoneNumber)
    {
        //send SMS
    }

    internal override void MakePhoneCall(string phoneNumber)
    {
        //make phone call
    }
}

internal class LatestSamsung : MobilePhone
{
    internal override void SendSms(string phoneNumber)
    {
        //send SMS
    }

    internal override void MakePhoneCall(string phoneNumber)
    {
        //make phone call
    }

    internal void SendEmail(string emailAddress)
    {
        //send email
    }

    internal void BrowseWeb(string webAddress)
    {
        //browse web
    }
}
