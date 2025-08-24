using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BlueprintLib.Attributes;
using DataModelLib;

namespace CubePuzzleLib.Models
{
	[DTO("Face"),   Blueprint("TableModel")]
	public partial class FaceModel
	{
		public IEnumerable<EdgeModel> GetEdges()
		{
			return this.GetFaceEdges().Select(item => item.GetEdge());
		}
	}
}
