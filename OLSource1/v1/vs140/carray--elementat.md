---
title: "CArray::ElementAt"
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
  - "CArray::ElementAt"
  - "CArray.ElementAt"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "CArray class, element access"
  - "ElementAt method"
ms.assetid: 2daccef9-0bfe-473f-a302-a350db717c5a
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CArray::ElementAt
Returns a temporary reference to the specified element within the array.  
  
## Syntax  
  
```  
  
      TYPE& ElementAt(  
   INT_PTR nIndex   
);  
const TYPE& ElementAt(   
   INT_PTR nIndex  
) const;  
```  
  
#### Parameters  
 `nIndex`  
 An integer index that is greater than or equal to 0 and less than or equal to the value returned by [GetUpperBound](../vs140/carray--getupperbound.md).  
  
## Return Value  
 A reference to an array element.  
  
## Remarks  
 It is used to implement the left-side assignment operator for arrays.  
  
## Example  
 See the example for [GetSize](../vs140/carray--getsize.md).  
  
## Requirements  
 **Header:** afxtempl.h  
  
## See Also  
 [CArray Class](../vs140/carray-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CArray::operator](../vs140/carray--operator.md)