---
title: "&lt;type_traits&gt;"
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
  - "<type_traits>"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "typetrait header [TR1]"
  - "type_traits"
ms.assetid: 2260b51f-8160-4c66-a82f-00b534cb60d4
caps.latest.revision: 37
translation.priority.mt: 
  - "de-de"
  - "ja-jp"
---
# &lt;type_traits&gt;
Defines templates that provide compile-time constants that give information about the properties of their type arguments or produce transformed types.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Remarks  
 The classes and templates in <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> are used to support type inference, classification, and transformation at compile time, to detect type-related errors, and to help you optimize your generic code. These classes and templates include unary type traits that describe a property of a type, binary type traits that describe a relationship between types, and transformation traits that modify a property of a type.  
  
 To support type traits, a helper class, <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>, is defined. It has template specializations <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> that form the base classes for type predicates. A *type predicate* is a template that takes one or more type arguments. When a type predicate *holds true*, it is publicly derived, directly or indirectly, from [true_type](../vs140/-type_traits--typedefs.md#true_type_typedef). When a type predicate *holds false*, it is publicly derived, directly or indirectly, from [false_type](../vs140/-type_traits--typedefs.md#false_type_typedef).  
  
 A *type modifier* or *transformation trait* is a template that takes one or more template arguments and has one member, <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>, which is a synonym for the modified type.  
  
### Alias Templates  
 To simplify type traits expressions, [alias templates](../vs140/aliases-and-typedefs--c---.md) for <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> are provided, where " <CodeContentPlaceHolder>8\</CodeContentPlaceHolder>" is the template class name. For example, [add_const](../vs140/add_const-class.md) has an alias template for its type, <CodeContentPlaceHolder>9\</CodeContentPlaceHolder>, defined as:  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
|||||  
|-|-|-|-|  
|add_const_t|aligned_storage_t|make_signed_t|remove_pointer_t|  
|add_cv_t|aligned_union_t|make_unsigned_t|remove_reference_t|  
|add_lvalue_reference_t|common_type_t|remove_all_extents_t|remove_volatile_t|  
|add_pointer_t|conditional_t|remove_const_t|result_of_t|  
|add_rvalue_reference_t|decay_t|remove_cv_t|underlying_type_t|  
|add_volatile_t|enable_if_t|remove_extent_t||  
  
### Classes  
 Helper class and typedefs  
  
|||  
|-|-|  
|[integral_constant](../vs140/integral_constant-class--bool_constant-class.md)|Makes an integral constant from a type and a value.|  
|[true_type](../vs140/-type_traits--typedefs.md#true_type_typedef)|Holds integral constant with true value.|  
|[false_type](../vs140/-type_traits--typedefs.md#false_type_typedef)|Holds integral constant with false value.|  
  
 Primary type categories  
  
|||  
|-|-|  
|[is_void](../vs140/is_void-class.md)|Tests whether the type is <CodeContentPlaceHolder>10\</CodeContentPlaceHolder>.|  
|[is_null_pointer](../vs140/is_null_pointer-class.md)|Tests whether the type is <CodeContentPlaceHolder>11\</CodeContentPlaceHolder>.|  
|[is_integral](../vs140/is_integral-class.md)|Tests whether the type is integral.|  
|[is_floating_point](../vs140/is_floating_point-class.md)|Tests whether the type is floating-point.|  
|[is_array](../vs140/is_array-class.md)|Tests whether the type is an array.|  
|[is_pointer](../vs140/is_pointer-class.md)|Tests whether the type is a pointer.|  
|[is_lvalue_reference](../vs140/is_lvalue_reference-class.md)|Tests if type is an lvalue reference.|  
|[is_rvalue_reference](../vs140/is_rvalue_reference-class.md)|Tests if type is an rvalue reference.|  
|[is_member_object_pointer](../vs140/is_member_object_pointer-class.md)|Tests whether the type is a pointer to a member object.|  
|[is_member_function_pointer](../vs140/is_member_function_pointer-class.md)|Tests whether the type is a pointer to a member function.|  
|[is_enum](../vs140/is_enum-class.md)|Tests whether the type is an enumeration.|  
|[is_union](../vs140/is_union-class.md)|Tests whether the type is a union.|  
|[is_class](../vs140/is_class-class.md)|Tests whether the type is a class.|  
|[is_function](../vs140/is_function-class.md)|Tests whether the type is a function type.|  
  
 Composite type categories  
  
|||  
|-|-|  
|[is_reference](../vs140/is_reference-class.md)|Tests whether the type is a reference.|  
|[is_arithmetic](../vs140/is_arithmetic-class.md)|Tests whether the type is arithmetic.|  
|[is_fundamental](../vs140/is_fundamental-class.md)|Tests whether the type is <CodeContentPlaceHolder>12\</CodeContentPlaceHolder> or arithmetic.|  
|[is_object](../vs140/is_object-class.md)|Tests whether the type is an object type.|  
|[is_scalar](../vs140/is_scalar-class.md)|Tests whether the type is scalar.|  
|[is_compound](../vs140/is_compound-class.md)|Tests whether the type is not scalar.|  
|[is_member_pointer](../vs140/is_member_pointer-class.md)|Tests whether the type is a pointer to a member.|  
  
 Type properties  
  
|||  
|-|-|  
|[is_const](../vs140/is_const-class.md)|Tests whether the type is <CodeContentPlaceHolder>13\</CodeContentPlaceHolder>.|  
|[is_volatile](../vs140/is_volatile-class.md)|Tests whether the type is <CodeContentPlaceHolder>14\</CodeContentPlaceHolder>.|  
|[is_trivial](../vs140/is_trivial-class.md)|Tests whether the type is trivial.|  
|[is_trivially_copyable](../vs140/is_trivially_copyable-class.md)|Tests whether the type is trivially copyable.|  
|[is_standard_layout](../vs140/is_standard_layout-class.md)|Tests if type is a standard layout type.|  
|[is_pod](../vs140/is_pod-class.md)|Tests whether the type is a POD.|  
|[is_literal_type](../vs140/is_literal_type-class.md)|Tests whether the type can be a <CodeContentPlaceHolder>15\</CodeContentPlaceHolder> variable or used in a <CodeContentPlaceHolder>16\</CodeContentPlaceHolder> function.|  
|[is_empty](../vs140/is_empty-class.md)|Tests whether the type is an empty class.|  
|[is_polymorphic](../vs140/is_polymorphic-class.md)|Tests whether the type is a polymorphic class.|  
|[is_abstract](../vs140/is_abstract-class.md)|Tests whether the type is an abstract class.|  
|[is_final](../vs140/is_final-class.md)|Tests whether the type is a class type marked <CodeContentPlaceHolder>17\</CodeContentPlaceHolder>.|  
|[is_signed](../vs140/is_signed-class.md)|Tests whether the type is a signed integer.|  
|[is_unsigned](../vs140/is_unsigned-class.md)|Tests whether the type is an unsigned integer.|  
|[is_constructible](../vs140/is_constructible-class.md)|Tests whether the type is constructible using the specified argument types.|  
|[is_default_constructible](../vs140/-type_traits--functions.md#is_default_constructible)|Tests whether the type has a default constructor.|  
|[is_copy_constructible](../vs140/-type_traits--functions.md#is_copy_constructible)|Tests whether the type has a copy constructor.|  
|[is_move_constructible](../vs140/-type_traits--functions.md#is_move_constructible)|Tests whether the type has a move constructor.|  
|[is_assignable](../vs140/-type_traits--functions.md#is_assignable)|Tests whether the first type can be assigned a value of the second type.|  
|[is_copy_assignable](../vs140/-type_traits--functions.md#is_copy_assignable)|Tests whether a type can be assigned a const reference value of the type.|  
|[is_move_assignable](../vs140/-type_traits--functions.md#is_move_assignable)|Tests whether a type can be assigned an rvalue reference of the type.|  
|[is_destructible](../vs140/is_destructible-class.md)|Tests whether the type is destructible.|  
|[is_trivially_constructible](../vs140/is_trivially_constructible-class.md)|Tests whether the type uses no non-trivial operations when constructed using the specified types.|  
|[is_trivially_default_constructible](../vs140/is_trivially_default_constructible-class.md)|Tests whether the type uses no non-trivial operations when default constructed.|  
|[is_trivially_copy_constructible](../vs140/is_trivially_copy_constructible-class.md)|Tests whether the type uses no non-trivial operations when copy constructed.|  
|[is_trivially_move_constructible](../vs140/-type_traits--functions.md#is_trivially_move_constructible)|Tests whether the type uses no non-trivial operations when move constructed.|  
|[is_trivially_assignable](../vs140/is_trivially_assignable-class.md)|Tests whether the types are assignable and the assignment uses no non-trivial operations.|  
|[is_trivially_copy_assignable](../vs140/-type_traits--functions.md#is_trivially_copy_assignable)|Tests whether the type is copy assignable and the assignment uses no non-trivial operations.|  
|[is_trivially_move_assignable](../vs140/-type_traits--functions.md#is_trivially_move_assignable)|Tests whether the type is move assignable and the assignment uses no non-trivial operations.|  
|[is_trivially_destructible](../vs140/is_trivially_destructible-class.md)|Tests whether the type is destructible and the destructor uses no non-trivial operations.|  
|[is_nothrow_constructible](../vs140/is_nothrow_constructible-class.md)|Tests whether the type is constructible and is known not to throw when constructed using the specified types.|  
|[is_nothrow_default_constructible](../vs140/is_nothrow_default_constructible-class.md)|Tests whether the type is default constructible and is known not to throw when default constructed.|  
|[is_nothrow_copy_constructible](../vs140/is_nothrow_copy_constructible-class.md)|Tests whether the type is copy constructible and the copy constructor is known not to throw.|  
|[is_nothrow_move_constructible](../vs140/is_nothrow_move_constructible-class.md)|Tests whether the type is move constructible and the move constructor is known not to throw.|  
|[is_nothrow_assignable](../vs140/is_nothrow_assignable-class.md)|Tests whether the type is assignable using the specified type and the assignment is known not to throw.|  
|[is_nothrow_copy_assignable](../vs140/is_nothrow_copy_assignable-class.md)|Tests whether the type is copy assignable and the assignment is known not to throw.|  
|[is_nothrow_move_assignable](../vs140/-type_traits--functions.md#is_nothrow_move_assignable)|Tests whether the type is move assignable and the assignment is known not to throw.|  
|[is_nothrow_destructible](../vs140/is_nothrow_destructible-class.md)|Tests whether the type is destructible and the destructor is known not to throw.|  
|[has_virtual_destructor](assetId:///c0f85f0b-c63c-410d-a046-72eeaf44f7eb)|Tests whether the type has a virtual destructor.|  
  
 Type property queries  
  
|||  
|-|-|  
|[alignment_of](../vs140/alignment_of-class.md)|Gets the alignment of a type.|  
|[rank](../vs140/rank-class.md)|Gets the number of array dimensions.|  
|[extent](../vs140/extent-class.md)|Gets the number of elements in the specified array dimension.|  
  
 Type relations  
  
|||  
|-|-|  
|[is_same](../vs140/is_same-class.md)|Tests whether two types are the same.|  
|[is_base_of](../vs140/is_base_of-class.md)|Tests whether one type is a base of another.|  
|[is_convertible](../vs140/is_convertible-class.md)|Tests whether one type is convertible to another.|  
  
 Const-volatile modifications  
  
|||  
|-|-|  
|[add_const](../vs140/add_const-class.md)|Produces a <CodeContentPlaceHolder>18\</CodeContentPlaceHolder> type from type.|  
|[add_volatile](../vs140/add_volatile-class.md)|Produces a <CodeContentPlaceHolder>19\</CodeContentPlaceHolder> type from type.|  
|[add_cv](../vs140/add_cv-class.md)|Produces a <CodeContentPlaceHolder>20\</CodeContentPlaceHolder> type from type.|  
|[remove_const](../vs140/remove_const-class.md)|Produces a non-const type from type.|  
|[remove_volatile](../vs140/remove_volatile-class.md)|Produces a non-volatile type from type.|  
|[remove_cv](../vs140/remove_cv-class.md)|Produces a non-const non-volatile type from type.|  
  
 Reference modifications  
  
|||  
|-|-|  
|[add_lvalue_reference](../vs140/add_lvalue_reference-class.md)|Produces a reference to type from type.|  
|[add_rvalue_reference](../vs140/add_rvalue_reference-class.md)|Produces an rvalue reference to type from type|  
|[remove_reference](../vs140/remove_reference-class.md)|Produces a non-reference type from type.|  
  
 Sign modifications  
  
|||  
|-|-|  
|[make_signed](../vs140/make_signed-class.md)|Produces the type if signed, or the smallest signed type greater than or equal in size to type.|  
|[make_unsigned](../vs140/make_unsigned-class.md)|Produces the type if unsigned, or the smallest unsigned type greater than or equal in size to type.|  
  
 Array modifications  
  
|||  
|-|-|  
|[remove_all_extents](../vs140/remove_all_extents-class.md)|Produces a non-array type from an array type.|  
|[remove_extent](../vs140/remove_extent-class.md)|Produces the element type from an array type.|  
  
 Pointer modifications  
  
|||  
|-|-|  
|[add_pointer](../vs140/add_pointer-class.md)|Produces a pointer to type from type.|  
|[remove_pointer](../vs140/remove_pointer-class.md)|Produces a type from a pointer to type.|  
  
 Other transformations  
  
|||  
|-|-|  
|[aligned_storage](../vs140/aligned_storage-class.md)|Allocates uninitialized memory for an aligned type.|  
|[aligned_union](../vs140/aligned_union-class.md)|Allocates uninitialized memory for an aligned union with a non-trivial constructor or destructor.|  
|[common_type](../vs140/common_type-class.md)|Produces the common type of all the types of the parameter pack.|  
|[conditional](../vs140/conditional-class.md)|If the condition is true, produces the first specified type, otherwise the second specified type.|  
|[decay](../vs140/decay-class.md)|Produces the type as passed by value. Makes non-reference, non-const, or non-volatile type, or makes a pointer to type.|  
|[enable_if](../vs140/enable_if-class.md)|If the condition is true, produces the specified type, otherwise no type.|  
|[result_of](../vs140/result_of-class1.md)|Determines the return type of the callable type that takes the specified argument types.|  
|[underlying_type](../vs140/underlying_type-class.md)|Produces the underlying integral type for an enumeration type.|  
  
## See Also  
 [\<functional>](../vs140/-functional-.md)