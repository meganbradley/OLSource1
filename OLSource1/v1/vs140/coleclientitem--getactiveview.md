---
title: "COleClientItem::GetActiveView"
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
  - "COleClientItem.GetActiveView"
  - "COleClientItem::GetActiveView"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "GetActiveView method"
  - "COleClientItem class, status"
ms.assetid: c301e7df-60e9-4cc9-8d0c-f8f89aa5e1ab
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# COleClientItem::GetActiveView
Returns the view on which the item is in-place activated.  
  
## Syntax  
  
```  
  
CView* GetActiveView( ) const;  
```  
  
## Return Value  
 A pointer to the view; otherwise **NULL** if the item is not in-place activated.  
  
## Requirements  
 **Header:** afxole.h  
  
## See Also  
 [COleClientItem Class](../vs140/coleclientitem-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [COleClientItem::IsInPlaceActive](../vs140/coleclientitem--isinplaceactive.md)   
 [COleClientItem::GetDocument](../vs140/coleclientitem--getdocument.md)