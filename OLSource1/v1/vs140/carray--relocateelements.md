---
title: "CArray::RelocateElements"
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
  - CArray.RelocateElements
  - CArray::RelocateElements
  - RelocateElements
dev_langs: 
  - C++
helpviewer_keywords: 
  - CArray class, relocating elements
  - RelocateElements method
ms.assetid: 0bacb202-afe6-4ca6-9160-3f3acf19cf74
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - de-de
  - ja-jp
---
# CArray::RelocateElements
Relocates data to a new buffer when the array should grow or shrink.  
  
## Syntax  
  
```  
template<class TYPE, class ARG_TYPE>   
AFX_INLINE void CArray<TYPE, ARG_TYPE>::RelocateElements(   
   TYPE* pNewData,  
   const TYPE* pData,  
   INT_PTR nCount   
);  
```  
  
#### Parameters  
 `pNewData`  
 A new buffer for the array of elements.  
  
 `pData`  
 The old array of elements.  
  
 `nCount`  
 Number of elements in the old array.  
  
## Remarks  
 `pNewData` is always large enough to hold all the `pData` elements.  
  
 The [CArray](../vs140/carray-class.md) implementation uses this method to copy the old data to a new buffer when the array should grow or shrink (when [SetSize](../vs140/carray--setsize.md) or [FreeExtra](../vs140/carray--freeextra.md) are called). The default implementation just copies the data.  
  
 For arrays in which an element contains a pointer to one of its own members, or another structure contains a pointer to one of the array elements, the pointers are not updated in plain copy. In this case, you can correct pointers by implementing a specialization of `RelocateElements` with the relevant types. You are also responsible for data copying.  
  
## Requirements  
 **Header:** afxtempl.h  
  
## See Also  
 [CArray::SetSize](../vs140/carray--setsize.md)   
 [CArray::FreeExtra](../vs140/carray--freeextra.md)