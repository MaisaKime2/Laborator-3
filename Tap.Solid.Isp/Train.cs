namespace Tap.Solid.Isp
{
    internal interface IMovable
    {
        public void MoveForward();
        public void MoveBackward();
    }

    internal interface ISteerable
    {
        public void SteerLeft();
        public void SteerRight();
    }

    internal class Car : IMovable, ISteerable
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

    internal class Train : IMovable
    {
        public void MoveBackward()
        {
            //Move Backward
        }

        public void MoveForward()
        {
            //Move Forward
        }
    }
}
