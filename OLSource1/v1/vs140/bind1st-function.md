---
title: "bind1st Function"
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
  - "xfunctional/std::bind1st"
  - "std::bind1st"
  - "std.bind1st"
  - "bind1st"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "bind1st function"
  - "bind1st"
ms.assetid: 4fd982e2-3588-47e9-b5a9-84ba4fff1923
caps.latest.revision: 22
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# bind1st Function
A helper template function that creates an adaptor to convert a binary function object into a unary function object by binding the first argument of the binary function to a specified value.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 The binary function object to be converted to a unary function object.  
  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 The value to which the first argument of the binary function object is to be bound.  
  
## Return Value  
 The unary function object that results from binding the first argument of the binary function object to the value <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
  
## Remarks  
 Function binders are a kind of function adaptor and, because they return function objects, can be used in certain types of function composition to construct more complicated and powerful expressions.  
  
 If <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> is an object of type <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> is a constant, then <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> (<CodeContentPlaceHolder>9\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>10\</CodeContentPlaceHolder>) is equivalent to the [binder1st](../vs140/binder1st-class.md) class constructor <CodeContentPlaceHolder>11\</CodeContentPlaceHolder><<CodeContentPlaceHolder>12\</CodeContentPlaceHolder>> (<CodeContentPlaceHolder>13\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>14\</CodeContentPlaceHolder>) and is more convenient.  
  
## Example  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 **The vector v1 = ( 0 5 10 15 20 25 )**  
**The number of elements in v1 greater than 10 is: 3.**  
**The number of elements in v1 greater than 5 is: 4.**  
**The number of elements in v1 less than 10 is: 2.**   
## Requirements  
 **Header:** \<functional>  
  
 **Namespace:** std  
  
## See Also  
 [Standard Template Library](../vs140/standard-template-library.md)