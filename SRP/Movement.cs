

namespace SRP
{
    public class Movement
    {
        private int _x;
        private int _y;

        public Movement(int x, int y)
        {
            _x = x;
            _y = y;
        }

        public void MoveForward()
        {
            // Logic for moving the robot forward
            _y++;
        }

        public void MoveBackward()
        {
            // Logic for moving the robot backwards
            _y--;
        }

        public void MoveLeft()
        {
            // Logic for moving the robot to the left
            _x--;
        }

        public void MoveRight()
        {
            // Logic for moving the robot to the right
            _x++;
        }
    }
}
