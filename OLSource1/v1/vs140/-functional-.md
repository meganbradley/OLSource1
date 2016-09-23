---
title: "&lt;functional&gt;"
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
  - <functional>
  - functional/std::<functional>
  - std.<functional>
  - std::<functional>
dev_langs: 
  - C++
helpviewer_keywords: 
  - functors
  - functional header
ms.assetid: 7dd463e8-a29f-49bc-aedd-8fa53b54bfbc
caps.latest.revision: 28
translation.priority.ht: 
  - de-de
  - ja-jp
---
# &lt;functional&gt;
Defines Standard Library functions that help construct *function objects*—also known as functors—and their binders. A function object is an object of a type that defines `operator()`. A function object can be a function pointer, but more typically, the object is used to store additional information that can be accessed during a function call.  
  
## Syntax  
  
```  
#include <functional>  
```  
  
## Remarks  
 Algorithms require two types of function objects: unary and binary. Unary function objects require one argument, and binary function objects require two arguments. A function object and function pointers can be passed as a predicate to an algorithm, but function objects are also adaptable and increase the scope, flexibility, and efficiency of the STL. If, for example, a value needed to be bound to a function before being passed to an algorithm, then a function pointer could not be used. Function adaptors convert function pointers into adaptable function objects that can be bound to a value. The header <functional\> also contains member function adaptors that allow member functions to be called as adaptable function objects. Functions are adaptable if they have nested type declarations specifying their argument and return types. The C++ Standard requires that this adaptability is implemented by having all standard object classes inherit from the unary_function or binary_function base classes. Function objects and their adaptors allow the STL to upgrade existing applications and help integrate the STL into the C++ programming environment.  
  
 The [!INCLUDE[vcprvc](../vs140/includes/vcprvc_md.md)] implementation of the function objects in <functional\> includes *transparent operator functors*, which are specializations of standard function objects and take no template parameters, and perform perfect forwarding of the function arguments and perfect return of the result. This feature is part of the C++14 Draft Standard specification. These template specializations do not require that you specify argument types when you invoke arithmetic, comparison, logical, and bitwise operator functors. You can overload arithmetic, comparison, logical, or bitwise operators for your own types, or for heterogeneous combinations of types, and then use the transparent operator functors as function arguments. For example, if your type *MyType* implements `operator<`, you can call `sort(my_collection.begin(), my_collection.end(), less<>())` instead of explicitly specifying the type `sort(my_collection.begin(), my_collection.end(), less<MyType>())`.  
  
## C++11/C++14 Implementation  
 The following features are added in the Visual C++ implementation of C++11/C++14:  
  
-   A *call signature* is the name of a return type followed by a parenthesized comma-separated list of zero or more argument types.  
  
-   A *callable type* is a pointer to function, a pointer to member function, a pointer to member data, or a class type whose objects can appear immediately to the left of a function call operator.  
  
-   A *callable object* is an object of a callable type.  
  
-   A *call wrapper type* is a type that holds a callable object and supports a call operation that forwards to that object.  
  
-   A *call wrapper* is an object of a call wrapper type.  
  
-   A *target object* is the callable object held by a call wrapper object.  
  
 The pseudo-function `INVOKE(f, t1, t2, ..., tN)` means one of the following things:  
  
-   `(t1.*f)(t2, ..., tN)` when `f` is a pointer to member function of class `T` and `t1` is an object of type `T` or a reference to an object of type `T` or a reference to an object of a type derived from `T`.  
  
-   `((*t1).*f)(t2, ..., tN)` when `f` is a pointer to member function of class `T` and `t1` is not one of the types described in the previous item.  
  
-   `t1.*f` when N == 1 and `f` is a pointer to member data of a class `T` and `t1` is an object of type `T` or a reference to an object of type `T` or a reference to an object of a type derived from `T`.  
  
-   `(*t1).*f` when N == 1 and `f` is a pointer to member data of a class `T` and `t1` is not one of the types described in the previous item.  
  
-   `f(t1, t2, ..., tN)` in all other cases.  
  
 The pseudo-function `INVOKE(f, t1, t2, ..., tN, R)` means `INVOKE(f, t1, t2, ..., tN)` implicitly converted to `R`.  
  
 If a call wrapper has a *weak result type*, the type of its member type `result_type` is based on the type `T` of the target object of the wrapper, as follows:  
  
-   If `T` is a pointer to function, `result_type` is a synonym for the return type of `T`.  
  
-   If `T` is a pointer to member function, `result_type` is a synonym for the return type of `T`.  
  
-   If `T` is a class type that has a member type `result_type`, then `result_type` is a synonym for `T::result_type`.  
  
