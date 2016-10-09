---
title: "Changes to the Design of Office Projects that Target the .NET Framework 4 or the .NET Framework 4.5"
ms.custom: na
ms.date: "10/01/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.tgt_pltfrm: na
ms.topic: "article"
dev_langs: 
  - "VB"
  - "CSharp"
helpviewer_keywords: 
  - "Office development in Visual Studio, what's new"
  - "what's new [Office development in Visual Studio]"
ms.assetid: 290f5cb4-e2ee-4ed8-987c-2f013405cee9
caps.latest.revision: 36
ms.author: "normesta"
manager: "ghogen"
translation.priority.ht: 
  - "de-de"
  - "es-es"
  - "fr-fr"
  - "it-it"
  - "ja-jp"
  - "ko-kr"
  - "ru-ru"
  - "zh-cn"
  - "zh-tw"
translation.priority.mt: 
  - "cs-cz"
  - "pl-pl"
  - "pt-br"
  - "tr-tr"
---
# Changes to the Design of Office Projects that Target the .NET Framework 4 or the .NET Framework 4.5
  Starting in [!INCLUDE[vs_dev10_long](../VS_officedev/includes/vs_dev10_long_md.md)], Visual Studio introduced some changes to the design of Office projects that target the [!INCLUDE[net_v40_short](../VS_officedev/includes/net_v40_short_md.md)] or later. If you are familiar with Office projects in previous versions of Visual Studio, you should be aware of these changes before you develop Office projects that target those versions of the .NET Framework 4.0 or later. By default, all projects that you create by using Visual Studio 2013 or later target the .NET Framework 4.0 or later.  
  
 The following sections describe these Office project design changes.  
  
## Understanding the Interface-Based Design of the Visual Studio 2010 Tools for Office Runtime  
 When you develop an Office project that targets the [!INCLUDE[net_v40_short](../VS_officedev/includes/net_v40_short_md.md)] or later, most of the types that you use in the Visual Studio 2010 Tools for Office Runtime are interfaces. This is a major change from previous versions of the [!INCLUDE[vsto_runtime](../VS_officedev/includes/vsto_runtime_md.md)], where these types are classes. For example, when you target the [!INCLUDE[net_v40_short](../VS_officedev/includes/net_v40_short_md.md)] or later, the \<xref:Microsoft.Office.Tools.Excel.Worksheet> and \<xref:Microsoft.Office.Tools.Word.Document> types are interfaces instead of classes. For more information, see [Visual Studio Tools for Office Runtime Overview](../VS_officedev/visual-studio-tools-for-office-runtime-overview.md).  
  
 For any types that you could instantiate directly in previous versions of the [!INCLUDE[vsto_runtime](../VS_officedev/includes/vsto_runtime_md.md)], you now use methods of the Globals.Factory object to get instances of these types. For example, to get an object that implements the \<xref:Microsoft.Office.Tools.Excel.SmartTag> interface, use the Globals.Factory.CreateSmartTag method. For more information, see the following topics:  
  
-   [Updating Excel and Word Projects that You Migrate to the .NET Framework 4 or the .NET Framework 4.5](../VS_officedev/updating-excel-and-word-projects-that-you-migrate-to-the-.net-framework-4-or-the-.net-framework-4.5.md)  
  
-   [Updating Ribbon Customizations in Office Projects that You Migrate to the .NET Framework 4 or the .NET Framework 4.5](../VS_officedev/3b7c8ad4-a616-4b42-9d62-9658fdefe6a3.md)  
  
-   [Updating Form Regions in Outlook Projects that You Migrate to the .NET Framework 4 or the .NET Framework 4.5](../VS_officedev/65991e2f-4875-49f0-b21b-6a3d0175d0f4.md)  
  
### New Base Classes in Office Projects  
 The new interface-based design of the Visual Studio 2010 Tools for Office Runtime affects the generated classes in Office projects, such as `ThisDocument`, `ThisWorkbook`, and `ThisAddIn`. In Office projects that target the .NET Framework 3.5 and previous versions of the framework, these generated classes derive from classes in the [!INCLUDE[vsto_runtime](../VS_officedev/includes/vsto_runtime_md.md)] such as Microsoft.Office.Tools.Word.Document, Microsoft.Office.Tools.Excel.Worksheet, and Microsoft.Office.Tools.AddIn. In projects that target the [!INCLUDE[net_v40_short](../VS_officedev/includes/net_v40_short_md.md)] or later, these [!INCLUDE[vsto_runtime](../VS_officedev/includes/vsto_runtime_md.md)] classes are now interfaces. Therefore the generated classes in Office projects can no longer derive their implementation from them. Instead, the generated classes derive from new base classes such as \<xref:Microsoft.Office.Tools.Word.DocumentBase>, \<xref:Microsoft.Office.Tools.Excel.WorksheetBase>, and \<xref:Microsoft.Office.Tools.AddInBase>. For more information, see [Programming VSTO Add-Ins](../VS_officedev/programming-vsto-add-ins.md) and [Programming Document-Level Customizations](../VS_officedev/programming-document-level-customizations.md).  
  
 The base classes are not part of the [!INCLUDE[vsto_runtime](../VS_officedev/includes/vsto_runtime_md.md)] redistributable. Instead, they are defined in utilities assemblies that are included with Visual Studio. These assemblies are copied to the output folder when you build Office projects and must be deployed with your solution. For more information about the utilities assemblies, see [Assemblies in the Visual Studio Tools for Office Runtime](../VS_officedev/assemblies-in-the-visual-studio-tools-for-office-runtime.md).  
  
