string GeneratePassword (int LenghtPassword)
{
	var rand = new Random();

	string password = string.Empty;
	for (int i=0;i<LenghtPassword/4;i++)
	{
			password += (char)rand.Next('a', 'z');
			password += (char)rand.Next('A', 'Z');
			password += rand.Next(1, 10);
			password += (char)rand.Next('!', ')');
			
	}
	return password;
}

System.Console.WriteLine(GeneratePassword(8));

