---
title: "vector::front"
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
  - "vector.front"
  - "vector::front"
  - "std::vector::front"
  - "std.vector.front"
  - "front"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "front method, vector class"
ms.assetid: 469e5cda-cbaa-4492-98a0-5562f0c06970
caps.latest.revision: 18
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# vector::front
Returns a reference to the first element in a vector.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Return Value  
 A reference to the first element in the vector object. If the vector is empty, the return is undefined.  
  
## Remarks  
 If the return value of <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> is assigned to a <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>, the vector object cannot be modified. If the return value of <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> is assigned to a **reference**, the vector object can be modified.  
  
 When compiling with _SECURE_SCL 1, a runtime error will occur if you attempt to access an element in an empty vector.  See [Checked Iterators](../vs140/checked-iterators.md) for more information.  
  
## Example  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
## Output  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
## Requirements  
 **Header:** \<vector>  
  
 **Namespace:** std  
  
## See Also  
 [vector Class](../vs140/vector-class.md)   
 [vector::front and vector::back](../vs140/vector--front-and-vector--back.md)   
 [Standard Template Library](../vs140/standard-template-library.md)