---
title: "CList::GetNext"
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
  - CList.GetNext
  - CList::GetNext
dev_langs: 
  - C++
helpviewer_keywords: 
  - CList class, iteration
  - GetNext method
ms.assetid: 63037e91-9b2b-4871-b7e5-588fa4e2c819
caps.latest.revision: 15
robots: noindex,nofollow
translation.priority.ht: 
  - de-de
  - ja-jp
---
# CList::GetNext
Gets the list element identified by `rPosition`, then sets `rPosition` to the **POSITION** value of the next entry in the list.  
  
## Syntax  
  
```  
  
      TYPE  
      & GetNext(  
   POSITION& rPosition   
);  
const TYPE& GetNext(   
   POSITION& rPosition    
) const;  
```  
  
#### Parameters  
 *TYPE*  
 Template parameter specifying the type of the elements in the list.  
  
 `rPosition`  
 A reference to a **POSITION** value returned by a previous `GetNext`, [GetHeadPosition](../vs140/clist--getheadposition.md), or other member function call.  
  
## Return Value  
 If the list is **const**, `GetNext` returns a copy of an element of the list. This allows the function to be used only on the right side of an assignment statement and protects the list from modification.  
  
 If the list is not **const**, `GetNext` returns a reference to an element of the list. This allows the function to be used on either side of an assignment statement and thus allows the list entries to be modified.  
  
## Remarks  
 You can use `GetNext` in a forward iteration loop if you establish the initial position with a call to `GetHeadPosition` or **Find**.  
  
 You must ensure that your **POSITION** value represents a valid position in the list. If it is invalid, then the Debug version of the Microsoft Foundation Class Library asserts.  
  
 If the retrieved element is the last in the list, then the new value of `rPosition` is set to **NULL**.  
  
## Example  
 [!code[NVC_MFCCollections#43](../vs140/codesnippet/CPP/clist--getnext_1.cpp)]
  
  
## Requirements  
 **Header:** afxtempl.h  
  
## See Also  
 [CList Class](../vs140/clist-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CList::Find](../vs140/clist--find.md)   
 [CList::GetHeadPosition](../vs140/clist--getheadposition.md)   
 [CList::GetTailPosition](../vs140/clist--gettailposition.md)   
 [CList::GetPrev](../vs140/clist--getprev.md)   
 [CList::GetHead](../vs140/clist--gethead.md)