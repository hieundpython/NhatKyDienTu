using NhatKyDienTu.Debugging;

namespace NhatKyDienTu
{
    public class NhatKyDienTuConsts
    {
        public const string LocalizationSourceName = "NhatKyDienTu";

        public const string ConnectionStringName = "Default";

        public const bool MultiTenancyEnabled = true;


        /// <summary>
        /// Default pass phrase for SimpleStringCipher decrypt/encrypt operations
        /// </summary>
        public static readonly string DefaultPassPhrase =
            DebugHelper.IsDebug ? "gsKxGZ012HLL3MI5" : "eec21f14f4d94e9f889db33787ede019";
    }
}
