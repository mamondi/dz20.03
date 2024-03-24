class Program
{
    static void Main(string[] args)
    {
        CommunicationFacade communication = new CommunicationFacade();

        string recipient = "example@example.com";
        string phoneNumber = "+123456789";
        string socialMediaPlatform = "Twitter";
        string message = "Привiт, це тестове повiдомлення!";

        communication.SendMessageByEmail(recipient, message);
        communication.SendMessageBySMS(phoneNumber, message);
        communication.PostMessageToSocialMedia(socialMediaPlatform, message);
    }
}
