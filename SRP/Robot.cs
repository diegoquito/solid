using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SRP
{
    public class Robot
    {
        private readonly Movement _movement;
        private readonly Weapon _weapon;

        public Robot(Movement movement, Weapon weapon)
        {
            _movement = movement;
            _weapon = weapon;
        }

        public void MoveForward()
        {
            _movement.MoveForward();
        }

        public void MoveBackward()
        {
            _movement.MoveBackward();
        }

        public void MoveLeft()
        {
            _movement.MoveLeft();
        }

        public void MoveRight()
        {
            _movement.MoveRight();
        }

        public void Attack()
        {
            _weapon.Attack();
        }
    }
}
