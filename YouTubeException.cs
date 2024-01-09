namespace ExceptionHandling
{
    public class YouTubeException : Exception
	{
		public YouTubeException(string message, Exception InnerException )
			:base(message, innerException)
		{

		}
	}
}

