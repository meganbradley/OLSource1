---
title: "COleServerItem::IsConnected"
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
  - COleServerItem::IsConnected
  - IsConnected
  - COleServerItem.IsConnected
dev_langs: 
  - C++
helpviewer_keywords: 
  - COleServerItem class, status
  - IsConnected method
ms.assetid: b2888a50-472b-4e31-a074-b1d0ad95bca3
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - de-de
  - ja-jp
---
# COleServerItem::IsConnected
Call this function to see if the OLE item is connected.  
  
## Syntax  
  
```  
  
BOOL IsConnected( ) const;  
```  
  
## Return Value  
 Nonzero if the item is connected; otherwise 0.  
  
## Remarks  
 An OLE item is considered connected if one or more containers have references to the item. An item is connected if its reference count is greater than 0 or if it is an embedded item.  
  
## Requirements  
 **Header:** afxole.h  
  
## See Also  
 [COleServerItem Class](../vs140/coleserveritem-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [COleServerItem::IsLinkedItem](../vs140/coleserveritem--islinkeditem.md)   
 [COleLinkingDoc::OnGetLinkedItem](../vs140/colelinkingdoc--ongetlinkeditem.md)