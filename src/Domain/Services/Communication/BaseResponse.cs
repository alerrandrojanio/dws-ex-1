namespace dws_ex_1.src.Domain.Services.Communication
{
    public abstract class BaseResponse
    {
        public bool Sucess { get; set; }
        public string Message { get; set; }

        public BaseResponse(bool success, string message)
        {
            Sucess = success;
            Message = message;
        }
    }
}
