---
title: "COleClientItem::OnGetClipRect"
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
  - COleClientItem.OnGetClipRect
  - OnGetClipRect
  - COleClientItem::OnGetClipRect
dev_langs: 
  - C++
helpviewer_keywords: 
  - OnGetClipRect method
  - COleClientItem class, overridables
ms.assetid: 7efc44c9-3d70-49b0-aced-679d2730f414
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - de-de
  - ja-jp
---
# COleClientItem::OnGetClipRect
The framework calls the `OnGetClipRect` member function to get the clipping-rectangle coordinates of the item that is being edited in place.  
  
## Syntax  
  
```  
  
      virtual void OnGetClipRect(  
   CRect& rClipRect   
);  
```  
  
#### Parameters  
 *rClipRect*  
 Pointer to an object of class [CRect](../vs140/crect-class.md) that will hold the clipping-rectangle coordinates of the item.  
  
## Remarks  
 Coordinates are in pixels relative to the container application window's client area.  
  
 The default implementation simply returns the client rectangle of the view on which the item is in-place active.  
  
## Requirements  
 **Header:** afxole.h  
  
## See Also  
 [COleClientItem Class](../vs140/coleclientitem-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [COleClientItem::OnActivate](../vs140/coleclientitem--onactivate.md)