namespace Practical_06
{
    public delegate void ProcessLogicHandler();
    //Created a class ProcessBusinessLogic that has ProcessCompleted event
    public class ProcessBuisnessLogic
    {
        //Defined ProcessCompleted event using ProcessLogicHandler Delegate
        public event ProcessLogicHandler? ProcessCompleted;
        //Added startProcess() method to invoke that OnProcessCompleted()
        public void startProcess()
        {
            Console.WriteLine("Process Started!");
            OnProcessCompleted();
        }
        //OnProcessCompleted method invoke registered method in event
        protected virtual void OnProcessCompleted() //protected virtual method
        {
            ProcessCompleted?.Invoke();
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            //Initialize ProcessBusinessLogic in main
            ProcessBuisnessLogic processBuisnessLogic = new ProcessBuisnessLogic();
            //Registered a method bl_ProcessCompleted in ProcessCompleted event
            processBuisnessLogic.ProcessCompleted += bl_ProcessCompleted;
            //Called StartProcess method
            processBuisnessLogic.startProcess();
        }
        //bl_ProcessCompleted will print “Method Invoked”
        static void bl_ProcessCompleted()
        {
            Console.WriteLine("Method Invoked");
        }
    }
}
