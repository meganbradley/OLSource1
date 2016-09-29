---
title: "COleServerItem::OnQueryUpdateItems"
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
  - "OnQueryUpdateItems"
  - "COleServerItem::OnQueryUpdateItems"
  - "COleServerItem.OnQueryUpdateItems"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "OnQueryUpdateItems method"
  - "COleServerItem class, overridables"
ms.assetid: 73793692-dafd-49b8-a04d-d0a01199d7bb
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# COleServerItem::OnQueryUpdateItems
Called by the framework to determine whether any linked items in the current server document are out of date.  
  
## Syntax  
  
```  
  
virtual BOOL OnQueryUpdateItems( );  
```  
  
## Return Value  
 Nonzero if the document has items needing updates; 0 if all items are up to date.  
  
## Remarks  
 An item is out of date if its source document has been changed but the linked item has not been updated to reflect the changes in the document.  
  
## Requirements  
 **Header:** afxole.h  
  
## See Also  
 [COleServerItem Class](../vs140/coleserveritem-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [COleServerItem::OnUpdate](../vs140/coleserveritem--onupdate.md)   
 [COleServerItem::OnUpdateItems](../vs140/coleserveritem--onupdateitems.md)