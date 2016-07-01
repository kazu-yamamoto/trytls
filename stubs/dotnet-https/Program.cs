﻿using System;
using System.Net.Http;
using System.Threading.Tasks;

class Program
{
	static void Main(string[] args)
	{
		try {
			string url = "https://"+args[0]+":"+args[1];
			GetURL(url).Wait();
			Console.WriteLine("VERIFY SUCCESS");
		} catch (AggregateException ae) {
			ae.Handle((x) =>
			{
			if (x is HttpRequestException) 
			{
				Console.WriteLine("VERIFY FAILURE");
				return true;
			}
			else {
				return false;
			}
			});
		} catch (System.IndexOutOfRangeException) {
			Console.WriteLine("Usage: dotnettest <URL>");
		} catch (Exception e) {
			Console.WriteLine("Unhandled exception: {0} {1}",e.Message,e);
		} 
	}
	
	static async Task GetURL(string url)
	{
		using (HttpClient client = new HttpClient())
		using (HttpResponseMessage response = await client.GetAsync(url))
		using (HttpContent content = response.Content)
		{
		// ... Read the string.
			string result = await content.ReadAsStringAsync();

		}
	}	
}


