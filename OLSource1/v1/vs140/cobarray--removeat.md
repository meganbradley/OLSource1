---
title: "CObArray::RemoveAt"
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
  - CObArray::RemoveAt
  - CObArray.RemoveAt
dev_langs: 
  - C++
helpviewer_keywords: 
  - CObArray class, insertion/removal
  - RemoveAt method
ms.assetid: 77597227-03e5-462b-b828-e2a9278f5345
caps.latest.revision: 15
robots: noindex,nofollow
translation.priority.ht: 
  - de-de
  - ja-jp
---
# CObArray::RemoveAt
Removes one or more elements starting at a specified index in an array.  
  
## Syntax  
  
```  
  
      void RemoveAt(  
   INT_PTR nIndex,  
   INT_PTR nCount = 1   
);  
```  
  
#### Parameters  
 `nIndex`  
 An integer index that is greater than or equal to 0 and less than or equal to the value returned by `GetUpperBound`.  
  
 `nCount`  
 The number of elements to remove.  
  
## Remarks  
 In the process, it shifts down all the elements above the removed element(s). It decrements the upper bound of the array but does not free memory.  
  
 If you try to remove more elements than are contained in the array above the removal point, then the Debug version of the library asserts.  
  
 The `RemoveAt` function removes the `CObject` pointer from the array, but it does not delete the object itself.  
  
 The following table shows other member functions that are similar to `CObArray::RemoveAt`.  
  
|Class|Member Function|  
|-----------|---------------------|  
|[CByteArray](../vs140/cbytearray-class.md)|**void RemoveAt( INT_PTR**  `nIndex` **, INT_PTR**  `nCount`  **= 1 );**|  
|[CDWordArray](../vs140/cdwordarray-class.md)|**void RemoveAt( INT_PTR**  `nIndex` **, INT_PTR**  `nCount`  **= 1 );**|  
|[CPtrArray](../vs140/cptrarray-class.md)|**void RemoveAt( INT_PTR**  `nIndex` **, INT_PTR**  `nCount`  **= 1 );**|  
|[CStringArray](../vs140/cstringarray-class.md)|**void RemoveAt( INT_PTR**  `nIndex` **, INT_PTR**  `nCount`  **= 1 );**|  
|[CUIntArray](../vs140/cuintarray-class.md)|**void RemoveAt( INT_PTR**  `nIndex` **, INT_PTR**  `nCount`  **= 1 );**|  
|[CWordArray](../vs140/cwordarray-class.md)|**void RemoveAt( INT_PTR** `nIndex` **, INT_PTR**  *nCount*  **= 1 );**|  
  
## Example  
 See [CObList::CObList](../vs140/coblist--coblist.md) for a listing of the `CAge` class used in all collection examples.  
  
 [!code[NVC_MFCCollections#112](../vs140/codesnippet/CPP/cobarray--removeat_1.cpp)]
  
  
 The results from this program are as follows:  
  
 `RemoveAt example: A CObArray with 1 elements`  
  
 `[0] = a CAge at $4606 40`  
  
## Requirements  
 **Header:** afxcoll.h  
  
## See Also  
 [CObArray Class](../vs140/cobarray-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CObArray::SetAt](../vs140/cobarray--setat.md)   
 [CObArray::SetAtGrow](../vs140/cobarray--setatgrow.md)   
 [CObArray::InsertAt](../vs140/cobarray--insertat.md)