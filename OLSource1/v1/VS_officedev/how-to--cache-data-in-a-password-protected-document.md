---
title: "How to: Cache Data in a Password-Protected Document"
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
  - "data caching [Office development in Visual Studio], protected documents"
  - "datasets [Office development in Visual Studio], caching"
  - "data [Office development in Visual Studio], caching"
ms.assetid: 91b865fc-bd01-438f-ac63-2fe3175bc2e8
caps.latest.revision: 23
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
# How to: Cache Data in a Password-Protected Document
  If you add data to the data cache in a document or workbook that is protected with a password, changes to the cached data are not saved automatically. You can save changes to the cached data by overriding two methods in your project.  
  
 [!INCLUDE[appliesto_alldoc](../VS_officedev/includes/appliesto_alldoc_md.md)]  
  
## Caching in Word Documents  
  
#### To cache data in a Word document that is protected with a password  
  
1.  In the `ThisDocument` class, mark a public field or property to be cached. For more information, see [Caching Data](../VS_officedev/caching-data.md).  
  
2.  Override the \<xref:Microsoft.Office.Tools.Word.DocumentBase.UnprotectDocument*> method in the `ThisDocument` class and remove protection from the document.  
  
     When the document is saved, the [!INCLUDE[vsto_runtime](../VS_officedev/includes/vsto_runtime_md.md)] calls this method to give you an opportunity to unprotect the document. This enables changes to the cached data to be saved.  
  
3.  Override the \<xref:Microsoft.Office.Tools.Word.DocumentBase.ProtectDocument*> method in the `ThisDocument` class and reapply protection to the document.  
  
     After the document is saved, the [!INCLUDE[vsto_runtime](../VS_officedev/includes/vsto_runtime_md.md)] calls this method to give you an opportunity to reapply protection to the document.  
  
### Example  
 The following code example demonstrates how to cache data in a Word document that is protected with a password. Before the code removes the protection in the \<xref:Microsoft.Office.Tools.Word.DocumentBase.UnprotectDocument*> method, it saves the current \<xref:Microsoft.Office.Tools.Word.Document.ProtectionType*> value, so that the same type of protection can be reapplied in the \<xref:Microsoft.Office.Tools.Word.DocumentBase.ProtectDocument*> method.  
  
 [!code[Trin_CachedDataProtectedDocument#1](../VS_officedev/codesnippet/CSharp/how-to--cache-data-in-a-password-protected-document_1.cs)]
[!code[Trin_CachedDataProtectedDocument#1](../VS_officedev/codesnippet/VisualBasic/how-to--cache-data-in-a-password-protected-document_1.vb)]  
  
### Compiling the Code  
 Add this code to the `ThisDocument` class in your project. This code assumes that the password is stored in a field named `securelyStoredPassword`.  
  
## Caching in Excel Workbooks  
 In Excel projects, this procedure is necessary only when you protect the entire workbook with a password by using the \<xref:Microsoft.Office.Tools.Excel.Workbook.Protect*> method. This procedure is not necessary if you protect only a specific worksheet with a password by using the \<xref:Microsoft.Office.Tools.Excel.Worksheet.Protect*> method.  
  
#### To cache data in an Excel workbook that is protected with a password  
  
1.  In the `ThisWorkbook` class or one of the `Sheet`*n* classes, mark a public field or property to be cached. For more information, see [Caching Data](../VS_officedev/caching-data.md).  
  
2.  Override the \<xref:Microsoft.Office.Tools.Excel.WorkbookBase.UnprotectDocument*> method in the `ThisWorkbook` class and remove protection from the workbook.  
  
     When the workbook is saved, the [!INCLUDE[vsto_runtime](../VS_officedev/includes/vsto_runtime_md.md)] calls this method to give you an opportunity to unprotect the workbook. This enables changes to the cached data to be saved.  
  
3.  Override the \<xref:Microsoft.Office.Tools.Excel.WorkbookBase.ProtectDocument*> method in the `ThisWorkbook` class and reapply protection to the document.  
  
     After the workbook is saved, the [!INCLUDE[vsto_runtime](../VS_officedev/includes/vsto_runtime_md.md)] calls this method to give you an opportunity to reapply protection to the workbook.  
  
### Example  
 The following code example demonstrates how to cache data in an Excel workbook that is protected with a password. Before the code removes the protection in the \<xref:Microsoft.Office.Tools.Excel.WorkbookBase.UnprotectDocument*> method, it saves the current \<xref:Microsoft.Office.Tools.Excel.Workbook.ProtectStructure*> and \<xref:Microsoft.Office.Tools.Excel.Workbook.ProtectWindows*> values, so that the same type of protection can be reapplied in the \<xref:Microsoft.Office.Tools.Excel.WorkbookBase.ProtectDocument*> method.  
  
 [!code[Trin_CachedDataProtectedWorkbook#1](../VS_officedev/codesnippet/VisualBasic/how-to--cache-data-in-a-password-protected-document_2.vb)]
[!code[Trin_CachedDataProtectedWorkbook#1](../VS_officedev/codesnippet/CSharp/how-to--cache-data-in-a-password-protected-document_2.cs)]  
  
### Compiling the Code  
 Add this code to the `ThisWorkbook` class in your project. This code assumes that the password is stored in a field named `securelyStoredPassword`.  
  
## See Also  
 [Caching Data](../VS_officedev/caching-data.md)   
 [How to: Cache Data for Use Offline or on a Server](../VS_officedev/how-to--cache-data-for-use-offline-or-on-a-server.md)   
 [How to: Programmatically Cache a Data Source in an Office Document](../VS_officedev/how-to--programmatically-cache-a-data-source-in-an-office-document.md)  
  
  