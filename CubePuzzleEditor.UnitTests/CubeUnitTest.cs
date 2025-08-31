using BlueprintLib.Attributes;
using DataModelLib;
using DataLib;

namespace CubePuzzleLib.UnitTests
{
	
	[TestClass, TableUnitTest, DTO("Cube"),  Blueprint("TableViewModel.UnitTest.*"), MockCount(3), Using("CubePuzzleEditor.ViewModels"), Using("CubePuzzleLib.Models")]
	public partial class CubeUnitTest
	{

	}
}
