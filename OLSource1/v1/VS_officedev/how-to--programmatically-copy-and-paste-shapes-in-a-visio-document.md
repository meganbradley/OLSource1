---
title: "How to: Programmatically Copy and Paste Shapes in a Visio Document"
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
  - "shapes [Office development in Visual Studio], copying and pasting Visio shapes"
  - "Visio [Office development in Visual Studio], copying and pasting Visio shapes"
ms.assetid: 762d95cf-2d5c-4dea-988b-8f4da88fa1f1
caps.latest.revision: 15
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
# How to: Programmatically Copy and Paste Shapes in a Visio Document
  You can programmatically copy shapes on one page of a document and paste them into a new page in the same document. You can choose to paste them into the default location (the center of the active window) or into the same coordinate locations as they had on the original page.  
  
## Copying and Pasting Shapes  
 For details about the object model, see the VBA reference documentation for the [Microsoft.Office.Interop.Visio.Shape.DrawRectangle](HV10070304), [Microsoft.Office.Interop.Visio.Shape.DrawOval](HV10070300), [Microsoft.Office.Interop.Visio.Shape.Copy](HV10070291), and [Microsoft.Office.Interop.Visio.Shape.Paste](HV10070437) methods and the [Microsoft.Office.Interop.Visio.VisCutCopyPasteCodes.visCopyPasteNormal](HV10071835) flag.  
  
#### To copy shapes to the center of another page  
  
-   The following example demonstrates how to copy the shapes from the first page and paste them into the center of the second page.  
  
     [!code[Trin_VstcoreVisioAutomationAddIn#14](../VS_officedev/codesnippet/CSharp/how-to--programmatically-copy-and-paste-shapes-in-a-visio-document_1.cs)]
[!code[Trin_VstcoreVisioAutomationAddIn#14](../VS_officedev/codesnippet/VisualBasic/how-to--programmatically-copy-and-paste-shapes-in-a-visio-document_1.vb)]  
  
## Copying and Pasting Shapes With the Same Positions  
 For details about the object model, see the VBA reference documentation for the [Microsoft.Office.Interop.Visio.Shape.DrawRectangle](HV10070304), [Microsoft.Office.Interop.Visio.Shape.DrawOval](HV10070300), [Microsoft.Office.Interop.Visio.Shape.Copy](HV10070291), and [Microsoft.Office.Interop.Visio.Shape.Paste](HV10070437) methods and the [Microsoft.Office.Interop.Visio.VisCutCopyPasteCodes.visCopyPasteNoTranslate](HV10071835) flag.  
  
 If you need to control the format of the pasted information and (optionally) establish a link to a source file (for example, a Microsoft Office Word document), use the PasteSpecial method.  
  
#### To copy shapes and shape locations to another page  
  
-   The following example demonstrates how to copy the shapes from the first page and paste them into the second page with their original coordinate locations.  
  
     [!code[Trin_VstcoreVisioAutomationAddIn#15](../VS_officedev/codesnippet/CSharp/how-to--programmatically-copy-and-paste-shapes-in-a-visio-document_2.cs)]
[!code[Trin_VstcoreVisioAutomationAddIn#15](../VS_officedev/codesnippet/VisualBasic/how-to--programmatically-copy-and-paste-shapes-in-a-visio-document_2.vb)]  
  
## See Also  
 [Visio Solutions](../VS_officedev/visio-solutions.md)   
 [Visio Object Model Overview](../VS_officedev/visio-object-model-overview.md)   
 [Working with Visio Shapes](../VS_officedev/working-with-visio-shapes.md)   
 [How to: Programmatically Add Shapes to a Visio Document](../VS_officedev/how-to--programmatically-add-shapes-to-a-visio-document.md)  
  
  