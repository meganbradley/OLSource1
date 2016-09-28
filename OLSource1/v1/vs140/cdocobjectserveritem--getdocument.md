---
title: "CDocObjectServerItem::GetDocument"
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
  - "CDocObjectServerItem::GetDocument"
  - "CDocObjectServerItem.GetDocument"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "GetDocument method"
ms.assetid: 32ea1efc-cc0d-4c85-8af4-fa12149ffbf0
caps.latest.revision: 14
author: ""
ms.author: ""
manager: ""
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CDocObjectServerItem::GetDocument
Retrieves a pointer to the document that contains the item.  
  
## Syntax  
  
```  
  
COleServerDoc* GetDocument( ) const;  
  
```  
  
## Return Value  
 A pointer to the document that contains the item; **NULL** if the item is not part of a document.  
  
## Remarks  
 This allows access to the server document that you passed as an argument to the [CDocObjectServerItem](../vs140/cdocobjectserveritem--cdocobjectserveritem.md) constructor.  
  
## Requirements  
 **Header:** afxdocob.h  
  
## See Also  
 [CDocObjectServerItem Class](../vs140/cdocobjectserveritem-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CDocObjectServer Class](../vs140/cdocobjectserver-class.md)