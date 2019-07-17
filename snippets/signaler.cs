class Signaler
{
    void InitAlert()
    {
        AlertPlaySound = false;
        AlertSoundName = "";
        AlertSendEmail = false;
        AlertEmail = "";
        AlertDebug = true;
    }
    DateTime _alertLastDate;
    void SendSignal(string message, DateTime dt)
    {
        if (_alertLastDate == dt)
            return;
        _alertLastDate = dt;
        if (AlertPlaySound)
            PlaySound(AlertSoundName);

        if (AlertSendEmail)
            SendMail(AlertEmail, message, message);
        if (AlertDebug)
            Print(message);
    }

    [NinjaScriptProperty]
    [Display(Name="Play sound", Order = 1000, GroupName = "Alert")]
    public bool AlertPlaySound
    { get; set; }

    [NinjaScriptProperty]
    [Display(Name="Sound", Order = 1001, GroupName = "Alert")]
    public string AlertSoundName
    { get; set; }

    [NinjaScriptProperty]
    [Display(Name="Send email", Order = 1002, GroupName = "Alert")]
    public bool AlertSendEmail
    { get; set; }

    [NinjaScriptProperty]
    [Display(Name="Email", Order = 1003, GroupName = "Alert")]
    public string AlertEmail
    { get; set; }

    [NinjaScriptProperty]
    [Display(Name="Print debug output", Order = 1100, GroupName = "Alert")]
    public bool AlertDebug
    { get; set; }
}