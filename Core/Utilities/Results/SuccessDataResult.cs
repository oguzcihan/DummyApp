﻿
namespace Core.Utilities.Results
{
    public class SuccessDataResult<T> : DataResult<T>
    {
        /// <summary>
        /// Başarılı işlem mesajı.
        /// </summary>
        /// <param name="data"></param>
        /// <param name="message"></param>
        public SuccessDataResult(T data, string message) : base(data, true, message)
        {

        }

        public SuccessDataResult(T data) : base(data, true)
        {
        }

        public SuccessDataResult(string message) : base(default, true, message)
        {

        }

        public SuccessDataResult() : base(default, true)
        {

        }
    }
}