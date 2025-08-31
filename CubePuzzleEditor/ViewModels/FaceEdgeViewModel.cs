using BlueprintLib.Attributes;
using DataModelLib;
using DataViewModelLib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CubePuzzleEditor.ViewModels
{
	[TableViewModel, DTO("FaceEdge"),  Blueprint("TableViewModel"), Blueprint("TableViewModelCollection"), Using("CubePuzzleLib.Models"), Using("CubePuzzleLib.Tables")]
	public partial class FaceEdgeViewModel
	{
		
	}
}
