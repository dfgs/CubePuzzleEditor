using BlueprintLib.Attributes;
using DataViewModelLib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace CubePuzzleEditor.ViewModels
{
	[TableViewModel, DTO("Face"),   Blueprint("TableViewModel"), Blueprint("TableViewModelCollection"), Using("CubePuzzleLib.Models"), Using("CubePuzzleLib.Tables")]
	public partial class FaceViewModel:DependencyObject	
	{
		public static readonly DependencyProperty RowProperty = DependencyProperty.Register("Row", typeof(int), typeof(FaceViewModel), new PropertyMetadata(0));
		public int Row
		{
			get { return (int)GetValue(RowProperty); }
			set { SetValue(RowProperty, value); }
		}

		public static readonly DependencyProperty ColumnProperty = DependencyProperty.Register("Column", typeof(int), typeof(FaceViewModel), new PropertyMetadata(0));
		public int Column
		{
			get { return (int)GetValue(ColumnProperty); }
			set { SetValue(ColumnProperty, value); }
		}

		public IEnumerable<EdgeViewModel> Edges()
		{
			return this.F_FaceEdges.Select(item => item.Edge);
		}
	}
}
