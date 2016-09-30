---
title: "vector::assign"
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
  - "vector.assign"
  - "Assign"
  - "std.vector.assign"
  - "std::vector::assign"
  - "vector::assign"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "assign function"
ms.assetid: ab241740-3ea8-4c77-98da-ef4dc0a2c00b
caps.latest.revision: 20
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# vector::assign
Erases a vector and copies the specified elements to the empty vector.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 Position of the first element in the range of elements to be copied.  
  
 <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
 Position of the first element beyond the range of elements to be copied.  
  
 <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
 The number of copies of an element being inserted into the vector.  
  
 <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>  
 The value of the element being inserted into the vector.  
  
 <CodeContentPlaceHolder>7\</CodeContentPlaceHolder>  
 The initializer_list containing the elements to insert.  
  
## Remarks  
 After erasing any existing elements in a vector, assign either inserts a specified range of elements from the original vector into a vector or inserts copies of a new element of a specified value into a vector.  
  
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