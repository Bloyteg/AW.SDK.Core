using System;
using System.Collections.Generic;

namespace AW
{
    public static partial class Utility
    {
        internal class RCTable : Utilities.IIndexedPropery<int, string>
        {
            private readonly Dictionary<int, string> rcDictionary = new Dictionary<int, string>
            {
                { 0, "RC_SUCCESS" },
                { 1, "RC_CITIZENSHIP_EXPIRED" },
                { 2, "RC_LAND_LIMIT_EXCEEDED" },
                { 3, "RC_NO_SUCH_CITIZEN" },
                { 5, "RC_LICENSE_PASSWORD_CONTAINS_SPACE" },
                { 6, "RC_LICENSE_PASSWORD_TOO_LONG" },
                { 7, "RC_LICENSE_PASSWORD_TOO_SHORT" },
                { 8, "RC_LICENSE_RANGE_TOO_LARGE" },
                { 9, "RC_LICENSE_RANGE_TOO_SMALL" },
                { 10, "RC_LICENSE_USERS_TOO_LARGE" },
                { 11, "RC_LICENSE_USERS_TOO_SMALL" },
                { 13, "RC_INVALID_PASSWORD" },
                { 15, "RC_LICENSE_WORLD_TOO_SHORT" },
                { 16, "RC_LICENSE_WORLD_TOO_LONG" },
                { 20, "RC_INVALID_WORLD" },
                { 21, "RC_SERVER_OUTDATED" },
                { 22, "RC_WORLD_ALREADY_STARTED" },
                { 27, "RC_NO_SUCH_WORLD" },
                { 32, "RC_UNAUTHORIZED" },
                { 34, "RC_NO_SUCH_LICENSE" },
                { 57, "RC_TOO_MANY_WORLDS" },
                { 58, "RC_MUST_UPGRADE" },
                { 59, "RC_BOT_LIMIT_EXCEEDED" },
                { 61, "RC_WORLD_EXPIRED" },
                { 62, "RC_CITIZEN_DOES_NOT_EXPIRE" },
                { 64, "RC_LICENSE_STARTS_WITH_NUMBER" },
                { 66, "RC_NO_SUCH_EJECTION" },
                { 67, "RC_NO_SUCH_SESSION" },
                { 72, "RC_WORLD_RUNNING" },
                { 73, "RC_WORLD_NOT_SET" },
                { 74, "RC_NO_SUCH_CELL" },
                { 75, "RC_NO_REGISTRY" },
                { 76, "RC_CANT_OPEN_REGISTRY" },
                { 77, "RC_CITIZEN_DISABLED" },
                { 78, "RC_WORLD_DISABLED" },
                { 85, "RC_TELEGRAM_BLOCKED" },
                { 88, "RC_UNABLE_TO_UPDATE_TERRAIN" },
                { 100, "RC_EMAIL_CONTAINS_INVALID_CHAR" },
                { 101, "RC_EMAIL_ENDS_WITH_BLANK" },
                { 101, "RC_NO_SUCH_OBJECT" },
                { 102, "RC_EMAIL_MISSING_DOT" },
                { 102, "RC_NOT_DELETE_OWNER" },
                { 103, "RC_EMAIL_MISSING_AT" },
                { 104, "RC_EMAIL_STARTS_WITH_BLANK" },
                { 105, "RC_EMAIL_TOO_LONG" },
                { 106, "RC_EMAIL_TOO_SHORT" },
                { 107, "RC_NAME_ALREADY_USED" },
                { 108, "RC_NAME_CONTAINS_NONALPHANUMERIC_CHAR" },
                { 109, "RC_NAME_CONTAINS_INVALID_BLANK" },
                { 111, "RC_NAME_ENDS_WITH_BLANK" },
                { 112, "RC_NAME_TOO_LONG" },
                { 113, "RC_NAME_TOO_SHORT" },
                { 115, "RC_PASSWORD_TOO_LONG" },
                { 116, "RC_PASSWORD_TOO_SHORT" },
                { 124, "RC_UNABLE_TO_DELETE_CITIZEN" },
                { 126, "RC_NUMBER_ALREADY_USED" },
                { 127, "RC_NUMBER_OUT_OF_RANGE" },
                { 128, "RC_PRIVILEGE_PASSWORD_IS_TOO_SHORT" },
                { 129, "RC_PRIVILEGE_PASSWORD_IS_TOO_LONG" },
                { 203, "RC_NOT_CHANGE_OWNER" },
                { 204, "RC_CANT_FIND_OLD_ELEMENT" },
                { 212, "RC_IMPOSTER" },
                { 300, "RC_ENCROACHES" },
                { 301, "RC_OBJECT_TYPE_INVALID" },
                { 303, "RC_TOO_MANY_BYTES" },
                { 306, "RC_UNREGISTERED_OBJECT" },
                { 308, "RC_ELEMENT_ALREADY_EXISTS" },
                { 309, "RC_RESTRICTED_COMMAND" },
                { 311, "RC_OUT_OF_BOUNDS" },
                { 313, "RC_RESTRICTED_OBJECT" },
                { 314, "RC_RESTRICTED_AREA" },
                { 401, "RC_NOT_YET" },
                { 402, "RC_TIMEOUT" },
                { 404, "RC_UNABLE_TO_CONTACT_UNIVERSE" },
                { 439, "RC_NO_CONNECTION" },
                { 444, "RC_NOT_INITIALIZED" },
                { 445, "RC_NO_INSTANCE" },
                { 448, "RC_INVALID_ATTRIBUTE" },
                { 449, "RC_TYPE_MISMATCH" },
                { 450, "RC_STRING_TOO_LONG" },
                { 451, "RC_READ_ONLY" },
                { 453, "RC_INVALID_INSTANCE" },
                { 454, "RC_VERSION_MISMATCH" },
                { 464, "RC_QUERY_IN_PROGRESS" },
                { 466, "RC_EJECTED" },
                { 467, "RC_NOT_WELCOME" },
                { 471, "RC_CONNECTION_LOST" },
                { 474, "RC_NOT_AVAILABLE" },
                { 500, "RC_CANT_RESOLVE_UNIVERSE_HOST" },
                { 505, "RC_INVALID_ARGUMENT" },
                { 514, "RC_UNABLE_TO_UPDATE_CAV" },
                { 515, "RC_UNABLE_TO_DELETE_CAV" },
                { 516, "RC_NO_SUCH_CAV" },
                { 521, "RC_WORLD_INSTANCE_ALREADY_EXISTS" },
                { 522, "RC_WORLD_INSTANCE_INVALID" },
                { 523, "RC_PLUGIN_NOT_AVAILABLE" },
                { 600, "RC_DATABASE_ERROR" },
                { 4995, "RC_Z_BUF_ERROR" },
                { 4996, "RC_Z_MEM_ERROR" },
                { 4997, "RC_Z_DATA_ERROR" }
            };

            #region Util.IIndexedPropery<int,string> Members

            string Utilities.IIndexedPropery<int, string>.this[int key]
            {
                get
                {
                    if (rcDictionary.ContainsKey(key))
                    {
                        return rcDictionary[key];
                    }
                    else
                    {
                        return "No such return code.";
                    }
                }

                set { throw new NotSupportedException("This is a read-only property."); }
            }

            #endregion
        }

        private static Utilities.IIndexedPropery<int, string> rcTable = new RCTable();

        public static Utilities.IIndexedPropery<int, string> ReturnCodes
        {
            get { return rcTable; }
        }
    }
}
