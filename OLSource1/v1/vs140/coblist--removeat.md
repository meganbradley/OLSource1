---
title: "CObList::RemoveAt"
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
  - "CObList::RemoveAt"
  - "CObList.RemoveAt"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "CObList class, retrieval/modification"
  - "RemoveAt method"
ms.assetid: 7dc6cf18-d01d-45f5-b5e2-2f17aa0511a8
caps.latest.revision: 16
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CObList::RemoveAt
Removes the specified element from this list.  
  
## Syntax  
  
```  
  
      void RemoveAt(  
   POSITION position   
);  
```  
  
#### Parameters  
 *position*  
 The position of the element to be removed from the list.  
  
## Remarks  
 When you remove an element from a `CObList`, you remove the object pointer from the list. It is your responsibility to delete the objects themselves.  
  
 You must ensure that your **POSITION** value represents a valid position in the list. If it is invalid, then the Debug version of the Microsoft Foundation Class Library asserts.  
  
 The following table shows other member functions that are similar to `CObList::RemoveAt`.  
  
|Class|Member Function|  
|-----------|---------------------|  
|[CPtrList](../vs140/cptrlist-class.md)|**void RemoveAt( POSITION**  *position*  **);**|  
|[CStringList](../vs140/cstringlist-class.md)|**void RemoveAt( POSITION**  *position*  **);**|  
  
## Example  
 Be careful when removing an element during a list iteration. The following example shows a removal technique that guarantees a valid **POSITION** value for [GetNext](../vs140/coblist--getnext.md).  
  
 See [CObList::CObList](../vs140/coblist--coblist.md) for a listing of the `CAge` class.  
  
 [!code[NVC_MFCCollections#106](../vs140/codesnippet/CPP/coblist--removeat_1.cpp)]  
  
 The results from this program are as follows:  
  
 `RemoveAt example: A CObList with 2 elements`  
  
 `a CAge at $4C1E 65`  
  
 `a CAge at $4B22 21`  
  
## Requirements  
 **Header:** afxcoll.h  
  
## See Also  
 [CObList Class](../vs140/coblist-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)