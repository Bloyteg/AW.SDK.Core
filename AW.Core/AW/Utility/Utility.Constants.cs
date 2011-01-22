namespace AW
{
    public static partial class Utility
    {
        private const int BufferSize = 4096;

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
                    return 93;
                }
            }

            /// <summary>
            /// Maximum number of <see cref="AW.Instance.StateChange" /> calls allowed by the world server.
            /// </summary>
            public static int MaxAvchangePerSecond
            {
                get
                {
                    return 10;
                }
            }

            /// <summary>
            /// The maximum number of <see cref="AW.Instance.Say(string)" />  calls allowed by the world server.
            /// </summary>
            public static int MaxMessagesPerSecond
            {
                get
                {
                    return 100;
                }
            }

            /// <summary>
            /// The maximum number of <see cref="AW.Instance.Whisper(int, string)" />  calls allowed by the world server.
            /// </summary>
            public static int MaxWhispersPerSecond
            {
                get
                {
                    return 100;
                }
            }

            /// <summary>
            /// The maximum number of <see cref="AW.Instance.BotgramSend" />  calls allowed by the universe server.
            /// </summary>
            public static int MaxBotgramsPerSecond
            {
                get
                {
                    return 32;
                }
            }

            /// <summary>
            /// The maximum length of strings being set by <see cref="AW.Instance.SetString" /> or retrieved by <see cref="AW.Instance.GetString" />
            /// </summary>
            public static int MaxAttributeLength
            {
                get
                {
                    return 255;
                }
            }

            /// <summary>
            /// Gets the length of the max user name.
            /// </summary>
            /// <value>The length of the max user name.</value>
            public static int MaxUserNameLength
            {
                get
                {
                    return 20;
                }
            }

            /// <summary>
            /// Gets the length of the min user name.
            /// </summary>
            /// <value>The length of the min user name.</value>
            public static int MinUserNameLength
            {
                get
                {
                    return 2;
                }
            }

            /// <summary>
            /// Gets the length of the max password.
            /// </summary>
            /// <value>The length of the max password.</value>
            public static int MaxPasswordLength
            {
                get
                {
                    return 16;
                }
            }

            /// <summary>
            /// Gets the length of the min password.
            /// </summary>
            /// <value>The length of the min password.</value>
            public static int MinPasswordLength
            {
                get
                {
                    return 4;
                }
            }

            /// <summary>
            /// Gets the length of the max email.
            /// </summary>
            /// <value>The length of the max email.</value>
            public static int MaxEmailLength
            {
                get
                {
                    return 64;
                }
            }

            /// <summary>
            /// Gets the length of the max world name.
            /// </summary>
            /// <value>The length of the max world name.</value>
            public static int MaxWorldNameLength
            {
                get
                {
                    return 16;
                }
            }

            /// <summary>
            /// Gets the max long data.
            /// </summary>
            /// <value>The max long data.</value>
            public static int MaxLongData
            {
                get
                {
                    return 4094;
                }
            }

            /// <summary>
            /// Gets the personal avatar.
            /// </summary>
            /// <value>The personal avatar.</value>
            public static int PersonalAvatar 
            {
                get
                {
                    return 65535;
                }
            }

            /// <summary>
            /// Gets the custom avatar.
            /// </summary>
            /// <value>The custom avatar.</value>
            public static int CustomAvatar
            {
                get
                {
                    return 65534;
                }
            }

            /// <summary>
            /// Gets the custom world avatar.
            /// </summary>
            /// <value>The custom world avatar.</value>
            public static int CustomWorldAvatar
            {
                get
                {
                    return 65533;
                }
            }
        }
    }
}