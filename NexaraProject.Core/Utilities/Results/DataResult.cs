namespace NexaraProject.Core.Utilities.Results
{
    public class DataResult<T> : Result, IDataResult<T>
    {
        public T Data { get; set; }

        public DataResult(bool success, T data) : base(success)
        {
            Data = data;
        }

        public DataResult(bool success, string message, T data) : base(success, message)
        {
            Data = data;
        }

        public DataResult(bool success) : this(success, data: default)
        {
        }

        public DataResult(bool success, string message) : this(success, message, default)
        {
        }
    }
}