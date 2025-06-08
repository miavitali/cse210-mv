// I added a breathing animation where dots grow quickly at first and then slow down while the user inhales, 
// and shrink the same way while the user exhales.
public class BreathingActivity : Activity
{
    public BreathingActivity()
        : base("Breathing", "This activity will help you relax by walking your through breathing in and out slowly. Clear your mind and focus on your breathing.")
    {
    }

    public void Run()
    {
        DisplayStartingMessage();

        int duration = GetDuration();
        int cycleTime = 6; // 3 segundos in + 3 segundos out
        int cycles = duration / cycleTime;

        for (int i = 0; i < cycles; i++)
        {
            AnimateBreathIn(3);
            AnimateBreathOut(3);
        }

        DisplayEndingMessage();
    }

    private void AnimateBreathIn(int totalSeconds)
    {
        int maxLength = 30; 
        int ticks = 30;     
        double totalTime = totalSeconds * 1000; 

        for (int i = 1; i <= ticks; i++)
        {
            double progress = (double)i / ticks;
            int length = (int)(maxLength * EaseOutQuad(progress));
            string text = new string('.', length);

            Console.Write("\rBreathe in... " + text.PadRight(maxLength));
            int sleepTime = (int)(totalTime / ticks * (1 + progress));
            Thread.Sleep(sleepTime);
        }
        Console.WriteLine();
    }

    private void AnimateBreathOut(int totalSeconds)
    {
        int maxLength = 30;
        int ticks = 30;
        double totalTime = totalSeconds * 1000;

        for (int i = ticks; i >= 1; i--)
        {
            double progress = (double)i / ticks;
            int length = (int)(maxLength * EaseOutQuad(progress));
            string text = new string('.', length);

            Console.Write("\rBreathe out... " + text.PadRight(maxLength));
            int sleepTime = (int)(totalTime / ticks * (1 + (1 - progress)));
            Thread.Sleep(sleepTime);
        }
        Console.WriteLine();
    }


    private double EaseOutQuad(double t)
    {
        return t * (2 - t);
    }
}