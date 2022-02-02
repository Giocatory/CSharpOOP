namespace LessonSix
{
    internal class Miniwan : Car
    {
        public Miniwan(int maxSpeed, string CarName, string Color)
            : base(maxSpeed)
        {
            this.Color = Color;
            Name = CarName;
        }

        public string Name { get; set; }
        public string Color { get; set; }
    }
}
