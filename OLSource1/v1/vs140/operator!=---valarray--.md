---
title: "operator!= (&lt;valarray&gt;)"
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
  - "std::!="
  - "!="
  - "std::operator!="
  - "valarray/std::operator!="
  - "std.operator!="
  - "std.!="
  - "operator!="
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "!= operator"
  - "operator !=, valarrays"
  - "operator!=, valarrays"
ms.assetid: a29dc772-b44e-4c67-b023-aa16ea481bb6
caps.latest.revision: 17
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# operator!= (&lt;valarray&gt;)
Tests whether the corresponding elements of two equally sized valarrays are unequal or whether all the elements of a valarray are unequal a specified value.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 The first of the two valarrays whose elements are to be tested for inequality.  
  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 The second of the two valarrays whose elements are to be tested for inequality.  
  
## Return Value  
 A valarray of Boolean values, each of which is:  
  
-   **true** if the corresponding elements are unequal.  
  
-   **false** if the corresponding elements are not unequal.  
  
## Remarks  
 The first template operator returns an object of class [valarray\<bool>](../vs140/valarray-bool--class.md), each of whose elements <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> is <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>[<CodeContentPlaceHolder>6\</CodeContentPlaceHolder>] != <CodeContentPlaceHolder>7\</CodeContentPlaceHolder>[<CodeContentPlaceHolder>8\</CodeContentPlaceHolder>].  
  
 The second template operator stores in element *I _Left*[<CodeContentPlaceHolder>9\</CodeContentPlaceHolder>] != _*Right*.  
  
 The third template operator stores in element *I _Left* != <CodeContentPlaceHolder>10\</CodeContentPlaceHolder>[<CodeContentPlaceHolder>11\</CodeContentPlaceHolder>].  
  
## Example  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 **The initial Left valarray is: ( 0 1 -2 3 -4 5 -6 7 -8 9 ).**  
**The initial Right valarray is: ( 0 1 2 3 4 5 6 7 8 9 ).**  
**The element-by-element result of the not equal comparison test is the**  
 **valarray: ( 0 0 1 0 1 0 1 0 1 0 ).**   
## Requirements  
 **Header:** \<valarray>  
  
 **Namespace:** std