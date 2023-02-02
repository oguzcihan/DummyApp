
namespace Core.Utilities.Results
{
    public class DataResult<T> : Result, IDataResult<T>
    {
        public DataResult(T data, bool success, string message) : base(success, message)
        {
            Data = data;
        }

        /// <summary>
        /// Hata yönetim sistemi mesajı
        /// </summary>
        /// <param name="data"></param>
        /// <param name="success"></param>
        public DataResult(T data, bool success) : base(success)
        {
            Data = data;
        }

        public T Data { get; }
    }
}
