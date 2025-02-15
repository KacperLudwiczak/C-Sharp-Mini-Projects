namespace Generics_in_C_
{
    internal class TaskProcessor<TTask, TResult> where TTask : ITask<TResult>
    {
        public TTask _task;

        public TaskProcessor(TTask task)
        {
            _task = task;
        }

        public TResult Execute()
        {
            return _task.Perform();
        }
    }
}
