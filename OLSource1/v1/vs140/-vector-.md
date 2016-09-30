---
title: "&lt;vector&gt;"
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
  - "<vector>"
  - "std.<vector>"
  - "std::<vector>"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "vector header"
ms.assetid: c1431ad8-c0b6-4dbb-89c4-5f651e432d7f
caps.latest.revision: 26
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# &lt;vector&gt;
Defines the container template class vector and several supporting templates.  
  
 The <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> is a container that organizes elements of a given type in a linear sequence. It enables fast random access to any element, and dynamic additions and removals to and from the sequence. The <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> is the preferred container for a sequence when random-access performance is at a premium.  
  
 For more information about the class <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>, see [vector Class](../vs140/vector-class.md). For information about the specialization <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>, see [vector\<bool> Class](../vs140/vector-bool--class.md).  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 Type  
 The template parameter for the type of data stored in the vector.  
  
 Allocator  
 The template parameter for the stored allocator object responsible for memory allocation and deallocation.  
  
 <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
 The first (left) vector in a compare operation  
  
 <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>  
 The second (right) vector in a compare operation.  
  
### Operators  
  
|||  
|-|-|  
|[operator! =](../vs140/-vector--operators.md#operator_neq)|Tests if the vector object on the left side of the operator is not equal to the vector object on the right side.|  
|[operator<](../vs140/-vector--operators.md#operator_lt_)|Tests if the vector object on the left side of the operator is less than the vector object on the right side.|  
|[operator\<=](../vs140/-vector--operators.md#operator_lt__eq)|Tests if the vector object on the left side of the operator is less than or equal to the vector object on the right side.|  
|[operator==](../vs140/-vector--operators.md#operator_eq_eq)|Tests if the vector object on the left side of the operator is equal to the vector object on the right side.|  
|[operator>](../vs140/-vector--operators.md#operator_gt_)|Tests if the vector object on the left side of the operator is greater than the vector object on the right side.|  
|[operator>=](../vs140/-vector--operators.md#operator_gt__eq)|Tests if the vector object on the left side of the operator is greater than or equal to the vector object on the right side.|  
  
### Classes  
  
|||  
|-|-|  
|[vector Class](../vs140/vector-class.md)|A template class of sequence containers that arrange elements of a given type in a linear arrangement and allow fast random access to any element.|  
  
### Specializations  
  
|||  
|-|-|  
|[vector\<bool> Class](../vs140/vector-bool--class.md)|A full specialization of the template class vector for elements of type <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> with an allocator for the underlying type used by the specialization.|  
  
## Requirements  
 **Header:** \<vector>  
  
 **Namespace:** std  
  
## See Also  
 [Header Files](../vs140/c---standard-library-header-files.md)   
 [Thread Safety in the Standard C++ Library](../vs140/thread-safety-in-the-c---standard-library.md)   
 [Standard Template Library](../vs140/standard-template-library.md)