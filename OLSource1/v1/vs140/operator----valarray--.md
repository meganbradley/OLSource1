---
title: "operator+ (&lt;valarray&gt;)"
ms.custom: na
ms.date: "09/21/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-cpp"
ms.tgt_pltfrm: na
ms.topic: "article"
f1_keywords: 
  - "std::operator+"
  - "valarray/std::operator+"
  - "+"
  - "operator+"
  - "std.operator+"
  - "std.+"
  - "std::+"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "operator+, valarrays"
  - "+ operator, valarrays"
  - "+ operator"
  - "operator +, valarrays"
ms.assetid: 156009ca-cb7c-4616-889c-22f187ca55ee
caps.latest.revision: 16
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# operator+ (&lt;valarray&gt;)
Obtains the element-wise sum between corresponding elements of two equally sized valarrays or of between a valarray a specified value.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 The first of the two valarrays whose elements are to be added or a specified value to be added with each element of a valarray.  
  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 The second of the two valarrays whose elements are to be added or a specified value to be added with each element of a valarray.  
  
## Return Value  
 A valarray whose elements are the element-wise sum of <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
  
## Example  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 **The initial Left valarray is: ( 2 -1 2 -1 2 -1 2 -1 ).**  
**The initial Right valarray is: ( 0 1 2 3 4 5 6 7 ).**  
**The element-by-element result of the sum is the**  
 **valarray: ( 2 0 4 2 6 4 8 6 ).**   
## Requirements  
 **Header:** \<valarray>  
  
 **Namespace:** std