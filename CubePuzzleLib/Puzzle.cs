using DataModelLib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BlueprintLib.Attributes;

namespace CubePuzzleLib
{
	[Database,DTO("Puzzle"), Blueprint("Database")]
	public partial class Puzzle
	{
	}
}
