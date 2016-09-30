---
title: "CArray::SetAt"
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
  - "CArray.SetAt"
  - "CArray::SetAt"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "CArray class, element access"
  - "SetAt method"
ms.assetid: 1b5a4f09-ea42-4ba0-b88d-75d7339b463e
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CArray::SetAt
Sets the array element at the specified index.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 An integer index that is greater than or equal to 0 and less than or equal to the value returned by [GetUpperBound](../vs140/carray--getupperbound.md).  
  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 Template parameter specifying the type of arguments used for referencing array elements.  
  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 The new element value to be stored at the specified position.  
  
## Remarks  
 <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> will not cause the array to grow. Use [SetAtGrow](../vs140/carray--setatgrow.md) if you want the array to grow automatically.  
  
 You must ensure that your index value represents a valid position in the array. If it is out of bounds, then the Debug version of the library asserts.  
  
## Example  
 See the example for [GetAt](../vs140/carray--getat.md).  
  
## Requirements  
 **Header:** afxtempl.h  
  
## See Also  
 [CArray Class](../vs140/carray-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CArray::GetAt](../vs140/carray--getat.md)   
 [CArray::SetAtGrow](../vs140/carray--setatgrow.md)   
 [CArray::ElementAt](../vs140/carray--elementat.md)   
 [CArray::operator](../vs140/carray--operator.md)