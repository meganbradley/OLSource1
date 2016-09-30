---
title: "COleClientItem::OnScrollBy"
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
  - "COleClientItem.OnScrollBy"
  - "COleClientItem::OnScrollBy"
  - "OnScrollBy"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "OnScrollBy method"
  - "COleClientItem class, overridables"
ms.assetid: b151bf79-536b-4d45-a937-af3a0579f420
caps.latest.revision: 15
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# COleClientItem::OnScrollBy
Called by the framework to scroll the OLE item in response to requests from the server.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 *sizeExtent*  
 Specifies the distances, in pixels, to scroll in the x and y directions.  
  
## Return Value  
 Nonzero if the item was scrolled; 0 if the item could not be scrolled.  
  
## Remarks  
 For example, if the OLE item is partially visible and the user moves outside the visible region while performing in-place editing, this function is called to keep the cursor visible. The default implementation does nothing. Override this function to scroll the item by the specified amount. Note that as a result of scrolling, the visible portion of the OLE item can change. Call [SetItemRects](../vs140/coleclientitem--setitemrects.md) to update the item's visible rectangle.  
  
 For more information, see [IOleInPlaceSite::Scroll](http://msdn.microsoft.com/library/windows/desktop/ms690291) in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
## Requirements  
 **Header:** afxole.h  
  
## See Also  
 [COleClientItem Class](../vs140/coleclientitem-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [COleClientItem::SetItemRects](../vs140/coleclientitem--setitemrects.md)