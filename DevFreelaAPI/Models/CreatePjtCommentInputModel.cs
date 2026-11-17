namespace DevFreelaAPI.Models
{
    public class CreatePjtCommentInputModel
    {
        public string Content { get; set; }
        public int IdProject { get; set; }
        public int IdUser { get; set; }
    }
}
