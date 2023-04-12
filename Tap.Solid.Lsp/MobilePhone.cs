namespace Tap.Solid.Lsp
{
    internal abstract class MobilePhone
    {
        internal abstract void BrowseWeb(string webAddress);

        internal abstract void MakePhoneCall(string phoneNumber);

        internal abstract void SendMessage(string address, string message);
    }
}
