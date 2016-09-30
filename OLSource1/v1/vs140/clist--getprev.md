---
title: "CList::GetPrev"
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
  - "CList.GetPrev"
  - "GetPrev"
  - "CList::GetPrev"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "CList class, iteration"
  - "GetPrev method"
ms.assetid: 86e941f8-ced9-45d9-b2a1-20e083963396
caps.latest.revision: 15
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CList::GetPrev
Gets the list element identified by <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>, then sets <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> to the **POSITION** value of the previous entry in the list.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 *TYPE*  
 Template parameter specifying the type of the elements in the list.  
  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 A reference to a **POSITION** value returned by a previous <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> or other member function call.  
  
## Return Value  
 If the list is **const**, <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> returns a copy of the element at the head of the list. This allows the function to be used only on the right side of an assignment statement and protects the list from modification.  
  
 If the list is not **const**, <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> returns a reference to an element of the list. This allows the function to be used on either side of an assignment statement and thus allows the list entries to be modified.  
  
## Remarks  
 You can use <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> in a reverse iteration loop if you establish the initial position with a call to <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> or **Find**.  
  
 You must ensure that your **POSITION** value represents a valid position in the list. If it is invalid, then the Debug version of the Microsoft Foundation Class Library asserts.  
  
 If the retrieved element is the first in the list, then the new value of <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> is set to **NULL**.  
  
## Example  
 [!code[NVC_MFCCollections#44](../vs140/codesnippet/CPP/clist--getprev_1.cpp)]  
  
## Requirements  
 **Header:** afxtempl.h  
  
## See Also  
 [CList Class](../vs140/clist-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CList::Find](../vs140/clist--find.md)   
 [CList::GetTailPosition](../vs140/clist--gettailposition.md)   
 [CList::GetHeadPosition](../vs140/clist--getheadposition.md)   
 [CList::GetNext](../vs140/clist--getnext.md)   
 [CList::GetHead](../vs140/clist--gethead.md)