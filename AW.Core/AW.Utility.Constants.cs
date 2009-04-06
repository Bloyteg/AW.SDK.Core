namespace AW
{
    public static partial class Utility
    {
        private static readonly uint bufferSize = 4096;

        /// <summary>
        /// A static container containing several constants representing different aspects of the SDK.
        /// </summary>
        public static class Constants
        {
            /// <summary>
            /// The current build of the SDK that this version of the SDK wrapper utilizes.
            /// </summary>
            public static int CurrentBuild
            {
                get
                {
                    return 77;
                }
            }

            /// <summary>
            /// Maximum number of <see cref="AW.Instance.StateChange" /> calls allowed by the world server.
            /// </summary>
            public static uint MaxAvchangePerSecond
            {
                get
                {
                    return 10;
                }
            }

            /// <summary>
            /// The maximum number of <see cref="AW.Instance.Say(string)" />  calls allowed by the world server.
            /// </summary>
            public static uint MaxMessagesPerSecond
            {
                get
                {
                    return 100;
                }
            }

            /// <summary>
            /// The maximum number of <see cref="AW.Instance.Whisper(int, string)" />  calls allowed by the world server.
            /// </summary>
            public static uint MaxWhispersPerSecond
            {
                get
                {
                    return 100;
                }
            }

            /// <summary>
            /// The maximum number of <see cref="AW.Instance.BotgramSend" />  calls allowed by the universe server.
            /// </summary>
            public static uint MaxBotgramsPerSecond
            {
                get
                {
                    return 32;
                }
            }

            /// <summary>
            /// The maximum length of strings being set by <see cref="AW.Instance.SetString" /> or retrieved by <see cref="AW.Instance.GetString" />
            /// </summary>
            public static uint MaxAttributeLength
            {
                get
                {
                    return 255;
                }
            }

            public static uint PersonalAvatar 
            {
                get
                {
                    return 65535;
                }
            }

            public static uint CustomAvatar
            {
                get
                {
                    return 65534;
                }
            }

            public static uint CustomWorldAvatar
            {
                get
                {
                    return 65533;
                }
            }
        }
    }
}