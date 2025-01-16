namespace Payload.MultiPart.Models
{
    public partial class MultiPartRequest
    {
        
        internal MultipartFormDataRequestContent ToMultipartContent()
        {
            MultipartFormDataRequestContent content = new MultipartFormDataRequestContent();

            content.Add(ProfileImage.Contents, "profileImage", ProfileImage.Filename, ProfileImage.ContentType);
            content.Add(Id, "id");

            return content;
        }
    }
}
