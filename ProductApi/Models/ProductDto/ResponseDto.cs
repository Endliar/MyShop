namespace ProductApi.Models.ProductDto
{
    public class ResponseDto
    {
        public bool IsSuccess { get; set; } = true;
        public object Result { get; set; }
        public string DisplayMessage { get; set; } = "";
        public List<String> ErrorMessages { get; set; }
    }
}
