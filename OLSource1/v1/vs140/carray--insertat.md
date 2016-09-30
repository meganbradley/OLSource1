---
title: "CArray::InsertAt"
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
  - "CArray.InsertAt"
  - "CArray::InsertAt"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "InsertAt method"
  - "CArray class, insertion/removal"
ms.assetid: 9fb8ab6c-00e5-4a55-b8cf-b854c8c52fa8
caps.latest.revision: 15
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CArray::InsertAt
The first version of <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> inserts one element (or multiple copies of an element) at a specified index in an array.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 An integer index that may be greater than the value returned by <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>.  
  
 <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
 Template parameter specifying the type of elements in this array.  
  
 <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
 The element to be placed in this array.  
  
 <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>  
 The number of times this element should be inserted (defaults to 1).  
  
 <CodeContentPlaceHolder>7\</CodeContentPlaceHolder>  
 An integer index that may be greater than the value returned by [GetUpperBound](../vs140/carray--getupperbound.md).  
  
 <CodeContentPlaceHolder>8\</CodeContentPlaceHolder>  
 Another array that contains elements to be added to this array.  
  
## Remarks  
 In the process, it shifts up (by incrementing the index) the existing element at this index, and it shifts up all the elements above it.  
  
 The second version inserts all the elements from another <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> collection, starting at the <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> position.  
  
 The <CodeContentPlaceHolder>11\</CodeContentPlaceHolder> function, in contrast, replaces one specified array element and does not shift any elements.  
  
## Example  
 [!code[NVC_MFCCollections#30](../vs140/codesnippet/CPP/carray--insertat_1.cpp)]  
  
## Requirements  
 **Header:** afxtempl.h  
  
## See Also  
 [CArray Class](../vs140/carray-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CArray::GetUpperBound](../vs140/carray--getupperbound.md)   
 [CArray::SetAt](../vs140/carray--setat.md)   
 [CArray::RemoveAt](../vs140/carray--removeat.md)