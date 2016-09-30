---
title: "&lt;tuple&gt; functions"
ms.custom: na
ms.date: "09/22/2016"
ms.reviewer: na
ms.suite: na
ms.tgt_pltfrm: na
ms.topic: "article"
ms.assetid: bc6be38f-5258-4c14-b81b-63caa335fd44
caps.latest.revision: 13
---
# &lt;tuple&gt; functions
||||  
|-|-|-|  
|[get Function](#get_function)|[make_tuple Function](#make_tuple_function)|[tie Function](#tie_function)|  
  
##  \<a name="get_function">\</a>  get Function  
 Gets an element from a <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> object, by index or (in C++14) by type.  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>7\</CodeContentPlaceHolder>  
 The index of the element to get.  
  
 <CodeContentPlaceHolder>8\</CodeContentPlaceHolder>  
 The sequence of types declared in the tuple, in declaration order.  
  
 <CodeContentPlaceHolder>9\</CodeContentPlaceHolder>  
 The type of the element to get.  
  
 <CodeContentPlaceHolder>10\</CodeContentPlaceHolder>  
 A std::tuple that contains any number of elements.  
  
### Remarks  
 The template functions return a reference to the value at index <CodeContentPlaceHolder>11\</CodeContentPlaceHolder>, or of type <CodeContentPlaceHolder>12\</CodeContentPlaceHolder> in the <CodeContentPlaceHolder>13\</CodeContentPlaceHolder> object.  
  
 Calling <CodeContentPlaceHolder>14\</CodeContentPlaceHolder> will produce a compiler error if Tuple contains more or less than one element of type T.  
  
### Example  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
##  \<a name="make_tuple_function">\</a>  make_tuple Function  
 Makes a <CodeContentPlaceHolder>15\</CodeContentPlaceHolder> from element values.  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>16\</CodeContentPlaceHolder>  
 The type of the Nth function parameter.  
  
 <CodeContentPlaceHolder>17\</CodeContentPlaceHolder>  
 The value of the Nth function parameter.  
  
### Remarks  
 The template function returns <CodeContentPlaceHolder>18\</CodeContentPlaceHolder>, where each type <CodeContentPlaceHolder>19\</CodeContentPlaceHolder> is <CodeContentPlaceHolder>20\</CodeContentPlaceHolder> when the corresponding type <CodeContentPlaceHolder>21\</CodeContentPlaceHolder> is <CodeContentPlaceHolder>22\</CodeContentPlaceHolder> <CodeContentPlaceHolder>23\</CodeContentPlaceHolder>; otherwise, it is <CodeContentPlaceHolder>24\</CodeContentPlaceHolder>.  
  
 One advantage of <CodeContentPlaceHolder>25\</CodeContentPlaceHolder> is that the types of objects that are being stored are determined automatically by the compiler and do not have to be explicitly specified. Don't use explicit template arguments such as <CodeContentPlaceHolder>26\</CodeContentPlaceHolder> when you use <CodeContentPlaceHolder>27\</CodeContentPlaceHolder> because it is unnecessarily verbose and adds complex rvalue reference problems that might cause compilation failure.  
  
### Example  
  
<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
  <CodeContentPlaceHolder>28\</CodeContentPlaceHolder>  
  
##  \<a name="tie_function">\</a>  tie Function  
 Makes a <CodeContentPlaceHolder>29\</CodeContentPlaceHolder> from element references.  
  
<CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>30\</CodeContentPlaceHolder>  
 The base type of the Nth tuple element.  
  
### Remarks  
 The template function returns <CodeContentPlaceHolder>31\</CodeContentPlaceHolder>.  
  
### Example  
  
<CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
   **0 1 2 3**  
 **0 1 2 3**    
## See Also  
 [&lt;tuple&gt;](../vs140/-tuple-.md)