---
title: "How to: Resize Bookmark Controls"
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
  - "controls [Office development in Visual Studio], resizing"
  - "Bookmark control, resizing"
ms.assetid: 3de1c774-921a-4113-a54a-e3b8d4a65d53
caps.latest.revision: 45
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
# How to: Resize Bookmark Controls
  You set the size of a \<xref:Microsoft.Office.Tools.Word.Bookmark> control when you add it to a Microsoft Office Word document. You can also resize it at a later time.  
  
 [!INCLUDE[appliesto_wdalldocapp](../VS_officedev/includes/appliesto_wdalldocapp_md.md)]  
  
 There are three ways to resize a bookmark:  
  
-   Add or remove text in the \<xref:Microsoft.Office.Tools.Word.Bookmark> control.  
  
     Whenever you add text in a bookmark, the size of the bookmark automatically increases to contain the new text. When you delete text, the size of the bookmark automatically decreases.  
  
-   Change the \<xref:Microsoft.Office.Tools.Word.Bookmark.Start*> and \<xref:Microsoft.Office.Tools.Word.Bookmark.End*> properties of the \<xref:Microsoft.Office.Tools.Word.Bookmark> control.  
  
     This is useful if you are changing the size by only a few characters.  
  
-   Recreate the \<xref:Microsoft.Office.Tools.Word.Bookmark> control.  
  
     This is useful if there is a substantial change in the size or location of a bookmark.  
  
 In document-level projects, you can add \<xref:Microsoft.Office.Tools.Word.Bookmark> controls to the document in your project at design time or at run time. In VSTO Add-in projects, you can add \<xref:Microsoft.Office.Tools.Word.Bookmark> controls to any open document at run time. For more information, see [How to: Add Bookmark Controls to Word Documents](../VS_officedev/how-to--add-bookmark-controls-to-word-documents.md).  
  
 [!INCLUDE[note_settings_general](../VS_officedev/includes/note_settings_general_md.md)]  
  
## Changing the Start and End Properties  
  
#### To resize a bookmark in a document-level project at design time  
  
1.  Select the bookmark in the **Properties** window.  
  
2.  Increase or decrease the value of the \<xref:Microsoft.Office.Tools.Word.Bookmark.Start*> property.  
  
3.  Increase or decrease the value of the \<xref:Microsoft.Office.Tools.Word.Bookmark.End*> property.  
  
#### To resize a bookmark in a document-level project at run time  
  
1.  Modify the \<xref:Microsoft.Office.Tools.Word.Bookmark.Start*> and \<xref:Microsoft.Office.Tools.Word.Bookmark.End*> properties of a \<xref:Microsoft.Office.Tools.Word.Bookmark> you created at run time or at design time.  
  
     The following code example adds five characters to the start of a bookmark named `SampleBookmark`. This code assumes that there are at least five characters of text before the bookmark.  
  
     [!code[Trin_VstcoreHostControlsWord#2](../VS_officedev/codesnippet/CSharp/how-to--resize-bookmark-controls_1.cs)]
[!code[Trin_VstcoreHostControlsWord#2](../VS_officedev/codesnippet/VisualBasic/how-to--resize-bookmark-controls_1.vb)]  
  
     The following code example adds five characters to the end of the same bookmark. This code assumes that there are at least five characters of text after the bookmark.  
  
     [!code[Trin_VstcoreHostControlsWord#3](../VS_officedev/codesnippet/CSharp/how-to--resize-bookmark-controls_2.cs)]
[!code[Trin_VstcoreHostControlsWord#3](../VS_officedev/codesnippet/VisualBasic/how-to--resize-bookmark-controls_2.vb)]  
  
#### To resize a bookmark in an VSTO Add-in project at run time  
  
1.  Modify the \<xref:Microsoft.Office.Tools.Word.Bookmark.Start*> and \<xref:Microsoft.Office.Tools.Word.Bookmark.End*> properties of a \<xref:Microsoft.Office.Tools.Word.Bookmark> you created at run time.  
  
     The following code example creates a \<xref:Microsoft.Office.Tools.Word.Bookmark> that contains the text in the first paragraph of the active document, and then removes five characters from the start and end of the \<xref:Microsoft.Office.Tools.Word.Bookmark>.  
  
     [!code[Trin_WordAddInDynamicControls#16](../VS_officedev/codesnippet/VisualBasic/how-to--resize-bookmark-controls_3.vb)]
[!code[Trin_WordAddInDynamicControls#16](../VS_officedev/codesnippet/CSharp/how-to--resize-bookmark-controls_3.cs)]  
  
## Recreating the Bookmark  
 You can resize a bookmark in a document-level project by adding a new bookmark that has the same name as the existing bookmark, but that has a different size.  
  
#### To recreate a bookmark in a document-level project at design time  
  
1.  Select the text to be included in the new \<xref:Microsoft.Office.Tools.Word.Bookmark> control.  
  
2.  On the **Insert** menu, click **Bookmark**.  
  
3.  In the **Bookmark** dialog box, select the name of the bookmark that you want to resize and click **Add**.  
  
## See Also  
 [How to: Add Bookmark Controls to Word Documents](../VS_officedev/how-to--add-bookmark-controls-to-word-documents.md)   
 [Automating Word by Using Extended Objects](../VS_officedev/automating-word-by-using-extended-objects.md)   
 [Host Items and Host Controls Overview](../VS_officedev/host-items-and-host-controls-overview.md)   
 [How to: Resize NamedRange Controls](../VS_officedev/how-to--resize-namedrange-controls.md)   
 [How to: Resize ListObject Controls](../VS_officedev/how-to--resize-listobject-controls.md)   
 [Programmatic Limitations of Host Items and Host Controls](../VS_officedev/programmatic-limitations-of-host-items-and-host-controls.md)  
  
  