---
title: "CDocObjectServerItem::CDocObjectServerItem"
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
  - "CDocObjectServerItem::CDocObjectServerItem"
  - "CDocObjectServerItem.CDocObjectServerItem"
  - "CDocObjectServerItem"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "CDocObjectServerItem class, constructor"
ms.assetid: 8585d9a3-90ec-4b41-807a-11673aa36b23
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CDocObjectServerItem::CDocObjectServerItem
Constructs a `CDocObjectServerItem` object.  
  
## Syntax  
  
```  
  
      CDocObjectServerItem(  
   COleServerDoc* pServerDoc,  
   BOOL bAutoDelete   
);  
```  
  
#### Parameters  
 `pServerDoc`  
 A pointer to the document that will contain the new DocObject item.  
  
 `bAutoDelete`  
 Indicates whether the object can be deleted when a link to it is released. Set the argument to **FALSE** if the `CDocObjectServerItem` object is an integral part of your document's data. Set it to **TRUE** if the object is a secondary structure used to identify a range in your document's data that can be deleted by the framework.  
  
## Requirements  
 **Header:** afxdocob.h  
  
## See Also  
 [CDocObjectServerItem Class](../vs140/cdocobjectserveritem-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CDocObjectServer Class](../vs140/cdocobjectserver-class.md)