---
title: "forward_list::insert_after"
ms.custom: na
ms.date: 09/22/2016
ms.prod: visual-studio-dev14
ms.reviewer: na
ms.suite: na
ms.technology: 
  - devlang-cpp
ms.tgt_pltfrm: na
ms.topic: article
f1_keywords: 
  - std.forward_list.insert_after
  - std::forward_list::insert_after
  - forward_list.insert_after
  - insert_after
  - forward_list::insert_after
  - forward_list/std::forward_list::insert_after
dev_langs: 
  - C++
helpviewer_keywords: 
  - insert_after method
ms.assetid: 94fb6c2c-4a46-4997-bd62-e703ed5a7bba
caps.latest.revision: 13
translation.priority.mt: 
  - de-de
  - ja-jp
---
# forward_list::insert_after
Adds elements to the forward list after a specified position.  
  
## Syntax  
  
```  
iterator insert_after(  
    const_iterator Where,   
     const Type& Val);  
void insert_after(  
     const_iterator Where,      size_type Count,   
    const Type& Val);  
void insert_after(  
    const iterator Where,  
    initializer_list<Type> IList  
);  
iterator insert_after(  
    const_iterator Where,   
    Type&& Val  
);  
template<class InputIterator>  
    void insert_after(  
        const_iterator Where,   
        InputIterator First,  
        InputIterator Last  
    );  
  
```  
  
#### Parameters  
  
|Parameter|Description|  
|---------------|-----------------|  
|`Where`|The position in the target forward list where the first element is inserted.|  
|`Count`|The number of elements to insert.|  
|`First`|The beginning of the insertion range.|  
|`Last`|The end of the insertion range.|  
|`Val`|The element added to the forward list.|  
|`IList`|The initializer_list to insert.|  
  
## Return Value  
 An iterator that designates the newly inserted element (first and last member functions only).  
  
## Remarks  
 Each of the member functions inserts—just after the element pointed to by `Where` in the controlled sequence—a sequence that' specified by the remaining operands.  
  
 The first member function inserts an element that has value `Val` and returns an iterator that designates the newly inserted element.  
  
 The second member function inserts a repetition of `Count` elements of value `Val`.  
  
 If `InputIterator` is an integer type, the third member function behaves the same as `insert(it, (size_type)First, (Type)Last)`. Otherwise, it inserts the sequence `[First, Last)`, which must not overlap the initial controlled sequence.  
  
 The fourth member function inserts the sequence that's specified by an object of class `initializer_list<Type>`.  
  
 The last member function is the same as the first, but with an [rvalue](../vs140/rvalue-reference-declarator----.md) reference.  
  
 Inserting `N` elements causes `N` constructor calls. [Reallocation](../vs140/forward_list-class.md) occurs, but no iterators or references become invalid.  
  
 If an exception is thrown during the insertion of one or more elements, the container is left unaltered and the exception is rethrown.  
  
## Requirements  
 **Header:** <forward_list>  
  
 **Namespace:** std  
  
## See Also  
 [forward_list Class](../vs140/forward_list-class.md)