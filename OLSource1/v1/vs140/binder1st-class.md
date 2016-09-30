---
title: "binder1st Class"
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
  - "xfunctional/std::binder1st"
  - "std::binder1st"
  - "binder1st"
  - "std.binder1st"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "binder1st class"
ms.assetid: 6b8ee343-c82f-48f8-867d-06f9d1d324c0
caps.latest.revision: 24
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# binder1st Class
A template class providing a constructor that converts a binary function object into a unary function object by binding the first argument of the binary function to a specified value.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 The binary function object to be converted to a unary function object.  
  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 The value to which the first argument of the binary function object is to be bound.  
  
 <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
 The value of the argument that the adapted binary object compares to the fixed value of the second argument.  
  
## Return Value  
 The unary function object that results from binding the first argument of the binary function object to the value <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
  
## Remarks  
 The template class stores a copy of a binary function object <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> in **op**, and a copy of <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> in **value**. It defines its member function <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> as returning **op**( **value**, <CodeContentPlaceHolder>9\</CodeContentPlaceHolder>).  
  
 If <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> is an object of type **Operation** and <CodeContentPlaceHolder>11\</CodeContentPlaceHolder> is a constant , then [bind1st](../vs140/-functional--functions.md#bind1st_function) ( <CodeContentPlaceHolder>12\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>13\</CodeContentPlaceHolder> ) is equivalent to the <CodeContentPlaceHolder>14\</CodeContentPlaceHolder> class constructor <CodeContentPlaceHolder>15\</CodeContentPlaceHolder>\< **Operation**> ( <CodeContentPlaceHolder>16\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>17\</CodeContentPlaceHolder> ) and more convenient.  
  
## Example  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
## Requirements  
 **Header:** \<functional>  
  
 **Namespace:** std  
  
## See Also  
 [Thread Safety in the Standard C++ Library](../vs140/thread-safety-in-the-c---standard-library.md)   
 [Standard Template Library](../vs140/standard-template-library.md)