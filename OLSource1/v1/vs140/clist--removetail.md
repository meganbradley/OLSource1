---
title: "CList::RemoveTail"
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
  - "CList::RemoveTail"
  - "CList.RemoveTail"
  - "RemoveTail"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "RemoveTail method"
  - "CList class, operations"
ms.assetid: 5a2c6c8e-f785-4ac1-9a68-f293f07d6ef7
caps.latest.revision: 15
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CList::RemoveTail
Removes the element from the tail of the list and returns a pointer to it.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 *TYPE*  
 Template parameter specifying the type of elements in the list.  
  
## Return Value  
 The element that was at the tail of the list.  
  
## Remarks  
 You must ensure that the list is not empty before calling <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>. If the list is empty, then the Debug version of the Microsoft Foundation Class Library asserts. Use [IsEmpty](../vs140/clist--isempty.md) to verify that the list contains elements.  
  
## Example  
 [!code[NVC_MFCCollections#54](../vs140/codesnippet/CPP/clist--removetail_1.cpp)]  
  
## Requirements  
 **Header:** afxtempl.h  
  
## See Also  
 [CList Class](../vs140/clist-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CList::GetTail](../vs140/clist--gettail.md)   
 [CList::AddTail](../vs140/clist--addtail.md)