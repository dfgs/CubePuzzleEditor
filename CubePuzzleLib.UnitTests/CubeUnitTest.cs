using BlueprintLib.Attributes;
using DataModelLib;
using DataLib;

namespace CubePuzzleLib.UnitTests
{
	
	[TestClass, TableUnitTest, DTO("Cube"),  Blueprint("TableModel.UnitTest.*"), MockCount(2)]
	public partial class CubeUnitTest
	{

	}
}
