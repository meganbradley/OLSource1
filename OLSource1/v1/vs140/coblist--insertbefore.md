---
title: "CObList::InsertBefore"
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
  - "CObList::InsertBefore"
  - "InsertBefore"
  - "CObList.InsertBefore"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "CObList class, insertion"
  - "InsertBefore method"
ms.assetid: 2671907d-5034-4c94-b531-23bc1c4ba4e4
caps.latest.revision: 17
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CObList::InsertBefore
Adds an element to this list before the element at the specified position.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 *position*  
 A **POSITION** value returned by a previous <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>, or **Find** member function call.  
  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 The object pointer to be added to this list.  
  
## Return Value  
 A **POSITION** value that can be used for iteration or object pointer retrieval; **NULL** if the list is empty.  
  
 The following table shows other member functions that are similar to <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>.  
  
|Class|Member Function|  
|-----------|---------------------|  
|[CPtrList](../vs140/cptrlist-class.md)|**POSITION InsertBefore( POSITION**  *position* **, void\***  <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  **);**|  
|[CStringList](../vs140/cstringlist-class.md)|**POSITION InsertBefore( POSITION**  *position* **, const CString&**  <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>  **);**\<br />\<br /> **POSITION InsertBefore( POSITION**  *position* **, LPCTSTR**  <CodeContentPlaceHolder>7\</CodeContentPlaceHolder>  **);**|  
  
## Example  
 See [CObList::CObList](../vs140/coblist--coblist.md) for a listing of the <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> class.  
  
 [!code[NVC_MFCCollections#104](../vs140/codesnippet/CPP/coblist--insertbefore_1.cpp)]  
  
 The results from this program are as follows:  
  
 <CodeContentPlaceHolder>9\</CodeContentPlaceHolder>  
  
 <CodeContentPlaceHolder>10\</CodeContentPlaceHolder>  
  
 <CodeContentPlaceHolder>11\</CodeContentPlaceHolder>  
  
 <CodeContentPlaceHolder>12\</CodeContentPlaceHolder>  
  
## Requirements  
 **Header:** afxcoll.h  
  
## See Also  
 [CObList Class](../vs140/coblist-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CObList::Find](../vs140/coblist--find.md)   
 [CObList::InsertAfter](../vs140/coblist--insertafter.md)