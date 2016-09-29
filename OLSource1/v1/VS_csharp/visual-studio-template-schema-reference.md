---
title: "Visual Studio Template Schema Reference"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "vs-ide-general"
ms.tgt_pltfrm: na
ms.topic: "article"
helpviewer_keywords: 
  - "VSTEMPLATE files"
  - "Visual Studio templates, schema"
  - ".vstemplate files"
ms.assetid: 6f74a2d5-3811-43d6-8b10-eb5823ad8995
caps.latest.revision: 29
ms.author: "gregvanl"
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Visual Studio Template Schema Reference
This section contains information about XML elements in .vstemplate files, which are files that store metadata for project templates, item templates, and Starter Kits.  
  
 You can use vstemplate.xsd to validate custom .vstemplate files. This file is available at ..\\*Visual Studio installation folder*\Xml\Schemas\1033\vstemplate.xsd.  
  
|Element|Child Elements|Attributes|  
|-------------|--------------------|----------------|  
|[AppliesTo](../VS_csharp/appliesto-element--visual-studio-templates-.md)|None|None|  
|[Assembly (Template)](../VS_csharp/assembly-element--visual-studio-templates-.md)|--|--|  
|[Assembly (Wizard Extension)](../VS_csharp/assembly-element--visual-studio-template-wizard-extension-.md)|--|--|  
|[BuildProjectOnload](../VS_csharp/buildprojectonload-element--visual-studio-templates-.md)|--|--|  
|[CreateInPlace](../VS_csharp/createinplace--visual-studio-templates-.md)|--|--|  
|[CreateNewFolder](../VS_csharp/createnewfolder-element--visual-studio-templates-.md)|--|--|  
|[CustomDataSignature](../VS_csharp/customdatasignature-element--visual-studio-templates-.md)|--|--|  
|[CustomParameter](../VS_csharp/customparameter-element--visual-studio-templates-.md)|--|Name<br /><br /> Value|  
|[CustomParameters](../VS_csharp/customparameters-element--visual-studio-templates-.md)|CustomParameter|--|  
|[DefaultName](../VS_csharp/defaultname-element--visual-studio-templates-.md)|--|--|  
|[Description](../VS_csharp/description-element--visual-studio-templates-.md)|--|Package<br /><br /> ID|  
|[EnableEditOfLocationField](../VS_csharp/enableeditoflocationfield-element--visual-studio-templates-.md)|--|--|  
|[EnableLocationBrowseButton](../VS_csharp/enablelocationbrowsebutton-element--visual-studio-templates-.md)|--|--|  
|[Folder](../VS_csharp/folder-element--visual-studio-project-templates-.md)|ProjectItem<br /><br /> Folder|Name|  
||[deprecated]|--|  
|[FullClassName](../VS_csharp/fullclassname-element--visual-studio-template-wizard-extension-.md)|--|--|  
|[Hidden](../VS_csharp/hidden-element--visual-studio-templates-.md)|--|--|  
|[Icon](../VS_csharp/icon-element--visual-studio-templates-.md)|--|Package<br /><br /> ID|  
|[LocationField](../VS_csharp/locationfield-element--visual-studio-project-templates-.md)|--|--|  
|[LocationFieldMRUPrefix](../VS_csharp/locationfieldmruprefix-element--visual-studio-templates-.md)|--|--|  
|[MaxFrameworkVersion](../VS_csharp/maxframeworkversion-element--visual-studio-templates-.md)|--|--|  
|[Name](../VS_csharp/name-element--visual-studio-templates-.md)|--|Package<br /><br /> ID|  
|[NumberOfParentCategoriesToRollUp](../VS_csharp/numberofparentcategoriestorollup--visual-studio-templates-.md)|--|--|  
|[PreviewImage](../VS_csharp/previewimage-element--visual-studio-templates-.md)|--|--|  
|[Project](../VS_csharp/project-element--visual-studio-templates-.md)|Folder<br /><br /> ProjectItem|File<br /><br /> TargetFileName<br /><br /> ReplaceParameters|  
|[ProjectCollection](../VS_csharp/projectcollection-element--visual-studio-templates-.md)|ProjectTemplateLink<br /><br /> SolutionFolder|--|  
|[ProjectItem (Item Templates)](../VS_csharp/projectitem-element--visual-studio-item-templates-.md)|--|SubType<br /><br /> CustomTool<br /><br /> ItemType<br /><br /> ReplaceParameters<br /><br /> TargetFileName|  
|[ProjectItem (Project Templates)](../VS_csharp/projectitem-element--visual-studio-project-templates-.md)|--|TargetFileName<br /><br /> ReplaceParameters<br /><br /> OpenInEditor<br /><br /> OpenOrder<br /><br /> OpenInWebBrowser<br /><br /> OpenInHelpBrowser|  
|[ProjectSubType](../VS_csharp/projectsubtype-element--visual-studio-templates-.md)|--|--|  
|[ProjectTemplateLink](../VS_csharp/projecttemplatelink-element--visual-studio-templates-.md)|--|ProjectName|  
|[ProjectType](../VS_csharp/projecttype-element--visual-studio-templates-.md)|--|--|  
|[PromptForSaveOnCreation](../VS_csharp/promptforsaveoncreation-element--visual-studio-templates-.md)|--|--|  
|[ProvideDefaultName](../VS_csharp/providedefaultname-element--visual-studio-templates-.md)|--|--|  
|[Reference](../VS_csharp/reference-element--visual-studio-templates-.md)|Assembly|--|  
|[References](../VS_csharp/references-element--visual-studio-templates-.md)|Reference|--|  
|[RequiredFrameworkVersion](../VS_csharp/requiredframeworkversion-element--visual-studio-templates-.md)|--|--|  
|[RequiredPlatformVersion](../VS_csharp/requiredplatformversion-element--visual-studio-templates-.md)|--|Version|  
|[SDKReference](72c8b352-0b7a-42b3-ba5d-2a2d1e90c3)|--|Package|  
|[ShowByDefault](../VS_csharp/showbydefault--visual-studio-templates-.md)|--|--|  
|[SolutionFolder](../VS_csharp/solutionfolder-element--visual-studio-templates-.md)|ProjectTemplateLink<br /><br /> SolutionFolder|Name|  
|[SortOrder](../VS_csharp/sortorder-element--visual-studio-templates-.md)|--|--|  
|[SupportsCodeSeparation](../VS_csharp/supportscodeseparation-element--visual-studio-templates-.md)|--|--|  
|[SupportsLanguageDropDown](../VS_csharp/supportslanguagedropdown-element--visual-studio-templates-.md)|--|--|  
|[SupportsMasterPage](../VS_csharp/supportsmasterpage-element--visual-studio-templates-.md)|--|--|  
|[TargetPlatformName](../VS_csharp/targetplatformname-element--visual-studio-templates-.md)|RequiredPlatformVersion|--|  
|[TemplateContent](../VS_csharp/templatecontent-element--visual-studio-templates-.md)|ProjectCollection<br /><br /> Project<br /><br /> References<br /><br /> ProjectItem<br /><br /> CustomParameters|[BuildOnLoad](../VS_csharp/buildprojectonload--visual-studio-templates-.md)|  
|[TemplateData](../VS_csharp/templatedata-element--visual-studio-templates-.md)|Name<br /><br /> Description<br /><br /> Icon<br /><br /> PreviewImage<br /><br /> ProjectType<br /><br /> ProjectSubType<br /><br /> TemplateID<br /><br /> TemplateGroupID<br /><br /> SortOrder<br /><br /> CreateNewFolder<br /><br /> DefaultName<br /><br /> ProvideDefaultName<br /><br /> PromptForSaveOnCreation<br /><br /> EnableLocationBrowseButton<br /><br /> EnableEditOfLocationField<br /><br /> Hidden<br /><br /> DisplayInParentCategories<br /><br /> LocationFieldMRUPrefix<br /><br /> NumberOfParentCategoriesToRollUp<br /><br /> CreateInPlace<br /><br /> BuildOnLoad<br /><br /> BuildProjectOnload<br /><br /> ShowByDefault<br /><br /> LocationField<br /><br /> SupportsMasterPage<br /><br /> SupportsCodeSeparation<br /><br /> SupportsLanguageDropDown<br /><br /> RequiredFrameworkVersion<br /><br /> FrameworkVersion<br /><br /> MaxFrameworkVersion<br /><br /> CustomDataSignature<br /><br /> TargetPlatformName|--|  
|[TemplateGroupID](../VS_csharp/templategroupid-element--visual-studio-templates-.md)|--|--|  
|[TemplateID](../VS_csharp/templateid-element--visual-studio-templates-.md)|--|--|  
|[VSTemplate](../VS_csharp/vstemplate-element--visual-studio-templates-.md)|TemplateData<br /><br /> TemplateContent<br /><br /> WizardExtension<br /><br /> WizardData|Type<br /><br /> Version|  
|[WizardData](../VS_csharp/wizarddata-element--visual-studio-templates-.md)|--|Name|  
|[WizardExtension](../VS_csharp/wizardextension-element--visual-studio-templates-.md)|Assembly<br /><br /> FullClassName|--|  
  
## See Also  
 [Introduction to Visual Studio Templates](../VS_csharp/creating-project-and-item-templates.md)   
 [How to: Create Starter Kits](../VS_csharp/how-to--create-starter-kits.md)