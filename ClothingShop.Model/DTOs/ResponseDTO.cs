namespace ClothingShop.Model.DTO
{
    public class Response : BaseResponse
    {
        public object Payload { get; set; }
    }

    public class Response<T> : BaseResponse where T : BaseDTO
    {
        public T Payload { get; set; }
    }
}
