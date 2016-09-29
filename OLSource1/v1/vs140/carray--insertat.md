---
title: "CArray::InsertAt"
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
  - "CArray.InsertAt"
  - "CArray::InsertAt"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "InsertAt method"
  - "CArray class, insertion/removal"
ms.assetid: 9fb8ab6c-00e5-4a55-b8cf-b854c8c52fa8
caps.latest.revision: 15
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CArray::InsertAt
The first version of `InsertAt` inserts one element (or multiple copies of an element) at a specified index in an array.  
  
## Syntax  
  
```  
  
      void InsertAt(  
   INT_PTR nIndex,  
   ARG_TYPE newElement,  
   INT_PTR nCount = 1   
);  
void InsertAt(  
   INT_PTR nStartIndex,  
   CArray* pNewArray   
);  
```  
  
#### Parameters  
 `nIndex`  
 An integer index that may be greater than the value returned by `GetUpperBound`.  
  
 `ARG_TYPE`  
 Template parameter specifying the type of elements in this array.  
  
 `newElement`  
 The element to be placed in this array.  
  
 `nCount`  
 The number of times this element should be inserted (defaults to 1).  
  
 `nStartIndex`  
 An integer index that may be greater than the value returned by [GetUpperBound](../vs140/carray--getupperbound.md).  
  
 `pNewArray`  
 Another array that contains elements to be added to this array.  
  
## Remarks  
 In the process, it shifts up (by incrementing the index) the existing element at this index, and it shifts up all the elements above it.  
  
 The second version inserts all the elements from another `CArray` collection, starting at the `nStartIndex` position.  
  
 The `SetAt` function, in contrast, replaces one specified array element and does not shift any elements.  
  
## Example  
 [!code[NVC_MFCCollections#30](../vs140/codesnippet/CPP/carray--insertat_1.cpp)]  
  
## Requirements  
 **Header:** afxtempl.h  
  
## See Also  
 [CArray Class](../vs140/carray-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CArray::GetUpperBound](../vs140/carray--getupperbound.md)   
 [CArray::SetAt](../vs140/carray--setat.md)   
 [CArray::RemoveAt](../vs140/carray--removeat.md)