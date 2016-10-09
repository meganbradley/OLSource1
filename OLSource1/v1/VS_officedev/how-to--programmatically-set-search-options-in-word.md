---
title: "How to: Programmatically Set Search Options in Word"
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
  - "settings, Word search options"
  - "documents [Office development in Visual Studio], search options"
  - "Word, searching options"
  - "searching, Word options"
ms.assetid: 4412b4e8-2868-4afb-a593-983603ef9b02
caps.latest.revision: 46
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
# How to: Programmatically Set Search Options in Word
  There are two ways to set search options for selections in Microsoft Office Word documents:  
  
-   Set individual properties of a \<xref:Microsoft.Office.Interop.Word.Find> object.  
  
-   Use arguments of the \<xref:Microsoft.Office.Interop.Word.Find.Execute*> method of a \<xref:Microsoft.Office.Interop.Word.Find> object.  
  
 [!INCLUDE[appliesto_wdalldocapp](../VS_officedev/includes/appliesto_wdalldocapp_md.md)]  
  
## Using Properties of a Find Object  
 The following code sets properties of a \<xref:Microsoft.Office.Interop.Word.Find> object to search for text within the current selection. Notice that the search criteria, such as searching forward, wrapping, and text to search for, are properties of the \<xref:Microsoft.Office.Interop.Word.Find> object.  
  
 Setting each of the properties of the \<xref:Microsoft.Office.Interop.Word.Find> object is not useful when you write C# code because you must specify the same properties as parameters in the \<xref:Microsoft.Office.Interop.Word.Find.Execute*> method. Therefore this example contains only Visual Basic code.  
  
#### To set search options using a Find object  
  
1.  Set the properties of a \<xref:Microsoft.Office.Interop.Word.Find> object to search forward through a selection for the text **find me**.  
  
     [!code[Trin_VstcoreWordAutomation#76](../VS_officedev/codesnippet/VisualBasic/how-to--programmatically-set-search-options-in-word_1.vb)]  
  
## Using Execute Method Arguments  
 The following code uses the \<xref:Microsoft.Office.Interop.Word.Find.Execute*> method of a \<xref:Microsoft.Office.Interop.Word.Find> object to search for text within the current selection. Notice that the search criteria, such as searching forward, wrapping, and text to search for, are passed as parameters of the \<xref:Microsoft.Office.Interop.Word.Find.Execute*> method.  
  
#### To set search options using Execute method arguments  
  
1.  Pass search criteria as parameters of the \<xref:Microsoft.Office.Interop.Word.Find.Execute*> method to search forward through a selection for the text **find me**.  
  
     [!code[Trin_VstcoreWordAutomation#77](../VS_officedev/codesnippet/VisualBasic/how-to--programmatically-set-search-options-in-word_2.vb)]
[!code[Trin_VstcoreWordAutomation#77](../VS_officedev/codesnippet/CSharp/how-to--programmatically-set-search-options-in-word_2.cs)]  
  
## See Also  
 [How to: Programmatically Search for and Replace Text  in Documents](../VS_officedev/how-to--programmatically-search-for-and-replace-text--in-documents.md)   
 [How to: Programmatically Loop Through Found Items in Documents](../VS_officedev/how-to--programmatically-loop-through-found-items-in-documents.md)   
 [How to: Programmatically Restore Selections After Searches](../VS_officedev/how-to--programmatically-restore-selections-after-searches.md)  
  
  