---
title: "Properties in Office Projects"
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
  - "Trust Assemblies Location property"
  - "Cache in Document property"
  - "properties [Office development in Visual Studio]"
  - "Namespace for Host Item property"
  - "Office projects [Office development in Visual Studio], properties"
  - "projects [Office development in Visual Studio], properties"
  - "Value2 property"
ms.assetid: 1284d6c3-8200-4151-88ce-0b5c7765af25
caps.latest.revision: 34
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
# Properties in Office Projects
  There are several important properties that are available to Office projects in Visual Studio. These properties can be accessed in the **Properties** window.  
  
 [!INCLUDE[appliesto_all](../VS_officedev/includes/appliesto_all_md.md)]  
  
## Namespace for Host Item  
 Use the **Namespace for Host Item** property to change the namespace for host item classes (for example, the `ThisAddIn`, `ThisWorkbook`, or `ThisDocument` classes) in Visual C# projects. This property appears in the **Properties** window when you select the document node in a document-level project (such as ExcelWorkbook1.xlsx or WordDocument1.docx) or the application node in a VSTO Add-in project (such as Excel or Word) in **Solution Explorer**.  
  
 When you create a Visual C# Office project, host items are given a namespace based on the name of the project. It is recommended that you use the **Namespace for Host Item** property to change the namespace rather than edit the code files directly. When you use this property, the namespace is changed in the generated (hidden) code files, as well as in the visible code files.  
  
## CacheInDocument  
 The **CacheInDocument** property appears in the **Properties** window for document-level projects when you select an instance of a \<xref:System.Data.DataSet> in the Visual Studio designer. Only public members can be cached; ensure that the **Modifiers** property is set to **Public** if you want to cache a \<xref:System.Data.DataSet>.  
  
 This property takes a Boolean value:  
  
-   Select **true** to cache the dataset in the document.  
  
-   Select **false** if you do not want the dataset to be cached in the document.  
  
 For more information about caching data, see [Cached Data in Document-Level Customizations](../VS_officedev/cached-data-in-document-level-customizations.md).  
  
## Value2  
 The **Value2** property is only available for Excel workbook or template projects. It appears under the **Databindings** property node in the **Properties** window when you select a \<xref:Microsoft.Office.Tools.Excel.NamedRange> control on the worksheet designer.  
  
 Use the **Value2** property in the **Properties** window to bind the \<xref:Microsoft.Office.Tools.Excel.NamedRange.Value2*> property of the \<xref:Microsoft.Office.Tools.Excel.NamedRange> to a field in your data source.  
  
## See Also  
 [Designing and Creating Office Solutions](../VS_officedev/designing-and-creating-office-solutions.md)   
 [Office Project Templates Overview](../VS_officedev/office-project-templates-overview.md)   
 [Events in Office Projects](../VS_officedev/events-in-office-projects.md)  
  
  