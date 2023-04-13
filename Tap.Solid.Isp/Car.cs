namespace Tap.Solid.Isp
{
    internal interface IMoveable
    {
        void MoveBackward();
        void MoveForward();
    }

    internal interface ISteerable
    {
        void SteerLeft();
        void SteerRight();
    }

    internal class Car : IMoveable, ISteerable
    {
        public void MoveBackward()
        {
            //Move Backward
        }

        public void MoveForward()
        {
            //Move Forward
        }

        public void SteerLeft()
        {
            //Steer Left
        }

        public void SteerRight()
        {
            //Steer Right
        }
    }
}
