---
title: "CObList::SetAt"
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
  - "CObList::SetAt"
  - "CObList.SetAt"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "CObList class, retrieval/modification"
  - "SetAt method"
ms.assetid: 58e705a2-4d90-49a5-b2ec-c7b397ff5d69
caps.latest.revision: 17
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CObList::SetAt
Sets the element at a given position.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 The **POSITION** of the element to be set.  
  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 The <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> pointer to be written to the list.  
  
## Remarks  
 A variable of type **POSITION** is a key for the list. It is not the same as an index, and you cannot operate on a **POSITION** value yourself. <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> writes the <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> pointer to the specified position in the list.  
  
 You must ensure that your **POSITION** value represents a valid position in the list. If it is invalid, then the Debug version of the Microsoft Foundation Class Library asserts.  
  
 The following table shows other member functions that are similar to <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>.  
  
|Class|Member Function|  
|-----------|---------------------|  
|[CPtrList](../vs140/cptrlist-class.md)|**void SetAt( POSITION**  <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> **, const CString&**  <CodeContentPlaceHolder>8\</CodeContentPlaceHolder>  **);**|  
|[CStringList](../vs140/cstringlist-class.md)|**void SetAt( POSITION**  <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> **, LPCTSTR**  <CodeContentPlaceHolder>10\</CodeContentPlaceHolder>  **);**|  
  
## Example  
 See [CObList::CObList](../vs140/coblist--coblist.md) for a listing of the <CodeContentPlaceHolder>11\</CodeContentPlaceHolder> class.  
  
 [!code[NVC_MFCCollections#109](../vs140/codesnippet/CPP/coblist--setat_1.cpp)]  
  
 The results from this program are as follows:  
  
 <CodeContentPlaceHolder>12\</CodeContentPlaceHolder>  
  
 <CodeContentPlaceHolder>13\</CodeContentPlaceHolder>  
  
 <CodeContentPlaceHolder>14\</CodeContentPlaceHolder>  
  
## Requirements  
 **Header:** afxcoll.h  
  
## See Also  
 [CObList Class](../vs140/coblist-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CObList::Find](../vs140/coblist--find.md)   
 [CObList::GetAt](../vs140/coblist--getat.md)   
 [CObList::GetNext](../vs140/coblist--getnext.md)   
 [CObList::GetPrev](../vs140/coblist--getprev.md)