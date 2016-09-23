---
title: "COleControl::OnGetViewRect"
ms.custom: na
ms.date: 09/22/2016
ms.prod: visual-studio-dev14
ms.reviewer: na
ms.suite: na
ms.technology: 
  - devlang-cpp
ms.tgt_pltfrm: na
ms.topic: reference
f1_keywords: 
  - OnGetViewRect
  - COleControl.OnGetViewRect
  - COleControl::OnGetViewRect
dev_langs: 
  - C++
helpviewer_keywords: 
  - OnGetViewRect method
ms.assetid: b8f3e5c2-ada9-439d-807b-6625d5ac2778
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - de-de
  - ja-jp
---
# COleControl::OnGetViewRect
Called by the framework in response to a container's **IViewObjectEx::GetRect** request.  
  
## Syntax  
  
```  
  
      virtual BOOL OnGetViewRect(  
   DWORD dwAspect,  
   LPRECTL pRect   
);  
```  
  
#### Parameters  
 `dwAspect`  
 `DWORD` describing which form, or aspect, of an object is to be displayed. Valid values are taken from the enumeration [DVASPECT](http://msdn.microsoft.com/library/windows/desktop/ms690318) or **DVASPECT2**:  
  
-   `DVASPECT_CONTENT` Bounding rectangle of the whole object. Top-left corner at the object's origin and size equal to the extent returned by **GetViewExtent***.*  
  
-   **DVASPECT_OPAQUE** Objects with a rectangular opaque region return that rectangle. Others fail.  
  
-   **DVASPECT_TRANSPARENT** Rectangle covering all transparent or irregular parts.  
  
 `pRect`  
 Points to the [RECTL](http://msdn.microsoft.com/library/windows/desktop/dd162907) structure specifying the rectangle in which the object should be drawn. This parameter controls the positioning and stretching of the object.  
  
## Return Value  
 Nonzero if the rectangle sized to the object is successfully returned; otherwise 0.  
  
## Remarks  
 The object's size is converted by `OnGetViewRect` into a rectangle starting at a specific position (the default is the upper left corner of the display). Override this function if your control uses two-pass drawing, and its opaque and transparent parts have different dimensions.  
  
## Requirements  
 **Header:** afxctl.h  
  
## See Also  
 [COleControl Class](../vs140/colecontrol-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [COleControl::OnGetViewExtent](../vs140/colecontrol--ongetviewextent.md)