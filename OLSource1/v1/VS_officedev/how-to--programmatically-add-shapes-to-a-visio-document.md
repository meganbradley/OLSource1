---
title: "How to: Programmatically Add Shapes to a Visio Document"
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
  - "Visio [Office development in Visual Studio], adding Visio shapes"
  - "shapes [Office development in Visual Studio], adding Visio shapes"
ms.assetid: 29613237-88f5-41a7-9e13-cfa177f41221
caps.latest.revision: 17
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
# How to: Programmatically Add Shapes to a Visio Document
  You can add shapes to a Microsoft Office Visio document by retrieving the masters from a stencil and dropping the shapes on the active page.  
  
 For more information, see the VBA reference documentation for the [Microsoft.Office.Interop.Visio.Documents.Add](HV10069241) method, [Microsoft.Office.Interop.Visio.Application.ActivePage](HV10069528) property, and [Microsoft.Office.Interop.Visio.Page.Drop](HV10070273) method.  
  
## Adding Shapes to a Visio Document  
  
#### To add shapes to a Visio document  
  
-   With a document active, retrieve the masters from the Documents.Masters collection and drop the shapes on the active document. You can retrieve a master by using the index or master name.  
  
     The following code example creates a blank Visio document, and then opens it with the **Basic Shapes** stencil docked. The code then retrieves several shapes and drops them on the active page.  
  
     [!code[Trin_VstcoreVisioAutomationAddIn#13](../VS_officedev/codesnippet/CSharp/how-to--programmatically-add-shapes-to-a-visio-document_1.cs)]
[!code[Trin_VstcoreVisioAutomationAddIn#13](../VS_officedev/codesnippet/VisualBasic/how-to--programmatically-add-shapes-to-a-visio-document_1.vb)]  
  
## See Also  
 [Visio Solutions](../VS_officedev/visio-solutions.md)   
 [Visio Object Model Overview](../VS_officedev/visio-object-model-overview.md)   
 [Working with Visio Shapes](../VS_officedev/working-with-visio-shapes.md)   
 [How to: Programmatically Copy and Paste Shapes in a Visio Document](../VS_officedev/how-to--programmatically-copy-and-paste-shapes-in-a-visio-document.md)  
  
  