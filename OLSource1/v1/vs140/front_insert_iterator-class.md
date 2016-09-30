---
title: "front_insert_iterator Class"
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
  - "iterator/std::front_insert_iterator"
  - "std::front_insert_iterator"
  - "std.front_insert_iterator"
  - "front_insert_iterator"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "front_insert_iterator class"
ms.assetid: a9a9c075-136a-4419-928b-c4871afa033c
caps.latest.revision: 18
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# front_insert_iterator Class
Describes an iterator adaptor that satisfies the requirements of an output iterator. It inserts, rather than overwrites, elements into the front of a sequence and thus provides semantics that are different from the overwrite semantics provided by the iterators of the C++ sequence containers. The <CodeContentPlaceHolder>13\</CodeContentPlaceHolder> class is templatized on the type of container.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>14\</CodeContentPlaceHolder>  
 The type of container into the front of which elements are to be inserted by a <CodeContentPlaceHolder>15\</CodeContentPlaceHolder>.  
  
## Remarks  
 The container must satisfy the requirements for a front insertion sequence where is it possible to insert elements at the beginning of the sequence in amortized constant time. The Standard Template Library sequence containers defined by the [deque Class](../vs140/deque-class.md) and [list Class](../vs140/list-class.md) provide the needed <CodeContentPlaceHolder>16\</CodeContentPlaceHolder> member function and satisfy these requirements. By contrast, sequence containers defined by the [vector Class](../vs140/vector-class.md) do not satisfy these requirements and cannot be adapted to use with <CodeContentPlaceHolder>17\</CodeContentPlaceHolder>s. A <CodeContentPlaceHolder>18\</CodeContentPlaceHolder> must always be initialized with its container.  
  
### Constructors  
  
|||  
|-|-|  
|[front_insert_iterator](#front_insert_iterator__front_insert_iterator)|Creates an iterator that can insert elements at the front of a specified container object.|  
  
### Typedefs  
  
|||  
|-|-|  
|[container_type](#front_insert_iterator__container_type)|A type that represents the container into which a front insertion is to be made.|  
|[reference](#front_insert_iterator__reference)|A type that provides a reference to an element in a sequence controlled by the associated container.|  
  
### Operators  
  
|||  
|-|-|  
|[operator*](#front_insert_iterator__operator_star)|Dereferencing operator used to implement the output iterator expression * <CodeContentPlaceHolder>19\</CodeContentPlaceHolder> = <CodeContentPlaceHolder>20\</CodeContentPlaceHolder> for a front insertion.|  
|[operator++](#front_insert_iterator__operator_add_add)|Increments the <CodeContentPlaceHolder>21\</CodeContentPlaceHolder> to the next location into which a value may be stored.|  
|[operator=](#front_insert_iterator__operator_eq)|Assignment operator used to implement the output iterator expression * <CodeContentPlaceHolder>22\</CodeContentPlaceHolder> = <CodeContentPlaceHolder>23\</CodeContentPlaceHolder> for a front insertion.|  
  
## Requirements  
 **Header**: \<iterator>  
  
 **Namespace:** std  
  
##  \<a name="front_insert_iterator__container_type">\</a>  front_insert_iterator::container_type  
 A type that represents the container into which a front insertion is to be made.  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
### Remarks  
 The type is a synonym for the template parameter **Container**.  
  
### Example  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
##  \<a name="front_insert_iterator__front_insert_iterator">\</a>  front_insert_iterator::front_insert_iterator  
 Creates an iterator that can insert elements at the front of a specified container object.  
  
<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>24\</CodeContentPlaceHolder>  
 The container object into which the <CodeContentPlaceHolder>25\</CodeContentPlaceHolder> is to insert elements.  
  
### Return Value  
 A <CodeContentPlaceHolder>26\</CodeContentPlaceHolder> for the parameter container object.  
  
### Example  
  
<CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
##  \<a name="front_insert_iterator__operator_star">\</a>  front_insert_iterator::operator*  
 Dereferences the insert iterator returning the element it addresses.  
  
<CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
### Return Value  
 The member function returns the value of the element addressed.  
  
### Remarks  
 Used to implement the output iterator expression **\*Iter** = **value**. If **Iter** is an iterator that addresses an element in a sequence, then **\*Iter** = **value** replaces that element with value and does not change the total number of elements in the sequence.  
  
### Example  
  
<CodeContentPlaceHolder>6\</CodeContentPlaceHolder>  
##  \<a name="front_insert_iterator__operator_add_add">\</a>  front_insert_iterator::operator++  
 Increments the <CodeContentPlaceHolder>27\</CodeContentPlaceHolder> to the next location into which a value may be stored.  
  
<CodeContentPlaceHolder>7\</CodeContentPlaceHolder>  
### Return Value  
 A <CodeContentPlaceHolder>28\</CodeContentPlaceHolder> addressing the next location into which a value may be stored.  
  
### Remarks  
 Both preincrementation and postincrementation operators return the same result.  
  
### Example  
  
<CodeContentPlaceHolder>8\</CodeContentPlaceHolder>  
##  \<a name="front_insert_iterator__operator_eq">\</a>  front_insert_iterator::operator=  
 Appends (pushes) a value onto the front of the container.  
  
<CodeContentPlaceHolder>9\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>29\</CodeContentPlaceHolder>  
 The value to be assigned to the container.  
  
### Return Value  
 A reference to the last element inserted at the front of the container.  
  
### Remarks  
 The first member operator evaluates <CodeContentPlaceHolder>30\</CodeContentPlaceHolder>, then returns <CodeContentPlaceHolder>31\</CodeContentPlaceHolder>.  
  
 The second member operator evaluates  
  
 <CodeContentPlaceHolder>32\</CodeContentPlaceHolder>,  
  
 then returns <CodeContentPlaceHolder>33\</CodeContentPlaceHolder>.  
  
### Example  
  
<CodeContentPlaceHolder>10\</CodeContentPlaceHolder>  
##  \<a name="front_insert_iterator__reference">\</a>  front_insert_iterator::reference  
 A type that provides a reference to an element in a sequence controlled by the associated container.  
  
<CodeContentPlaceHolder>11\</CodeContentPlaceHolder>  
### Example  
  
<CodeContentPlaceHolder>12\</CodeContentPlaceHolder>  
## See Also  
 [\<iterator>](../vs140/-iterator-.md)   
 [Thread Safety in the Standard C++ Library](../vs140/thread-safety-in-the-c---standard-library.md)   
 [Standard Template Library](../vs140/standard-template-library.md)