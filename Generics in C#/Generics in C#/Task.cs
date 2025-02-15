namespace Generics_in_C_
{
    public interface ITask<TResult>
    {
        TResult Perform();
    }
}
