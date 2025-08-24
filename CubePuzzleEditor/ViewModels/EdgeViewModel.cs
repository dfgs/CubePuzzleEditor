using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BlueprintLib.Attributes;
using DataModelLib;

namespace CubePuzzleEditor.ViewModels
{
	[DTO("Edge"),  Blueprint("TableViewModel")]
	public partial class EdgeViewModel
	{
		/*public IEnumerable<FaceModel> GetFaces()
		{
			return this.GetFaceEdges().Select(item => item.GetFace());
		}*/
	}
}
