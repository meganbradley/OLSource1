---
title: "CArray::SetAtGrow"
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
  - CArray::SetAtGrow
  - CArray.SetAtGrow
dev_langs: 
  - C++
helpviewer_keywords: 
  - CArray class, growing the array
  - SetAtGrow method
ms.assetid: eb62b6d5-7b7c-4c84-bad5-04ba0ea7f935
caps.latest.revision: 15
robots: noindex,nofollow
translation.priority.ht: 
  - de-de
  - ja-jp
---
# CArray::SetAtGrow
Sets the array element at the specified index.  
  
## Syntax  
  
```  
  
      void SetAtGrow(  
   INT_PTR nIndex,  
   ARG_TYPE newElement   
);  
```  
  
#### Parameters  
 `nIndex`  
 An integer index that is greater than or equal to 0.  
  
 `ARG_TYPE`  
 Template parameter specifying the type of elements in the array.  
  
 `newElement`  
 The element to be added to this array. A **NULL** value is allowed.  
  
## Remarks  
 The array grows automatically if necessary (that is, the upper bound is adjusted to accommodate the new element).  
  
## Example  
 [!code[NVC_MFCCollections#33](../vs140/codesnippet/CPP/carray--setatgrow_1.cpp)]
  
  
## Requirements  
 **Header:** afxtempl.h  
  
## See Also  
 [CArray Class](../vs140/carray-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CArray::GetAt](../vs140/carray--getat.md)   
 [CArray::SetAt](../vs140/carray--setat.md)   
 [CArray::ElementAt](../vs140/carray--elementat.md)   
 [CArray::operator](../vs140/carray--operator.md)