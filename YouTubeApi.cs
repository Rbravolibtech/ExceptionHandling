using System;
using System.Collections.Generic;

namespace ExceptionHandling
{
    public class YouTubeApi
	{
		public List<Video> GetVideos(string user)
		{
			try
			{
				//Access YouTube web service
				//Read the data
				// Create a list of video objects
				throw new Exception("oops some low level youtube video");
			}
			catch (Exception ex)
			{
				//Log

				throw new YouTubeException("could not fetch the videos from Youtube", ex);
			}

			return new List<Video>();
		}
	}
}

