---
title: "COleControl::OnDraw"
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
  - "COleControl.OnDraw"
  - "COleControl::OnDraw"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "OnDraw method"
ms.assetid: cfea3e9e-2abf-4142-91e0-a0b88e2f8ce0
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# COleControl::OnDraw
Called by the framework to draw the OLE control in the specified bounding rectangle using the specified device context.  
  
## Syntax  
  
```  
  
      virtual void OnDraw(  
   CDC* pDC,  
   const CRect& rcBounds,  
   const CRect& rcInvalid   
);  
```  
  
#### Parameters  
 `pDC`  
 The device context in which the drawing occurs.  
  
 `rcBounds`  
 The rectangular area of the control, including the border.  
  
 `rcInvalid`  
 The rectangular area of the control that is invalid.  
  
## Remarks  
 `OnDraw` is typically called for screen display, passing a screen device context as `pDC`. The `rcBounds` parameter identifies the rectangle in the target device context (relative to its current mapping mode). The `rcInvalid` parameter is the actual rectangle that is invalid. In some cases this will be a smaller area than `rcBounds`.  
  
## Requirements  
 **Header:** afxctl.h  
  
## See Also  
 [COleControl Class](../vs140/colecontrol-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [COleControl::OnDrawMetafile](../vs140/colecontrol--ondrawmetafile.md)   
 [COleControl::DrawContent](../vs140/colecontrol--drawcontent.md)   
 [COleControl::DrawMetafile](../vs140/colecontrol--drawmetafile.md)