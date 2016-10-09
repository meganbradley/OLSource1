---
title: "How to: Programmatically Open Visio Documents"
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
  - "documents [Office development in Visual Studio], opening Visio documents"
  - "Visio [Office development in Visual Studio], opening Visio documents"
ms.assetid: bddb820c-bde7-4d21-a0b3-6d1968baccab
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
# How to: Programmatically Open Visio Documents
  There are two methods for opening existing Microsoft Office Visio documents: Open and OpenEx. The OpenEx method is identical to the Open method, except that it provides arguments in which the caller can specify how the document opens.  
  
 For details about the object model, see the VBA reference documentation for the [Microsoft.Office.Interop.Visio.Documents.Open](HV10070351) method and [Microsoft.Office.Interop.Visio.Documents.OpenEx](HV10071456) method.  
  
## Opening a Visio Document  
  
#### To open a Visio document  
  
-   Call the Microsoft.Office.Interop.Visio.Documents.Open method and supply the fully qualified path of the Visio document.  
  
     [!code[Trin_VstcoreVisioAutomationAddIn#5](../VS_officedev/codesnippet/CSharp/how-to--programmatically-open-visio-documents_1.cs)]
[!code[Trin_VstcoreVisioAutomationAddIn#5](../VS_officedev/codesnippet/VisualBasic/how-to--programmatically-open-visio-documents_1.vb)]  
  
## Opening a Visio Document with Specified Arguments  
  
#### To open a Visio document as read-only and docked  
  
-   Call the Microsoft.Office.Interop.Visio.Documents.OpenEx method, supply the fully qualified path of the Visio document, and include the arguments you want to use—in this case, Docked and Read-only.  
  
     [!code[Trin_VstcoreVisioAutomationAddIn#6](../VS_officedev/codesnippet/CSharp/how-to--programmatically-open-visio-documents_2.cs)]
[!code[Trin_VstcoreVisioAutomationAddIn#6](../VS_officedev/codesnippet/VisualBasic/how-to--programmatically-open-visio-documents_2.vb)]  
  
## Compiling the Code  
 This code example requires the following:  
  
-   A Visio document named `myDrawing.vsd` must be located in a directory named `Test` in the My Documents folder (for Windows XP and earlier) or the Documents folder (for Windows Vista).  
  
## See Also  
 [Visio Solutions](../VS_officedev/visio-solutions.md)   
 [Visio Object Model Overview](../VS_officedev/visio-object-model-overview.md)   
 [How to: Programmatically Create New Visio Documents](../VS_officedev/how-to--programmatically-create-new-visio-documents.md)   
 [How to: Programmatically Close Visio Documents](../VS_officedev/how-to--programmatically-close-visio-documents.md)   
 [How to: Programmatically Save Visio Documents](../VS_officedev/how-to--programmatically-save-visio-documents.md)   
 [How to: Programmatically Print Visio Documents](../VS_officedev/how-to--programmatically-print-visio-documents.md)  
  
  