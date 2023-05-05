

using SRP;

var robot = new Robot(new Movement(5,10), new Weapon(50));
robot.MoveRight();
robot.MoveLeft();
robot.MoveBackward();
robot.MoveForward();
robot.Attack();