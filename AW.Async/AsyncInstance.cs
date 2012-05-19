using System.Collections.Generic;
using System.Threading.Tasks;

namespace AW.Async
{
    /// <summary>
    /// Provides extension methods to <see cref="AW.IInstance">IInstance</see> for several asynchronous operations.
    /// These operations are wrapped up as <see cref="Task{TResult}" /> of <see cref="AW.Result" />.
    /// </summary>
    public static partial class AsyncInstance
    {
        private static readonly Dictionary<IInstance, Dictionary<Callbacks, Queue<CallbackWorkItem>>> _CallbackWorkItemQueues = new Dictionary<IInstance, Dictionary<Callbacks, Queue<CallbackWorkItem>>>();

        private static readonly Dictionary<IInstance, CallbackObjectReferenceCounter> _CallbackObjectReferenceCounters = new Dictionary<IInstance, CallbackObjectReferenceCounter>();

        /// <summary>
        /// Asynchronously retrieves the IP address for the given session.
        /// </summary>
        /// <param name="instance"></param>
        /// <param name="session">The session to retrieve the IP address of.</param>
        /// <returns>
        /// </returns>
        public static Task<Result> AddressAsync(this IInstance instance, int session)
        {
            return instance.CreateCallbackTask(Callbacks.Address,
                                               () => instance.Address(session),
                                               handler => instance.CallbackAddress += handler);
        }

        public static Task<Result> AvatarLocationAsync(this IInstance instance, int citizenNumber = 0, int session = 0, string name = "")
        {
            return instance.CreateCallbackTask(Callbacks.AvatarLocation,
                                               () => instance.AvatarLocation(citizenNumber, session, name),
                                               handler => instance.CallbackAvatarLocation += handler);
        }

        public static Task<Result> EnterAsync(this IInstance instance, string worldName)
        {
            return instance.CreateCallbackTask(Callbacks.Enter,
                                               () => instance.Enter(worldName),
                                               handler => instance.CallbackEnter += handler);
        }

        public static Task<Result> LoginAsync(this IInstance instance)
        {
            return instance.CreateCallbackTask(Callbacks.Login,
                                               instance.Login,
                                               handler => instance.CallbackLogin += handler);
        }

        public static Task<Result> WorldResetAttributesAsync(this IInstance instance)
        {
            return instance.CreateCallbackTask(Callbacks.AttributesResetResult,
                                               instance.WorldAttributesReset,
                                               handler => instance.CallbackAttributesResetResult += handler);
        }

        public static Task<Result> BotgramSendAsync(this IInstance instance)
        {
            return instance.CreateCallbackTask(Callbacks.BotgramResult,
                                               instance.BotgramSend,
                                               handler => instance.CallbackBotgramResult += handler);
        }

        public static Task<Result> BotmenuSendAsync(this IInstance instance)
        {
            return instance.CreateCallbackTask(Callbacks.BotmenuResult,
                                               instance.BotmenuSend,
                                               handler => instance.CallbackBotmenuResult += handler);
        }

        public static Task<Result> CellNextAsync(this IInstance instance)
        {
            return instance.CreateCallbackTask(Callbacks.CellResult,
                                               instance.CellNext,
                                               handler => instance.CallbackCellResult += handler);
        }

        public static Task<Result> CavRequestAsync(this IInstance instance, int citizen = 0, int session = 0)
        {
            return instance.CreateCallbackTask(Callbacks.Cav,
                                               () => instance.CavRequest(citizen, session),
                                               handler => instance.CallbackCav += handler);
        }

        public static Task<Result> DeleteAllObjectsAsync(this IInstance instance)
        {
            return instance.CreateCallbackTask(Callbacks.DeleteAllObjectsResult,
                                               instance.DeleteAllObjects,
                                               handler => instance.CallbackDeleteAllObjectsResult += handler);
        }

        public static Task<Result> HudCreateAsync(this IInstance instance)
        {
            return instance.CreateCallbackTask(Callbacks.HudResult,
                                               instance.HudCreate,
                                               handler => instance.CallbackHudResult += handler);
        }

        public static Task<Result> ObjectQueryAsync(this IInstance instance)
        {
            return instance.CreateCallbackTask(Callbacks.ObjectQuery,
                                               instance.ObjectQuery,
                                               handler => instance.CallbackObjectQuery += handler);
        }

