using System;
class Clock { protected int Hour, Minute, Second; public Clock(int h, int m, int s) { Hour = h % 24; Minute = m % 60; Second = s % 60; } public virtual void Display() => Console.WriteLine($"{Hour:D2}:{Minute:D2}:{Second:D2}"); }
class DisplayClock : Clock { public DisplayClock(int h, int m, int s) : base(h, m, s) { } public override void Display() { string period = Hour < 12 ? "AM" : "PM"; int h12 = Hour % 12; if (h12 == 0) h12 = 12; Console.WriteLine($"12-hour: {h12:D2}:{Minute:D2}:{Second:D2} {period}\n24-hour: {Hour:D2}:{Minute:D2}:{Second:D2}"); } }
class Program { static void Main() { new DisplayClock(14, 30, 5).Display(); } }
