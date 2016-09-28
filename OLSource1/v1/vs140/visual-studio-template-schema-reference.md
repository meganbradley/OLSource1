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
author: ""
ms.author: "gregvanl"
manager: ""
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Visual Studio Template Schema Reference
This section contains information about XML elements in .vstemplate files, which are files that store metadata for project templates, item templates, and Starter Kits.  
  
 You can use vstemplate.xsd to validate custom .vstemplate files. This file is available at ..\\*Visual Studio installation folder*\Xml\Schemas\1033\vstemplate.xsd.  
  
|Element|Child Elements|Attributes|  
|-------------|--------------------|----------------|  
|[AppliesTo](../vs140/appliesto-element--visual-studio-templates-.md)|None|None|  
|[Assembly (Template)](../vs140/assembly-element--visual-studio-templates-.md)|--|--|  
|[Assembly (Wizard Extension)](../vs140/assembly-element--visual-studio-template-wizard-extension-.md)|--|--|  
|[BuildProjectOnload](../vs140/buildprojectonload-element--visual-studio-templates-.md)|--|--|  
|[CreateInPlace](../vs140/createinplace--visual-studio-templates-.md)|--|--|  
|[CreateNewFolder](../vs140/createnewfolder-element--visual-studio-templates-.md)|--|--|  
|[CustomDataSignature](../vs140/customdatasignature-element--visual-studio-templates-.md)|--|--|  
|[CustomParameter](../vs140/customparameter-element--visual-studio-templates-.md)|--|Name<br /><br /> Value|  
|[CustomParameters](../vs140/customparameters-element--visual-studio-templates-.md)|CustomParameter|--|  
|[DefaultName](../vs140/defaultname-element--visual-studio-templates-.md)|--|--|  
|[Description](../vs140/description-element--visual-studio-templates-.md)|--|Package<br /><br /> ID|  
|[EnableEditOfLocationField](../vs140/enableeditoflocationfield-element--visual-studio-templates-.md)|--|--|  
|[EnableLocationBrowseButton](../vs140/enablelocationbrowsebutton-element--visual-studio-templates-.md)|--|--|  
|[Folder](../vs140/folder-element--visual-studio-project-templates-.md)|ProjectItem<br /><br /> Folder|Name|  
||[deprecated]|--|  
|[FullClassName](../vs140/fullclassname-element--visual-studio-template-wizard-extension-.md)|--|--|  
|[Hidden](../vs140/hidden-element--visual-studio-templates-.md)|--|--|  
|[Icon](../vs140/icon-element--visual-studio-templates-.md)|--|Package<br /><br /> ID|  
|[LocationField](../vs140/locationfield-element--visual-studio-project-templates-.md)|--|--|  
|[LocationFieldMRUPrefix](../vs140/locationfieldmruprefix-element--visual-studio-templates-.md)|--|--|  
|[MaxFrameworkVersion](../vs140/maxframeworkversion-element--visual-studio-templates-.md)|--|--|  
|[Name](../vs140/name-element--visual-studio-templates-.md)|--|Package<br /><br /> ID|  
|[NumberOfParentCategoriesToRollUp](../vs140/numberofparentcategoriestorollup--visual-studio-templates-.md)|--|--|  
|[PreviewImage](../vs140/previewimage-element--visual-studio-templates-.md)|--|--|  
|[Project](../vs140/project-element--visual-studio-templates-.md)|Folder<br /><br /> ProjectItem|File<br /><br /> TargetFileName<br /><br /> ReplaceParameters|  
|[ProjectCollection](../vs140/projectcollection-element--visual-studio-templates-.md)|ProjectTemplateLink<br /><br /> SolutionFolder|--|  
|[ProjectItem (Item Templates)](../vs140/projectitem-element--visual-studio-item-templates-.md)|--|SubType<br /><br /> CustomTool<br /><br /> ItemType<br /><br /> ReplaceParameters<br /><br /> TargetFileName|  
|[ProjectItem (Project Templates)](../vs140/projectitem-element--visual-studio-project-templates-.md)|--|TargetFileName<br /><br /> ReplaceParameters<br /><br /> OpenInEditor<br /><br /> OpenOrder<br /><br /> OpenInWebBrowser<br /><br /> OpenInHelpBrowser|  
|[ProjectSubType](../vs140/projectsubtype-element--visual-studio-templates-.md)|--|--|  
|[ProjectTemplateLink](../vs140/projecttemplatelink-element--visual-studio-templates-.md)|--|ProjectName|  
|[ProjectType](../vs140/projecttype-element--visual-studio-templates-.md)|--|--|  
|[PromptForSaveOnCreation](../vs140/promptforsaveoncreation-element--visual-studio-templates-.md)|--|--|  
|[ProvideDefaultName](../vs140/providedefaultname-element--visual-studio-templates-.md)|--|--|  
|[Reference](../vs140/reference-element--visual-studio-templates-.md)|Assembly|--|  
|[References](../vs140/references-element--visual-studio-templates-.md)|Reference|--|  
|[RequiredFrameworkVersion](../vs140/requiredframeworkversion-element--visual-studio-templates-.md)|--|--|  
|[RequiredPlatformVersion](../vs140/requiredplatformversion-element--visual-studio-templates-.md)|--|Version|  
|[SDKReference](72c8b352-0b7a-42b3-ba5d-2a2d1e90c3)|--|Package|  
|[ShowByDefault](../vs140/showbydefault--visual-studio-templates-.md)|--|--|  
|[SolutionFolder](../vs140/solutionfolder-element--visual-studio-templates-.md)|ProjectTemplateLink<br /><br /> SolutionFolder|Name|  
|[SortOrder](../vs140/sortorder-element--visual-studio-templates-.md)|--|--|  
|[SupportsCodeSeparation](../vs140/supportscodeseparation-element--visual-studio-templates-.md)|--|--|  
|[SupportsLanguageDropDown](../vs140/supportslanguagedropdown-element--visual-studio-templates-.md)|--|--|  
|[SupportsMasterPage](../vs140/supportsmasterpage-element--visual-studio-templates-.md)|--|--|  
|[TargetPlatformName](../vs140/targetplatformname-element--visual-studio-templates-.md)|RequiredPlatformVersion|--|  
|[TemplateContent](../vs140/templatecontent-element--visual-studio-templates-.md)|ProjectCollection<br /><br /> Project<br /><br /> References<br /><br /> ProjectItem<br /><br /> CustomParameters|[BuildOnLoad](../vs140/buildprojectonload--visual-studio-templates-.md)|  
|[TemplateData](../vs140/templatedata-element--visual-studio-templates-.md)|Name<br /><br /> Description<br /><br /> Icon<br /><br /> PreviewImage<br /><br /> ProjectType<br /><br /> ProjectSubType<br /><br /> TemplateID<br /><br /> TemplateGroupID<br /><br /> SortOrder<br /><br /> CreateNewFolder<br /><br /> DefaultName<br /><br /> ProvideDefaultName<br /><br /> PromptForSaveOnCreation<br /><br /> EnableLocationBrowseButton<br /><br /> EnableEditOfLocationField<br /><br /> Hidden<br /><br /> DisplayInParentCategories<br /><br /> LocationFieldMRUPrefix<br /><br /> NumberOfParentCategoriesToRollUp<br /><br /> CreateInPlace<br /><br /> BuildOnLoad<br /><br /> BuildProjectOnload<br /><br /> ShowByDefault<br /><br /> LocationField<br /><br /> SupportsMasterPage<br /><br /> SupportsCodeSeparation<br /><br /> SupportsLanguageDropDown<br /><br /> RequiredFrameworkVersion<br /><br /> FrameworkVersion<br /><br /> MaxFrameworkVersion<br /><br /> CustomDataSignature<br /><br /> TargetPlatformName|--|  
|[TemplateGroupID](../vs140/templategroupid-element--visual-studio-templates-.md)|--|--|  
|[TemplateID](../vs140/templateid-element--visual-studio-templates-.md)|--|--|  
|[VSTemplate](../vs140/vstemplate-element--visual-studio-templates-.md)|TemplateData<br /><br /> TemplateContent<br /><br /> WizardExtension<br /><br /> WizardData|Type<br /><br /> Version|  
|[WizardData](../vs140/wizarddata-element--visual-studio-templates-.md)|--|Name|  
|[WizardExtension](../vs140/wizardextension-element--visual-studio-templates-.md)|Assembly<br /><br /> FullClassName|--|  
  
## See Also  
 [Introduction to Visual Studio Templates](../vs140/creating-project-and-item-templates.md)   
 [How to: Create Starter Kits](../vs140/how-to--create-starter-kits.md)