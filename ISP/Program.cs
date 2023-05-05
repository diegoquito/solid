

using ISP;

var lead = new TeamLead();

lead.AssignTask();
lead.CreateSubTask();
lead.WorkOnTask();

var manager = new Manager();
manager.CreateSubTask();
manager.AssignTask();

IProgrammer programmer = new Programmer();
programmer.WorkOnTask();