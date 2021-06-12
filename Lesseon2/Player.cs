namespace LesseonTwo
{
    internal class Player
    {
        public void Fire(Weapon weapon) => weapon.Fire();

        public void CheckInfo(Weapon weapon) => weapon.GetInfo(weapon);
    }
}