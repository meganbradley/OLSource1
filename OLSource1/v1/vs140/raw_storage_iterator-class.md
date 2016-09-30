---
title: "raw_storage_iterator Class"
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
  - "std::raw_storage_iterator"
  - "raw_storage_iterator"
  - "std.raw_storage_iterator"
  - "memory/std::raw_storage_iterator"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "raw_storage_iterator class"
ms.assetid: 6f033f15-f48e-452a-a326-647ea2cf346f
caps.latest.revision: 19
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# raw_storage_iterator Class
An adaptor class that is provided to enable algorithms to store their results into uninitialized memory.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>11\</CodeContentPlaceHolder>  
 Specifies the output iterator for the object being stored.  
  
 *Type*  
 The type of object for which storage is being allocated.  
  
## Remarks  
 The class describes an output iterator that constructs objects of type **Type** in the sequence it generates. An object of class <CodeContentPlaceHolder>12\</CodeContentPlaceHolder>\< **ForwardIterator**, **Type**> accesses storage through a forward iterator object, of class **ForwardIterator**, that you specify when you construct the object. For an object first of class **ForwardIterator**, the expression **&\*first** must designate unconstructed storage for the next object (of type **Type**) in the generated sequence.  
  
 This adaptor class is used when it is necessary to separate memory allocation and object construction. The <CodeContentPlaceHolder>13\</CodeContentPlaceHolder> can be used to copy objects into uninitialized storage, such as memory allocated using the <CodeContentPlaceHolder>14\</CodeContentPlaceHolder> function.  
  
## Members  
  
### Constructors  
  
|||  
|-|-|  
|[raw_storage_iterator](#raw_storage_iterator__raw_storage_iterator)|Constructs a raw storage iterator with a specified underlying output iterator.|  
  
### Typedefs  
  
|||  
|-|-|  
|[element_type](#raw_storage_iterator__element_type)|Provides a type that describes an element to be stored a raw storage iterator.|  
|[iter_type](#raw_storage_iterator__iter_type)|Provides a type that describes an iterator that underlies a raw storage iterator.|  
  
### Operators  
  
|||  
|-|-|  
|[operator*](#raw_storage_iterator__operator_star)|A dereferencing operator used to implement the output iterator expression * <CodeContentPlaceHolder>15\</CodeContentPlaceHolder> = <CodeContentPlaceHolder>16\</CodeContentPlaceHolder>.|  
|[operator=](#raw_storage_iterator__operator_eq)|An assignment operator used to implement the raw storage iterator expression * <CodeContentPlaceHolder>17\</CodeContentPlaceHolder> = <CodeContentPlaceHolder>18\</CodeContentPlaceHolder> for storing in memory.|  
|[operator++](#raw_storage_iterator__operator_add_add)|Preincrement and postincrement operators for raw storage iterators.|  
  
## Requirements  
 **Header:** \<memory>  
  
 **Namespace:** std  
  
##  \<a name="raw_storage_iterator__element_type">\</a>  raw_storage_iterator::element_type  
 Provides a type that describes an element to be stored a raw storage iterator.  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
### Remarks  
 The type is a synonym for the raw_storage_iterator class template parameter **Type**.  
  
##  \<a name="raw_storage_iterator__iter_type">\</a>  raw_storage_iterator::iter_type  
 Provides a type that describes an iterator that underlies a raw storage iterator.  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
### Remarks  
 The type is a synonym for the template parameter **ForwardIterator**.  
  
##  \<a name="raw_storage_iterator__operator_star">\</a>  raw_storage_iterator::operator*  
 A dereferencing operator used to implement the raw storage iterator expression \*                *ii* =                 *x*.  
  
<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
### Return Value  
 A reference to the raw storage iterator  
  
### Remarks  
 The requirements for a **ForwardIterator** are that the raw storage iterator must satisfy require only the expression \*                        *ii* =                         *t* be valid and that it says nothing about the **operator** or the <CodeContentPlaceHolder>19\</CodeContentPlaceHolder> on their own. The member operators in this implementation returns **\*this**, so that [operator=](#raw_storage_iterator__operator_eq)( **constType**&) can perform the actual store in an expression, such as \*                        *_Ptr* = <CodeContentPlaceHolder>20\</CodeContentPlaceHolder>.  
  
### Example  
  
<CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
##  \<a name="raw_storage_iterator__operator_eq">\</a>  raw_storage_iterator::operator=  
 Assignment operator used to implement the raw storage iterator expression \*                *i* =                 *x* for storing in memory.  
  
<CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>21\</CodeContentPlaceHolder>  
 The value of the object of type **Type** to be inserted into memory.  
  
### Return Value  
 The operator inserts <CodeContentPlaceHolder>22\</CodeContentPlaceHolder> into memory, and then returns a reference to the raw storage iterator.  
  
### Remarks  
 The requirements for a **ForwardIterator** state that the raw storage iterator must satisfy require only the expression \*                        *ii* =                         *t* be valid, and that it says nothing about the **operator** or the <CodeContentPlaceHolder>23\</CodeContentPlaceHolder> on their own. These member operators return **\*this**.  
  
 The assignment operator constructs the next object in the output sequence using the stored iterator value first, by evaluating the placement new expression **new** ( ( <CodeContentPlaceHolder>24\</CodeContentPlaceHolder> \*)&\* **first**) **Type**( <CodeContentPlaceHolder>25\</CodeContentPlaceHolder>).  
  
### Example  
  
<CodeContentPlaceHolder>6\</CodeContentPlaceHolder>  
##  \<a name="raw_storage_iterator__operator_add_add">\</a>  raw_storage_iterator::operator++  
 Preincrement and postincrement operators for raw storage iterators.  
  
<CodeContentPlaceHolder>7\</CodeContentPlaceHolder>  
### Return Value  
 An raw storage iterator or a reference to an raw storage iterator.  
  
### Remarks  
 The first operator eventually attempts to extract and store an object of type **CharType** from the associated input stream. The second operator makes a copy of the object, increments the object, and then returns the copy.  
  
 The first preincrement operator increments the stored output iterator object, and then returns **\*this**.  
  
 The second postincrement operator makes a copy of **\*this**, increments the stored output iterator object, and then returns the copy.  
  
 The constructor stores **first** as the output iterator object.  
  
### Example  
  
<CodeContentPlaceHolder>8\</CodeContentPlaceHolder>  
##  \<a name="raw_storage_iterator__raw_storage_iterator">\</a>  raw_storage_iterator::raw_storage_iterator  
 Constructs a raw storage iterator with a specified underlying output iterator.  
  
<CodeContentPlaceHolder>9\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>26\</CodeContentPlaceHolder>  
 The forward iterator that is to underlie the <CodeContentPlaceHolder>27\</CodeContentPlaceHolder> object being constructed.  
  
### Example  
  
<CodeContentPlaceHolder>10\</CodeContentPlaceHolder>  
## See Also  
 [Thread Safety in the Standard C++ Library](../vs140/thread-safety-in-the-c---standard-library.md)