---
title: "How to: Programmatically Save Visio Documents"
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
  - "documents [Office development in Visual Studio], saving Visio documents"
  - "Visio [Office development in Visual Studio], saving Visio documents"
ms.assetid: 1a29ac7e-1da4-4c7a-87a5-d3d16897fe7c
caps.latest.revision: 20
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
# How to: Programmatically Save Visio Documents
  There are several ways to save Microsoft Office Visio documents:  
  
-   Save changes in an existing document.  
  
-   Save a new document, or save a document with a new name.  
  
-   Save a document with specified arguments.  
  
 For more information, see the VBA reference documentation for the [Microsoft.Office.Interop.Visio.Document.Save](HV10071468) method, [Microsoft.Office.Interop.Visio.Document.SaveAs](HV10071469) method, and [Microsoft.Office.Interop.Visio.Document.SaveAsEx](HV10071470) method.  
  
## Saving an Existing Document  
  
#### To save a document  
  
-   Call the Microsoft.Office.Interop.Visio.Document.Save method of the Microsoft.Office.Tools.Visio.Document class of a document that has been previously saved.  
  
     To use this code example, run it from the `ThisAddIn` class in your project.  
  
    > [!NOTE]  
    >  The Microsoft.Office.Interop.Visio.Document.Save method throws an exception if a new Visio document has not yet been saved.  
  
     [!code[Trin_VstcoreVisioAutomationAddIn#11](../VS_officedev/codesnippet/CSharp/how-to--programmatically-save-visio-documents_1.cs)]
[!code[Trin_VstcoreVisioAutomationAddIn#11](../VS_officedev/codesnippet/VisualBasic/how-to--programmatically-save-visio-documents_1.vb)]  
  
## Saving a Document with a New Name  
 Use the Microsoft.Office.Interop.Visio.Document.SaveAs method to save a new document, or a document that has a new name. This method requires that you specify the new file name.  
  
#### To save the active Visio document with a new name  
  
-   Call the Microsoft.Office.Interop.Visio.Document.SaveAs method of the Microsoft.Office.Tools.Visio.Document that you want to save, by using a fully qualified path including a file name. If a file by that name already exists in that folder, it is silently overwritten.  
  
     To use this code example, run it from the `ThisAddIn` class in your project.  
  
     [!code[Trin_VstcoreVisioAutomationAddIn#10](../VS_officedev/codesnippet/CSharp/how-to--programmatically-save-visio-documents_2.cs)]
[!code[Trin_VstcoreVisioAutomationAddIn#10](../VS_officedev/codesnippet/VisualBasic/how-to--programmatically-save-visio-documents_2.vb)]  
  
## Saving a Document with a New Name and Specified Arguments  
 Use the Microsoft.Office.Interop.Visio.Document.SaveAsEx method to save a document with a new name, and specify any applicable arguments to apply to the document.  
  
#### To save document with a new name and specified arguments  
  
-   Call the Microsoft.Office.Interop.Visio.Document.SaveAsEx method of the Microsoft.Office.Tools.Visio.Document that you want to save, by using a fully qualified path including a file name. If a file by that name already exists in that folder, an exception is thrown.  
  
     The following code example saves the active document with a new name, marks the document as read-only, and shows the document in the Most Recently Used list of documents. To use this code example, run it from the `ThisAddIn` class in your project.  
  
     [!code[Trin_VstcoreVisioAutomationAddIn#12](../VS_officedev/codesnippet/CSharp/how-to--programmatically-save-visio-documents_3.cs)]
[!code[Trin_VstcoreVisioAutomationAddIn#12](../VS_officedev/codesnippet/VisualBasic/how-to--programmatically-save-visio-documents_3.vb)]  
  
## Compiling the Code  
 This code example requires the following:  
  
-   To save a document that has a new name, a directory named `Test` must be located in the My Documents folder (for Windows XP and earlier) or the Documents folder (for Windows Vista).  
  
## See Also  
 [Visio Solutions](../VS_officedev/visio-solutions.md)   
 [Visio Object Model Overview](../VS_officedev/visio-object-model-overview.md)   
 [How to: Programmatically Create New Visio Documents](../VS_officedev/how-to--programmatically-create-new-visio-documents.md)   
 [How to: Programmatically Open Visio Documents](../VS_officedev/how-to--programmatically-open-visio-documents.md)   
 [How to: Programmatically Close Visio Documents](../VS_officedev/how-to--programmatically-close-visio-documents.md)   
 [How to: Programmatically Print Visio Documents](../VS_officedev/how-to--programmatically-print-visio-documents.md)  
  
  