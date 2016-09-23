---
title: "CObArray::InsertAt"
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
  - CObArray.InsertAt
  - CObArray::InsertAt
dev_langs: 
  - C++
helpviewer_keywords: 
  - InsertAt method
  - CObArray class, insertion/removal
ms.assetid: dab9c3d4-baaf-44e7-b406-1c9eb7799a1b
caps.latest.revision: 17
robots: noindex,nofollow
translation.priority.ht: 
  - de-de
  - ja-jp
---
# CObArray::InsertAt
Inserts an element (or all the elements in another array) at a specified index.  
  
## Syntax  
  
```  
  
      void InsertAt(  
   INT_PTR nIndex,  
   CObject* newElement,  
   INT_PTR nCount = 1   
);  
void InsertAt(  
   INT_PTR nStartIndex,  
   CObArray* pNewArray   
);  
```  
  
#### Parameters  
 `nIndex`  
 An integer index that may be greater than the value returned by `GetUpperBound`.  
  
 `newElement`  
 The `CObject` pointer to be placed in this array. A `newElement` of value **NULL** is allowed.  
  
 `nCount`  
 The number of times this element should be inserted (defaults to 1).  
  
 `nStartIndex`  
 An integer index that may be greater than the value returned by `GetUpperBound`.  
  
 `pNewArray`  
 Another array that contains elements to be added to this array.  
  
## Remarks  
 The first version of `InsertAt` inserts one element (or multiple copies of an element) at a specified index in an array. In the process, it shifts up (by incrementing the index) the existing element at this index, and it shifts up all the elements above it.  
  
 The second version inserts all the elements from another `CObArray` collection, starting at the `nStartIndex` position.  
  
 The `SetAt` function, in contrast, replaces one specified array element and does not shift any elements.  
  
 The following table shows other member functions that are similar to `CObArray::InsertAt`.  
  
|Class|Member Function|  
|-----------|---------------------|  
|[CByteArray](../vs140/cbytearray-class.md)|**void InsertAt( INT_PTR**  `nIndex` **, BYTE**  `newElement` **, int**  `nCount` **= 1 );**<br /><br /> **throw( CMemoryException\* );**<br /><br /> **void InsertAt( INT_PTR**  `nStartIndex` **, CByteArray\***  `pNewArray`  **);**<br /><br /> **throw( CMemoryException\* );**|  
|[CDWordArray](../vs140/cdwordarray-class.md)|**void InsertAt( INT_PTR**  `nIndex` **, DWORD**  `newElement` **, int**  `nCount` **= 1 );**<br /><br /> **throw( CMemoryException\* );**<br /><br /> **void InsertAt( INT_PTR**  `nStartIndex` **, CDWordArray\***  `pNewArray`  **);**<br /><br /> **throw( CMemoryException\* );**|  
|[CPtrArray](../vs140/cptrarray-class.md)|**void InsertAt( INT_PTR**  `nIndex` **, void\***  `newElement` **, int**  `nCount` **= 1 );**<br /><br /> **throw( CMemoryException\* );**<br /><br /> **void InsertAt( INT_PTR**  `nStartIndex` **, CPtrArray\***  `pNewArray`  **);**<br /><br /> **throw( CMemoryException\* );**|  
|[CStringArray](../vs140/cstringarray-class.md)|**void InsertAt( INT_PTR**  `nIndex` **, LPCTSTR**  `newElement` **, int**  `nCount` **= 1 );**<br /><br /> **throw( CMemoryException\* );**<br /><br /> **void InsertAt( INT_PTR**  `nStartIndex` **, CStringArray\***  `pNewArray`  **);**<br /><br /> **throw( CMemoryException\* );**|  
|[CUIntArray](../vs140/cuintarray-class.md)|**void InsertAt( INT_PTR**  `nIndex` **, UINT**  `newElement` **, int**  `nCount` **= 1 );**<br /><br /> **throw( CMemoryException\* );**<br /><br /> **void InsertAt( INT_PTR**  `nStartIndex` **, CUIntArray\***  `pNewArray`  **);**<br /><br /> **throw( CMemoryException\* );**|  
|[CWordArray](../vs140/cwordarray-class.md)|**void InsertAt( INT_PTR**  `nIndex` **, WORD**  `newElement` **, int**  `nCount` **= 1 );**<br /><br /> **throw( CMemoryException\* );**<br /><br /> **void InsertAt( INT_PTR**  `nStartIndex` **, CWordArray\***  `pNewArray`  **);**<br /><br /> **throw( CMemoryException\* );**|  
  
## Example  
 See [CObList::CObList](../vs140/coblist--coblist.md) for a listing of the `CAge` class used in all collection examples.  
  
 [!code[NVC_MFCCollections#84](../vs140/codesnippet/CPP/cobarray--insertat_1.cpp)]
  
  
 The results from this program are as follows:  
  
 `InsertAt example: A CObArray with 3 elements`  
  
 `[0] = a CAge at $45C8 21`  
  
 `[1] = a CAge at $4646 30`  
  
 `[2] = a CAge at $4606 40`  
  
## Requirements  
 **Header:** afxcoll.h  
  
## See Also  
 [CObArray Class](../vs140/cobarray-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CObArray::SetAt](../vs140/cobarray--setat.md)   
 [CObArray::RemoveAt](../vs140/cobarray--removeat.md)