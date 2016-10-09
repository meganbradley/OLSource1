---
title: "How to: Read from and Write to Document Properties"
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
  - "Word [Office development in Visual Studio], document properties"
  - "documents [Office development in Visual Studio], properties"
  - "document properties [Office development in Visual Studio]"
  - "Excel [Office development in Visual Studio], document properties"
ms.assetid: e9ef9fa3-36b9-48fb-8148-f5152463c03c
caps.latest.revision: 54
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
# How to: Read from and Write to Document Properties
  You can store document properties along with a document. Office applications provide a number of built-in properties, such as author, title, and subject. This topic shows how to set document properties in Microsoft Office Excel and Microsoft Office Word.  
  
 ![link to video](../VS_officedev/media/playvideo.gif "PlayVideo") For a related video demonstration, see [How Do I: Access and Manipulate Custom Document Properties in Microsoft Word?](http://go.microsoft.com/fwlink/?LinkId=136772).  
  
 [!INCLUDE[appliesto_docprops](../VS_officedev/includes/appliesto_docprops_md.md)]  
  
## Setting Document Properties in Excel  
 To work with built-in properties in Excel, use the following properties:  
  
-   In a document-level project, use the \<xref:Microsoft.Office.Tools.Excel.Workbook.BuiltinDocumentProperties*> property of the `ThisWorkbook` class.  
  
-   In a VSTO Add-in project, use the \<xref:Microsoft.Office.Interop.Excel._Workbook.BuiltinDocumentProperties*> property of a \<xref:Microsoft.Office.Interop.Excel.Workbook> object.  
  
 These properties return a \<xref:Microsoft.Office.Core.DocumentProperties> object, which is a collection of \<xref:Microsoft.Office.Core.DocumentProperty> objects. You can use the `Item` property of the collection to retrieve a particular property, either by name or by index within the collection.  
  
 The following code example shows how to change the built-in **Revision Number** property in a document-level project.  
  
#### To change the Revision Number property in Excel  
  
1.  Assign the built-in document properties to a variable.  
  
     [!code[Trin_VstcoreProgramming#7](../VS_officedev/codesnippet/VisualBasic/how-to--read-from-and-write-to-document-properties_1.vb)]
[!code[Trin_VstcoreProgramming#7](../VS_officedev/codesnippet/CSharp/how-to--read-from-and-write-to-document-properties_1.cs)]  
  
2.  Increment the `Revision Number` property by one.  
  
     [!code[Trin_VstcoreProgramming#8](../VS_officedev/codesnippet/VisualBasic/how-to--read-from-and-write-to-document-properties_2.vb)]
[!code[Trin_VstcoreProgramming#8](../VS_officedev/codesnippet/CSharp/how-to--read-from-and-write-to-document-properties_2.cs)]  
  
## Setting Document Properties in Word  
 To work with built-in properties in Word, use the following properties:  
  
-   In a document-level project, use the \<xref:Microsoft.Office.Tools.Word.Document.BuiltInDocumentProperties*> property of the `ThisDocument` class.  
  
-   In a VSTO Add-in project, use the \<xref:Microsoft.Office.Interop.Word._Document.BuiltInDocumentProperties*> property of a \<xref:Microsoft.Office.Interop.Word.Document> object.  
  
 These properties return a \<xref:Microsoft.Office.Core.DocumentProperties> object, which is a collection of \<xref:Microsoft.Office.Core.DocumentProperty> objects. You can use the `Item` property of the collection to retrieve a particular property, either by name or by index within the collection.  
  
 The following code example shows how to change the built-in **Subject** property in a document-level project.  
  
#### To change the Subject property  
  
1.  Assign the built-in document properties to a variable.  
  
     [!code[Trin_VstcoreProgrammingWord#1](../VS_officedev/codesnippet/CSharp/how-to--read-from-and-write-to-document-properties_3.cs)]
[!code[Trin_VstcoreProgrammingWord#1](../VS_officedev/codesnippet/VisualBasic/how-to--read-from-and-write-to-document-properties_3.vb)]  
  
2.  Change the `Subject` property to "Whitepaper".  
  
     [!code[Trin_VstcoreProgrammingWord#2](../VS_officedev/codesnippet/CSharp/how-to--read-from-and-write-to-document-properties_4.cs)]
[!code[Trin_VstcoreProgrammingWord#2](../VS_officedev/codesnippet/VisualBasic/how-to--read-from-and-write-to-document-properties_4.vb)]  
  
## Robust Programming  
 The examples assume that you have written the code in the `ThisWorkbook` class in a document-level project for Excel, and the `ThisDocument` class in a document-level project for Word.  
  
 Although you are working with Word and Excel and their objects, Microsoft Office supplies the list of available built-in document properties. Attempting to access an undefined property raises an exception.  
  
## See Also  
 [Programming VSTO Add-Ins](../VS_officedev/programming-vsto-add-ins.md)   
 [Programming Document-Level Customizations](../VS_officedev/programming-document-level-customizations.md)   
 [How to: Create and Modify Custom Document Properties](../VS_officedev/how-to--create-and-modify-custom-document-properties.md)  
  
  