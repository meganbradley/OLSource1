---
title: "function::function"
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
  - "functional/std::tr1::function"
  - "function::function"
  - "std::tr1::function::function"
  - "function.function"
  - "std.tr1.function.function"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "function constructor [TR1]"
ms.assetid: 10504e05-f7ed-4c1f-83d7-a955964afc4e
caps.latest.revision: 25
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# function::function
Constructs a wrapper that either is empty or stores a callable object of arbitrary type with a fixed signature.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 The function object to copy.  
  
 Fx  
 The type of the callable object.  
  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 The callable object to wrap.  
  
 Alloc  
 The allocator type.  
  
 <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
 The allocator.  
  
 <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
 The callable object reference to wrap.  
  
## Remarks  
 The first two constructors construct an empty <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> object. The next three constructors construct a <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> object that holds the callable object passed as the operand. The last two constructors allocate storage with the allocator object _Ax.  
  
## Example  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 **100**  
**-10**  
**30**  
**f is non-empty (correct).**  
**g is empty (correct).**   
## Requirements  
 **Header:** \<functional>  
  
 **Namespace:** std  
  
## See Also  
 [function](../vs140/function-class.md)   
 [function::operator=](../vs140/function--operator=.md)   
 [lvalues and rvalues](../vs140/lvalues-and-rvalues--visual-c---.md)