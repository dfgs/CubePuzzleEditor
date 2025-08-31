using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BlueprintLib.Attributes;
using DataViewModelLib;

namespace CubePuzzleEditor.ViewModels
{
	[TableViewModel, DTO("Face"),   Blueprint("TableViewModel"), Blueprint("TableViewModelCollection"), Using("CubePuzzleLib.Models"), Using("CubePuzzleLib.Tables")]
	public partial class FaceViewModel
	{
		public IEnumerable<EdgeViewModel> Edges()
		{
			return this.F_FaceEdges.Select(item => item.Edge);
		}
	}
}
