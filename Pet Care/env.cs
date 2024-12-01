using DotNetEnv;

class EnvLoader
{
    public static string connection {  get; private set; }
    public static string Nama_Email {  get; private set; }
    public static string Email {  get; private set; }
    public static string Token_Email {  get; private set; }
    public static string Token_Tele {  get; private set; }
    public static void LoadEnvironmentVariables()
    {
        Env.Load();
        connection = Env.GetString("DATABASE");
        Nama_Email = Env.GetString("Nama_Email");
        Email = Env.GetString("Email");
        Token_Email = Env.GetString("Token_SMTP");
        Token_Tele = Env.GetString("Token_Telegram");
    }
}