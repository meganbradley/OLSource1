---
title: "COleServerItem::GetDocument"
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
  - "COleServerItem.GetDocument"
  - "COleServerItem::GetDocument"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "COleServerItem class, status"
  - "GetDocument method"
ms.assetid: b7bb0be5-233d-4998-b78f-f5e1a3136dd1
caps.latest.revision: 14
author: ""
ms.author: ""
manager: ""
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# COleServerItem::GetDocument
Call this function to get a pointer to the document that contains the item.  
  
## Syntax  
  
```  
  
COleServerDoc* GetDocument( ) const;  
```  
  
## Return Value  
 A pointer to the document that contains the item; **NULL** if the item is not part of a document.  
  
## Remarks  
 This allows access to the server document that you passed as an argument to the `COleServerItem` constructor.  
  
## Requirements  
 **Header:** afxole.h  
  
## See Also  
 [COleServerItem Class](../vs140/coleserveritem-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [COleServerItem::COleServerItem](../vs140/coleserveritem--coleserveritem.md)   
 [COleServerDoc Class](../vs140/coleserverdoc-class.md)