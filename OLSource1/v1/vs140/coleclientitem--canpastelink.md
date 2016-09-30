---
title: "COleClientItem::CanPasteLink"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-cpp"
ms.tgt_pltfrm: na
ms.topic: "reference"
f1_keywords: 
  - "COleClientItem::CanPasteLink"
  - "CanPasteLink"
  - "COleClientItem.CanPasteLink"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "CanPasteLink method"
  - "COleClientItem class, clipboard operations"
ms.assetid: ca61ca9c-bc06-473a-b9da-481c1e777c22
caps.latest.revision: 15
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# COleClientItem::CanPasteLink
Call this function to see whether a linked OLE item can be pasted from the Clipboard.  
  
## Syntax  
  
```  
  
static BOOL PASCAL CanPasteLink( );  
```  
  
## Return Value  
 Nonzero if a linked OLE item can be pasted from the Clipboard; otherwise 0.  
  
## Remarks  
 For more information, see [OleGetClipboard](http://msdn.microsoft.com/library/windows/desktop/ms692778) and [OleQueryLinkFromData](http://msdn.microsoft.com/library/windows/desktop/ms690244) in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
## Requirements  
 **Header:** afxole.h  
  
## See Also  
 [COleClientItem Class](../vs140/coleclientitem-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [COleClientItem::CanPaste](../vs140/coleclientitem--canpaste.md)   
 [COleClientItem::CreateLinkFromClipboard](../vs140/coleclientitem--createlinkfromclipboard.md)