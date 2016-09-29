---
title: "CList::GetCount"
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
  - "CList.GetCount"
  - "CList::GetCount"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "GetCount method [MFC]"
  - "CList class, status"
ms.assetid: 839f78f3-905f-417b-903c-8f738d0ddf94
caps.latest.revision: 16
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CList::GetCount
Gets the number of elements in this list.  
  
## Syntax  
  
```  
  
INT_PTR GetCount() const;  
```  
  
## Return Value  
 An integer value containing the element count.  
  
## Remarks  
 Calling this method will generate the same result as the [CList::GetSize](../vs140/clist--getsize.md) method.  
  
## Example  
 See the example for [CList::RemoveHead](../vs140/clist--removehead.md).  
  
## Requirements  
 **Header:** afxtempl.h  
  
## See Also  
 [CList Class](../vs140/clist-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CList::IsEmpty](../vs140/clist--isempty.md)   
 [CList::GetSize](../vs140/clist--getsize.md)