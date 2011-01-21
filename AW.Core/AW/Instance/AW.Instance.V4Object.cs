namespace AW
{
    public partial class Instance
    {
        /// <summary>
        /// Sets the attribute Attributes.ObjectData of the instance to the data represented by the V4 object.
        /// </summary>
        /// <typeparam name="TV4Object">The type of the V4 object being used.</typeparam>
        /// <param name="v4Object">The V4 object representing the data to be set.</param>
        public void SetV4Object<TV4Object>(TV4Object v4Object)
            where TV4Object : V4Object<TV4Object>, new()
        {
            SetInstance();
            SetData(AW.Attributes.ObjectData, v4Object.GetData());
        }

        /// <summary>
        /// Retrieves a V4 object from the Attributes.ObjectData attribute of the instance.
        /// </summary>
        /// <typeparam name="TV4Object">the type of V4 object to be returned.</typeparam>
        /// <returns></returns>
        public TV4Object GetV4Object<TV4Object>() 
            where TV4Object : V4Object<TV4Object>, new()
        {
            SetInstance();
            var v4Object = new TV4Object();
            v4Object.SetData(GetData(AW.Attributes.ObjectData));
            return v4Object;
        }
    }
}