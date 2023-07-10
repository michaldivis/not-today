using System.Net;

namespace NotToday;

public class NotTodayOptions
{
    public HttpStatusCode StatusCode { get; set; } = HttpStatusCode.InternalServerError;
}
