---
title: "combinable Class"
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
  - "ppl/concurrency::combinable"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "combinable class"
ms.assetid: fe0bfbf6-6250-47da-b8d0-f75369f0b5be
caps.latest.revision: 21
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# combinable Class
The             <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> object is intended to provide thread-private copies of data, to perform lock-free thread-local sub-computations during parallel algorithms. At the end of the parallel operation, the thread-private sub-computations can then be merged into a final result. This class can be used instead of a shared variable, and can result in a performance improvement if there would otherwise be a lot of contention on that shared variable.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>9\</CodeContentPlaceHolder>  
 The data type of the final merged result. The type must have a copy constructor and a default constructor.  
  
## Members  
  
### Public Constructors  
  
|Name|Description|  
|----------|-----------------|  
|[combinable::combinable Constructor](#combinable__combinable_constructor)|Overloaded. Constructs a new                                         <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> object.|  
|[combinable::~combinable Destructor](#combinable___dtorcombinable_destructor)|Destroys a                                         <CodeContentPlaceHolder>11\</CodeContentPlaceHolder> object.|  
  
### Public Methods  
  
|Name|Description|  
|----------|-----------------|  
|[combinable::clear Method](#combinable__clear_method)|Clears any intermediate computational results from a previous usage.|  
|[combinable::combine Method](#combinable__combine_method)|Computes a final value from the set of thread-local sub-computations by calling the supplied combine functor.|  
|[combinable::combine_each Method](#combinable__combine_each_method)|Computes a final value from the set of thread-local sub-computations by calling the supplied combine functor once per thread-local sub-computation. The final result is accumulated by the function object.|  
|[combinable::local Method](#combinable__local_method)|Overloaded. Returns a reference to the thread-private sub-computation.|  
  
### Public Operators  
  
|Name|Description|  
|----------|-----------------|  
|[combinable::operator= Operator](#combinable__operator_eq_operator)|Assigns to a                                         <CodeContentPlaceHolder>12\</CodeContentPlaceHolder> object from another                                         <CodeContentPlaceHolder>13\</CodeContentPlaceHolder> object.|  
  
## Remarks  
 For more information, see                 [Parallel Containers and Objects](../vs140/parallel-containers-and-objects.md).  
  
## Inheritance Hierarchy  
 <CodeContentPlaceHolder>14\</CodeContentPlaceHolder>  
  
## Requirements  
 **Header:** ppl.h  
  
 **Namespace:** concurrency  
  
##  \<a name="combinable__clear_method">\</a>  combinable::clear Method  
 Clears any intermediate computational results from a previous usage.  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
##  \<a name="combinable__combinable_constructor">\</a>  combinable::combinable Constructor  
 Constructs a new                 <CodeContentPlaceHolder>15\</CodeContentPlaceHolder> object.  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>16\</CodeContentPlaceHolder>  
 The type of the initialization functor object.  
  
 <CodeContentPlaceHolder>17\</CodeContentPlaceHolder>  
 A function which will be called to initialize each new thread-private value of the type                                 <CodeContentPlaceHolder>18\</CodeContentPlaceHolder>. It must support a function call operator with the signature                                 <CodeContentPlaceHolder>19\</CodeContentPlaceHolder>.  
  
 <CodeContentPlaceHolder>20\</CodeContentPlaceHolder>  
 An existing                                 <CodeContentPlaceHolder>21\</CodeContentPlaceHolder> object to be copied into this one.  
  
### Remarks  
 The first constructor initializes new elements with the default constructor for the type                         <CodeContentPlaceHolder>22\</CodeContentPlaceHolder>.  
  
 The second constructor initializes new elements using the initialization functor supplied as the                         <CodeContentPlaceHolder>23\</CodeContentPlaceHolder> parameter.  
  
 The third constructor is the copy constructor.  
  
##  \<a name="combinable___dtorcombinable_destructor">\</a>  combinable::~combinable Destructor  
 Destroys a                 <CodeContentPlaceHolder>24\</CodeContentPlaceHolder> object.  
  
<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
##  \<a name="combinable__combine_method">\</a>  combinable::combine Method  
 Computes a final value from the set of thread-local sub-computations by calling the supplied combine functor.  
  
<CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>25\</CodeContentPlaceHolder>  
 The type of the function object that will be invoked to combine two thread-local sub-computations.  
  
 <CodeContentPlaceHolder>26\</CodeContentPlaceHolder>  
 The functor that is used to combine the sub-computations. Its signature is                                 <CodeContentPlaceHolder>27\</CodeContentPlaceHolder> or                                 <CodeContentPlaceHolder>28\</CodeContentPlaceHolder>, and it must be associative and commutative.  
  
### Return Value  
 The final result of combining all the thread-private sub-computations.  
  
##  \<a name="combinable__combine_each_method">\</a>  combinable::combine_each Method  
 Computes a final value from the set of thread-local sub-computations by calling the supplied combine functor once per thread-local sub-computation. The final result is accumulated by the function object.  
  
<CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>29\</CodeContentPlaceHolder>  
 The type of the function object that will be invoked to combine a single thread-local sub-computation.  
  
 <CodeContentPlaceHolder>30\</CodeContentPlaceHolder>  
 The functor that is used to combine one sub-computation. Its signature is                                 <CodeContentPlaceHolder>31\</CodeContentPlaceHolder> or                                 <CodeContentPlaceHolder>32\</CodeContentPlaceHolder>, and must be associative and commutative.  
  
##  \<a name="combinable__local_method">\</a>  combinable::local Method  
 Returns a reference to the thread-private sub-computation.  
  
<CodeContentPlaceHolder>6\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>33\</CodeContentPlaceHolder>  
 A reference to a boolean. The boolean value referenced by this argument will be set to                                 <CodeContentPlaceHolder>34\</CodeContentPlaceHolder> if the sub-computation already existed on this thread, and set to                                 <CodeContentPlaceHolder>35\</CodeContentPlaceHolder> if this was the first sub-computation on this thread.  
  
### Return Value  
 A reference to the thread-private sub-computation.  
  
##  \<a name="combinable__operator_eq_operator">\</a>  combinable::operator= Operator  
 Assigns to a                 <CodeContentPlaceHolder>36\</CodeContentPlaceHolder> object from another                 <CodeContentPlaceHolder>37\</CodeContentPlaceHolder> object.  
  
<CodeContentPlaceHolder>7\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>38\</CodeContentPlaceHolder>  
 An existing                                 <CodeContentPlaceHolder>39\</CodeContentPlaceHolder> object to be copied into this one.  
  
### Return Value  
 A reference to this                         <CodeContentPlaceHolder>40\</CodeContentPlaceHolder> object.  
  
## See Also  
 [concurrency Namespace](../vs140/concurrency-namespace.md)