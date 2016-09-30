---
title: "operator== (&lt;valarray&gt;)"
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
  - "std.=="
  - "std::=="
  - "valarray/std::operator=="
  - "operator=="
  - "std.operator=="
  - "std::operator=="
  - "=="
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "operator==, valarrays"
  - "== operator, with specific standard C++ objects"
  - "operator ==, valarrays"
ms.assetid: 550386bf-1780-4e89-a79f-fb69e3dc60d8
caps.latest.revision: 17
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# operator== (&lt;valarray&gt;)
Tests whether the corresponding elements of two equally sized valarrays are equal or whether all the elements of a valarray are equal a specified value.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 The first of the two valarrays whose elements are to be tested for equality.  
  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 The second of the two valarrays whose elements are to be tested for equality.  
  
## Return Value  
 A valarray of Boolean values, each of which is:  
  
-   **true** if the corresponding elements are equal.  
  
-   **false** if the corresponding elements are not equal.  
  
## Remarks  
 The first template operator returns an object of class [valarray\<bool>](../vs140/valarray-bool--class.md), each of whose elements <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> is _*Left*[<CodeContentPlaceHolder>5\</CodeContentPlaceHolder>] == \_*Right*[<CodeContentPlaceHolder>6\</CodeContentPlaceHolder>]. The second template operator stores in element <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> <CodeContentPlaceHolder>8\</CodeContentPlaceHolder>[<CodeContentPlaceHolder>9\</CodeContentPlaceHolder>] == \_*Right*. The third template operator stores in element <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> <CodeContentPlaceHolder>11\</CodeContentPlaceHolder> == <CodeContentPlaceHolder>12\</CodeContentPlaceHolder>[<CodeContentPlaceHolder>13\</CodeContentPlaceHolder>].  
  
## Example  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 **The initial Left valarray is: ( 0 1 -2 3 -4 5 -6 7 -8 9 ).**  
**The initial Right valarray is: ( 0 1 2 3 4 5 6 7 8 9 ).**  
**The element-by-element result of the equality comparison test is the**  
 **valarray: ( 1 1 0 1 0 1 0 1 0 1 ).**   
## Requirements  
 **Header:** \<valarray>  
  
 **Namespace:** std  
  
## See Also  
 [stack::operator==](../vs140/stack--operator==.md)