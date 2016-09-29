---
title: "COleClientItem::IsOpen"
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
  - "IsOpen"
  - "COleClientItem.IsOpen"
  - "COleClientItem::IsOpen"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "COleClientItem class, status"
  - "open state, OLE client items"
  - "OLE items, open state"
  - "IsOpen method"
ms.assetid: d8f5f2b1-c70b-4921-abe3-fe8c2ca4fd97
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# COleClientItem::IsOpen
Call this function to see whether the OLE item is open; that is, opened in an instance of the server application running in a separate window.  
  
## Syntax  
  
```  
  
BOOL IsOpen( ) const;  
```  
  
## Return Value  
 Nonzero if the OLE item is open; otherwise 0.  
  
## Remarks  
 It is used to determine when to draw the object with a hatching pattern. An open object should have a hatch pattern drawn on top of the object. You can use a [CRectTracker](../vs140/crecttracker-class.md) object to accomplish this.  
  
## Requirements  
 **Header:** afxole.h  
  
## See Also  
 [COleClientItem Class](../vs140/coleclientitem-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [COleClientItem::GetItemState](../vs140/coleclientitem--getitemstate.md)   
 [CRectTracker Class](../vs140/crecttracker-class.md)