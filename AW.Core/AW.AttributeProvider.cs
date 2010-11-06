 

namespace AW
{
	internal class AttributeProvider : IAttributeProvider
	{
		private readonly IInstance _instance;
		
		public AttributeProvider(IInstance instance)
		{
			_instance = instance;
		}
	
	}
}

