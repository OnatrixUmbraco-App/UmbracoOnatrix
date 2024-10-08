//------------------------------------------------------------------------------
// <auto-generated>
//   This code was generated by a tool.
//
//    Umbraco.ModelsBuilder.Embedded v14.2.0+1b21caa
//
//   Changes to this file will be lost if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Linq.Expressions;
using Umbraco.Cms.Core.Models.PublishedContent;
using Umbraco.Cms.Core.PublishedCache;
using Umbraco.Cms.Infrastructure.ModelsBuilder;
using Umbraco.Cms.Core;
using Umbraco.Extensions;

namespace Umbraco.Cms.Web.Common.PublishedModels
{
	/// <summary>Risk Management</summary>
	[PublishedModel("riskManagement")]
	public partial class RiskManagement : PublishedContentModel
	{
		// helpers
#pragma warning disable 0109 // new is redundant
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "14.2.0+1b21caa")]
		public new const string ModelTypeAlias = "riskManagement";
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "14.2.0+1b21caa")]
		public new const PublishedItemType ModelItemType = PublishedItemType.Content;
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "14.2.0+1b21caa")]
		[return: global::System.Diagnostics.CodeAnalysis.MaybeNull]
		public new static IPublishedContentType GetModelContentType(IPublishedSnapshotAccessor publishedSnapshotAccessor)
			=> PublishedModelUtility.GetModelContentType(publishedSnapshotAccessor, ModelItemType, ModelTypeAlias);
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "14.2.0+1b21caa")]
		[return: global::System.Diagnostics.CodeAnalysis.MaybeNull]
		public static IPublishedPropertyType GetModelPropertyType<TValue>(IPublishedSnapshotAccessor publishedSnapshotAccessor, Expression<Func<RiskManagement, TValue>> selector)
			=> PublishedModelUtility.GetModelPropertyType(GetModelContentType(publishedSnapshotAccessor), selector);
