---
title: "How to: Programmatically Create New Workbooks"
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
  - "Excel [Office development in Visual Studio], creating workbooks"
  - "workbooks, creating"
ms.assetid: be0196fe-7dc5-4811-b0cd-3c219731a3ff
caps.latest.revision: 48
ms.author: "normesta"
manager: "ghogen"
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
# How to: Programmatically Create New Workbooks
  When you create a workbook programmatically, it is a native \<xref:Microsoft.Office.Interop.Excel.Workbook> object, not a \<xref:Microsoft.Office.Tools.Excel.Workbook> host item.  
  
 [!INCLUDE[appliesto_xlalldocapp](../VS_officedev/includes/appliesto_xlalldocapp_md.md)]  
  
 You can generate a \<xref:Microsoft.Office.Tools.Excel.Workbook> host item for a \<xref:Microsoft.Office.Interop.Excel.Workbook> object in VSTO Add-in project. For more information, see [Extending Word Documents and Excel Workbooks in VSTO Add-ins at Run Time](../VS_officedev/extending-word-documents-and-excel-workbooks-in-vsto-add-ins-at-run-time.md).  
  
### To create a new workbook  
  
1.  Use the \<xref:Microsoft.Office.Interop.Excel.Workbooks.Add*> method of the \<xref:Microsoft.Office.Interop.Excel.Workbooks> collection.  
  
     [!code[Trin_VstcoreExcelAutomation#1](../VS_officedev/codesnippet/CSharp/how-to--programmatically-create-new-workbooks_1.cs)]
[!code[Trin_VstcoreExcelAutomation#1](../VS_officedev/codesnippet/VisualBasic/how-to--programmatically-create-new-workbooks_1.vb)]  
  
    > [!NOTE]  
    >  You can create a workbook based on a template other than the default template: pass the template you want to use as a parameter to the \<xref:Microsoft.Office.Interop.Excel.Workbooks.Add*> method.  
  
## See Also  
 [Extending Word Documents and Excel Workbooks in VSTO Add-ins at Run Time](../VS_officedev/extending-word-documents-and-excel-workbooks-in-vsto-add-ins-at-run-time.md)   
 [Adding Controls to Office Documents at Run Time](../VS_officedev/adding-controls-to-office-documents-at-run-time.md)   
 [Working with Workbooks](../VS_officedev/working-with-workbooks.md)   
 [How to: Programmatically Open Workbooks](../VS_officedev/how-to--programmatically-open-workbooks.md)   
 [How to: Programmatically Save Workbooks](../VS_officedev/how-to--programmatically-save-workbooks.md)   
 [How to: Programmatically Close Workbooks](../VS_officedev/how-to--programmatically-close-workbooks.md)   
 [Programmatic Limitations of Host Items and Host Controls](../VS_officedev/programmatic-limitations-of-host-items-and-host-controls.md)   
 [Optional Parameters in Office Solutions](../VS_officedev/optional-parameters-in-office-solutions.md)   
 [Host Items and Host Controls Overview](../VS_officedev/host-items-and-host-controls-overview.md)  
  
  