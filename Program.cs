using System;
using System.Collections.Generic;


namespace WorkflowEngine
{
    public interface IActivity
    {
        void Execute();
    }

    public class UploadActivity : IActivity
    {
        public void Execute()
        {
            Console.WriteLine("Uploading a video to cloud storage");
        }
    }

    public class VideoEncodingActivity : IActivity
    {
        public void Execute()
        {
            Console.WriteLine("Calling a third-party video encoding service");
        }
    }

    public class EmailNotificationActivity : IActivity
    {
        public void Execute()
        {
            Console.WriteLine("Sending email notification to the owner");
        }
    }

    public class ChangeStatusActivity : IActivity
    {
        public void Execute()
        {
            Console.WriteLine("Changing the status of the video record in the database to Processing");
        }
    }

    public class WorkflowEngine
    {
        public void Run(List<IActivity> workflow)
        {
            foreach (var activity in workflow)
            {
                activity.Execute();
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Create a workflow
            var workflow = new List<IActivity>
            {
                new UploadActivity(),
                new VideoEncodingActivity(),
                new EmailNotificationActivity(),
                new ChangeStatusActivity()
            };

            // Run the workflow using the workflow engine
            var workflowEngine = new WorkflowEngine();
            workflowEngine.Run(workflow);
        }
    }
}

///// Design a workflow engine that takes a workflow object and runs it.
//A workflow is a series of steps or activities.
//The workflow engine class should have one method called Run() that takes a workflow,
//and then iterates over each activity in the workflow and runs it.////////

//Educational tip: we should represent the concept of an activity using an interface.
//Each activity should have a method called Execute().
//The workflow engine does not care about the concrete implementation of activities.
//All it cares about is that these activities have a common interface: they provide a method called
//Execute().
//The engine simply calls this method and this way it executes a series of activities in sequence

//Each of these steps can be represented by an activity.
//For the purpose of this exercise, do not worry about these complexities.
//Simply use Console.WriteLine() in each of your activity classes.
//Your focus should be on sending a workflow to the workflow engine and having it run the workflow and all the activities inside it.
//We don’t care about the actual activities. 2