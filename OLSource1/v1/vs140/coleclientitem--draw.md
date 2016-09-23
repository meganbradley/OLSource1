---
title: "COleClientItem::Draw"
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
  - COleClientItem.Draw
  - COleClientItem::Draw
dev_langs: 
  - C++
helpviewer_keywords: 
  - Draw method
  - COleClientItem class, general operations
ms.assetid: 9b00e4ad-2a5f-4317-a9b7-b0472544b6ee
caps.latest.revision: 15
robots: noindex,nofollow
translation.priority.ht: 
  - de-de
  - ja-jp
---
# COleClientItem::Draw
Call this function to draw the OLE item into the specified bounding rectangle using the specified device context.  
  
## Syntax  
  
```  
  
      BOOL Draw(  
   CDC* pDC,  
   LPCRECT lpBounds,  
   DVASPECT nDrawAspect = (DVASPECT  
)-1   
);  
```  
  
#### Parameters  
 `pDC`  
 Pointer to a [CDC](../vs140/cdc-class.md) object used for drawing the OLE item.  
  
 `lpBounds`  
 Pointer to a [CRect](../vs140/crect-class.md) object or `RECT` structure that defines the bounding rectangle in which to draw the OLE item (in logical units determined by the device context).  
  
 `nDrawAspect`  
 Specifies the aspect of the OLE item, that is, how it should be displayed. If `nDrawAspect` is –1, the last aspect set by using [SetDrawAspect](../vs140/coleclientitem--setdrawaspect.md) is used. For more information about possible values for this flag, see [SetDrawAspect](../vs140/coleclientitem--setdrawaspect.md).  
  
## Return Value  
 Nonzero if successful; otherwise 0.  
  
## Remarks  
 The function may use the metafile representation of the OLE item created by the [OnDraw](../vs140/coleserveritem--ondraw.md) member function of `COleServerItem`.  
  
 Typically you use **Draw** for screen display, passing the screen device context as `pDC`. In this case, you need to specify only the first two parameters.  
  
 The `lpBounds` parameter identifies the rectangle in the target device context (relative to its current mapping mode). Rendering may involve scaling the picture and can be used by container applications to impose a view that scales between the displayed view and the final printed image.  
  
 For more information, see [IViewObject::Draw](http://msdn.microsoft.com/library/windows/desktop/ms688655) in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
## Requirements  
 **Header:** afxole.h  
  
## See Also  
 [COleClientItem Class](../vs140/coleclientitem-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [COleClientItem::SetExtent](../vs140/coleclientitem--setextent.md)   
 [COleServerItem::OnDraw](../vs140/coleserveritem--ondraw.md)