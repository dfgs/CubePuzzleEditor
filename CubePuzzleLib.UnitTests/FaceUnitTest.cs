using BlueprintLib.Attributes;
using DataModelLib;
using DataLib;

namespace CubePuzzleLib.UnitTests
{
	[TestClass,TableUnitTest, DTO("Face"), Blueprint("TableModel.UnitTest.*"),MockCount(6)]
	public partial class FaceUnitTest
	{

	}
}
