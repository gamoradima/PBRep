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
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,141,82,81,107,219,48,16,126,47,244,63,28,102,15,54,4,209,190,174,91,161,201,178,81,40,219,168,157,189,140,61,40,242,197,213,144,37,163,147,211,101,99,255,125,39,203,89,82,167,133,30,6,75,167,239,190,251,190,227,172,108,145,58,169,16,42,244,94,146,219,4,177,112,118,163,155,222,203,160,157,61,63,251,115,126,6,28,61,105,219,64,185,163,128,237,213,113,234,184,176,109,157,125,241,209,163,88,218,160,131,70,122,13,70,44,183,104,195,30,250,125,72,239,134,220,157,102,17,22,125,94,170,7,108,229,103,246,0,239,33,91,145,191,71,105,194,46,43,126,164,162,174,95,27,173,64,25,73,4,233,237,25,26,120,11,115,73,248,204,75,98,25,7,112,68,232,182,44,89,215,8,91,167,107,248,98,75,185,101,35,185,91,255,68,21,128,208,214,232,103,144,8,231,184,97,87,3,237,141,111,8,176,56,208,29,49,199,88,179,10,241,159,109,79,131,197,213,83,88,226,5,63,248,97,227,121,74,20,169,96,2,174,81,233,86,26,232,188,86,113,74,169,74,124,194,80,237,58,172,23,206,244,173,253,38,77,143,239,70,232,117,30,39,249,53,226,87,229,135,108,218,93,111,32,79,100,215,112,121,177,143,226,41,104,98,44,6,138,91,90,72,171,208,96,205,58,130,239,145,153,79,113,20,124,92,10,94,75,146,13,86,216,118,70,134,168,220,226,35,220,57,37,141,254,45,215,6,203,1,151,143,126,86,132,158,247,214,242,252,121,105,197,61,146,235,189,98,144,243,204,50,59,109,19,227,176,49,105,213,178,25,100,39,29,72,12,211,185,165,202,185,185,110,210,45,43,68,229,70,5,197,43,108,176,252,148,16,31,157,111,101,200,39,246,184,241,165,184,152,191,57,153,118,140,240,224,221,227,96,127,249,75,97,23,13,238,235,167,240,191,135,235,120,228,31,127,255,0,72,255,215,47,231,3,0,0 };
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

