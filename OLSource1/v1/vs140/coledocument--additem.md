---
title: "COleDocument::AddItem"
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
  - "COleDocument::AddItem"
  - "AddItem"
  - "COleDocument.AddItem"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "AddItem method"
  - "COleDocument class, operations"
ms.assetid: 50596791-1bd4-4336-b0bb-e317861d8372
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# COleDocument::AddItem
Call this function to add an item to the document.  
  
## Syntax  
  
```  
  
      virtual void AddItem(  
   CDocItem* pItem   
);  
```  
  
#### Parameters  
 `pItem`  
 Pointer to the document item being added.  
  
## Remarks  
 You do not need to call this function explicitly when it is called by the `COleClientItem` or `COleServerItem` constructor that accepts a pointer to a document.  
  
## Requirements  
 **Header:** afxole.h  
  
## See Also  
 [COleDocument Class](../vs140/coledocument-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CDocItem Class](../vs140/cdocitem-class.md)   
 [COleDocument::RemoveItem](../vs140/coledocument--removeitem.md)   
 [COleServerItem::COleServerItem](../vs140/coleserveritem--coleserveritem.md)   
 [COleClientItem::COleClientItem](../vs140/coleclientitem--coleclientitem.md)