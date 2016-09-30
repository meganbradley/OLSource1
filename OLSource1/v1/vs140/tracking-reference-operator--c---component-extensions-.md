---
title: "Tracking Reference Operator (C++ Component Extensions)"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-cpp"
ms.tgt_pltfrm: na
ms.topic: "language-reference"
f1_keywords: 
  - "%"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "tracking references"
  - "% tracking reference [C++]"
ms.assetid: 142a7269-ab69-4b54-a6d7-833bef06228f
caps.latest.revision: 33
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Tracking Reference Operator (C++ Component Extensions)
A *tracking reference* (<CodeContentPlaceHolder>4\</CodeContentPlaceHolder>) behaves like an ordinary C++ reference (<CodeContentPlaceHolder>5\</CodeContentPlaceHolder>) except that when an object is assigned to a tracking reference, the object’s reference count is incremented.  
  
## All Platforms  
 A tracking reference has the following characteristics.  
  
-   Assignment of an object to a tracking reference causes the object’s reference count to be incremented.  
  
-   A native reference (&) is the result when you dereference a *. A tracking reference (%) is the result when you dereference a ^. As long as you have a % to an object, the object will stay alive in memory.  
  
-   The dot (<CodeContentPlaceHolder>6\</CodeContentPlaceHolder>) member-access operator is used to access a member of the object.  
  
-   Tracking references are valid for value types and handles (for example <CodeContentPlaceHolder>7\</CodeContentPlaceHolder>).  
  
-   A tracking reference cannot be assigned a null or <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> value. A tracking reference may be reassigned to another valid object as many times as required.  
  
-   A tracking reference cannot be used as a unary take-address operator.  
  
## [!INCLUDE[wrt](../vs140/includes/wrt_md.md)]  
 A tracking reference behaves like a standard C++ reference, except that a % is reference-counted. The following snippet shows how to convert between % and ^ types:  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
 The following example shows how to pass a ^ to a function that takes a %.  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
## [!INCLUDE[clr_for_headings](../vs140/includes/clr_for_headings_md.md)]  
 In C++/CLI, you can use a tracking reference to a handle when you bind to an object of a CLR type on the garbage-collected heap.  
  
 In the CLR, the value of a tracking reference variable is updated automatically whenever the garbage collector moves the referenced object.  
  
 A tracking reference can be declared only on the stack. A tracking reference cannot be a member of a class.  
  
 It is not possible to have a native C++ reference to an object on the garbage-collected heap.  
  
 For more information about tracking references in C++/CLI, see:  
  
-   [How to: Pass CLR Types by Reference with Tracking References](../vs140/how-to--use-tracking-references-in-c---cli.md)  
  
-   [How to: Use Tracking References and Value Types](../vs140/how-to--use-tracking-references-and-value-types.md)  
  
-   [How to: Use Tracking References and Interior Pointers](../vs140/how-to--use-tracking-references-and-interior-pointers.md)  
  
-   [How to: Write Template Functions that Take Native, Value, or Reference Parameters](../vs140/how-to--write-template-functions-that-take-native--value--or-reference-parameters.md)  
  
### Examples  
 **Example**  
  
 The following sample for C++/CLI shows how to use a tracking reference with native and managed types.  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 **Example**  
  
 The following sample for C++/CLI shows how to bind a tracking reference to an array.  
  
<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 **Output**  
  
 **21**   
**222**