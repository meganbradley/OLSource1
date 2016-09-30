---
title: "CArray::operator"
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
  - "CArray::operator[]"
  - "CArray.operator[]"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "operator [], arrays"
  - "[] operator"
  - "operator[], arrays"
ms.assetid: c8704f88-22ed-4f93-ae8b-f80512e8d9eb
caps.latest.revision: 15
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CArray::operator
These subscript operators are a convenient substitute for the [SetAt](../vs140/carray--setat.md) and [GetAt](../vs140/carray--getat.md) functions.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 *TYPE*  
 Template parameter specifying the type of elements in this array.  
  
 <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 Index of the element to be accessed.  
  
## Remarks  
 The first operator, called for arrays that are not **const**, may be used on either the right (r-value) or the left (l-value) of an assignment statement. The second, called for **const** arrays, may be used only on the right.  
  
 The Debug version of the library asserts if the subscript (either on the left or right side of an assignment statement) is out of bounds.  
  
## Example  
 [!code[NVC_MFCCollections#34](../vs140/codesnippet/CPP/carray--operator_1.cpp)]  
  
## Requirements  
 **Header:** afxtempl.h  
  
## See Also  
 [CArray Class](../vs140/carray-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CArray::GetAt](../vs140/carray--getat.md)   
 [CArray::SetAt](../vs140/carray--setat.md)   
 [CArray::ElementAt](../vs140/carray--elementat.md)