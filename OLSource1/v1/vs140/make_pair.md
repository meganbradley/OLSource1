---
title: "make_pair"
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
  - "std.make_pair"
  - "make_pair"
  - "utility/std::make_pair"
  - "std::make_pair"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "make_pair"
  - "make_pair function"
ms.assetid: d4cc3871-ec32-469c-b96a-8e1409a62a0b
caps.latest.revision: 25
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# make_pair
A template function that you can use to construct objects of type <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>, where the component types are automatically chosen based on the data types that are passed as parameters.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 Value that initializes the first element of <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>.  
  
 <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
 Value that initializes the second element of <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>.  
  
## Return Value  
 The pair object that's constructed: <CodeContentPlaceHolder>6\</CodeContentPlaceHolder><<CodeContentPlaceHolder>7\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>8\</CodeContentPlaceHolder>>(<CodeContentPlaceHolder>9\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>10\</CodeContentPlaceHolder>).  
  
## Remarks  
 <CodeContentPlaceHolder>11\</CodeContentPlaceHolder> converts object of type [reference_wrapper](../vs140/reference_wrapper-class.md) to reference types and converts decaying arrays and functions to pointers.  
  
 In the returned <CodeContentPlaceHolder>12\</CodeContentPlaceHolder> object, <CodeContentPlaceHolder>13\</CodeContentPlaceHolder> is determined as follows:  
  
-   If the input type <CodeContentPlaceHolder>14\</CodeContentPlaceHolder> is <CodeContentPlaceHolder>15\</CodeContentPlaceHolder>, the returned type <CodeContentPlaceHolder>16\</CodeContentPlaceHolder> is <CodeContentPlaceHolder>17\</CodeContentPlaceHolder>.  
  
-   Otherwise, the returned type <CodeContentPlaceHolder>18\</CodeContentPlaceHolder> is <CodeContentPlaceHolder>19\</CodeContentPlaceHolder>. If [decay](../vs140/decay-class.md) is not supported, the returned type <CodeContentPlaceHolder>20\</CodeContentPlaceHolder> is the same as the input type <CodeContentPlaceHolder>21\</CodeContentPlaceHolder>.  
  
 The returned type <CodeContentPlaceHolder>22\</CodeContentPlaceHolder> is similarly determined from the input type <CodeContentPlaceHolder>23\</CodeContentPlaceHolder>.  
  
 One advantage of <CodeContentPlaceHolder>24\</CodeContentPlaceHolder> is that the types of objects that are being stored are determined automatically by the compiler and do not have to be explicitly specified. Don't use explicit template arguments such as <CodeContentPlaceHolder>25\</CodeContentPlaceHolder> when you use <CodeContentPlaceHolder>26\</CodeContentPlaceHolder> because it is unnecessarily verbose and adds complex rvalue reference problems that might cause compilation failure. For this example, the correct syntax would be <CodeContentPlaceHolder>27\</CodeContentPlaceHolder>  
  
 The <CodeContentPlaceHolder>28\</CodeContentPlaceHolder> helper function also makes it possible to pass two values to a function that requires a pair as an input parameter.  
  
## Example  
 For an example about how to use the helper function <CodeContentPlaceHolder>29\</CodeContentPlaceHolder> to declare and initialize a pair, see [pair Structure](../vs140/pair-structure.md).  
  
## Requirements  
 **Header:** \<utility>  
  
 **Namespace:** std  
  
## See Also  
 [\<utility>](../vs140/-utility-.md)   
 [lvalues and rvalues](../vs140/lvalues-and-rvalues--visual-c---.md)