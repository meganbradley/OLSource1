---
title: "CTypedPtrList::RemoveTail"
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
  - "CTypedPtrList.RemoveTail"
  - "CTypedPtrList::RemoveTail"
  - "RemoveTail"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "RemoveTail method"
ms.assetid: 4bb352cf-437f-4e8b-96f2-62b49a659817
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CTypedPtrList::RemoveTail
Removes the element from the tail of the list and returns it.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 *TYPE*  
 Template parameter specifying the type of elements stored in the list.  
  
## Return Value  
 The pointer previously at the tail of the list. This pointer is of the type specified by the template parameter *TYPE*.  
  
## Remarks  
 You must ensure that the list is not empty before calling <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>. If the list is empty, then the Debug version of the Microsoft Foundation Class Library asserts. Use [IsEmpty](../vs140/coblist--isempty.md) to verify that the list contains elements.  
  
## Requirements  
 **Header:** afxtempl.h  
  
## See Also  
 [CTypedPtrList Class](../vs140/ctypedptrlist-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CTypedPtrList::RemoveHead](../vs140/ctypedptrlist--removehead.md)   
 [CObList::IsEmpty](../vs140/coblist--isempty.md)   
 [CObList::GetTail](../vs140/coblist--gettail.md)   
 [CObList::AddTail](../vs140/coblist--addtail.md)