## Breaking Changes in Office Projects that Are Retargeted to the .NET Framework 4  
 The following table lists the main breaking changes you can encounter in Office projects that are retargeted to the [!INCLUDE[net_v40_short](../VS_officedev/includes/net_v40_short_md.md)] or later. For further details, see [Migrating Office Solutions to the .NET Framework 4 or later](../VS_officedev/migrating-office-solutions-to-the-.net-framework-4-or-later.md).  
  
|Breaking change|Consequence|  
|---------------------|-----------------|  
|The \<xref:System.Security.SecurityTransparentAttribute> is no longer used or supported in Office projects.|You must remove this attribute from the AssemblyInfo code file in Office projects that you upgrade from Visual Studio 2008. For more information, see [Required Changes to Run Office Projects that You Migrate to the .NET Framework 4 or the .NET Framework 4.5](../VS_officedev/e2cd35cc-7731-428e-9046-34fc57a02c48.md).|  
|The ExcelLocale1033Attribute is no longer used or supported in Excel projects.|You must remove this attribute from the AssemblyInfo code file in Excel projects. For more information, see [Updating Excel and Word Projects that You Migrate to the .NET Framework 4 or the .NET Framework 4.5](../VS_officedev/updating-excel-and-word-projects-that-you-migrate-to-the-.net-framework-4-or-the-.net-framework-4.5.md).|  
|The programming model of **Ribbon (Visual Designer)** project items has changed.|You must modify the code-behind file for any ribbon items in your project. You must also modify any code that instantiates ribbon controls at run time, handles ribbon events, or sets the position of a ribbon component programmatically. For more information, see [Updating Ribbon Customizations in Office Projects that You Migrate to the .NET Framework 4 or the .NET Framework 4.5](../VS_officedev/3b7c8ad4-a616-4b42-9d62-9658fdefe6a3.md).|  
|The programming model of Outlook form regions has changed.|You must modify the code-behind file for any form regions in your project and any code that instantiates certain form region classes at run time. For more information, see [Updating Form Regions in Outlook Projects that You Migrate to the .NET Framework 4 or the .NET Framework 4.5](../VS_officedev/65991e2f-4875-49f0-b21b-6a3d0175d0f4.md).|  
|The programming model for smart tags in Excel and Word projects has changed. Smart tags are deprecated in [!INCLUDE[Excel_14_short](../VS_officedev/includes/excel_14_short_md.md)] and [!INCLUDE[Word_14_short](../VS_officedev/includes/word_14_short_md.md)].|If your solution uses smart tags, errors will occur when you build the project. Because smart tags are deprecated in [!INCLUDE[Excel_14_short](../VS_officedev/includes/excel_14_short_md.md)] and [!INCLUDE[Word_14_short](../VS_officedev/includes/word_14_short_md.md)], you must remove the tags before you can test and debug the solution in [!INCLUDE[vs_dev12](../VS_officedev/includes/vs_dev12_md.md)] or later.|  
|The syntax of the GetVstoObject and HasVstoObject methods has changed|You must pass the Globals.Factory object to these methods when you access them on native objects from the primary interop assemblies (PIAs), or you can access these methods on the object that is returned by the Globals.Factory property in your project. For more information, see [Updating Excel and Word Projects that You Migrate to the .NET Framework 4 or the .NET Framework 4.5](../VS_officedev/updating-excel-and-word-projects-that-you-migrate-to-the-.net-framework-4-or-the-.net-framework-4.5.md).|  
|The events of Word content controls are associated with new delegates.|You must modify any code that handles events of Word content controls to specify the new delegates. For more information, see [Updating Excel and Word Projects that You Migrate to the .NET Framework 4 or the .NET Framework 4.5](../VS_officedev/updating-excel-and-word-projects-that-you-migrate-to-the-.net-framework-4-or-the-.net-framework-4.5.md).|  
|The OLEObject and OLEControl classes have been renamed.|You must modify any code that uses instances of these classes to use \<xref:Microsoft.Office.Tools.Excel.ControlSite> or \<xref:Microsoft.Office.Tools.Word.ControlSite> objects instead. For more information, see [Updating Excel and Word Projects that You Migrate to the .NET Framework 4 or the .NET Framework 4.5](../VS_officedev/updating-excel-and-word-projects-that-you-migrate-to-the-.net-framework-4-or-the-.net-framework-4.5.md).|  
|Host item classes, such as `ThisWorkbook`, `Sheet`*n*, `ThisDocument`, and `ThisAddIn`, no longer provide a Dispose method that you can override.|You must move any code in the Dispose method override to the Shutdown event handler in the host item class, for example, `ThisAddIn_Shutdown`, and remove the Dispose method override from your host item class.|  
  
## See Also  
 [Migrating Office Solutions to the .NET Framework 4 or later](../VS_officedev/migrating-office-solutions-to-the-.net-framework-4-or-later.md)   
 [What's New in Office Development](assetId:///bf054af2-c896-4723-aa15-6381145b14bb)   
 [Visual Studio Tools for Office Runtime Overview](../VS_officedev/visual-studio-tools-for-office-runtime-overview.md)  
  
  