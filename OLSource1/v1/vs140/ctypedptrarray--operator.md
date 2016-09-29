---
title: "CTypedPtrArray::operator"
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
  - "CTypedPtrArray::operator[]"
  - "CTypedPtrArray.operator[]"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "operator [], arrays"
  - "[] operator"
  - "operator[], arrays"
ms.assetid: ef5231a0-e41d-4c29-93a1-b7c2b3bc1f36
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CTypedPtrArray::operator
These inline operators call `BASE_CLASS`**::operator [ ]**.  
  
## Syntax  
  
```  
  
      TYPE  
      & operator[ ](INT_PTR nIndex);  
TYPE operator[ ](INT_PTR nIndex) const;  
```  
  
#### Parameters  
 *TYPE*  
 Template parameter specifying the type of elements stored in the array.  
  
 `nIndex`  
 An integer index that is greater than or equal to 0 and less than or equal to the value returned by `BASE_CLASS`**::GetUpperBound**.  
  
## Remarks  
 The first operator, called for arrays that are not **const**, can be used on either the right (r-value) or the left (l-value) of an assignment statement. The second, invoked for **const** arrays, can be used only on the right.  
  
 The Debug version of the library asserts if the subscript (either on the left or right side of an assignment statement) is out of bounds.  
  
## Requirements  
 **Header:** afxtempl.h  
  
## See Also  
 [CTypedPtrArray Class](../vs140/ctypedptrarray-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CObArray::operator](../vs140/cobarray--operator.md)