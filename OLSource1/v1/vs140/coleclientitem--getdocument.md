---
title: "COleClientItem::GetDocument"
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
  - "COleClientItem.GetDocument"
  - "COleClientItem::GetDocument"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "GetDocument method"
  - "COleClientItem class, data access"
ms.assetid: 5fc698b9-727f-4eda-8413-53a90e2f462f
caps.latest.revision: 14
author: ""
ms.author: ""
manager: ""
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# COleClientItem::GetDocument
Call this function to get a pointer to the document that contains the OLE item.  
  
## Syntax  
  
```  
  
COleDocument* GetDocument( ) const;  
```  
  
## Return Value  
 A pointer to the document that contains the OLE item. **NULL** if the item is not part of a document.  
  
## Remarks  
 This pointer allows access to the `COleDocument` object that you passed as an argument to the `COleClientItem` constructor.  
  
## Requirements  
 **Header:** afxole.h  
  
## See Also  
 [COleClientItem Class](../vs140/coleclientitem-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [COleClientItem::COleClientItem](../vs140/coleclientitem--coleclientitem.md)   
 [COleDocument Class](../vs140/coledocument-class.md)   
 [COleLinkingDoc Class](../vs140/colelinkingdoc-class.md)