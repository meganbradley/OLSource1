---
title: "COleServerItem::NotifyChanged"
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
  - "DVASPECT"
  - "COleServerItem::NotifyChanged"
  - "NotifyChanged"
  - "COleServerItem.NotifyChanged"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "NotifyChanged method"
  - "COleServerItem class, operations"
  - "DVASPECT"
  - "change notifications, C++"
ms.assetid: 666e63df-3df7-405e-afd2-7a26f4651575
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# COleServerItem::NotifyChanged
Call this function after the linked item has been changed.  
  
## Syntax  
  
```  
  
      void NotifyChanged(  
   DVASPECT nDrawAspect = DVASPECT_CONTENT   
);  
```  
  
#### Parameters  
 `nDrawAspect`  
 A value from the `DVASPECT` enumeration that indicates which aspect of the OLE item has changed. This parameter can have any of the following values:  
  
-   `DVASPECT_CONTENT` Item is represented in such a way that it can be displayed as an embedded object inside its container.  
  
-   `DVASPECT_THUMBNAIL` Item is rendered in a "thumbnail" representation so that it can be displayed in a browsing tool.  
  
-   `DVASPECT_ICON` Item is represented by an icon.  
  
-   `DVASPECT_DOCPRINT` Item is represented as if it were printed using the Print command from the File menu.  
  
## Remarks  
 If a container item is linked to the document with an automatic link, the item is updated to reflect the changes. In container applications written using the Microsoft Foundation Class Library, [COleClientItem::OnChange](../vs140/coleclientitem--onchange.md) is called in response.  
  
## Requirements  
 **Header:** afxole.h  
  
## See Also  
 [COleServerItem Class](../vs140/coleserveritem-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [COleClientItem::OnChange](../vs140/coleclientitem--onchange.md)   
 [COleServerItem::OnUpdate](../vs140/coleserveritem--onupdate.md)   
 [COleServerDoc::NotifyChanged](../vs140/coleserverdoc--notifychanged.md)