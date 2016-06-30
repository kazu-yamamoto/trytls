import java.net.URL;
import java.io.*;
import javax.net.ssl.HttpsURLConnection;

public class Main{
	
	public static void main(String[] args)
	{

		if (args.length < 2)
			System.exit(1);

		String host = args[0];
		String port = args[1];
		String ca_bundle = "";
		
		if (args.length > 3) {
			ca_bundle = args[3]; 
			System.out.println("UNSUPPORTED");	//for now
			System.exit(2);
		}

		URL url;
		String https_url = String.format("https://%s:%s", host, port);
		try {
			url = new URL(https_url);
			HttpsURLConnection con = (HttpsURLConnection)url.openConnection();
			
			if (con.getResponseCode() == 200)
				System.out.println("VERIFY SUCCESS");
			else
				System.out.println("VERIFY FAILURE");
		} catch (Exception e) {
			System.out.println(e.getMessage());
			System.exit(3);
		}

		System.exit(0);
	} 
	
}

