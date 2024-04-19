#region Selection statements

string password = "ninja";

if (password.Length < 8) {
	WriteLine("Your password is too short. Use at least 8 chars.");
}
else
{
	WriteLine("Your password is long enough.");
}
#endregion