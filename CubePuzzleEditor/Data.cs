using CubePuzzleEditor.ViewModels;
using CubePuzzleLib.Models;
using CubePuzzleLib.Tables;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CubePuzzleEditor
{
	public static class Data
	{
		public static PuzzleViewModel DefaultPuzzle;
		public  static CubeViewModel DefaultCube
		{
			get => DefaultPuzzle.CubeViewModelCollection.First();
		}
		public static FaceViewModel DefaultFace
		{
			get => DefaultCube.Faces.First();
		}

		static Data()
		{
			DefaultPuzzle = CreatePuzzleViewModel();
		}

		public static PuzzleViewModel CreatePuzzleViewModel()
		{
			Puzzle puzzle;
			PuzzleModel puzzleModel;
			CubeViewModel cube;
			PuzzleViewModel puzzleViewModel;

			puzzle = CubePuzzleLib.Utils.CreatePuzzle();
			puzzleModel = new CubePuzzleLib.Models.PuzzleModel(puzzle);
			puzzleViewModel = new PuzzleViewModel(puzzleModel);

			cube = puzzleViewModel.CubeViewModelCollection.First();
			cube.Faces[0].Row = 0;
			cube.Faces[0].Column= 1;

			cube.Faces[1].Row = 1;
			cube.Faces[1].Column = 1;

			cube.Faces[2].Row = 2;
			cube.Faces[2].Column = 1;

			cube.Faces[3].Row = 3;
			cube.Faces[3].Column = 1;

			cube.Faces[4].Row = 1;
			cube.Faces[4].Column = 0;

			cube.Faces[5].Row = 1;
			cube.Faces[5].Column = 2;


			return puzzleViewModel;
		}
		
			



	}
}
