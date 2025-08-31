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
	[TableViewModel, DTO("Edge"),  Blueprint("TableViewModel"), Blueprint("TableViewModelCollection"), Using("CubePuzzleLib.Models"), Using("CubePuzzleLib.Tables")]
	public partial class EdgeViewModel
	{
		public IEnumerable<FaceViewModel> Faces()
		{
			return this.E_FaceEdges.Select(item => item.Face);
		}
	}
}
