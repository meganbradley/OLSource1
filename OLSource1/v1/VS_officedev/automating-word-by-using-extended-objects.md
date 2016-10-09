---
title: "Automating Word by Using Extended Objects"
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
  - "Word [Office development in Visual Studio], automating"
  - "extended objects [Office development in Visual Studio], Word"
  - "automation [Office development in Visual Studio], Word"
  - "host items [Office development in Visual Studio], Word"
  - "automating Word"
  - "controls [Office development in Visual Studio], Word host controls"
  - "host controls, Word"
  - "host controls [Office development in Visual Studio], Word"
  - "Word [Office development in Visual Studio], host controls"
ms.assetid: 3911c7cd-7092-468d-bd82-2fdec53a2d9b
caps.latest.revision: 27
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
# Automating Word by Using Extended Objects
  When you develop Word solutions in Visual Studio, you can use *host items* and *host control*s in your solutions. These are objects that extend certain commonly used objects in the Word object model (that is, the object model that is exposed by the primary interop assembly for Word), such as the \<xref:Microsoft.Office.Interop.Word.Document> and \<xref:Microsoft.Office.Interop.Word.ContentControl> objects. The extended objects behave like the Word objects they are based on, but they add additional events and data binding capabilities to the objects.  
  
 [!INCLUDE[appliesto_wdalldocapp](../VS_officedev/includes/appliesto_wdalldocapp_md.md)]  
  
 Host items and host controls are available in both VSTO Add-ins and document-level customizations, although the context in which these can be used is different for each type of solution. For more information, see [Host Items and Host Controls Overview](../VS_officedev/host-items-and-host-controls-overview.md).  
  
## Document Host Item  
 Word projects give you access to the \<xref:Microsoft.Office.Tools.Word.Document> host item. The \<xref:Microsoft.Office.Tools.Word.Document> host item acts as a container for other controls, including host controls and Windows Forms controls, and it maintains information about the controls on its surface. The \<xref:Microsoft.Office.Tools.Word.Document> host item also provides most of the same members as the \<xref:Microsoft.Office.Interop.Word.Document> class, which is the corresponding class in the object model of Word.  
  
 For more information, see [Document Host Item](../VS_officedev/document-host-item.md).  
  
## Word Host Controls  
 There are several host controls for Word that help you create, organize, and automate documents. Most of their functionality involves importing, presenting, and protecting data. These host controls provide events and data-binding capabilities that their counterparts in the native Word object model do not have.  
  
 In document-level projects, you can add any host control to your document at design time, or you can add content controls and bookmark controls at run time. In VSTO Add-in projects, you can add content controls and bookmark controls to any open document at run time.  
  
 For more information about the host controls you can use in Word projects, see the following topics:  
  
-   [Content Controls](../VS_officedev/content-controls.md)  
  
-   [Bookmark Control](../VS_officedev/bookmark-control.md)  
  
-   [XMLNode Control](../VS_officedev/xmlnode-control.md)  
  
-   [XMLNodes Control](../VS_officedev/xmlnodes-control.md)  
  
## See Also  
 [How to: Add Content Controls to Word Documents](../VS_officedev/how-to--add-content-controls-to-word-documents.md)   
 [How to: Add Bookmark Controls to Word Documents](../VS_officedev/how-to--add-bookmark-controls-to-word-documents.md)   
 [How to: Add XMLNode Controls to Word Documents](../VS_officedev/how-to--add-xmlnode-controls-to-word-documents.md)   
 [How to: Add XMLNodes Controls to Word Documents](../VS_officedev/how-to--add-xmlnodes-controls-to-word-documents.md)   
 [How to: Resize Bookmark Controls](../VS_officedev/how-to--resize-bookmark-controls.md)   
 [Walkthrough: Creating a Template By Using Content Controls](../VS_officedev/walkthrough--creating-a-template-by-using-content-controls.md)   
 [Walkthrough: Binding Content Controls to Custom XML Parts](../VS_officedev/walkthrough--binding-content-controls-to-custom-xml-parts.md)   
 [Walkthrough: Creating Shortcut Menus for Bookmarks](../VS_officedev/walkthrough--creating-shortcut-menus-for-bookmarks.md)   
 [Word Solutions](../VS_officedev/word-solutions.md)   
 [Host Items and Host Controls Overview](../VS_officedev/host-items-and-host-controls-overview.md)   
 [Programmatic Limitations of Host Items and Host Controls](../VS_officedev/programmatic-limitations-of-host-items-and-host-controls.md)   
 [Extending Word Documents and Excel Workbooks in VSTO Add-ins at Run Time](../VS_officedev/extending-word-documents-and-excel-workbooks-in-vsto-add-ins-at-run-time.md)  
  
  