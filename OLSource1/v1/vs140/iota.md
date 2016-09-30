---
title: "iota"
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
  - "std.iota"
  - "std::iota"
  - "iota"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "iota function"
ms.assetid: ccde879c-5cf7-4963-bb91-e5455c3edd61
caps.latest.revision: 11
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# iota
Stores a starting value, beginning with the first element and filling with successive increments of that value (<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>) in each of the elements in the interval <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
 An input iterator that addresses the first element in the range to be filled.  
  
 <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
 An input iterator that addresses the last element in the range to be filled.  
  
 <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>  
 The starting value to store in the first element and to successively increment for subsequent elements.  
  
## Remarks  
  
## Example  
 The following example demonstrates some uses for the <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> function by filling a [list](../vs140/-list-.md) of integers and then filling a [vector](../vs140/-vector-.md) with the <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> so that the [random_shuffle](../vs140/random_shuffle.md) function can be used.  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
## Output  
 <CodeContentPlaceHolder>9\</CodeContentPlaceHolder>  
  
 <CodeContentPlaceHolder>10\</CodeContentPlaceHolder>  
  
 <CodeContentPlaceHolder>11\</CodeContentPlaceHolder>  
  
 <CodeContentPlaceHolder>12\</CodeContentPlaceHolder>  
  
## Requirements  
 **Header:** \<numeric>  
  
 **Namespace:** std  
  
## See Also  
 [Standard Template Library](../vs140/standard-template-library.md)