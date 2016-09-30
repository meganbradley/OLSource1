---
title: "vector::resize"
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
  - "Resize"
  - "std.vector.resize"
  - "std::vector::resize"
  - "vector.resize"
  - "vector::resize"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "resize method"
ms.assetid: c1cb7b49-74bc-4044-aab6-d3d0628a535f
caps.latest.revision: 19
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# vector::resize
Specifies a new size for a vector.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 The new size of the vector.  
  
 <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
 The initialization value of new elements added to the vector if the new size is larger that the original size. If the value is omitted, the new objects use their default constructor.  
  
## Remarks  
 If the container's size is less than the requested size, <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>, elements are added to the vector until it reaches the requested size. If the container's size is larger than the requested size, the elements closest to the end of the container are deleted until the container reaches the size <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>. If the present size of the container is the same as the requested size, no action is taken.  
  
 [size](../vs140/vector--size.md) reflects the current size of the vector.  
  
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