namespace LessonSix
{
    internal class Car
    {
        private int maxSpeed;
        private int currSpeed;
        private static int howManyCarsCreated;


        // Chaining Constructors
        public Car() : this(0, 0) { }
        public Car(int maxSpeed) : this(maxSpeed, 0) { }
        // Chief constructor doing all the work
        public Car(int maxSpeed, int currentSpeed)
        {
            if (maxSpeed >= 0) MaxSpeed = maxSpeed;
            if (currentSpeed >= 0) CurrSpeed = currentSpeed;
            howManyCarsCreated += 1;
        }
        // But you can do it like this (Using only 1 constructor)
        /*public Car(int maxSpeed = 0, int currentSpeed = 0)
        {
            if (maxSpeed >= 0) MaxSpeed = maxSpeed;
            if (currentSpeed >= 0) CurrSpeed = currentSpeed;
        }*/


        public int MaxSpeed { get => maxSpeed; private set => maxSpeed = value; }
        public int CurrSpeed { get => currSpeed; set => currSpeed = value; }

        public static int HowManyCarsCreated { get => howManyCarsCreated; }
    }
}
