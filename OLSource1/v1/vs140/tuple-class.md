---
title: "tuple Class"
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
  - "tr1::tuple"
  - "std.tr1.tuple"
  - "tuple"
  - "tr1.tuple"
  - "std::tr1::tuple"
  - "tuple/std::tr1::tuple"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "tuple class"
  - "tuple class [TR1]"
ms.assetid: c38749be-ae4d-41f3-98ea-6aa3250de9a3
caps.latest.revision: 19
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# tuple Class
Wraps a fixed-length sequence of elements.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>7\</CodeContentPlaceHolder>  
 The type of the Nth tuple element.  
  
## Remarks  
 The template class describes an object that stores N objects of types <CodeContentPlaceHolder>8\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>9\</CodeContentPlaceHolder>, ..., <CodeContentPlaceHolder>10\</CodeContentPlaceHolder>, respectively, where where <CodeContentPlaceHolder>11\</CodeContentPlaceHolder>. The extent of a tuple instance <CodeContentPlaceHolder>12\</CodeContentPlaceHolder> is the number <CodeContentPlaceHolder>13\</CodeContentPlaceHolder> of its template arguments. The index of the template argument <CodeContentPlaceHolder>14\</CodeContentPlaceHolder> and of the corresponding stored value of that type is <CodeContentPlaceHolder>15\</CodeContentPlaceHolder>. Thus, while we number the types from 1 to N in this documentation, the corresponding index values range from 0 to N - 1.  
  
## Example  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
## Requirements  
 **Header:** \<tuple>  
  
 **Namespace:** std  
  
##  \<a name="tuple__operator_eq">\</a>  tuple::operator=  
 Assigns a <CodeContentPlaceHolder>16\</CodeContentPlaceHolder> object.  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>17\</CodeContentPlaceHolder>  
 The type of the Nth copied tuple element.  
  
 <CodeContentPlaceHolder>18\</CodeContentPlaceHolder>  
 The tuple to copy from.  
  
### Remarks  
 The first two member operators assign the elements of <CodeContentPlaceHolder>19\</CodeContentPlaceHolder> to the corresponding elements of <CodeContentPlaceHolder>20\</CodeContentPlaceHolder>. The third member operator assigns <CodeContentPlaceHolder>21\</CodeContentPlaceHolder> to the element at index 0 of <CodeContentPlaceHolder>22\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>23\</CodeContentPlaceHolder> to the element at index 1. All three member operators return <CodeContentPlaceHolder>24\</CodeContentPlaceHolder>.  
  
 The remaining member operators are analogs to earlier ones, but with [rvalue references](../vs140/rvalue-reference-declarator----.md).  
  
### Example  
  
<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
   **0 1 2 3**  
 **0 1 2 3**  
 **x 4**    
##  \<a name="tuple_swap">\</a>  tuple:swap  
 Exchanges the elements of two tuples.  
  
<CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
### Parameters  
  
|Parameter|Description|  
|---------------|-----------------|  
|<CodeContentPlaceHolder>25\</CodeContentPlaceHolder>|A tuple whose elements are to be exchanged with those of the tuple <CodeContentPlaceHolder>26\</CodeContentPlaceHolder>.|  
|<CodeContentPlaceHolder>27\</CodeContentPlaceHolder>|A tuple whose elements are to be exchanged with those of the tuple <CodeContentPlaceHolder>28\</CodeContentPlaceHolder>.|  
  
### Remarks  
 The function executes <CodeContentPlaceHolder>29\</CodeContentPlaceHolder>.  
  
##  \<a name="tuple__tuple">\</a>  tuple::tuple  
 Constructs a <CodeContentPlaceHolder>30\</CodeContentPlaceHolder> object.  
  
<CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>31\</CodeContentPlaceHolder>  
 The type of the Nth copied tuple element.  
  
 <CodeContentPlaceHolder>32\</CodeContentPlaceHolder>  
 The tuple to copy from.  
  
### Remarks  
 The first constructor constructs an object whose elements are default constructed.  
  
 The second constructor constructs an object whose elements are copy constructed from the arguments <CodeContentPlaceHolder>33\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>34\</CodeContentPlaceHolder>, ..., <CodeContentPlaceHolder>35\</CodeContentPlaceHolder> with each <CodeContentPlaceHolder>36\</CodeContentPlaceHolder> initializing the element at index <CodeContentPlaceHolder>37\</CodeContentPlaceHolder>.  
  
 The third and fourth constructors construct an object whose elements are copy constructed from the corresponding element of <CodeContentPlaceHolder>38\</CodeContentPlaceHolder>.  
  
 The fifth constructor constructs an object whose element at index 0 is copy constructed from <CodeContentPlaceHolder>39\</CodeContentPlaceHolder> and whose element at index 1 is copy constructed from <CodeContentPlaceHolder>40\</CodeContentPlaceHolder>.  
  
 The remaining constructors are analogs to earlier ones, but with [rvalue references](../vs140/rvalue-reference-declarator----.md).  
  
### Example  
  
<CodeContentPlaceHolder>6\</CodeContentPlaceHolder>  
   **0 1 2 3**  
 **0 1 2 3**  
 **x 4**  
 **0 1 2 3**  
 **4 5 6 7**    
## See Also  
 [\<tuple>](../vs140/-tuple-.md)   
 [make_tuple](../vs140/-tuple--functions.md#make_tuple_function)