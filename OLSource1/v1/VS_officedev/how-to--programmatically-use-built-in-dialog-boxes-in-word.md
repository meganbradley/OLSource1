---
title: "How to: Programmatically Use Built-In Dialog Boxes in Word"
ms.custom: na
ms.date: "10/01/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.tgt_pltfrm: na
ms.topic: "article"
dev_langs: 
  - "VB"
  - "CSharp"
helpviewer_keywords: 
  - "Word [Office development in Visual Studio], dialog boxes"
  - "dialog boxes, Word"
ms.assetid: 0c7e4338-dead-4444-868b-3b0212368455
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
# How to: Programmatically Use Built-In Dialog Boxes in Word
  When working with Microsoft Office Word, there are times when you need to display dialog boxes for user input. Although you can create your own, you might also want to take the approach of using the built-in dialog boxes in Word, which are exposed in the \<xref:Microsoft.Office.Interop.Word.Dialogs> collection of the \<xref:Microsoft.Office.Interop.Word.Application> object. This enables you to access over 200 of the built-in dialog boxes, which are represented as enumerations.  
  
 [!INCLUDE[appliesto_wdalldocapp](../VS_officedev/includes/appliesto_wdalldocapp_md.md)]  
  
## Displaying Dialog Boxes  
 To display a dialog box, use one of the values of the \<xref:Microsoft.Office.Interop.Word.WdWordDialog> enumeration to create a \<xref:Microsoft.Office.Interop.Word.Dialog> object that represents the dialog box you want to display. Then, call the \<xref:Microsoft.Office.Interop.Word.Dialog.Show*> method of the \<xref:Microsoft.Office.Interop.Word.Dialog> object.  
  
 The following code example demonstrates how to display the **File Open** dialog box. To use this example, run it from the `ThisDocument` or `ThisAddIn` class in your project.  
  
 [!code[Trin_VstcoreWordAutomation#100](../VS_officedev/codesnippet/VisualBasic/how-to--programmatically-use-built-in-dialog-boxes-in-word_1.vb)]
[!code[Trin_VstcoreWordAutomation#100](../VS_officedev/codesnippet/CSharp/how-to--programmatically-use-built-in-dialog-boxes-in-word_1.cs)]  
  
### Accessing Dialog Box Members That Are Available Through Late Binding  
 Some properties and methods of dialog boxes in Word are available only through late binding. In Visual Basic projects where **Option Strict** is on, you must use reflection to access these members. For more information, see [Late Binding in Office Solutions](../VS_officedev/late-binding-in-office-solutions.md).  
  
 The following code example demonstrates how to use the **Name** property of the **File Open** dialog box in Visual Basic projects where **Option Strict** is off or in Visual C# projects that target the [!INCLUDE[net_v40_short](../VS_officedev/includes/net_v40_short_md.md)] or the [!INCLUDE[net_v45](../VS_officedev/includes/net_v45_md.md)]. To use this example, run it from the `ThisDocument` or `ThisAddIn` class in your project.  
  
 [!code[Trin_VstcoreWordAutomation#122](../VS_officedev/codesnippet/VisualBasic/how-to--programmatically-use-built-in-dialog-boxes-in-word_2.vb)]
[!code[Trin_VstcoreWordAutomation#122](../VS_officedev/codesnippet/CSharp/how-to--programmatically-use-built-in-dialog-boxes-in-word_2.cs)]  
  
 The following code example demonstrates how to use reflection to access the **Name** property of the **File Open** dialog box in Visual Basic projects where **Option Strict** is on. To use this example, run it from the `ThisDocument` or `ThisAddIn` class in your project.  
  
 [!code[Trin_VstcoreWordAutomation#102](../VS_officedev/codesnippet/VisualBasic/how-to--programmatically-use-built-in-dialog-boxes-in-word_3.vb)]  
  
## See Also  
 [How to: Programmatically Use Word Dialog Boxes in Hidden Mode](../VS_officedev/how-to--programmatically-use-word-dialog-boxes-in-hidden-mode.md)   
 [Word Object Model Overview](../VS_officedev/word-object-model-overview.md)   
 [Optional Parameters in Office Solutions](../VS_officedev/optional-parameters-in-office-solutions.md)   
 [Option Strict Statement](../Topic/Option%20Strict%20Statement.md)   
 [Reflection &#40;C&#35; and Visual Basic&#41;](../Topic/Reflection%20(C%23%20and%20Visual%20Basic).md)  
  
  