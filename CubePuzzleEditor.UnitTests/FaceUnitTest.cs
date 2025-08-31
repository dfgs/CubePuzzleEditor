using BlueprintLib.Attributes;
using DataModelLib;
using DataLib;

namespace CubePuzzleLib.UnitTests
{
	[TestClass,TableUnitTest, DTO("Face"), Blueprint("TableViewModel.UnitTest.*"),MockCount(12), Using("CubePuzzleEditor.ViewModels"), Using("CubePuzzleLib.Models")]
	public partial class FaceUnitTest
	{

	}
}
