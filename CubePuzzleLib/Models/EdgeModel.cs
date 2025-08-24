using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BlueprintLib.Attributes;
using DataModelLib;

namespace CubePuzzleLib.Models
{
	[DTO("Edge"),  Blueprint("TableModel")]
	public partial class EdgeModel
	{
		public IEnumerable<FaceModel> GetFaces()
		{
			return this.GetFaceEdges().Select(item => item.GetFace());
		}
	}
}
