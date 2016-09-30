---
title: "back_insert_iterator Class"
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
  - "iterator/std::back_insert_iterator"
  - "std::back_insert_iterator"
  - "back_insert_iterator"
  - "std.back_insert_iterator"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "back_insert_iterator class"
ms.assetid: a1ee07f2-cf9f-46a1-8608-cfaf207f9713
caps.latest.revision: 19
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# back_insert_iterator Class
Describes an iterator adaptor that satisfies the requirements of an output iterator. It inserts, rather than overwrites, elements into the back end of a sequence and thus provides semantics that are different from the overwrite semantics provided by the iterators of the C++ sequence containers. The             <CodeContentPlaceHolder>13\</CodeContentPlaceHolder> class is templatized on the type of container.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>14\</CodeContentPlaceHolder>  
 The type of container into the back of which elements are to be inserted by a                         <CodeContentPlaceHolder>15\</CodeContentPlaceHolder>.  
  
## Remarks  
 The container must satisfy the requirements for a back insertion sequence where is it possible to insert elements at the end of the sequence in amortized constant time. STL sequence containers defined by the                 [deque Class](../vs140/deque-class.md),                 [list Class](../vs140/list-class.md) and                 [vector Class](../vs140/vector-class.md) provide the needed                 <CodeContentPlaceHolder>16\</CodeContentPlaceHolder> member function and satisfy these requirements. These three containers as well as strings may each be adapted to use with                 <CodeContentPlaceHolder>17\</CodeContentPlaceHolder>s. A                 <CodeContentPlaceHolder>18\</CodeContentPlaceHolder> must always be initialized with its container.  
  
### Constructors  
  
