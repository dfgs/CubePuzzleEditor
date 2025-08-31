using BlueprintLib.Attributes;
using DataModelLib;
using DataLib;

namespace CubePuzzleLib.UnitTests
{
	[TestClass, TableUnitTest, DTO("Edge"), Blueprint("TableModel.UnitTest.*"), MockCount(12)]
	public partial class EdgeUnitTest
	{

	}
}
