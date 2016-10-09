---
title: "How to: Programmatically Remove Protection from Worksheets"
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
  - "worksheets, unprotecting"
  - "documents [Office development in Visual Studio], document protection"
  - "document protection, removing from worksheets"
  - "Unprotect method"
ms.assetid: 034688d2-eda7-4b4a-bcc2-d0999ff879a4
caps.latest.revision: 48
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
# How to: Programmatically Remove Protection from Worksheets
  You can programmatically remove protection from a Microsoft Office Excel worksheet.  
  
 [!INCLUDE[appliesto_xlalldocapp](../VS_officedev/includes/appliesto_xlalldocapp_md.md)]  
  
 The following example uses the variable `getPasswordFromUser`, which contains a password obtained from the user.  
  
### To unprotect a worksheet in a document-level customization  
  
1.  Call the \<xref:Microsoft.Office.Tools.Excel.Worksheet.Unprotect*> method of the worksheet and pass in the password, if required. This example assumes that you are working with a worksheet named `Sheet1`.  
  
     [!code[Trin_VstcoreExcelAutomation#28](../VS_officedev/codesnippet/CSharp/how-to--programmatically-remove-protection-from-worksheets_1.cs)]
[!code[Trin_VstcoreExcelAutomation#28](../VS_officedev/codesnippet/VisualBasic/how-to--programmatically-remove-protection-from-worksheets_1.vb)]  
  
### To unprotect a worksheet in an VSTO Add-in  
  
1.  Call the \<xref:Microsoft.Office.Interop.Excel._Worksheet.Unprotect*> method of the active worksheet and pass in the password, if required.  
  
     [!code[Trin_VstcoreExcelAutomationAddIn#18](../VS_officedev/codesnippet/CSharp/how-to--programmatically-remove-protection-from-worksheets_2.cs)]
[!code[Trin_VstcoreExcelAutomationAddIn#18](../VS_officedev/codesnippet/VisualBasic/how-to--programmatically-remove-protection-from-worksheets_2.vb)]  
  
## See Also  
 [Working with Worksheets](../VS_officedev/working-with-worksheets.md)   
 [How to: Programmatically Protect Worksheets](../VS_officedev/how-to--programmatically-protect-worksheets.md)   
 [How to: Programmatically Protect Workbooks](../VS_officedev/how-to--programmatically-protect-workbooks.md)   
 [How to: Programmatically Hide Worksheets](../VS_officedev/how-to--programmatically-hide-worksheets.md)   
 [Global Access to Objects in Office Projects](../VS_officedev/global-access-to-objects-in-office-projects.md)  
  
  