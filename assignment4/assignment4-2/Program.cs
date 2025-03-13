using System;
using System.Timers; 

public class AlarmClock
{
    private readonly System.Timers.Timer _timer; 
    public DateTime AlarmTime { get; set; }

    public event EventHandler Tick;
    public event EventHandler Alarm;

    public AlarmClock(DateTime alarmTime)
    {
        AlarmTime = alarmTime;
        _timer = new System.Timers.Timer(1000); 
        _timer.Elapsed += TimerElapsed;
        _timer.AutoReset = true;
        _timer.Enabled = true;
    }

    private void TimerElapsed(object sender, ElapsedEventArgs e)
    {
        Tick?.Invoke(this, EventArgs.Empty);
        if (DateTime.Now >= AlarmTime)
        {
            Alarm?.Invoke(this, EventArgs.Empty);
            _timer.Stop();
        }
    }

    public void Start() => _timer.Start();
}

class Program
{
    static void Main()
    {
        var alarmTime = DateTime.Now.AddSeconds(10);
        var clock = new AlarmClock(alarmTime);

        clock.Tick += (sender, e) =>
            Console.WriteLine($"[{DateTime.Now:T}] 滴答...");

        clock.Alarm += (sender, e) =>
            Console.WriteLine($"[{DateTime.Now:T}] 叮铃铃！闹钟时间到！");

        Console.WriteLine($"闹钟已设置，将在 {alarmTime:T} 响铃");
        clock.Start();
        Console.ReadLine();
    }
}