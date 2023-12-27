namespace CSU.Api.Extensions
{
    public static class GeneralExtensions
    {
        public static string GetUserId(this HttpContext context)
        {
            return context.User.Claims.Single(x => x.Type == "userId").Value;
        }
    }
}
