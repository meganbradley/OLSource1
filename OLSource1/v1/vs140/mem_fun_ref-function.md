---
title: "mem_fun_ref Function"
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
  - "std.mem_fun_ref"
  - "xfunctional/std::mem_fun_ref"
  - "std::mem_fun_ref"
  - "mem_fun_ref"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "mem_fun_ref"
  - "mem_fun_ref function"
ms.assetid: 1fb77eb2-5bd4-4818-ac8a-21b73085f2c1
caps.latest.revision: 19
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# mem_fun_ref Function
Helper template functions used to construct function object adaptors for member functions when initialized by using reference arguments.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 A pointer to the member function of class <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> to be converted to a function object.  
  
## Return Value  
 A <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> or <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> function object of type<CodeContentPlaceHolder>6\</CodeContentPlaceHolder> or <CodeContentPlaceHolder>7\</CodeContentPlaceHolder>.  
  
## Example  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 **The original values stored in v1 are: 1 2 3 4 5 6 7 8 9 10 11 12 13**   
**With the primes removed, the remaining values in v1 are: 4 6 8 9 10 12**   
**The original values stored in v2 are: 1 2 3 4 5 6 7 8 9 10 11 12 13**   
**With the even numbers removed, the remaining values are: 1 3 5 7 9 11 13**    
## Requirements  
 **Header:** \<functional>  
  
 **Namespace:** std  
  
## See Also  
 [Standard Template Library](../vs140/standard-template-library.md)