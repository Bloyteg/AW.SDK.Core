using System.IO;

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
            where TV4Object : IV4Object, new()
        {
            using (var stream = new MemoryStream())
            {
                SetInstance();
                var serializer = new V4ObjectSerializer<TV4Object>();
                serializer.Serialize(stream, v4Object);

                var buffer = new byte[stream.Length];
                stream.Position = 0;
                stream.Read(buffer, 0, buffer.Length);
                SetData(AW.Attributes.ObjectData, buffer);
            }
        }

        /// <summary>
        /// Retrieves a V4 object from the Attributes.ObjectData attribute of the instance.
        /// </summary>
        /// <typeparam name="TV4Object">the type of V4 object to be returned.</typeparam>
        /// <returns></returns>
        public TV4Object GetV4Object<TV4Object>()
            where TV4Object : IV4Object, new()
        {
            SetInstance();
            using (var stream = new MemoryStream(GetData(AW.Attributes.ObjectData)))
            {
                var serializer = new V4ObjectSerializer<TV4Object>();
                return serializer.Deserialize(stream);
            }
        }
    }
}