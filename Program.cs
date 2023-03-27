using System.Reflection.Metadata.Ecma335;


//click on the run without debugging and paste in a base64 encoded string and click enter
//hit enter without data or type 'exit' to quit

bool loop = true;
while (loop)
{
	Console.WriteLine("enter the base 64 encoded string that you wish to process and hit 'enter'");
	Console.WriteLine("type 'exit' to exit");
	string base64EncodedData = Console.ReadLine();
	if (base64EncodedData != "exit")
	{
		if (base64EncodedData.Count() != 0)
		{
			Console.WriteLine();
			byte[] base64EncodedBytes = System.Convert.FromBase64String(base64EncodedData);
			Console.WriteLine(System.Text.Encoding.UTF8.GetString(base64EncodedBytes));
		}
		else
		{ 
			loop = false;
		}
	}
	else 
	{ 
		loop = false;
	} 
}

