---
title: "COleDocument::RemoveItem"
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
  - RemoveItem
  - COleDocument.RemoveItem
  - COleDocument::RemoveItem
dev_langs: 
  - C++
helpviewer_keywords: 
  - RemoveItem method
  - COleDocument class, operations
ms.assetid: ee245182-1bbb-4ed0-bdad-2c647a484a0b
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - de-de
  - ja-jp
---
# COleDocument::RemoveItem
Call this function to remove an item from the document.  
  
## Syntax  
  
```  
  
      virtual void RemoveItem(  
   CDocItem* pItem   
);  
```  
  
#### Parameters  
 `pItem`  
 Pointer to the document item to be removed.  
  
## Remarks  
 You typically do not need to call this function explicitly; it is called by the destructors for `COleClientItem` and `COleServerItem`.  
  
## Requirements  
 **Header:** afxole.h  
  
## See Also  
 [COleDocument Class](../vs140/coledocument-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [COleServerItem Class](../vs140/coleserveritem-class.md)   
 [COleClientItem Class](../vs140/coleclientitem-class.md)   
 [COleDocument::AddItem](../vs140/coledocument--additem.md)   
 [CDocItem Class](../vs140/cdocitem-class.md)