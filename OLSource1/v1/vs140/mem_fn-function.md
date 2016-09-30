---
title: "mem_fn Function"
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
  - "std.tr1.mem_fn"
  - "functional/std::tr1::mem_fn"
  - "std::tr1::mem_fn"
  - "mem_fn"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "mem_fn function [TR1]"
ms.assetid: c6f9bccf-cfb0-44c5-bdd9-64c021ceae03
caps.latest.revision: 18
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# mem_fn Function
Generates a simple call wrapper.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 The return type of the wrapped function.  
  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 The type of the member function pointer.  
  
## Remarks  
 The template function returns a simple call wrapper <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>, with a weak result type, such that the expression <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> is equivalent to <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>. It does not throw any exceptions.  
  
 The returned call wrapper is derived from <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> (hence defining the nested type <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> as a synonym for <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> and the nested type <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> as a synonym for <CodeContentPlaceHolder>11\</CodeContentPlaceHolder>) only if the type <CodeContentPlaceHolder>12\</CodeContentPlaceHolder> is a pointer to member function with cv-qualifier <CodeContentPlaceHolder>13\</CodeContentPlaceHolder> that takes no arguments.  
  
 The returned call wrapper is derived from <CodeContentPlaceHolder>14\</CodeContentPlaceHolder> (hence defining the nested type <CodeContentPlaceHolder>15\</CodeContentPlaceHolder> as a synonym for <CodeContentPlaceHolder>16\</CodeContentPlaceHolder>, the nested type <CodeContentPlaceHolder>17\</CodeContentPlaceHolder> as a synonym for <CodeContentPlaceHolder>18\</CodeContentPlaceHolder>, and the nested type <CodeContentPlaceHolder>19\</CodeContentPlaceHolder> as a synonym for <CodeContentPlaceHolder>20\</CodeContentPlaceHolder>) only if the type <CodeContentPlaceHolder>21\</CodeContentPlaceHolder> is a pointer to member function with cv-qualifier <CodeContentPlaceHolder>22\</CodeContentPlaceHolder> that takes one argument, of type <CodeContentPlaceHolder>23\</CodeContentPlaceHolder>.  
  
## Example  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 **3^2 == 9**  
**3\*2 == 6**   
## Requirements  
 **Header:** \<functional>  
  
 **Namespace:** std  
  
## See Also  
 [function](../vs140/function-class.md)