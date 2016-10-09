---
title: "How to: Programmatically Update Bookmark Text"
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
  - "bookmarks, updating text"
  - "text [Office development in Visual Studio], updating in bookmarks"
  - "Bookmark control, updating contents"
ms.assetid: 2324164d-2538-4695-9aaf-7285ce403be3
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
# How to: Programmatically Update Bookmark Text
  You can insert text into a placeholder bookmark in a Microsoft Office Word document so that you can retrieve the text at a later time, or to replace text in a bookmark. If you are developing a document-level customization, you can also update text in a \<xref:Microsoft.Office.Tools.Word.Bookmark> control that is bound to data. For more information, see [Binding Data to Controls in Office Solutions](../VS_officedev/binding-data-to-controls-in-office-solutions.md).  
  
 [!INCLUDE[appliesto_wdalldocapp](../VS_officedev/includes/appliesto_wdalldocapp_md.md)]  
  
 The bookmark object can be one of two types:  
  
-   A \<xref:Microsoft.Office.Tools.Word.Bookmark> host control.  
  
     \<xref:Microsoft.Office.Tools.Word.Bookmark> controls extend native \<xref:Microsoft.Office.Interop.Word.Bookmark> objects by enabling data binding and exposing events. For more information about host controls, see [Host Items and Host Controls Overview](../VS_officedev/host-items-and-host-controls-overview.md).  
  
-   A native \<xref:Microsoft.Office.Interop.Word.Bookmark> object.  
  
     \<xref:Microsoft.Office.Interop.Word.Bookmark> objects do not have events or data binding capabilities.  
  
 When you assign text to a bookmark, the behavior differs between a \<xref:Microsoft.Office.Interop.Word.Bookmark> and a \<xref:Microsoft.Office.Tools.Word.Bookmark>. For more information, see [Bookmark Control](../VS_officedev/bookmark-control.md).  
  
## Using Host Controls  
  
#### To update bookmark contents using a Bookmark control  
  
1.  Create a procedure that takes a `bookmark` argument for the name of the bookmark, and a `newText` argument for the string to assign to the \<xref:Microsoft.Office.Tools.Word.Bookmark.Text*> property.  
  
    > [!NOTE]  
    >  Assigning text to the \<xref:Microsoft.Office.Tools.Word.Bookmark.Text*> or \<xref:Microsoft.Office.Tools.Word.Bookmark.FormattedText*> property of a \<xref:Microsoft.Office.Tools.Word.Bookmark> control does not cause the bookmark to be deleted.  
  
     [!code[Trin_VstcoreWordAutomation#63](../VS_officedev/codesnippet/VisualBasic/how-to--programmatically-update-bookmark-text_1.vb)]
[!code[Trin_VstcoreWordAutomation#63](../VS_officedev/codesnippet/CSharp/how-to--programmatically-update-bookmark-text_1.cs)]  
  
2.  Assign the *newText* string to the \<xref:Microsoft.Office.Tools.Word.Bookmark.Text*> property of the \<xref:Microsoft.Office.Tools.Word.Bookmark>.  
  
     [!code[Trin_VstcoreWordAutomation#64](../VS_officedev/codesnippet/VisualBasic/how-to--programmatically-update-bookmark-text_2.vb)]
[!code[Trin_VstcoreWordAutomation#64](../VS_officedev/codesnippet/CSharp/how-to--programmatically-update-bookmark-text_2.cs)]  
  
## Using Word Objects  
  
#### To update bookmark contents using a Word Bookmark object  
  
1.  Create a procedure that has a `bookmark` argument for the name of the \<xref:Microsoft.Office.Interop.Word.Bookmark>, and a `newText` argument for the string to assign to the \<xref:Microsoft.Office.Interop.Word.Range.Text*> property of the bookmark.  
  
    > [!NOTE]  
    >  Assigning text to a native Word \<xref:Microsoft.Office.Interop.Word.Bookmark> object causes the bookmark to be deleted.  
  
     [!code[Trin_VstcoreWordAutomation#65](../VS_officedev/codesnippet/VisualBasic/how-to--programmatically-update-bookmark-text_3.vb)]
[!code[Trin_VstcoreWordAutomation#65](../VS_officedev/codesnippet/CSharp/how-to--programmatically-update-bookmark-text_3.cs)]  
  
2.  Assign the *newText* string to the \<xref:Microsoft.Office.Interop.Word.Range.Text*> property of the bookmark, which automatically deletes the bookmark. Then re-add the bookmark to the \<xref:Microsoft.Office.Interop.Word.Bookmarks> collection.  
  
     The following code example can be used in a document-level customization.  
  
     [!code[Trin_VstcoreWordAutomation#66](../VS_officedev/codesnippet/VisualBasic/how-to--programmatically-update-bookmark-text_4.vb)]
[!code[Trin_VstcoreWordAutomation#66](../VS_officedev/codesnippet/CSharp/how-to--programmatically-update-bookmark-text_4.cs)]  
  
     The following code example can be used in a VSTO Add-in. This example uses the active document.  
  
     [!code[Trin_VstcoreWordAutomationAddIn#66](../VS_officedev/codesnippet/VisualBasic/how-to--programmatically-update-bookmark-text_5.vb)]
[!code[Trin_VstcoreWordAutomationAddIn#66](../VS_officedev/codesnippet/CSharp/how-to--programmatically-update-bookmark-text_5.cs)]  
  
## See Also  
 [How to: Programmatically Insert Text into Word Documents](../VS_officedev/how-to--programmatically-insert-text-into-word-documents.md)   
 [Word Object Model Overview](../VS_officedev/word-object-model-overview.md)   
 [Bookmark Control](../VS_officedev/bookmark-control.md)  
  
  