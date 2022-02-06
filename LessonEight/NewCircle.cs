namespace LessonEight
{
    internal class NewCircle : Circle
    {
        public NewCircle() : this($"{nameof(NewCircle)}")
        {
        }

        public NewCircle(string name) : base(name)
        {
            PetName = name;
        }

        public new string PetName { get; set; }

        // Hide any Draw() implementation higher in the hierarchy
        // {nameof(NewCircle)} => Circle
        public new void Draw()
        {
            Console.WriteLine($"We draw {nameof(NewCircle)}: {PetName}");
        }
    }
}