---
title: "COleServerItem::OnUpdateItems"
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
  - "COleServerItem::OnUpdateItems"
  - "OnUpdateItems"
  - "COleServerItem.OnUpdateItems"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "OnUpdateItems method"
  - "COleServerItem class, overridables"
ms.assetid: f7f61a27-f1a3-4527-98f7-f524dcbb0114
caps.latest.revision: 14
author: ""
ms.author: ""
manager: ""
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# COleServerItem::OnUpdateItems
Called by the framework to update all items in the server document.  
  
## Syntax  
  
```  
  
virtual void OnUpdateItems( );  
```  
  
## Remarks  
 The default implementation calls [UpdateLink](../vs140/coleclientitem--updatelink.md) for all `COleClientItem` objects in the document.  
  
## Requirements  
 **Header:** afxole.h  
  
## See Also  
 [COleServerItem Class](../vs140/coleserveritem-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [COleServerItem::OnUpdate](../vs140/coleserveritem--onupdate.md)   
 [COleServerItem::OnQueryUpdateItems](../vs140/coleserveritem--onqueryupdateitems.md)