using IdentityServer.Debugging;

namespace IdentityServer
{
    public class IdentityServerConsts
    {
        public const string LocalizationSourceName = "IdentityServer";

        public const string ConnectionStringName = "Default";

        public const bool MultiTenancyEnabled = true;


        /// <summary>
        /// Default pass phrase for SimpleStringCipher decrypt/encrypt operations
        /// </summary>
        public static readonly string DefaultPassPhrase =
            DebugHelper.IsDebug ? "gsKxGZ012HLL3MI5" : "7c822db01db340a2be19488b3911ec63";
    }
}