|||  
|-|-|  
|[back_insert_iterator](#back_insert_iterator__back_insert_iterator)|Constructs a                                         <CodeContentPlaceHolder>19\</CodeContentPlaceHolder> that inserts elements after the last element in a container.|  
  
### Typedefs  
  
|||  
|-|-|  
|[container_type](#back_insert_iterator__container_type)|A type that provides a container for the                                         <CodeContentPlaceHolder>20\</CodeContentPlaceHolder>.|  
|[reference](#back_insert_iterator__reference)|A type that provides a reference for the                                         <CodeContentPlaceHolder>21\</CodeContentPlaceHolder>.|  
  
### Operators  
  
|||  
|-|-|  
|[operator*](#back_insert_iterator__operator_star)|Dereferencing operator used to implement the output iterator expression *                                        <CodeContentPlaceHolder>22\</CodeContentPlaceHolder> =                                         <CodeContentPlaceHolder>23\</CodeContentPlaceHolder> for a back insertion.|  
|[operator++](#back_insert_iterator__operator_add_add)|Increments the                                         <CodeContentPlaceHolder>24\</CodeContentPlaceHolder> to the next location into which a value may be stored.|  
|[operator=](#back_insert_iterator__operator_eq)|Assignment operator used to implement the output iterator expression *                                        <CodeContentPlaceHolder>25\</CodeContentPlaceHolder> =                                         <CodeContentPlaceHolder>26\</CodeContentPlaceHolder> for a back insertion.|  
  
## Requirements  
 **Header**: \<iterator>  
  
 **Namespace:** std  
  
##  \<a name="back_insert_iterator__back_insert_iterator">\</a>  back_insert_iterator::back_insert_iterator  
 Constructs a                 <CodeContentPlaceHolder>27\</CodeContentPlaceHolder> that inserts elements after the last element in a container.  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>28\</CodeContentPlaceHolder>  
 The container that the                                 <CodeContentPlaceHolder>29\</CodeContentPlaceHolder> is to insert an element into.  
  
### Return Value  
 A                         <CodeContentPlaceHolder>30\</CodeContentPlaceHolder> for the parameter container.  
  
### Example  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
  **The initial vector vec is: ( 1 2 3 ).**  
**After the insertions, the vector vec is: ( 1 2 3 40 50 600 700 ).**    
##  \<a name="back_insert_iterator__container_type">\</a>  back_insert_iterator::container_type  
 A type that provides a container for the                 <CodeContentPlaceHolder>31\</CodeContentPlaceHolder>.  
  
<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
### Remarks  
 The type is a synonym for the template parameter                         **Container**.  
  
### Example  
  
<CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
  **The original vector vec is: ( 1 2 3 ).**  
**After the insertion, the vector is: ( 1 2 3 40 ).**    
##  \<a name="back_insert_iterator__operator_star">\</a>  back_insert_iterator::operator*  
 Dereferencing operator used to implement the output iterator expression \*                *i* =                 *x*.  
  
<CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
### Return Value  
 A reference to the element inserted at the back of the container.  
  
### Remarks  
 Used to implement the output iterator expression                         **\*Iter** =                         **value**. If                         **Iter** is an iterator that addresses an element in a sequence, then                         **\*Iter** =                         **value** replaces that element with value and does not change the total number of elements in the sequence.  
  
### Example  
  
<CodeContentPlaceHolder>6\</CodeContentPlaceHolder>  
  **The vector vec is: ( 1 2 3 ).**  
**After the insertions, the vector vec becomes: ( 1 2 3 10 20 ).**    
##  \<a name="back_insert_iterator__operator_add_add">\</a>  back_insert_iterator::operator++  
 Increments the                 <CodeContentPlaceHolder>32\</CodeContentPlaceHolder> to the next location into which a value may be stored.  
  
<CodeContentPlaceHolder>7\</CodeContentPlaceHolder>  
### Return Value  
 A                         <CodeContentPlaceHolder>33\</CodeContentPlaceHolder> addressing the next location into which a value may be stored.  
  
### Remarks  
 Both preincrementation and postincrementation operators return the same result.  
  
### Example  
  
<CodeContentPlaceHolder>8\</CodeContentPlaceHolder>  
  **The vector vec is: ( 10 20 ).**  
**After the insertions, the vector vec becomes: ( 10 20 30 40 ).**    
##  \<a name="back_insert_iterator__operator_eq">\</a>  back_insert_iterator::operator=  
 Appends or pushes a value onto the back end of a container.  
  
<CodeContentPlaceHolder>9\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>34\</CodeContentPlaceHolder>  
 The value to be inserted into the container.  
  
### Return Value  
 A reference to the last element inserted at the back of the container.  
  
### Remarks  
 The first member operator evaluates                         <CodeContentPlaceHolder>35\</CodeContentPlaceHolder>,  
  
 then returns                         <CodeContentPlaceHolder>36\</CodeContentPlaceHolder>. The second member operator evaluates  
  
 <CodeContentPlaceHolder>37\</CodeContentPlaceHolder>,  
  
 then returns                         <CodeContentPlaceHolder>38\</CodeContentPlaceHolder>.  
  
### Example  
  
<CodeContentPlaceHolder>10\</CodeContentPlaceHolder>  
##  \<a name="back_insert_iterator__reference">\</a>  back_insert_iterator::reference  
 A type that provides a reference for the                 <CodeContentPlaceHolder>39\</CodeContentPlaceHolder>.  
  
<CodeContentPlaceHolder>11\</CodeContentPlaceHolder>  
### Remarks  
 The type describes a reference to an element of the sequence controlled by the associated container.  
  
### Example  
  
<CodeContentPlaceHolder>12\</CodeContentPlaceHolder>  
  **The vector vec is: ( 1 2 3 ).**  
**The last element in the vector vec is: 3.**    
## See Also  
 [\<iterator>](../vs140/-iterator-.md)   
 [Thread Safety in the Standard C++ Library](../vs140/thread-safety-in-the-c---standard-library.md)   
 [Standard Template Library](../vs140/standard-template-library.md)