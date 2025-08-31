using BlueprintLib.Attributes;
using DataModelLib;
using DataLib;

namespace CubePuzzleLib.UnitTests
{
	[TestClass, TableUnitTest, DTO("Edge"), Blueprint("TableViewModel.UnitTest.*"), MockCount(24), Using("CubePuzzleEditor.ViewModels"), Using("CubePuzzleLib.Models")]
	public partial class EdgeUnitTest
	{

	}
}
