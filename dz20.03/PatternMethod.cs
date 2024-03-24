using System;

public class EmailSystem
{
    public void SendEmail(string recipient, string message)
    {
        Console.WriteLine($"Вiдправлено лист на адресу {recipient}: {message}");
    }
}

public class SMSSystem
{
    public void SendSMS(string phoneNumber, string message)
    {
        Console.WriteLine($"Вiдправлено SMS на номер {phoneNumber}: {message}");
    }
}

public class SocialMediaSystem
{
    public void PostToSocialMedia(string platform, string message)
    {
        Console.WriteLine($"Опублiковано повiдомлення на {platform}: {message}");
    }
}

public class CommunicationFacade
{
    private readonly EmailSystem emailSystem;
    private readonly SMSSystem smsSystem;
    private readonly SocialMediaSystem socialMediaSystem;

    public CommunicationFacade()
    {
        emailSystem = new EmailSystem();
        smsSystem = new SMSSystem();
        socialMediaSystem = new SocialMediaSystem();
    }

    public void SendMessageByEmail(string recipient, string message)
    {
        emailSystem.SendEmail(recipient, message);
    }

    public void SendMessageBySMS(string phoneNumber, string message)
    {
        smsSystem.SendSMS(phoneNumber, message);
    }

    public void PostMessageToSocialMedia(string platform, string message)
    {
        socialMediaSystem.PostToSocialMedia(platform, message);
    }
}
