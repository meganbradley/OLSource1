---
title: "ProjectItem Element"
ms.custom: na
ms.date: "08/09/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.tgt_pltfrm: na
ms.topic: "article"
dev_langs: 
  - "VB"
  - "CSharp"
helpviewer_keywords: 
  - "ProjectItem element"
ms.assetid: df588235-12a1-4798-bc56-ef81843de17f
caps.latest.revision: 15
ms.author: "kempb"
manager: "douge"
translation.priority.ht: 
  - "cs-cz"
  - "de-de"
  - "es-es"
  - "fr-fr"
  - "it-it"
  - "ja-jp"
  - "ko-kr"
  - "pl-pl"
  - "pt-br"
  - "ru-ru"
  - "tr-tr"
  - "zh-cn"
  - "zh-tw"
---
# ProjectItem Element
  Represents a SharePoint project item. This is the required root element of the .spdata file.  
  
## Syntax  
  
```  
<ProjectItem DefaultFile = "File that opens in the editor when you open the project item"  
    FeatureReceiverClass = "Class that implements a feature receiver for the project item"  
    FeatureReceiverAssembly = "Assembly that defines a feature receiver for the project item"  
    SupportedTrustLevels = "Trust levels that the project item supports"  
    SupportedDeploymentScopes = "Deployment scopes that the project item supports"  
    Type="Identifier for the project item">  
  <Files>...</Files>  
  <ProjectItemFolder>...</ProjectItemFolder>  
  <SafeControls>...</SafeControls>  
  <FeatureProperties>...</FeatureProperties>  
  <ExtensionData>...</ExtensionData>  
</ProjectItem>  
```  
  
## Attributes and Elements  
 The following sections describe attributes, child elements, and parent elements.  
  
### Attributes  
  
|Attribute|Description|  
|---------------|-----------------|  
|**DefaultFile**|Optional **xs:string** attribute.<br /><br /> The relative path, including the file name, of the file that opens in the Visual Studio editor when you open the SharePoint project item in **Solution Explorer**. The path is relative from the folder that contains the .spdata file.|  
|**FeatureReceiverClass**|Optional **xs:string** attribute.<br /><br /> The fully qualified name of a feature receiver class for this SharePoint project item. For more information about feature receivers, see [Providing Packaging and Deployment Information in Project Items](../VS_officedev/providing-packaging-and-deployment-information-in-project-items.md).|  
|**FeatureReceiverAssembly**|Optional **xs:string** attribute.<br /><br /> Specifies the fully qualified name of an assembly that defines a feature receiver for this SharePoint project item. For more information about feature receivers, see [Providing Packaging and Deployment Information in Project Items](../VS_officedev/providing-packaging-and-deployment-information-in-project-items.md). For more information about fully qualified assembly names, see [Assembly Names](../Topic/Assembly%20Names.md).|  
|**SupportedTrustLevels**|Optional **xs:string** attribute.<br /><br /> Specifies the trust levels that this SharePoint project item supports. This value can be one of the following strings: Sandboxed, FullTrust, or All. The value All specifies both Sandboxed and FullTrust.<br /><br /> In a custom SharePoint project item type, the value of this attribute corresponds to the value that you assign to the \<xref:Microsoft.VisualStudio.SharePoint.ISharePointProjectItemTypeDefinition.SupportedTrustLevels*> property in your implementation of the \<xref:Microsoft.VisualStudio.SharePoint.ISharePointProjectItemTypeProvider.InitializeType*> method. If you specify a different value for this attribute, Visual Studio overwrites the value so that it specifies the same trust level that you specify in the \<xref:Microsoft.VisualStudio.SharePoint.ISharePointProjectItemTypeDefinition.SupportedTrustLevels*> property.|  
|**SupportedDeploymentScopes**|Optional **xs:string** attribute.<br /><br /> Specifies the deployment scopes that this SharePoint project item supports. This value is a comma-delimited string that consists of one or more of the following strings: Farm, Site, Web, WebApplication, or Package. For example, "Web, Site".<br /><br /> In a custom SharePoint project item type, the value of this attribute corresponds to the value that you assign to the \<xref:Microsoft.VisualStudio.SharePoint.ISharePointProjectItemTypeDefinition.SupportedDeploymentScopes*> property in your implementation of the \<xref:Microsoft.VisualStudio.SharePoint.ISharePointProjectItemTypeProvider.InitializeType*> method. If you specify a different value for this attribute, Visual Studio overwrites the value so that it specifies the same trust level that you specify in the \<xref:Microsoft.VisualStudio.SharePoint.ISharePointProjectItemTypeDefinition.SupportedDeploymentScopes*> property.|  
|**Type**|Required **xs:string** attribute.<br /><br /> The identifier for the SharePoint project item. In a custom SharePoint project item type, the identifier is the string that you pass to the \<xref:Microsoft.VisualStudio.SharePoint.SharePointProjectItemTypeAttribute>. For more information, see [How to: Define a SharePoint Project Item Type](../VS_officedev/how-to--define-a-sharepoint-project-item-type.md).<br /><br /> For a list of the identifiers for the built-in SharePoint project items included with Visual Studio, see [Extending SharePoint Project Items](../VS_officedev/extending-sharepoint-project-items.md).|  
  
### Child Elements  
  
|Element|Description|  
|-------------|-----------------|  
|[ExtensionData](../VS_officedev/extensiondata-element.md)|Optional element.<br /><br /> Represents a collection of custom data items that are associated with the SharePoint project item.<br /><br /> You can include only one **ExtensionData** element.|  
|[FeatureProperties](../VS_officedev/featureproperties-element.md)|Optional element.<br /><br /> Represents a collection of property values that are included with a Feature when it is deployed to SharePoint.<br /><br /> You can include only one **FeatureProperties** element.|  
|[Files](../VS_officedev/files-element.md)|Optional **FileCollectionType** element.<br /><br /> Specifies the files to deploy with the SharePoint project item, such as Feature element files and the output of dependent non-SharePoint projects.<br /><br /> You must include either a **Files** or a **ProjectItemFolder** element, but not both.|  
|[ProjectItemFolder](../VS_officedev/projectitemfolder-element.md)|Optional **ProjectItemFolderType** element.<br /><br /> Represents a mapped folder.<br /><br /> You must include either a **Files** or a **ProjectItemFolder** element, but not both.|  
|[SafeControls](../VS_officedev/safecontrols-element.md)|Optional element.<br /><br /> Represents a collection of ASPX controls and Web Parts that are designated as secure for any user to access on any ASPX page on the SharePoint site.<br /><br /> You can include only one **SafeControls** element.|  
  
### Parent Elements  
 None.  
  
## Element Information  
  
|||  
|-|-|  
|**Namespace**|http://schemas.microsoft.com/VisualStudio/2010/SharePointTools/SharePointProjectItemModel|  
|**Schema name**|SharePoint Project Item Schema|  
|**Validation file**|ProjectItemModelSchema.xsd|  
|**Can be empty**|No|  
  
## See Also  
 [SharePoint Project Item Schema Reference](../VS_officedev/sharepoint-project-item-schema-reference.md)  
  
  