using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BlueprintLib.Attributes;
using DataViewModelLib;

namespace CubePuzzleEditor.ViewModels
{
	[DatabaseViewModel, DTO("Puzzle"), Blueprint("DatabaseViewModel"), Blueprint("RelationViewModelCollection"), Using("CubePuzzleLib.Models")]
	public partial class PuzzleViewModel
	{
		
	}
}
