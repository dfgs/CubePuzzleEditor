using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BlueprintLib.Attributes;
using DataModelLib;

namespace CubePuzzleLib.Models
{
	[TableModel, DTO("Edge"),  Blueprint("TableModel")]
	public partial class EdgeModel
	{
		public IEnumerable<FaceModel> GetFaces()
		{
			return this.GetE_FaceEdges().Select(item => item.GetFace());
		}
	}
}
