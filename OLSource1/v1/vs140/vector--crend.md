---
title: "vector::crend"
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
  - "vector.crend"
  - "std.vector.crend"
  - "crend"
  - "std::vector::crend"
  - "vector::crend"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "crend method"
ms.assetid: d71945d6-63de-49f1-a3b1-cd004b5b117e
caps.latest.revision: 12
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# vector::crend
Returns a const iterator that addresses the location succeeding the last element in a reversed vector.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Return Value  
 A const reverse random-access iterator that addresses the location succeeding the last element in a reversed [vector](../vs140/vector-class.md) (the location that had preceded the first element in the unreversed <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>).  
  
## Remarks  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> is used with a reversed <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> just as [cend](../vs140/vector--cend.md) is used with a <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>.  
  
 With the return value of <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> (suitably decremented), the <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> object cannot be modified.  
  
 <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> can be used to test to whether a reverse iterator has reached the end of its <CodeContentPlaceHolder>9\</CodeContentPlaceHolder>.  
  
 The value returned by <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> should not be dereferenced.  
  
## Example  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 **2**  
**1**   
## Requirements  
 **Header:** \<vector>  
  
 **Namespace:** std  
  
## See Also  
 [vector Class](../vs140/vector-class.md)   
 [Standard Template Library](../vs140/standard-template-library.md)