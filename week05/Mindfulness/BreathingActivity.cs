public class BreathingActivity : Activity
{
    public BreathingActivity() 
        : base("Breathing", "This activity will help you relax by walking you through breathing in and out slowly. Clear your mind and focus on your breathing.")
    {
    }

    public override void PerformActivity()
    {
        StartMessage();

        int remainingTime = GetDuration();
        while (remainingTime > 0)
        {
            Console.WriteLine("\nBreathe in...");
            Animate(4); // Simulate inhaling
            remainingTime -= 4;

            if (remainingTime <= 0) break;

            Console.WriteLine("Breathe out...");
            Animate(6); // Simulate exhaling
            remainingTime -= 6;
        }

        EndMessage();
    }
}