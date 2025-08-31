using DataModelLib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BlueprintLib.Attributes;
using DataLib;

namespace CubePuzzleLib.UnitTests
{
	[TestClass, DatabaseUnitTest,DTO("Puzzle"), Blueprint("DatabaseViewModel.UnitTest.*"),Blueprint("DatabaseModel.UnitTest.Mock"), Using("CubePuzzleEditor.ViewModels"), Using("CubePuzzleLib.Models")]
	public partial class PuzzleUnitTest
	{
	}
}
