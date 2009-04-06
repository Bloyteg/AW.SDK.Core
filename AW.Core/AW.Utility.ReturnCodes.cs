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
                {0, "RC_SUCCESS"},
                {1, "RC_CITIZENSHIP_EXPIRED"},
                {2, "RC_LAND_LIMIT_EXCEEDED"},
                {3, "RC_NO_SUCH_CITIZEN"},
                {4, "RC_MESSAGE_LENGTH_BAD"},
                {5, "RC_LICENSE_PASSWORD_CONTAINS_SPACE"},
                {6, "RC_LICENSE_PASSWORD_TOO_LONG"},
                {7, "RC_LICENSE_PASSWORD_TOO_SHORT"},
                {8, "RC_LICENSE_RANGE_TOO_LARGE"},
                {9, "RC_LICENSE_RANGE_TOO_SMALL"},
                {10, "RC_LICENSE_USERS_TOO_LARGE"},
                {11, "RC_LICENSE_USERS_TOO_SMALL"},
                {12, "RC_LICENSE_CONTAINS_INVALID_CHAR"},
                {13, "RC_INVALID_PASSWORD"},
                {14, "RC_UNABLE_TO_MAIL_BACK_NUMBER"},
                {15, "RC_LICENSE_WORLD_TOO_SHORT"},
                {16, "RC_LICENSE_WORLD_TOO_LONG"},
                {17, "RC_SERVER_OUT_OF_MEMORY"},
                {20, "RC_INVALID_WORLD"},
                {21, "RC_SERVER_OUTDATED"},
                {22, "RC_WORLD_ALREADY_STARTED"},
                {27, "RC_NO_SUCH_WORLD"},
                {31, "RC_NOT_LOGGED_IN"},
                {32, "RC_UNAUTHORIZED"},
                {33, "RC_WORLD_ALREADY_EXISTS"},
                {34, "RC_NO_SUCH_LICENSE"},
                {39, "RC_IDENTITY_ALREADY_IN_USE"},
                {40, "RC_UNABLE_TO_REPORT_LOCATION"},
                {41, "RC_INVALID_EMAIL"},
                {42, "RC_NO_SUCH_ACTING_CITIZEN"},
                {43, "RC_ACTING_PASSWORD_INVALID"},
                {45, "RC_UNIVERSE_FULL"},
                {46, "RC_BILLING_TIMEOUT"},
                {47, "RC_BILLING_RECV_FAILED"},
                {48, "RC_BILLING_RESPONSE_INVALID"},
                {55, "RC_BILLING_REJECTED"},
                {56, "RC_BILLING_BLOCKED"},
                {57, "RC_TOO_MANY_WORLDS"},
                {58, "RC_MUST_UPGRADE"},
                {59, "RC_BOT_LIMIT_EXCEEDED"},
                {61, "RC_WORLD_EXPIRED"},
                {62, "RC_CITIZEN_DOES_NOT_EXPIRE"},
                {64, "RC_LICENSE_STARTS_WITH_NUMBER"},
                {66, "RC_NO_SUCH_EJECTION"},
                {67, "RC_NO_SUCH_SESSION"},
                {69, "RC_EJECTION_EXPIRED"},
                {70, "RC_ACTING_CITIZEN_EXPIRED"},
                {71, "RC_ALREADY_STARTED"},
                {72, "RC_WORLD_RUNNING"},
                {73, "RC_WORLD_NOT_SET"},
                {74, "RC_NO_SUCH_CELL"},
                {75, "RC_NO_REGISTRY"},
                {76, "RC_CANT_OPEN_REGISTRY"},
                {77, "RC_CITIZEN_DISABLED"},
                {78, "RC_WORLD_DISABLED"},
                {79, "RC_BETA_REQUIRED"},
                {80, "RC_ACTING_CITIZEN_DISABLED"},
                {81, "RC_INVALID_USER_COUNT"},
                {91, "RC_PRIVATE_WORLD"},
                {92, "RC_NO_TOURISTS"},
                {100, "RC_EMAIL_CONTAINS_INVALID_CHAR"},
                {101, "RC_EMAIL_ENDS_WITH_BLANK"},
                {102, "RC_EMAIL_MISSING_DOT"},
                {103, "RC_EMAIL_MISSING_AT"},
                {104, "RC_EMAIL_STARTS_WITH_BLANK"},
                {105, "RC_EMAIL_TOO_LONG"},
                {106, "RC_EMAIL_TOO_SHORT"},
                {107, "RC_NAME_ALREADY_USED"},
                {108, "RC_NAME_CONTAINS_NONALPHANUMERIC_CHAR"},
                {109, "RC_NAME_CONTAINS_INVALID_BLANK"},
                {110, "RC_NAME_DOESNT_EXIST"},
                {111, "RC_NAME_ENDS_WITH_BLANK"},
                {112, "RC_NAME_TOO_LONG"},
                {113, "RC_NAME_TOO_SHORT"},
                {114, "RC_NAME_UNUSED"},
                {115, "RC_PASSWORD_TOO_LONG"},
                {116, "RC_PASSWORD_TOO_SHORT"},
                {117, "RC_PASSWORD_WRONG"},
                {119, "RC_UNABLE_TO_DELETE_NAME"},
                {120, "RC_UNABLE_TO_GET_CITIZEN"},
                {121, "RC_UNABLE_TO_INSERT_CITIZEN"},
                {122, "RC_UNABLE_TO_INSERT_NAME"},
                {123, "RC_UNABLE_TO_PUT_CITIZEN_COUNT"},
                {124, "RC_UNABLE_TO_DELETE_CITIZEN"},
                {126, "RC_NUMBER_ALREADY_USED"},
                {127, "RC_NUMBER_OUT_OF_RANGE"},
                {128, "RC_PRIVILEGE_PASSWORD_IS_TOO_SHORT"},
                {129, "RC_PRIVILEGE_PASSWORD_IS_TOO_LONG"},
                {203, "RC_NOT_CHANGE_OWNER"},
                {204, "RC_CANT_FIND_OLD_ELEMENT"},
                {210, "RC_UNABLE_TO_CHANGE_ATTRIBUTE"},
                {211, "RC_CANT_CHANGE_OWNER"},
                {212, "RC_IMPOSTER"},
                {213, "RC_INVALID_REQUEST"},
                {216, "RC_CANT_BUILD_HERE"},
                {300, "RC_ENCROACHES"},
                {301, "RC_NO_SUCH_OBJECT"},
                {302, "RC_NOT_DELETE_OWNER"},
                {303, "RC_TOO_MANY_BYTES"},
                {305, "RC_UNABLE_TO_STORE"},
                {306, "RC_UNREGISTERED_OBJECT"},
                {308, "RC_ELEMENT_ALREADY_EXISTS"},
                {309, "RC_RESTRICTED_COMMAND"},
                {310, "RC_NO_BUILD_RIGHTS"},
                {311, "RC_OUT_OF_BOUNDS"},
                {313, "RC_RESTRICTED_OBJECT"},
                {314, "RC_RESTRICTED_AREA"},
                {400, "RC_OUT_OF_MEMORY"},
                {401, "RC_NOT_YET"},
                {402, "RC_TIMEOUT"},
                {403, "RC_NULL_POINTER"},
                {404, "RC_UNABLE_TO_CONTACT_UNIVERSE"},
                {405, "RC_UNABLE_TO_CONTACT_WORLD"},
                {406, "RC_INVALID_WORLD_NAME"},
                {415, "RC_SEND_FAILED"},
                {416, "RC_RECEIVE_FAILED"},
                {421, "RC_STREAM_EMPTY"},
                {422, "RC_STREAM_MESSAGE_TOO_LONG"},
                {423, "RC_WORLD_NAME_TOO_LONG"},
                {426, "RC_MESSAGE_TOO_LONG"},
                {427, "RC_TOO_MANY_RESETS"},
                {428, "RC_UNABLE_TO_CREATE_SOCKET"},
                {429, "RC_UNABLE_TO_CONNECT"},
                {430, "RC_UNABLE_TO_SET_NONBLOCKING"},
                {434, "RC_CANT_OPEN_STREAM"},
                {435, "RC_CANT_WRITE_STREAM"},
                {436, "RC_CANT_CLOSE_STREAM"},
                {439, "RC_NO_CONNECTION"},
                {442, "RC_UNABLE_TO_INITIALIZE_NETWORK"},
                {443, "RC_INCORRECT_MESSAGE_LENGTH"},
                {444, "RC_NOT_INITIALIZED"},
                {445, "RC_NO_INSTANCE"},
                {446, "RC_OUT_BUFFER_FULL"},
                {447, "RC_INVALID_CALLBACK"},
                {448, "RC_INVALID_ATTRIBUTE"},
                {449, "RC_TYPE_MISMATCH"},
                {450, "RC_STRING_TOO_LONG"},
                {451, "RC_READ_ONLY"},
                {452, "RC_UNABLE_TO_REGISTER_RESOLVE"},
                {453, "RC_INVALID_INSTANCE"},
                {454, "RC_VERSION_MISMATCH"},
                {461, "RC_IN_BUFFER_FULL"},
                {463, "RC_PROTOCOL_ERROR"},
                {464, "RC_QUERY_IN_PROGRESS"},
                {465, "RC_WORLD_FULL"},
                {466, "RC_EJECTED"},
                {467, "RC_NOT_WELCOME"},
                {468, "RC_UNABLE_TO_BIND"},
                {469, "RC_UNABLE_TO_LISTEN"},
                {470, "RC_UNABLE_TO_ACCEPT"},
                {471, "RC_CONNECTION_LOST"},
                {473, "RC_NO_STREAM"},
                {474, "RC_NOT_AVAILABLE"},
                {487, "RC_OLD_UNIVERSE"},
                {488, "RC_OLD_WORLD"},
                {489, "RC_WORLD_NOT_RUNNING"},
                {500, "RC_CANT_RESOLVE_UNIVERSE_HOST"},
                {505, "RC_INVALID_ARGUMENT"},
                {521, "RC_WORLD_INSTANCE_ALREADY_EXISTS"},
                {522, "RC_WORLD_INSTANCE_INVALID"},
                {525, "RC_EMAIL_CHANGE_NOT_ALLOWED"},
                {526, "RC_NAME_CHANGE_NOT_ALLOWED"},
                {527, "RC_EMAIL_ALREADY_USED"},
                {528, "RC_EMAIL_NOT_ALLOWED"},
                {529, "RC_WORLD_REDIRECT"},
                {600, "RC_DATABASE_ERROR"}
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
