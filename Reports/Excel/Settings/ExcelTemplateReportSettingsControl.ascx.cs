using System.Xml.Serialization;
using DNNStuff.SQLViewPro.Controls;

namespace DNNStuff.SQLViewPro.ExcelReports
{
	
	public partial class ExcelTemplateReportSettingsControl : ReportSettingsControlBase
	{
		
#region  Web Form Designer Generated Code
		
		//This call is required by the Web Form Designer.
		[System.Diagnostics.DebuggerStepThrough()]private void InitializeComponent()
		{
			
		}
		
		private void Page_Init(System.Object sender, System.EventArgs e)
		{
			//CODEGEN: This method call is required by the Web Form Designer
			//Do not modify it using the code editor.
			InitializeComponent();
		}
		
#endregion
		
	
#region  Base Method Implementations
		protected override string LocalResourceFile => ResolveUrl("App_LocalResources/ExcelTemplateReportSettingsControl");

	    public override string UpdateSettings()
		{
			
			var obj = new ExcelTemplateReportSettings();
			obj.DataSheetName = txtDataSheetName.Text;
			obj.ContainsHeaderRow = chkContainsHeaderRow.Checked;
			obj.XlsFileName = (string) ctlXlsFileName.Url;
			obj.XlsxFileName = (string) ctlXlsxFileName.Url;
			obj.OutputFileName = txtOutputFileName.Text;
			obj.DispositionType = ddDispositionType.SelectedValue;
			
			return Serialization.SerializeObject(obj, typeof(ExcelTemplateReportSettings));
			
		}
		
		public override void LoadSettings(string settings)
		{
			var obj = new ExcelTemplateReportSettings();
			if (!string.IsNullOrEmpty(settings))
			{
				obj = (ExcelTemplateReportSettings) (Serialization.DeserializeObject(settings, typeof(ExcelTemplateReportSettings)));
			}
			txtDataSheetName.Text = obj.DataSheetName;
			chkContainsHeaderRow.Checked = obj.ContainsHeaderRow;
			ctlXlsFileName.Url = obj.XlsFileName;
			ctlXlsxFileName.Url = obj.XlsxFileName;
			txtOutputFileName.Text = obj.OutputFileName;
			
			ControlHelpers.InitDropDownByValue(ddDispositionType, obj.DispositionType);
		}
		
#endregion
		
	}
	
#region  Settings
	[XmlRootAttribute(ElementName = "Settings", IsNullable = false)]public class ExcelTemplateReportSettings
	{
		public string DataSheetName {get; set;}
		public string OutputFileName {get; set;}
		public string XlsFileName {get; set;}
		public string XlsxFileName {get; set;}
		public bool ContainsHeaderRow {get; set;}
	    public string DispositionType { get; set; } = "attachment";
	}
#endregion
	
}

