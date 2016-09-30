---
title: "CTypedPtrList::GetNext"
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
  - "CTypedPtrList.GetNext"
  - "CTypedPtrList::GetNext"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "GetNext method"
ms.assetid: 0d2bbeb0-470a-40e6-abba-1857dcdec1f4
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CTypedPtrList::GetNext
Gets the list element identified by <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>, then sets <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> to the **POSITION** value of the next entry in the list.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 *TYPE*  
 Template parameter specifying the type of elements contained in this list.  
  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 A reference to a **POSITION** value returned by a previous <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>, or other member function call.  
  
## Return Value  
 If the list is accessed through a pointer to a **const CTypedPtrList**, then <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> returns a pointer of the type specified by the template parameter *TYPE*. This allows the function to be used only on the right side of an assignment statement and thus protects the list from modification.  
  
 If the list is accessed directly or through a pointer to a <CodeContentPlaceHolder>7\</CodeContentPlaceHolder>, then <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> returns a reference to a pointer of the type specified by the template parameter *TYPE*. This allows the function to be used on either side of an assignment statement and thus allows the list entries to be modified.  
  
## Remarks  
 You can use <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> in a forward iteration loop if you establish the initial position with a call to <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> or [CPtrList::Find](../vs140/coblist--find.md).  
  
 You must ensure that your **POSITION** value represents a valid position in the list. If it is invalid, then the Debug version of the Microsoft Foundation Class Library asserts.  
  
 If the retrieved element is the last in the list, then the new value of <CodeContentPlaceHolder>11\</CodeContentPlaceHolder> is set to **NULL**.  
  
 It is possible to remove an element during an iteration. See the example for [CObList::RemoveAt](../vs140/coblist--removeat.md).  
  
## Requirements  
 **Header:** afxtempl.h  
  
## See Also  
 [CTypedPtrList Class](../vs140/ctypedptrlist-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CObList::Find](../vs140/coblist--find.md)   
 [CObList::GetHeadPosition](../vs140/coblist--getheadposition.md)   
 [CObList::GetTailPosition](../vs140/coblist--gettailposition.md)   
 [CTypedPtrList::GetPrev](../vs140/ctypedptrlist--getprev.md)   
 [CTypedPtrList::GetHead](../vs140/ctypedptrlist--gethead.md)   
 [CTypedPtrList::GetTail](../vs140/ctypedptrlist--gettail.md)