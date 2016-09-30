---
title: "bind2nd Function"
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
  - "std::bind2nd"
  - "xfunctional/std::bind2nd"
  - "bind2nd"
  - "std.bind2nd"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "bind2nd"
  - "bind2nd function"
ms.assetid: 84c7bf43-1ec9-4fb3-99c9-5f04debdfc2a
caps.latest.revision: 22
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# bind2nd Function
A helper template function that creates an adaptor to convert a binary function object into a unary function object by binding the second argument of the binary function to a specified value.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 The binary function object to be converted to a unary function object.  
  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 The value to which the second argument of the binary function object is to be bound.  
  
## Return Value  
 The unary function object that results from binding the second argument of the binary function object to the value <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
  
## Remarks  
 Function binders are a kind of function adaptor and, because they return function objects, can be used in certain types of function composition to construct more complicated and powerful expressions.  
  
 If <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> is an object of type **Operation** and <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> is a constant, then <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> ( <CodeContentPlaceHolder>8\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> ) is equivalent to the [binder2nd](../vs140/binder2nd-class.md) class constructor **binder2nd\<Operation>** ( <CodeContentPlaceHolder>10\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>11\</CodeContentPlaceHolder> ) and more convenient.  
  
## Example  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 **The vector v1 = ( 0 5 10 15 20 25 )**  
**The number of elements in v1 greater than 10 is: 3.**  
**The number of elements in v1 greater than 15 is: 2.**  
**The number of elements in v1 less than 10 is: 2.**   
## Requirements  
 **Header:** \<functional>  
  
 **Namespace:** std  
  
## See Also  
 [Standard Template Library](../vs140/standard-template-library.md)