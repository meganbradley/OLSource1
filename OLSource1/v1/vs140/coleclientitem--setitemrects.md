---
title: "COleClientItem::SetItemRects"
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
  - "COleClientItem.SetItemRects"
  - "COleClientItem::SetItemRects"
  - "SetItemRects"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "SetItemRects method"
  - "COleClientItem class, activation"
ms.assetid: 0e07932f-b126-4e1a-80e4-864f2b96d44c
caps.latest.revision: 15
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# COleClientItem::SetItemRects
Call this function to set the bounding rectangle or the visible rectangle of the OLE item.  
  
## Syntax  
  
```  
  
      BOOL SetItemRects(   
   LPCRECT lpPosRect = NULL,   
   LPCRECT lpClipRect = NULL    
);  
```  
  
#### Parameters  
 *lprcPosRect*  
 Pointer to the rectangle containing the bounds of the OLE item relative to its parent window, in client coordinates.  
  
 *lprcClipRect*  
 Pointer to the rectangle containing the bounds of the visible portion of the OLE item relative to its parent window, in client coordinates.  
  
## Return Value  
 Nonzero if successful; otherwise, 0.  
  
## Remarks  
 This function is called by the default implementation of the [OnChangeItemPosition](../vs140/coleclientitem--onchangeitemposition.md) member function. You should call this function whenever the position or visible portion of the OLE item changes. Usually this means that you call it from your view's [OnSize](../vs140/cwnd--onsize.md) and [OnScrollBy](../vs140/cview--onscrollby.md) member functions.  
  
 For more information, see [IOleInPlaceObject::SetObjectRects](http://msdn.microsoft.com/library/windows/desktop/ms683767) in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
## Requirements  
 **Header:** afxole.h  
  
## See Also  
 [COleClientItem Class](../vs140/coleclientitem-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [COleClientItem::OnChangeItemPosition](../vs140/coleclientitem--onchangeitemposition.md)   
 [COleClientItem::OnGetItemPosition](../vs140/coleclientitem--ongetitemposition.md)