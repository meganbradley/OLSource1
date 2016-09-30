---
title: "insert_iterator Class"
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
  - "std::insert_iterator"
  - "iterator/std::insert_iterator"
  - "std.insert_iterator"
  - "insert_iterator"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "insert_iterator class"
  - "insert_iterator class, syntax"
ms.assetid: d5d86405-872e-4e3b-9e68-c69a2b7e8221
caps.latest.revision: 19
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# insert_iterator Class
Describes an iterator adaptor that satisfies the requirements of an output iterator. It inserts, rather than overwrites, elements into a sequence and thus provides semantics that are different from the overwrite semantics provided by the iterators of the C++ sequence and associative containers. The <CodeContentPlaceHolder>13\</CodeContentPlaceHolder> class is templatized on the type of container being adapted.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>14\</CodeContentPlaceHolder>  
 The type of container into which elements are to be inserted by an <CodeContentPlaceHolder>15\</CodeContentPlaceHolder>.  
  
## Remarks  
 The container of type **Container** must satisfy the requirements for a variable-sized container and have a two-argument insert member function where the parameters are of type **Container::iterator** and **Container::value_type** and that returns a type **Container::iterator**. Standard Template Library sequence and sorted associative containers satisfy these requirements and can be adapted to use with <CodeContentPlaceHolder>16\</CodeContentPlaceHolder>s. For associative containers, the position argument is treated as a hint, which has the potential to improve or degrade performance depending on how good the hint is. An <CodeContentPlaceHolder>17\</CodeContentPlaceHolder> must always be initialized with its container.  
  
### Constructors  
  
|||  
|-|-|  
|[insert_iterator](#insert_iterator__insert_iterator)|Constructs an <CodeContentPlaceHolder>18\</CodeContentPlaceHolder> that inserts an element into a specified position in a container.|  
  
### Typedefs  
  
|||  
|-|-|  
|[container_type](#insert_iterator__container_type)|A type that represents the container into which a general insertion is to be made.|  
|[reference](#insert_iterator__reference)|A type that provides a reference to an element in a sequence controlled by the associated container.|  
  
### Operators  
  
|||  
|-|-|  
|[operator*](#insert_iterator__operator_star)|Dereferencing operator used to implement the output iterator expression * <CodeContentPlaceHolder>19\</CodeContentPlaceHolder> = <CodeContentPlaceHolder>20\</CodeContentPlaceHolder> for a general insertion.|  
|[operator++](#insert_iterator__operator_add_add)|Increments the <CodeContentPlaceHolder>21\</CodeContentPlaceHolder> to the next location into which a value may be stored.|  
|[operator=](#insert_iterator__operator_eq)|Assignment operator used to implement the output iterator expression * <CodeContentPlaceHolder>22\</CodeContentPlaceHolder> = <CodeContentPlaceHolder>23\</CodeContentPlaceHolder> for a general insertion.|  
  
## Requirements  
 **Header**: \<iterator>  
  
 **Namespace:** std  
  
##  \<a name="insert_iterator__container_type">\</a>  insert_iterator::container_type  
 A type that represents the container into which a general insertion is to be made.  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
### Remarks  
 The type is a synonym for the template parameter **Container**.  
  
### Example  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
##  \<a name="insert_iterator__insert_iterator">\</a>  insert_iterator::insert_iterator  
 Constructs an <CodeContentPlaceHolder>24\</CodeContentPlaceHolder> that inserts an element into a specified position in a container.  
  
<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>25\</CodeContentPlaceHolder>  
 The container into which the <CodeContentPlaceHolder>26\</CodeContentPlaceHolder> is to insert elements.  
  
 <CodeContentPlaceHolder>27\</CodeContentPlaceHolder>  
 The position for the insertion.  
  
### Remarks  
 All containers have the insert member function called by the <CodeContentPlaceHolder>28\</CodeContentPlaceHolder>. For associative containers the position parameter is merely a suggestion. The inserter function provides a convenient way to insert to values.  
  
### Example  
  
<CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
##  \<a name="insert_iterator__operator_star">\</a>  insert_iterator::operator*  
 Dereferences the insert iterator returning the element is addresses.  
  
<CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
### Return Value  
 The member function returns the value of the element addressed.  
  
### Remarks  
 Used to implement the output iterator expression **\*Iter** = **value**. If **Iter** is an iterator that addresses an element in a sequence, then **\*Iter** = **value** replaces that element with value and does not change the total number of elements in the sequence.  
  
### Example  
  
<CodeContentPlaceHolder>6\</CodeContentPlaceHolder>  
##  \<a name="insert_iterator__operator_add_add">\</a>  insert_iterator::operator++  
 Increments the  **insert_iterator** to the next location into which a value may be stored.  
  
<CodeContentPlaceHolder>7\</CodeContentPlaceHolder>  
### Parameters  
 A <CodeContentPlaceHolder>29\</CodeContentPlaceHolder> addressing the next location into which a value may be stored.  
  
### Remarks  
 Both preincrementation and postincrementation operators return the same result.  
  
### Example  
  
<CodeContentPlaceHolder>8\</CodeContentPlaceHolder>  
##  \<a name="insert_iterator__operator_eq">\</a>  insert_iterator::operator=  
 Inserts a value into the container and returns the iterator updated to point to the new element.  
  
<CodeContentPlaceHolder>9\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>30\</CodeContentPlaceHolder>  
 The value to be assigned to the container.  
  
### Return Value  
 A reference to the element inserted into the container.  
  
### Remarks  
 The first member operator evaluates  
  
 <CodeContentPlaceHolder>31\</CodeContentPlaceHolder>;  
  
 <CodeContentPlaceHolder>32\</CodeContentPlaceHolder>  
  
 then returns <CodeContentPlaceHolder>33\</CodeContentPlaceHolder>.  
  
 The second member operator evaluates  
  
 <CodeContentPlaceHolder>34\</CodeContentPlaceHolder>  
  
 <CodeContentPlaceHolder>35\</CodeContentPlaceHolder>  
  
 then returns <CodeContentPlaceHolder>36\</CodeContentPlaceHolder>.  
  
### Example  
  
<CodeContentPlaceHolder>10\</CodeContentPlaceHolder>  
##  \<a name="insert_iterator__reference">\</a>  insert_iterator::reference  
 A type that provides a reference to an element in a sequence controlled by the associated container.  
  
<CodeContentPlaceHolder>11\</CodeContentPlaceHolder>  
### Remarks  
 The type describes a reference to an element of the sequence controlled by the associated container.  
  
### Example  
  
<CodeContentPlaceHolder>12\</CodeContentPlaceHolder>  
## See Also  
 [\<iterator>](../vs140/-iterator-.md)   
 [Thread Safety in the Standard C++ Library](../vs140/thread-safety-in-the-c---standard-library.md)   
 [Standard Template Library](../vs140/standard-template-library.md)