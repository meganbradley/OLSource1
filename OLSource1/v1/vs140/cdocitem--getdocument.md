---
title: "CDocItem::GetDocument"
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
  - "CDocItem::GetDocument"
  - "CDocItem.GetDocument"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "CDocItem class, operations"
  - "GetDocument method"
ms.assetid: 5e0529b3-1223-4b64-9c09-5618288a1090
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CDocItem::GetDocument
Call this function to get the document that contains the item.  
  
## Syntax  
  
```  
  
CDocument* GetDocument( ) const;  
```  
  
## Return Value  
 A pointer to the document that contains the item; **NULL**, if the item is not part of a document.  
  
## Remarks  
 This function is overridden in the derived classes [COleClientItem](../vs140/coleclientitem-class.md) and [COleServerItem](../vs140/coleserveritem-class.md), returning a pointer to either a [COleDocument](../vs140/coledocument-class.md), a [COleLinkingDoc](../vs140/colelinkingdoc-class.md), or a [COleServerDoc](../vs140/coleserverdoc-class.md) object.  
  
## Requirements  
 **Header:** afxole.h  
  
## See Also  
 [CDocItem Class](../vs140/cdocitem-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [COleDocument Class](../vs140/coledocument-class.md)   
 [COleLinkingDoc Class](../vs140/colelinkingdoc-class.md)   
 [COleServerDoc Class](../vs140/coleserverdoc-class.md)   
 [COleClientItem Class](../vs140/coleclientitem-class.md)   
 [COleServerItem Class](../vs140/coleserveritem-class.md)