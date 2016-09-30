---
title: "CArray::RemoveAt"
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
  - "CArray.RemoveAt"
  - "CArray::RemoveAt"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "CArray class, insertion/removal"
  - "RemoveAt method"
ms.assetid: 27c8d85a-b8b8-4aed-bb23-97e92b06f3e9
caps.latest.revision: 15
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CArray::RemoveAt
Removes one or more elements starting at a specified index in an array.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 An integer index that is greater than or equal to 0 and less than or equal to the value returned by [GetUpperBound](../vs140/carray--getupperbound.md).  
  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 The number of elements to remove.  
  
## Remarks  
 In the process, it shifts down all the elements above the removed element(s). It decrements the upper bound of the array but does not free memory.  
  
 If you try to remove more elements than are contained in the array above the removal point, then the Debug version of the library asserts.  
  
## Example  
 [!code[NVC_MFCCollections#32](../vs140/codesnippet/CPP/carray--removeat_1.cpp)]  
  
## Requirements  
 **Header:** afxtempl.h  
  
## See Also  
 [CArray Class](../vs140/carray-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CArray::SetAt](../vs140/carray--setat.md)   
 [CArray::SetAtGrow](../vs140/carray--setatgrow.md)   
 [CArray::InsertAt](../vs140/carray--insertat.md)