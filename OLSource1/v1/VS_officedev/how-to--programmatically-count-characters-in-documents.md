---
title: "How to: Programmatically Count Characters in Documents"
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
  - "characters, counting in documents"
  - "counting characters in documents"
  - "documents [Office development in Visual Studio], counting characters"
ms.assetid: ab64fe87-896a-4b56-bdf8-91c4326b540e
caps.latest.revision: 37
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
# How to: Programmatically Count Characters in Documents
  The first character in a document is at character position 0, which represents the insertion point. The last character position is equal to the total number of characters in the document. You can determine the number of characters in a document by using the \<xref:Microsoft.Office.Interop.Word.Characters.Count*> property of the \<xref:Microsoft.Office.Interop.Word.Characters> collection.  
  
 All characters in the document are counted, including spaces, paragraph marks, and other characters that are normally hidden. Even a new, blank document returns a count of one character because it contains a paragraph mark.  
  
 [!INCLUDE[appliesto_wdalldocapp](../VS_officedev/includes/appliesto_wdalldocapp_md.md)]  
  
### To display the number of characters in a document-level customization  
  
1.  Select the entire document.  
  
     [!code[Trin_VstcoreWordAutomation#98](../VS_officedev/codesnippet/VisualBasic/how-to--programmatically-count-characters-in-documents_1.vb)]
[!code[Trin_VstcoreWordAutomation#98](../VS_officedev/codesnippet/CSharp/how-to--programmatically-count-characters-in-documents_1.cs)]  
  
2.  Display the number of characters in the document in a message box.  
  
     [!code[Trin_VstcoreWordAutomation#99](../VS_officedev/codesnippet/VisualBasic/how-to--programmatically-count-characters-in-documents_2.vb)]
[!code[Trin_VstcoreWordAutomation#99](../VS_officedev/codesnippet/CSharp/how-to--programmatically-count-characters-in-documents_2.cs)]  
  
### To display the number of characters in an VSTO Add-in  
  
1.  Select the entire document. The following example selects the active document.  
  
     [!code[Trin_VstcoreWordAutomationAddIn#98](../VS_officedev/codesnippet/VisualBasic/how-to--programmatically-count-characters-in-documents_3.vb)]
[!code[Trin_VstcoreWordAutomationAddIn#98](../VS_officedev/codesnippet/CSharp/how-to--programmatically-count-characters-in-documents_3.cs)]  
  
2.  Display the number of characters in the document in a message box.  
  
     [!code[Trin_VstcoreWordAutomationAddIn#99](../VS_officedev/codesnippet/VisualBasic/how-to--programmatically-count-characters-in-documents_4.vb)]
[!code[Trin_VstcoreWordAutomationAddIn#99](../VS_officedev/codesnippet/CSharp/how-to--programmatically-count-characters-in-documents_4.cs)]  
  
## See Also  
 [How to: Programmatically Retrieve Start and End Characters in Ranges](../VS_officedev/how-to--programmatically-retrieve-start-and-end-characters-in-ranges.md)   
 [How to: Programmatically Define and Select Ranges in Documents](../VS_officedev/how-to--programmatically-define-and-select-ranges-in-documents.md)  
  
  