---
title: "CArray::SetSize"
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
  - CArray.SetSize
  - CArray::SetSize
dev_langs: 
  - C++
helpviewer_keywords: 
  - SetSize method
  - CArray class, attributes
ms.assetid: fcb31f5b-2aa5-4251-97b7-f00557e08592
caps.latest.revision: 15
robots: noindex,nofollow
translation.priority.ht: 
  - de-de
  - ja-jp
---
# CArray::SetSize
Establishes the size of an empty or existing array; allocates memory if necessary.  
  
## Syntax  
  
```  
  
      void SetSize(  
   INT_PTR nNewSize,  
   INT_PTR nGrowBy = -1   
);  
```  
  
#### Parameters  
 `nNewSize`  
 The new array size (number of elements). Must be greater than or equal to 0.  
  
 `nGrowBy`  
 The minimum number of element slots to allocate if a size increase is necessary.  
  
## Remarks  
 If the new size is smaller than the old size, then the array is truncated and all unused memory is released.  
  
 Use this function to set the size of your array before you begin using the array. If you do not use `SetSize`, adding elements to your array causes it to be frequently reallocated and copied. Frequent reallocation and copying are inefficient and can fragment memory.  
  
 The `nGrowBy` parameter affects internal memory allocation while the array is growing. Its use never affects the array size as reported by [GetSize](../vs140/carray--getsize.md) and [GetUpperBound](../vs140/carray--getupperbound.md). If the default value is used, MFC allocates memory in a way calculated to avoid memory fragmentation and optimize efficiency for most cases.  
  
## Example  
 See the example for [GetData](../vs140/carray--getdata.md).  
  
## Requirements  
 **Header:** afxtempl.h  
  
## See Also  
 [CArray Class](../vs140/carray-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CArray::GetUpperBound](../vs140/carray--getupperbound.md)   
 [CArray::GetSize](../vs140/carray--getsize.md)   
 [CArray::GetCount](../vs140/carray--getcount.md)