        public static Task<Result> QueryAsync(this IInstance instance, int xSector, int zSector, int[,] sequence)
        {
            return instance.CreateCallbackTask(Callbacks.Query,
                                               () => instance.Query(xSector, zSector, sequence),
                                               handler => instance.CallbackQuery += handler);
        }

        public static Task<Result> Query5x5Async(this IInstance instance, int xSector, int zSector, int[,] sequence)
        {
            return instance.CreateCallbackTask(Callbacks.Query,
                                               () => instance.Query5x5(xSector, zSector, sequence),
                                               handler => instance.CallbackQuery += handler);
        }

        public static Task<Result> WorldReloadRegistryAsync(this IInstance instance)
        {
            return instance.CreateCallbackTask(Callbacks.ReloadRegistry,
                                               instance.WorldReloadRegistry,
                                               handler => instance.CallbackReloadRegistry += handler);
        }

        public static Task<Result> TerrainDeleteAllAsync(this IInstance instance)
        {
            return instance.CreateCallbackTask(Callbacks.TerrainDeleteAllResult,
                                               instance.TerrainDeleteAll,
                                               handler => instance.CallbackTerrainDeleteAllResult += handler);
        }

        public static Task<Result> TerrainNextAsync(this IInstance instance)
        {
            return instance.CreateCallbackTask(Callbacks.TerrainNextResult,
                                               instance.TerrainNext,
                                               handler => instance.CallbackTerrainNextResult += handler);
        }

        public static Task<Result> TerrainSetAsync(this IInstance instance, int x, int z, int texture, int[] heights)
        {
            return instance.CreateCallbackTask(Callbacks.TerrainSetResult,
                                               () => instance.TerrainSet(x, z, texture, heights),
                                               handler => instance.CallbackTerrainSetResult += handler);
        }

        public static Task<Result> TerrainLoadNodeAsync(this IInstance instance)
        {
            return instance.CreateCallbackTask(Callbacks.TerrainLoadNodeResult,
                                               instance.TerrainLoadNode,
                                               handler => instance.CallbackTerrainLoadNodeResult += handler);
        }

        public static Task<Result> UserListAsync(this IInstance instance)
        {
            return instance.CreateCallbackTask(Callbacks.UserList,
                                               instance.UserList,
                                               handler => instance.CallbackUserList += handler);
        }

        public static Task<Result> WorldListAsync(this IInstance instance)
        {
            return instance.CreateCallbackTask(Callbacks.WorldList,
                                               instance.WorldList,
                                               handler => instance.CallbackWorldList += handler);
        }

        #region Object Result based async tasks

        public static Task<Result> ObjectAddAsync(this IInstance instance)
        {
            return instance.CreateCallbackTask(Callbacks.ObjectResult,
                                               instance.ObjectAdd,
                                               handler => instance.CallbackObjectResult += handler);
        }

        public static Task<Result> ObjectDeleteAsync(this IInstance instance)
        {
            return instance.CreateCallbackTask(Callbacks.ObjectResult,
                                               instance.ObjectDelete,
                                               handler => instance.CallbackObjectResult += handler);
        }

        public static Task<Result> ObjectChangeAsync(this IInstance instance)
        {
            return instance.CreateCallbackTask(Callbacks.ObjectResult,
                                               instance.ObjectChange,
                                               handler => instance.CallbackObjectResult += handler);
        }

        public static Task<Result> ObjectLoadAsync(this IInstance instance)
        {
            return instance.CreateCallbackTask(Callbacks.ObjectResult,
                                               instance.ObjectLoad,
                                               handler => instance.CallbackObjectResult += handler);
        }

        public static Task<Result> ObjectAddSessionAsync(this IInstance instance, int session)
        {
            return instance.CreateCallbackTask(Callbacks.ObjectResult,
                                               () => instance.ObjectAddSession(session),
                                               handler => instance.CallbackObjectResult += handler);
        }

        public static Task<Result> ObjectDeleteSessionAsync(this IInstance instance, int session)
        {
            return instance.CreateCallbackTask(Callbacks.ObjectResult,
                                               () => instance.ObjectDeleteSession(session),
                                               handler => instance.CallbackObjectResult += handler);
        }

        #endregion
    }
}
