---
title: "vector::emplace"
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
  - "std.vector.emplace"
  - "vector.emplace"
  - "vector::emplace"
  - "std::vector::emplace"
  - "emplace"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "emplace method"
ms.assetid: 3bbd498e-aa3e-48a8-9926-1a0d4d6479e1
caps.latest.revision: 13
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# vector::emplace
Inserts an element constructed in place into the vector at a specified position.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
  
|||  
|-|-|  
|Parameter|Description|  
|<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>|The position in the [vector](../vs140/vector-class.md) where the first element is inserted.|  
|<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>|The value of the element being inserted into the <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>.|  
  
## Return Value  
 The function returns an iterator that points to the position where the new element was inserted into the <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>.  
  
## Remarks  
 Any insertion operation can be expensive, see [vector Class](../vs140/vector-class.md) for a discussion of <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> performance.  
  
## Example  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 **v1 = 10 20 30**  
**vv1[0] = 10 20 30**   
## Requirements  
 **Header:** \<vector>  
  
 **Namespace:** std  
  
## See Also  
 [vector Class](../vs140/vector-class.md)   
 [Standard Template Library](../vs140/standard-template-library.md)