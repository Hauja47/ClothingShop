using ClothingShop.Model.Enums;

namespace ClothingShop.Model.DTO
{
    public class BaseRequest
    {

    }

    public class BaseResponse
    { 
        public bool IsSuccess { get; set; }

        public IEnumerable<string> Messages { get; set; }

        public IEnumerable<string> Errors { get; set; }
    }

    public class BaseUpdateRequest
    {
        public Guid Id { get; set; }
    }

    public class BaseDTO
    {
        public Guid Id { get; set; }

        public DateTime CreatedDate { get; set; }

        public DateTime? UpdatedDate { get; set; }

        public RecordStatus RecordStatus { get; set; }
    }
}