#pragma warning restore 0109

		private IPublishedValueFallback _publishedValueFallback;

		// ctor
		public RiskManagement(IPublishedContent content, IPublishedValueFallback publishedValueFallback)
			: base(content, publishedValueFallback)
		{
			_publishedValueFallback = publishedValueFallback;
		}

		// properties

		///<summary>
		/// AboutUsCornerText
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "14.2.0+1b21caa")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("aboutUsCornerText")]
		public virtual global::Umbraco.Cms.Core.Strings.IHtmlEncodedString AboutUsCornerText => this.Value<global::Umbraco.Cms.Core.Strings.IHtmlEncodedString>(_publishedValueFallback, "aboutUsCornerText");

		///<summary>
		/// AboutUsCornerTitle
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "14.2.0+1b21caa")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("aboutUsCornerTitle")]
		public virtual string AboutUsCornerTitle => this.Value<string>(_publishedValueFallback, "aboutUsCornerTitle");

		///<summary>
		/// ContactInformationAddress
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "14.2.0+1b21caa")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("contactInformationAddress")]
		public virtual string ContactInformationAddress => this.Value<string>(_publishedValueFallback, "contactInformationAddress");

		///<summary>
		/// ContactInformationEmail
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "14.2.0+1b21caa")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("contactInformationEmail")]
		public virtual string ContactInformationEmail => this.Value<string>(_publishedValueFallback, "contactInformationEmail");

		///<summary>
		/// ContactInformationEmailAddress
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "14.2.0+1b21caa")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("contactInformationEmailAddress")]
		public virtual string ContactInformationEmailAddress => this.Value<string>(_publishedValueFallback, "contactInformationEmailAddress");

		///<summary>
		/// ContactInformationLocation
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "14.2.0+1b21caa")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("contactInformationLocation")]
		public virtual string ContactInformationLocation => this.Value<string>(_publishedValueFallback, "contactInformationLocation");

		///<summary>
		/// ContactInformationPhone
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "14.2.0+1b21caa")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("contactInformationPhone")]
		public virtual string ContactInformationPhone => this.Value<string>(_publishedValueFallback, "contactInformationPhone");

		///<summary>
		/// ContactInformationPhoneNumber
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "14.2.0+1b21caa")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("contactInformationPhoneNumber")]
		public virtual string ContactInformationPhoneNumber => this.Value<string>(_publishedValueFallback, "contactInformationPhoneNumber");

		///<summary>
		/// ContactInformationPicture
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "14.2.0+1b21caa")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("contactInformationPicture")]
		public virtual global::Umbraco.Cms.Core.Models.MediaWithCrops ContactInformationPicture => this.Value<global::Umbraco.Cms.Core.Models.MediaWithCrops>(_publishedValueFallback, "contactInformationPicture");

		///<summary>
		/// ContactInformationTitle
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "14.2.0+1b21caa")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("contactInformationTitle")]
		public virtual global::Umbraco.Cms.Core.Strings.IHtmlEncodedString ContactInformationTitle => this.Value<global::Umbraco.Cms.Core.Strings.IHtmlEncodedString>(_publishedValueFallback, "contactInformationTitle");

		///<summary>
		/// FooterPicture
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "14.2.0+1b21caa")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("footerPicture")]
		public virtual global::Umbraco.Cms.Core.Models.MediaWithCrops FooterPicture => this.Value<global::Umbraco.Cms.Core.Models.MediaWithCrops>(_publishedValueFallback, "footerPicture");

		///<summary>
		/// HeaderLogo
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "14.2.0+1b21caa")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("headerLogo")]
		public virtual global::Umbraco.Cms.Core.Models.MediaWithCrops HeaderLogo => this.Value<global::Umbraco.Cms.Core.Models.MediaWithCrops>(_publishedValueFallback, "headerLogo");

		///<summary>
		/// RiskManagementMainDownText
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "14.2.0+1b21caa")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("riskManagementMainDownText")]
		public virtual global::Umbraco.Cms.Core.Strings.IHtmlEncodedString RiskManagementMainDownText => this.Value<global::Umbraco.Cms.Core.Strings.IHtmlEncodedString>(_publishedValueFallback, "riskManagementMainDownText");

		///<summary>
		/// RiskManagementMainDownTitle
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "14.2.0+1b21caa")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("riskManagementMainDownTitle")]
		public virtual string RiskManagementMainDownTitle => this.Value<string>(_publishedValueFallback, "riskManagementMainDownTitle");

		///<summary>
		/// RiskManagementMainFormTitle
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "14.2.0+1b21caa")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("riskManagementMainFormTitle")]
		public virtual string RiskManagementMainFormTitle => this.Value<string>(_publishedValueFallback, "riskManagementMainFormTitle");

		///<summary>
		/// RiskManagementMainMiddlePicture
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "14.2.0+1b21caa")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("riskManagementMainMiddlePicture")]
		public virtual global::Umbraco.Cms.Core.Models.MediaWithCrops RiskManagementMainMiddlePicture => this.Value<global::Umbraco.Cms.Core.Models.MediaWithCrops>(_publishedValueFallback, "riskManagementMainMiddlePicture");

		///<summary>
		/// RiskManagementMainMiddleText
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "14.2.0+1b21caa")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("riskManagementMainMiddleText")]
		public virtual global::Umbraco.Cms.Core.Strings.IHtmlEncodedString RiskManagementMainMiddleText => this.Value<global::Umbraco.Cms.Core.Strings.IHtmlEncodedString>(_publishedValueFallback, "riskManagementMainMiddleText");

		///<summary>
		/// RiskManagementMainMiddleTitle
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "14.2.0+1b21caa")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("riskManagementMainMiddleTitle")]
		public virtual string RiskManagementMainMiddleTitle => this.Value<string>(_publishedValueFallback, "riskManagementMainMiddleTitle");

		///<summary>
		/// RiskManagementMainPicture
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "14.2.0+1b21caa")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("riskManagementMainPicture")]
		public virtual global::Umbraco.Cms.Core.Models.MediaWithCrops RiskManagementMainPicture => this.Value<global::Umbraco.Cms.Core.Models.MediaWithCrops>(_publishedValueFallback, "riskManagementMainPicture");

		///<summary>
		/// RiskManagementMainPictureRight
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "14.2.0+1b21caa")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("riskManagementMainPictureRight")]
		public virtual global::Umbraco.Cms.Core.Models.MediaWithCrops RiskManagementMainPictureRight => this.Value<global::Umbraco.Cms.Core.Models.MediaWithCrops>(_publishedValueFallback, "riskManagementMainPictureRight");

		///<summary>
		/// RiskManagementMainRightText
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "14.2.0+1b21caa")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("riskManagementMainRightText")]
		public virtual global::Umbraco.Cms.Core.Strings.IHtmlEncodedString RiskManagementMainRightText => this.Value<global::Umbraco.Cms.Core.Strings.IHtmlEncodedString>(_publishedValueFallback, "riskManagementMainRightText");

		///<summary>
		/// RiskManagementMainRightTitle
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "14.2.0+1b21caa")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("riskManagementMainRightTitle")]
		public virtual string RiskManagementMainRightTitle => this.Value<string>(_publishedValueFallback, "riskManagementMainRightTitle");

		///<summary>
		/// RiskManagementMainText
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "14.2.0+1b21caa")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("riskManagementMainText")]
		public virtual global::Umbraco.Cms.Core.Strings.IHtmlEncodedString RiskManagementMainText => this.Value<global::Umbraco.Cms.Core.Strings.IHtmlEncodedString>(_publishedValueFallback, "riskManagementMainText");

		///<summary>
		/// RiskManagementMainTitle
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "14.2.0+1b21caa")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("riskManagementMainTitle")]
		public virtual string RiskManagementMainTitle => this.Value<string>(_publishedValueFallback, "riskManagementMainTitle");

		///<summary>
		/// RiskManagementText
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "14.2.0+1b21caa")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("riskManagementText")]
		public virtual string RiskManagementText => this.Value<string>(_publishedValueFallback, "riskManagementText");

		///<summary>
		/// RiskManagementTitle
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "14.2.0+1b21caa")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("riskManagementTitle")]
		public virtual string RiskManagementTitle => this.Value<string>(_publishedValueFallback, "riskManagementTitle");
	}
}
