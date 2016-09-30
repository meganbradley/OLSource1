---
title: "vector::operator"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-cpp"
ms.tgt_pltfrm: na
ms.topic: "article"
f1_keywords: 
  - "vector::operator[]"
  - "[]"
  - "std.vector.operator[]"
  - "operator[]"
  - "std::vector::operator[]"
  - "vector.operator[]"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "[] operator, with specific standard C++ objects"
  - "operator[], vector"
  - "operator [], vector"
ms.assetid: 9f19d479-152d-40c6-aab8-d7e5b62a41ed
caps.latest.revision: 21
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# vector::operator
Returns a reference to the vector element at a specified position.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
  
|||  
|-|-|  
|Parameter|Description|  
|<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>|The position of the vector element.|  
  
## Return Value  
 If the position specified is greater than or equal to the size of the container, the result is undefined.  
  
## Remarks  
 If the return value of <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> is assigned to a <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>, the vector object cannot be modified. If the return value of <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> is assigned to a reference, the vector object can be modified.  
  
 When compiling with _SECURE_SCL 1 (controlled with [_ITERATOR_DEBUG_LEVEL](../vs140/_iterator_debug_level.md)), a runtime error will occur if you attempt to access an element outside the bounds of the vector.  See [Checked Iterators](../vs140/checked-iterators.md) for more information.  
  
## Example  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
## Output  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
## Requirements  
 **Header:** \<vector>  
  
 **Namespace:** std  
  
## See Also  
 [vector Class](../vs140/vector-class.md)   
 [Standard Template Library](../vs140/standard-template-library.md)