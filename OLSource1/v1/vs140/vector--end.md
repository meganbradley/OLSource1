---
title: "vector::end"
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
  - "std::vector::end"
  - "std.vector.end"
  - "end"
  - "vector::end"
  - "vector.end"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "end method"
ms.assetid: 6a11275b-81c1-4fb3-a053-b8cf5f5e4bbc
caps.latest.revision: 18
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# vector::end
Returns the past-the-end iterator.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Return Value  
 The past-the-end iterator for the vector. If the vector is empty, <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>.  
  
## Remarks  
 If the return value of **end** is assigned to a variable of type <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>, the vector object cannot be modified. If the return value of **end** is assigned to a variable of type **iterator**, the vector object can be modified.  
  
## Example  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 **1**  
**2**   
## Requirements  
 **Header:** \<vector>  
  
 **Namespace:** std  
  
## See Also  
 [vector Class](../vs140/vector-class.md)   
 [Standard Template Library](../vs140/standard-template-library.md)