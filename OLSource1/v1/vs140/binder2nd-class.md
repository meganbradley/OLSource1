---
title: "binder2nd Class"
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
  - "std.binder2nd"
  - "binder2nd"
  - "xfunctional/std::binder2nd"
  - "std::binder2nd"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "binder2nd class"
ms.assetid: b2a9c1d1-dfc4-4ca9-a10e-ae84e195a62d
caps.latest.revision: 24
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# binder2nd Class
A template class providing a constructor that converts a binary function object into a unary function object by binding the second argument of the binary function to a specified value.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 The binary function object to be converted to a unary function object.  
  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 The value to which the second argument of the binary function object is to be bound.  
  
 <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
 The value of the argument that the adapted binary object compares to the fixed value of the second argument.  
  
## Return Value  
 The unary function object that results from binding the second argument of the binary function object to the value <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
  
## Remarks  
 The template class stores a copy of a binary function object _                *Func* in **op**, and a copy of <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> in **value**. It defines its member function <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> as returning **op**( <CodeContentPlaceHolder>8\</CodeContentPlaceHolder>, **value**).  
  
 If <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> is an object of type **Operation** and c is a constant, then [bind2nd](../vs140/-functional--functions.md#bind2nd_function) ( <CodeContentPlaceHolder>10\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>11\</CodeContentPlaceHolder> ) is equivalent to the <CodeContentPlaceHolder>12\</CodeContentPlaceHolder> class constructor <CodeContentPlaceHolder>13\</CodeContentPlaceHolder>\< **Operation**> ( <CodeContentPlaceHolder>14\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>15\</CodeContentPlaceHolder> ) and more convenient.  
  
## Example  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
## Requirements  
 **Header:** \<functional>  
  
 **Namespace:** std  
  
## See Also  
 [Thread Safety in the Standard C++ Library](../vs140/thread-safety-in-the-c---standard-library.md)   
 [Standard Template Library](../vs140/standard-template-library.md)