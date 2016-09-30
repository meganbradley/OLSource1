---
title: "Reference-Type Function Returns"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-cpp"
ms.tgt_pltfrm: na
ms.topic: "language-reference"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "function return types, reference type"
  - "data types [C++], function return types"
  - "functions [C++], return types"
ms.assetid: 5b73be1d-2dc7-41df-ab0a-adcba36f2ad1
caps.latest.revision: 12
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Reference-Type Function Returns
Functions can be declared to return a reference type. There are two reasons to make such a declaration:  
  
-   The information being returned is a large enough object that returning a reference is more efficient than returning a copy.  
  
-   The type of the function must be an l-value.  
  
-   The referred-to object will not go out of scope when the function returns.  
  
 Just as it can be more efficient to pass large objects *to* functions by reference, it also can be more efficient to return large objects *from* functions by reference. Reference-return protocol eliminates the necessity of copying the object to a temporary location prior to returning.  
  
 Reference-return types can also be useful when the function must evaluate to an l-value. Most overloaded operators fall into this category, particularly the assignment operator. Overloaded operators are covered in [Overloaded Operators](../vs140/operator-overloading.md).  
  
## Example  
 Consider the <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> example:  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Output  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 Notice that the functions <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> are declared as returning reference types. These functions can be used on either side of an assignment statement.  
  
 Note also that in main, ThePoint object remains in scope, and therefore its reference members are still alive and can be safely accessed.  
  
 Declarations of reference types must contain initializers except in the following cases:  
  
-   Explicit <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> declaration  
  
-   Declaration of a class member  
  
-   Declaration within a class  
  
-   Declaration of an argument to a function or the return type for a function  
  
## Caution returning address of local  
 If you declare an object at local scope, that object will be destroyed when the function returns. If the function returns a reference to that object, that reference will probably cause an access violation at runtime if the caller attempts to use the null reference.  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 The compiler issues a warning in this case: <CodeContentPlaceHolder>7\</CodeContentPlaceHolder>. In simple programs it is possible that occasionally no access violation will occur if the reference is accessed by the caller before the memory location is overwritten. This is due to sheer luck. Heed the warning.  
  
## See Also  
 [References](../vs140/references--c---.md)