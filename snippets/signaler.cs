#region Alert
// Signaler 1.1
void InitAlert()
{
    AlertPlaySound = false;
    AlertSoundName = "";
    AlertSendEmail = false;
    AlertEmail = "";
    AlertDebug = true;
}


[NinjaScriptProperty]
[Display(Name="Play sound", Order = 1000, GroupName = "Alert")]
public bool AlertPlaySound
{ get; set; }

[NinjaScriptProperty]
[Display(Name="Sound", Order = 1001, GroupName = "Alert")]
public string AlertSoundName { get; set; }

[NinjaScriptProperty]
[Display(Name="Send email", Order = 1002, GroupName = "Alert")]
public bool AlertSendEmail { get; set; }

[NinjaScriptProperty]
[Display(Name="Email", Order = 1003, GroupName = "Alert")]
public string AlertEmail { get; set; }

[NinjaScriptProperty]
[Display(Name="Print debug output", Order = 1100, GroupName = "Alert")]
public bool AlertDebug { get; set; }

class Signaler
{
    bool _alertPlaySound;
    string _alertSoundName;
    bool _alertSendEmail;
    string _alertEmail;
    bool _alertDebug;
    Indicator _indicator;

    public void Init(Indicator indicator, bool alertPlaySound, string alertSoundName, bool alertSendEmail, 
        string alertEmail, bool alertDebug)
    {
        _indicator = indicator;
        _alertPlaySound = alertPlaySound;
        _alertSoundName = alertSoundName;
        _alertSendEmail = alertSendEmail;
        _alertEmail = alertEmail;
        _alertDebug = alertDebug;
    }

    DateTime _alertLastDate;
    public void SendSignal(string message, DateTime dt)
    {
        if (_alertLastDate == dt)
            return;
        _alertLastDate = dt;
        if (_alertPlaySound)
            _indicator.PlaySound(_alertSoundName);

        if (_alertSendEmail)
            _indicator.SendMail(_alertEmail, message, message);
        if (_alertDebug)
            _indicator.Print(message);
    }
}
#endregion