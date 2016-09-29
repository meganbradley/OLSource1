---
title: "COleServerDoc::OnSetItemRects"
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
  - "OnSetItemRects"
  - "COleServerDoc::OnSetItemRects"
  - "COleServerDoc.OnSetItemRects"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "COleServerDoc class, overridables"
  - "OnSetItemRects method"
ms.assetid: 5de6fde5-217d-4a74-8aaa-be674cd39bea
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# COleServerDoc::OnSetItemRects
The framework calls this function to position the in-place editing frame window within the container application's frame window.  
  
## Syntax  
  
```  
  
      virtual void OnSetItemRects(  
   LPCRECT lpPosRect,  
   LPCRECT lpClipRect   
);  
```  
  
#### Parameters  
 `lpPosRect`  
 Pointer to a `RECT` structure or a `CRect` object that specifies the in-place frame window's position relative to the container application's client area.  
  
 `lpClipRect`  
 Pointer to a `RECT` structure or a `CRect` object that specifies the in-place frame window's clipping rectangle relative to the container application's client area.  
  
## Remarks  
 Override this function to update the view's zoom factor, if necessary.  
  
 This function is usually called in response to a `RequestPositionChange` call, although it can be called at any time by the container to request a position change for the in-place item.  
  
## Requirements  
 **Header:** afxole.h  
  
## See Also  
 [COleServerDoc Class](../vs140/coleserverdoc-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [COleServerDoc::RequestPositionChange](../vs140/coleserverdoc--requestpositionchange.md)   
 [COleIPFrameWnd::RepositionFrame](../vs140/coleipframewnd--repositionframe.md)   
 [COleClientItem::SetItemRects](../vs140/coleclientitem--setitemrects.md)   
 [COleServerDoc::GetZoomFactor](../vs140/coleserverdoc--getzoomfactor.md)