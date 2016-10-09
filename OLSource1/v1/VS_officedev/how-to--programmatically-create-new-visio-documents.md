---
title: "How to: Programmatically Create New Visio Documents"
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
  - "Visio [Office development in Visual Studio], creating Visio documents"
  - "documents [Office development in Visual Studio], creating Visio documents"
ms.assetid: a0294d4c-be49-4cd0-b22e-3ec7568f3ec7
caps.latest.revision: 22
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
# How to: Programmatically Create New Visio Documents
  When you create a new Microsoft Office Visio drawing document, you add it to the Microsoft.Office.Interop.Visio.Documents collection of open Visio documents. Consequently, the Microsoft.Office.Interop.Visio.Documents.Add method creates a new Visio drawing document. For more information, see the VBA reference documentation for the [Microsoft.Office.Interop.Visio.Documents.Add](HV10069241) method.  
  
## Creating New Blank Documents  
  
#### To create a new document  
  
-   Use the Microsoft.Office.Interop.Visio.Documents.Add method to create a new blank document that is not based on a template.  
  
     [!code[Trin_VstcoreVisioAutomationAddIn#1](../VS_officedev/codesnippet/CSharp/how-to--programmatically-create-new-visio-documents_1.cs)]
[!code[Trin_VstcoreVisioAutomationAddIn#1](../VS_officedev/codesnippet/VisualBasic/how-to--programmatically-create-new-visio-documents_1.vb)]  
  
## Creating Documents Copied From Existing Documents  
 The Microsoft.Office.Interop.Visio.Documents.Add method can create a new document that is a copy of an existing Visio document. You must supply the file name and fully qualified path of the diagram.  
  
#### To create a new document that is copied from an existing document  
  
-   Call the Microsoft.Office.Interop.Visio.Documents.Add method and specify the path of the Visio diagram.  
  
     [!code[Trin_VstcoreVisioAutomationAddIn#2](../VS_officedev/codesnippet/CSharp/how-to--programmatically-create-new-visio-documents_2.cs)]
[!code[Trin_VstcoreVisioAutomationAddIn#2](../VS_officedev/codesnippet/VisualBasic/how-to--programmatically-create-new-visio-documents_2.vb)]  
  
## Creating Stencils Copied From Existing Stencils  
 The [Microsoft.Office.Interop.Visio.Documents.Add](HV10069241) method can create a new stencil that is a copy of an existing Visio stencil. You must supply the file name and fully qualified path of the stencil.  
  
#### To create a new stencil that is copied from an existing stencil  
  
-   Call the Microsoft.Office.Interop.Visio.Documents.Add method and specify the path of the stencil.  
  
     [!code[Trin_VstcoreVisioAutomationAddIn#3](../VS_officedev/codesnippet/CSharp/how-to--programmatically-create-new-visio-documents_3.cs)]
[!code[Trin_VstcoreVisioAutomationAddIn#3](../VS_officedev/codesnippet/VisualBasic/how-to--programmatically-create-new-visio-documents_3.vb)]  
  
## Creating Documents Based on Existing Templates  
 The Microsoft.Office.Interop.Visio.Documents.Add method can create a new document (a .vsd file) that is based on an existing Visio template (a .vst file). This method copies the stencils, styles, and settings that are part of the template workspace. You must supply the file name and fully qualified path of the template.  
  
#### To create a new document that is based on an existing template  
  
-   Call the Microsoft.Office.Interop.Visio.Documents.Add method and specify the path of the template.  
  
     [!code[Trin_VstcoreVisioAutomationAddIn#4](../VS_officedev/codesnippet/CSharp/how-to--programmatically-create-new-visio-documents_4.cs)]
[!code[Trin_VstcoreVisioAutomationAddIn#4](../VS_officedev/codesnippet/VisualBasic/how-to--programmatically-create-new-visio-documents_4.vb)]  
  
## Compiling the Code  
 This code example requires the following:  
  
-   A Visio document named `myDrawing.vsd` must be located in a directory named `Test` in the My Documents folder (for Windows XP and earlier) or the Documents folder (for Windows Vista).  
  
-   A Visio document named `myStencil.vss` must be located in a directory named `Test` in the My Documents folder (for Windows XP and earlier) or the Documents folder (for Windows Vista).  
  
-   A Visio document named `myTemplate.vst` must be located in a directory named `Test` in the My Documents folder (for Windows XP and earlier) or the Documents folder (for Windows Vista).  
  
## See Also  
 [Visio Solutions](../VS_officedev/visio-solutions.md)   
 [Visio Object Model Overview](../VS_officedev/visio-object-model-overview.md)   
 [How to: Programmatically Open Visio Documents](../VS_officedev/how-to--programmatically-open-visio-documents.md)   
 [How to: Programmatically Close Visio Documents](../VS_officedev/how-to--programmatically-close-visio-documents.md)   
 [How to: Programmatically Save Visio Documents](../VS_officedev/how-to--programmatically-save-visio-documents.md)   
 [How to: Programmatically Print Visio Documents](../VS_officedev/how-to--programmatically-print-visio-documents.md)  
  
  