using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BlueprintLib.Attributes;
using DataModelLib;

namespace CubePuzzleLib.Models
{
	[TableModel, DTO("Face"),   Blueprint("TableModel")]
	public partial class FaceModel
	{
		public IEnumerable<EdgeModel> GetEdges()
		{
			return this.GetF_FaceEdges().Select(item => item.GetEdge());
		}
	}
}
