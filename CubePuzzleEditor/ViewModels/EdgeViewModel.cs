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
	[TableViewModel, DTO("Edge"),  Blueprint("TableViewModel"), Blueprint("TableViewModelCollection"), Using("CubePuzzleLib.Models")]
	public partial class EdgeViewModel
	{
		/*public IEnumerable<FaceModel> GetFaces()
		{
			return this.GetFaceEdges().Select(item => item.GetFace());
		}*/
	}
}
