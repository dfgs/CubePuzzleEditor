using DataModelLib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BlueprintLib.Attributes;
using DataLib;

namespace CubePuzzleLib.Tables
{
	[Database,DTO("Puzzle"), Blueprint("Database")]
	public partial class Puzzle
	{
	}
}
