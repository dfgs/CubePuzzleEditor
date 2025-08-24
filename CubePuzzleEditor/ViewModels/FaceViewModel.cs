using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BlueprintLib.Attributes;
using DataModelLib;

namespace CubePuzzleEditor.ViewModels
{
	[DTO("Face"),   Blueprint("TableViewModel")]
	public partial class FaceViewModel
	{
		/*public IEnumerable<EdgeModel> GetEdges()
		{
			return this.GetFaceEdges().Select(item => item.GetEdge());
		}*/
	}
}