-   Otherwise, there is no member `result_type`.  
  
 Every call wrapper has a move constructor and a copy constructor. A *simple call wrapper* is a call wrapper that has an assignment operator and whose copy constructor, move constructor, and assignment operator do not throw exceptions. A *forwarding call wrapper* is a call wrapper that can be called by using an arbitrary argument list and that delivers the arguments to the wrapped callable object as references. All rvalue arguments are delivered as rvalue references, and lvalue arguments are delivered as lvalue references.  
  
### Classes  
  
|||  
|-|-|  
|[bad_function_call](../vs140/bad_function_call-class.md)|A class that describes an exception thrown to indicate that a call to `operator()` on a [function](../vs140/function-class.md) object failed because the object was empty.|  
|[binary_negate](../vs140/binary_negate-class.md)|A template class providing a member function that negates the return value of a specified binary function.|  
|[binder1st](../vs140/binder1st-class.md)|A template class providing a constructor that converts a binary function object into a unary function object by binding the first argument of the binary function to a specified value.|  
|[binder2nd](../vs140/binder2nd-class.md)|A template class providing a constructor that converts a binary function object into a unary function object by binding the second argument of the binary function to a specified value.|  
|[const_mem_fun_ref_t](../vs140/const_mem_fun_ref_t-class.md)|An adapter class that allows a const member function that takes no arguments to be called as a unary function object when initialized with a reference argument.|  
|[const_mem_fun_t](../vs140/const_mem_fun_t-class.md)|An adapter class that allows a const member function that takes no arguments to be called as a unary function object when initialized with a pointer argument.|  
|[const_mem_fun1_ref_t](../vs140/const_mem_fun1_ref_t-class.md)|An adapter class that allows a const member function that takes a single argument to be called as a binary function object when initialized with a reference argument.|  
|[const_mem_fun1_t](../vs140/const_mem_fun1_t-class.md)|An adapter class that allows a const member function that takes a single argument to be called as a binary function object when initialized with a pointer argument.|  
|[function](../vs140/function-class.md)|A class that wraps a callable object.|  
|[hash](../vs140/hash-class.md)|A class that computes a hash code for a value.|  
|[is_bind_expression](../vs140/is_bind_expression-class.md)|A class that tests if a particular type is generated by calling `bind`.|  
|[is_placeholder](../vs140/is_placeholder-class.md)|A class that tests if a particular type is a placeholder.|  
|[mem_fun_ref_t](../vs140/mem_fun_ref_t-class.md)|An adapter class that allows a **non_const** member function that takes no arguments to be called as a unary function object when initialized with a reference argument.|  
|[mem_fun_t](../vs140/mem_fun_t-class.md)|An adapter class that allows a **non_const** member function that takes no arguments to be called as a unary function object when initialized with a pointer argument.|  
|[mem_fun1_ref_t](../vs140/mem_fun1_ref_t-class.md)|An adapter class that allows a **non_const** member function that takes a single argument to be called as a binary function object when initialized with a reference argument.|  
|[mem_fun1_t](../vs140/mem_fun1_t-class.md)|An adapter class that allows a **non_const** member function that takes a single argument to be called as a binary function object when initialized with a pointer argument.|  
|[pointer_to_binary_function](../vs140/pointer_to_binary_function-class.md)|Converts a binary function pointer into an adaptable binary function.|  
|[pointer_to_unary_function](../vs140/pointer_to_unary_function-class.md)|Converts a unary function pointer into an adaptable unary function.|  
|[reference_wrapper](../vs140/reference_wrapper-class.md)|A class that wraps a reference.|  
|[result_of](../vs140/result_of-class2.md)|A struct that holds the return type of a wrapped callable object.|  
|[unary_negate](../vs140/unary_negate-class.md)|A template class providing a member function that negates the return value of a specified unary function.|  
  
### Functions  
  
