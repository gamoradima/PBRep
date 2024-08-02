namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: UsrRealtyEventsSchema

	/// <exclude/>
	public class UsrRealtyEventsSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public UsrRealtyEventsSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public UsrRealtyEventsSchema(UsrRealtyEventsSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("6cdd55d3-974e-4fcc-8d0f-629b649b8f25");
			Name = "UsrRealtyEvents";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("4d685f88-18b1-4c3b-9dc3-ad97bb4bd9d1");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,141,82,81,107,219,48,16,126,47,244,63,28,102,15,54,4,209,190,174,91,97,14,105,41,148,173,52,110,95,198,30,20,249,226,106,200,146,209,201,233,178,177,255,190,147,229,44,169,211,66,15,131,165,211,119,223,125,223,113,86,182,72,157,84,8,21,122,47,201,173,131,152,59,187,214,77,239,101,208,206,158,158,252,57,61,1,142,158,180,109,96,185,165,128,237,197,97,234,176,176,109,157,125,243,209,163,88,216,160,131,70,122,15,70,44,54,104,195,14,250,125,72,111,135,220,173,102,17,22,125,190,84,79,216,202,175,236,1,62,67,246,64,254,30,165,9,219,172,248,145,138,186,126,101,180,2,101,36,17,164,183,87,104,224,35,148,146,240,149,151,196,50,14,224,128,208,109,88,178,174,17,54,78,215,240,205,46,229,134,141,228,110,245,19,85,0,66,91,163,159,65,34,44,113,205,174,6,218,47,190,33,192,98,79,119,192,28,99,197,42,196,127,182,29,13,22,23,47,97,137,23,252,224,135,141,231,41,81,164,130,9,184,70,165,91,105,160,243,90,197,41,165,42,113,141,161,218,118,88,207,157,233,91,251,40,77,143,159,70,232,101,30,39,121,23,241,215,229,93,54,237,174,215,144,39,178,75,56,63,219,69,241,18,52,49,22,3,197,13,205,165,85,104,176,102,29,193,247,200,204,199,56,10,62,46,5,175,37,201,6,43,108,59,35,67,84,110,241,25,110,157,146,70,255,150,43,131,203,1,151,143,126,30,8,61,239,173,229,249,243,210,138,123,36,215,123,197,32,231,153,101,118,220,38,198,126,99,210,170,101,51,200,142,58,144,24,166,115,67,149,115,165,110,210,45,43,68,229,70,5,197,59,108,176,252,148,16,87,206,183,50,228,19,123,220,248,92,156,149,31,142,166,29,35,60,121,247,60,216,95,252,82,216,69,131,187,250,41,252,239,254,58,30,249,199,223,63,181,157,178,62,231,3,0,0 };
		}

		protected override void InitializeLocalizableStrings() {
			base.InitializeLocalizableStrings();
			SetLocalizableStringsDefInheritance();
			LocalizableStrings.Add(CreateValueIsTooBigLocalizableString());
		}

		protected virtual SchemaLocalizableString CreateValueIsTooBigLocalizableString() {
			SchemaLocalizableString localizableString = new SchemaLocalizableString() {
				UId = new Guid("2918d830-ac18-3c7b-463e-b5afcaa6752e"),
				Name = "ValueIsTooBig",
				CreatedInPackageId = new Guid("4d685f88-18b1-4c3b-9dc3-ad97bb4bd9d1"),
				CreatedInSchemaUId = new Guid("6cdd55d3-974e-4fcc-8d0f-629b649b8f25"),
				ModifiedInSchemaUId = new Guid("6cdd55d3-974e-4fcc-8d0f-629b649b8f25")
			};
			return localizableString;
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("6cdd55d3-974e-4fcc-8d0f-629b649b8f25"));
		}

		#endregion

	}

	#endregion

}

