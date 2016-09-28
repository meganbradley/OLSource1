---
title: "CComSafeArray::operator"
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
  - "CComSafeArray::operator[]"
  - "CComSafeArray.operator[]"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "operator [], arrays"
  - "[] operator"
  - "operator[], arrays"
ms.assetid: 701b3117-4e34-4076-b9fe-63f244bd5215
caps.latest.revision: 14
author: ""
ms.author: ""
manager: ""
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CComSafeArray::operator
Retrieves an element from the array.  
  
## Syntax  
  
```  
  
      T & operator [](LONG lIndex) const;  
T & operator [](int nIndex) const;  
```  
  
#### Parameters  
 *lIndex, nIndex*  
 The index number of the required element in the array.  
  
## Return Value  
 Returns the appropriate array element.  
  
## Remarks  
 Performs a similar function to [CComSafeArray::GetAt](../vs140/ccomsafearray--getat.md), however this operator only works with single-dimensional arrays.  
  
## Requirements  
 **Header:** atlsafe.h  
  
## See Also  
 [CComSafeArray Class](../vs140/ccomsafearray-class.md)   
 [CComSafeArray::GetAt](../vs140/ccomsafearray--getat.md)