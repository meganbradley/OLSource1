---
title: "CObList::InsertAfter"
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
  - "CObList.InsertAfter"
  - "InsertAfter"
  - "CObList::InsertAfter"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "CObList class, insertion"
  - "InsertAfter method"
ms.assetid: 6b7258b1-467d-45b7-ba89-0fdbc01d5f4b
caps.latest.revision: 18
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CObList::InsertAfter
Adds an element to this list after the element at the specified position.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 *position*  
 A **POSITION** value returned by a previous <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>, or **Find** member function call.  
  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 The object pointer to be added to this list.  
  
 The following table shows other member functions that are similar to <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>.  
  
|Class|Member Function|  
|-----------|---------------------|  
|[CPtrList](../vs140/cptrlist-class.md)|**POSITION InsertAfter( POSITION**  *position* **, void\***  <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  **);**|  
|[CStringList](../vs140/cstringlist-class.md)|**POSITION InsertAfter( POSITION**  *position* **, const CString&**  <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>  **);**\<br />\<br /> **POSITION InsertAfter( POSITION**  *position* **, LPCTSTR**  <CodeContentPlaceHolder>7\</CodeContentPlaceHolder>  **);**|  
  
## Return Value  
 A **POSITION** value which is the same as the *position* parameter.  
  
## Example  
 See [CObList::CObList](../vs140/coblist--coblist.md) for a listing of the <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> class.  
  
 [!code[NVC_MFCCollections#103](../vs140/codesnippet/CPP/coblist--insertafter_1.cpp)]  
  
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
 [CObList::InsertBefore](../vs140/coblist--insertbefore.md)