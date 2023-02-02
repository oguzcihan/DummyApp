
namespace Core.Utilities.Results
{
    public class ErrorDataResult<T> : DataResult<T>
    {
        /// <summary>
        /// Hata mesajı.
        /// </summary>
        /// <param name="data"></param>
        /// <param name="message"></param>
        public ErrorDataResult(T data, string message) : base(data, false, message)
        {
        }

        public ErrorDataResult(T data) : base(data, false)
        {
        }

        public ErrorDataResult(string message) : base(default, false, message)
        {

        }

        public ErrorDataResult() : base(default, false)
        {

        }
    }
}
