---
title: "COleServerItem::OnDrawEx"
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
  - OnDrawEx
  - COleServerItem::OnDrawEx
  - COleServerItem.OnDrawEx
dev_langs: 
  - C++
helpviewer_keywords: 
  - COleServerItem class, overridables
  - OnDrawEx method
ms.assetid: 39fa9d17-4a1e-4a37-b8f8-747bf62d4a40
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - de-de
  - ja-jp
---
# COleServerItem::OnDrawEx
Called by the framework for all drawing.  
  
## Syntax  
  
```  
  
      virtual BOOL OnDrawEx(  
   CDC* pDC,  
   DVASPECT nDrawAspect,  
   CSize& rSize   
);  
```  
  
#### Parameters  
 `pDC`  
 A pointer to the [CDC](../vs140/cdc-class.md) object on which to draw the item. The DC is automatically connected to the attribute DC so you can call attribute functions, although doing so would make the metafile device-specific.  
  
 `nDrawAspect`  
 A value from the `DVASPECT` enumeration. This parameter can have any of the following values:  
  
-   `DVASPECT_CONTENT` Item is represented in such a way that it can be displayed as an embedded object inside its container.  
  
-   `DVASPECT_THUMBNAIL` Item is rendered in a "thumbnail" representation so that it can be displayed in a browsing tool.  
  
-   `DVASPECT_ICON` Item is represented by an icon.  
  
-   `DVASPECT_DOCPRINT` Item is represented as if it were printed using the Print command from the File menu.  
  
 `rSize`  
 Size of the item in **HIMETRIC** units.  
  
## Return Value  
 Nonzero if the item was successfully drawn; otherwise 0.  
  
## Remarks  
 The default implementation calls `OnDraw` when `DVASPECT` is equal to `DVASPECT_CONTENT`; otherwise it fails.  
  
 Override this function to provide presentation data for aspects other than `DVASPECT_CONTENT`, such as `DVASPECT_ICON` or `DVASPECT_THUMBNAIL`.  
  
## Requirements  
 **Header:** afxole.h  
  
## See Also  
 [COleServerItem Class](../vs140/coleserveritem-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [COleServerItem::OnDraw](../vs140/coleserveritem--ondraw.md)