|||  
|-|-|  
|[bind](../vs140/-functional--functions.md#bind_function)|Binds arguments to a callable object.|  
|[bind1st](../vs140/-functional--functions.md#bind1st_function)|A helper template function that creates an adaptor to convert a binary function object into a unary function object by binding the first argument of the binary function to a specified value.|  
|[bind2nd](../vs140/-functional--functions.md#bind2nd_function)|A helper template function that creates an adaptor to convert a binary function object into a unary function object by binding the second argument of the binary function to a specified value.|  
|[bit_and](../vs140/-functional--functions.md#bit_and_function)|Returns the bitwise logical AND (binary operator&) of the two parameters.|  
|[bit_not](../vs140/-functional--functions.md#bit_not_function)|Returns the bitwise logical complement (operator~) of the parameter.|  
|[bit_or](../vs140/-functional--functions.md#bit_or_function)|Returns the bitwise logical OR (operator&#124;) of the two parameters.|  
|[bit_xor](../vs140/-functional--functions.md#bit_xor_function)|Returns the bitwise logical XOR (operator^) of the two parameters.|  
|[cref](../vs140/-functional--functions.md#cref_function)|Constructs a const `reference_wrapper` from an argument.|  
|[mem_fn](../vs140/-functional--functions.md#mem_fn_function)|Generates a simple call wrapper.|  
|[mem_fun](../vs140/-functional--functions.md#mem_fun_function)|Helper template functions used to construct function object adaptors for member functions when initialized with pointer arguments.|  
|[mem_fun_ref](../vs140/-functional--functions.md#mem_fun_ref_function)|A helper template function used to construct function object adaptors for member functions when initialized with reference arguments.|  
|[not1](../vs140/-functional--functions.md#not1_function)|Returns the complement of a unary predicate.|  
|[not2](../vs140/-functional--functions.md#not2_function)|Returns the complement of a binary predicate.|  
|[ptr_fun](../vs140/-functional--functions.md#ptr_fun_function)|A helper template function used to convert unary and binary function pointers, respectively, into unary and binary adaptable functions.|  
|[ref](../vs140/-functional--functions.md#ref_function)|Constructs a `reference_wrapper` from an argument.|  
|[swap](../vs140/-functional--functions.md#swap_function)|Swaps two `function` objects.|  
  
### Structs  
  
|||  
|-|-|  
|[binary_function](../vs140/binary_function-struct.md)|An empty base class that defines types that may be inherited by derived class that provides a binary function object.|  
|[divides](../vs140/divides-struct.md)|The class provides a predefined function object that performs the arithmetic operation of division on elements of a specified value type.|  
|[equal_to](../vs140/equal_to-struct.md)|A binary predicate that tests whether a value of a specified type is equal to another value of that type.|  
|[greater](../vs140/greater-struct.md)|A binary predicate that tests whether a value of a specified type is greater than another value of that type.|  
|[greater_equal](../vs140/greater_equal-struct.md)|A binary predicate that tests whether a value of a specified type is greater than or equal to another value of that type.|  
|[less](../vs140/less-struct.md)|A binary predicate that tests whether a value of a specified type is less than another value of that type.|  
|[less_equal](../vs140/less_equal-struct.md)|A binary predicate that tests whether a value of a specified type is less than or equal to another value of that type.|  
|[logical_and](../vs140/logical_and-struct.md)|The class provides a predefined function object that performs the logical operation of conjunction on elements of a specified value type and tests for the truth or falsity of the result.|  
|[logical_not](../vs140/logical_not-struct.md)|The class provides a predefined function object that performs the logical operation of negation on elements of a specified value type and tests for the truth or falsity of the result.|  
|[logical_or](../vs140/logical_or-struct.md)|The class provides a predefined function object that performs the logical operation of disjunction on elements of a specified value type and tests for the truth or falsity of the result.|  
|[minus](../vs140/minus-struct.md)|The class provides a predefined function object that performs the arithmetic operation of subtraction on elements of a specified value type.|  
|[modulus](../vs140/modulus-struct.md)|The class provides a predefined function object that performs the arithmetic operation of modulus on elements of a specified value type.|  
|[multiplies](../vs140/multiplies-struct.md)|The class provides a predefined function object that performs the arithmetic operation of multiplication on elements of a specified value type.|  
|[negate](../vs140/negate-struct.md)|The class provides a predefined function object that returns the negative of an element value.|  
|[not_equal_to](../vs140/not_equal_to-struct.md)|A binary predicate that tests whether a value of a specified type is not equal to another value of that type.|  
|[plus](../vs140/plus-struct.md)|The class provides a predefined function object that performs the arithmetic operation of addition on elements of a specified value type.|  
|[unary_function](../vs140/unary_function-struct.md)|An empty base class that defines types that may be inherited by derived class that provides a unary function object.|  
  
### Objects  
  
|||  
|-|-|  
|[_1.._M](../vs140/_1-object.md)|Placeholders for replaceable arguments.|  
  
### Operators  
  
|||  
|-|-|  
|[operator==](../vs140/-functional--operators.md#operator_eq_eq)|Disallows equality comparison of callable objects.|  
|[operator!=](../vs140/-functional--operators.md#operator_neq)|Disallows inequality comparison of callable objects.|  
  
## See Also  
 [Header Files](../vs140/c---standard-library-header-files.md)   
 [Thread Safety in the Standard C++ Library](../vs140/thread-safety-in-the-c---standard-library.md)   
 [Standard Template Library](../vs140/standard-template-library.md)