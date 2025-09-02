using CubePuzzleLib.Tables;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CubePuzzleLib
{
	public static class Utils
	{
		public static Puzzle CreatePuzzle()
		{
			Puzzle puzzle;
			Cube cube;
			Face face;
			Edge edge;
			FaceEdge faceEdge;

			puzzle = new Puzzle();

			cube = new Cube() { CubeID = 1, Name = "Cube" };
			puzzle.CubeTable.Add(cube);

			for (byte t = 1; t <= 6; t++)
			{
				face = new Face() { FaceID = t, Name = $"Face{t}", CubeID = 1 };
				puzzle.FaceTable.Add(face);
			}
			for (byte t = 1; t <= 12; t++)
			{
				edge = new Edge() { EdgeID = t, Name = $"Edge{t}", CubeID = 1 };
				puzzle.EdgeTable.Add(edge);
			}

			faceEdge = new FaceEdge() { FaceEdgeID = 1, FaceID = 1, EdgeID = 1 };
			faceEdge = new FaceEdge() { FaceEdgeID = 2, FaceID = 4, EdgeID = 1 };

			faceEdge = new FaceEdge() { FaceEdgeID = 1, FaceID = 1, EdgeID = 2 };
			faceEdge = new FaceEdge() { FaceEdgeID = 1, FaceID = 6, EdgeID = 2 };

			faceEdge = new FaceEdge() { FaceEdgeID = 1, FaceID = 1, EdgeID = 3 };
			faceEdge = new FaceEdge() { FaceEdgeID = 1, FaceID = 2, EdgeID = 3 };

			faceEdge = new FaceEdge() { FaceEdgeID = 1, FaceID = 1, EdgeID = 4 };
			faceEdge = new FaceEdge() { FaceEdgeID = 1, FaceID = 5, EdgeID = 4 };

			faceEdge = new FaceEdge() { FaceEdgeID = 1, FaceID = 2, EdgeID = 5 };
			faceEdge = new FaceEdge() { FaceEdgeID = 1, FaceID = 6, EdgeID = 5 };

			faceEdge = new FaceEdge() { FaceEdgeID = 1, FaceID = 2, EdgeID = 6 };
			faceEdge = new FaceEdge() { FaceEdgeID = 1, FaceID = 3, EdgeID = 6 };

			faceEdge = new FaceEdge() { FaceEdgeID = 1, FaceID = 2, EdgeID = 7 };
			faceEdge = new FaceEdge() { FaceEdgeID = 1, FaceID = 5, EdgeID = 7 };

			faceEdge = new FaceEdge() { FaceEdgeID = 1, FaceID = 3, EdgeID = 8 };
			faceEdge = new FaceEdge() { FaceEdgeID = 1, FaceID = 6, EdgeID = 8 };

			faceEdge = new FaceEdge() { FaceEdgeID = 1, FaceID = 3, EdgeID = 9 };
			faceEdge = new FaceEdge() { FaceEdgeID = 1, FaceID = 4, EdgeID = 9 };

			faceEdge = new FaceEdge() { FaceEdgeID = 1, FaceID = 3, EdgeID = 10 };
			faceEdge = new FaceEdge() { FaceEdgeID = 1, FaceID = 5, EdgeID = 10 };

			faceEdge = new FaceEdge() { FaceEdgeID = 1, FaceID = 4, EdgeID = 11 };
			faceEdge = new FaceEdge() { FaceEdgeID = 1, FaceID = 6, EdgeID = 11 };

			faceEdge = new FaceEdge() { FaceEdgeID = 1, FaceID = 4, EdgeID = 12 };
			faceEdge = new FaceEdge() { FaceEdgeID = 1, FaceID = 5, EdgeID = 12 };


			return puzzle;
		}


	}
}
