---
title: "CArray::GetUpperBound"
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
  - "CArray.GetUpperBound"
  - "CArray::GetUpperBound"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "GetUpperBound method"
  - "CArray class, attributes"
ms.assetid: fa9a5309-4df7-44c4-9cfd-edc2495d45dc
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CArray::GetUpperBound
Returns the current upper bound of this array.  
  
## Syntax  
  
```  
  
INT_PTR GetUpperBound( ) const;  
```  
  
## Remarks  
 Because array indexes are zero-based, this function returns a value 1 less than `GetSize`.  
  
 The condition **GetUpperBound( )** = –1 indicates that the array contains no elements.  
  
## Example  
 See the example for [CArray::GetAt](../vs140/carray--getat.md).  
  
## Requirements  
 **Header:** afxtempl.h  
  
## See Also  
 [CArray Class](../vs140/carray-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CArray::GetSize](../vs140/carray--getsize.md)   
 [CArray::SetSize](../vs140/carray--setsize.md)