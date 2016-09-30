---
title: "vector::rbegin"
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
  - "std::vector::rbegin"
  - "std.vector.rbegin"
  - "rbegin"
  - "vector.rbegin"
  - "vector::rbegin"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "rbegin method"
ms.assetid: 15678651-44b3-4960-b54a-df3123f2b1de
caps.latest.revision: 17
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# vector::rbegin
Returns an iterator to the first element in a reversed vector.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Return Value  
 A reverse random-access iterator addressing the first element in a reversed vector or addressing what had been the last element in the unreversed vector.  
  
## Remarks  
 If the return value of <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> is assigned to a <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>, the vector object cannot be modified. If the return value of <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> is assigned to a <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>, the vector object can be modified.  
  
## Example  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 **The first element of vector is 1.**  
**The first element of the reversed vector is 2.**   
## Requirements  
 **Header:** \<vector>  
  
 **Namespace:** std  
  
## See Also  
 [vector Class](../vs140/vector-class.md)   
 [Standard Template Library](../vs140/standard-template-library.md)