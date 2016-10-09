---
title: "How to: Programmatically Use Word Dialog Boxes in Hidden Mode"
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
  - "hidden dialog boxes"
  - "Word [Office development in Visual Studio], dialog boxes"
  - "dialog boxes, hidden mode in Word"
ms.assetid: a5619325-8b54-41f1-becb-3f6eae7e4a6b
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
# How to: Programmatically Use Word Dialog Boxes in Hidden Mode
  You can perform complex operations with one method call by invoking the built-in dialog boxes in Microsoft Office Word without displaying them to the user. You can do this by using the \<xref:Microsoft.Office.Interop.Word.Dialog.Execute*> method of the \<xref:Microsoft.Office.Interop.Word.Dialog> object without calling the \<xref:Microsoft.Office.Interop.Word.Dialog.Display*> method.  
  
 [!INCLUDE[appliesto_wdalldocapp](../VS_officedev/includes/appliesto_wdalldocapp_md.md)]  
  
## Examples  
 The following code examples demonstrate how to use the **Page Setup** dialog box in hidden mode to set multiple page setup properties with no user input. The examples use a \<xref:Microsoft.Office.Interop.Word.Dialog> object to configure a custom page size. The specific settings for page setup, such as the top margin, bottom margin, and so on, are available as late-bound properties of the \<xref:Microsoft.Office.Interop.Word.Dialog> object. These properties are dynamically created by Word at run time.  
  
 The following example demonstrates how to perform this task in Visual Basic projects where **Option Strict** is off and in Visual C# projects that target the [!INCLUDE[net_v40_short](../VS_officedev/includes/net_v40_short_md.md)]. In these projects, you can use late binding features in the Visual Basic and Visual C# compilers. To use this example, run it from the `ThisDocument` or `ThisAddIn` class in your project.  
  
 [!code[Trin_VstcoreWordAutomation#123](../VS_officedev/codesnippet/VisualBasic/how-to--programmatically-use-word-dialog-boxes-in-hidden-mode_1.vb)]
[!code[Trin_VstcoreWordAutomation#123](../VS_officedev/codesnippet/CSharp/how-to--programmatically-use-word-dialog-boxes-in-hidden-mode_1.cs)]  
  
 The following example demonstrates how to perform this task in Visual Basic projects where **Option Strict** is on. In these projects, you must use reflection to access the late-bound properties. To use this example, run it from the `ThisDocument` or `ThisAddIn` class in your project.  
  
 [!code[Trin_VstcoreWordAutomation#104](../VS_officedev/codesnippet/VisualBasic/how-to--programmatically-use-word-dialog-boxes-in-hidden-mode_2.vb)]  
  
## See Also  
 [How to: Programmatically Use Built-In Dialog Boxes in Word](../VS_officedev/how-to--programmatically-use-built-in-dialog-boxes-in-word.md)   
 [Word Object Model Overview](../VS_officedev/word-object-model-overview.md)   
 [Late Binding in Office Solutions](../VS_officedev/late-binding-in-office-solutions.md)   
 [Reflection &#40;C&#35; and Visual Basic&#41;](../Topic/Reflection%20(C%23%20and%20Visual%20Basic).md)  
  
  