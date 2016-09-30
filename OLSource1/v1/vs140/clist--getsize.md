---
title: "CList::GetSize"
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
  - "CList::GetSize"
  - "CList.GetSize"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "GetSize method"
ms.assetid: 7c421ac1-45ee-4503-a490-0beb5a56d52c
caps.latest.revision: 17
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CList::GetSize
Returns the number of list elements.  
  
## Syntax  
  
```  
  
INT_PTR GetSize( ) const;  
```  
  
## Return Value  
 The number of items in the list.  
  
## Remarks  
 Call this method to retrieve the number of elements in the list.  Calling this method will generate the same result as the [CList::GetCount](../vs140/clist--getcount.md) method.  
  
## Example  
 [!code[NVC_MFCCollections#45](../vs140/codesnippet/CPP/clist--getsize_1.cpp)]  
  
## Requirements  
 **Header:** afxtempl.h  
  
## See Also  
 [CList Class](../vs140/clist-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CList::GetCount](../vs140/clist--getcount.md)