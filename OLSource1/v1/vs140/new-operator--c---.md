---
title: "new Operator (C++)"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-cpp"
ms.tgt_pltfrm: na
ms.topic: "language-reference"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "new keyword [C++]"
ms.assetid: 69fee812-1c28-4882-8fda-d1ad17860004
caps.latest.revision: 15
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# new Operator (C++)
Allocates memory for an object or array of objects of *type-name* from the free store and returns a suitably typed, nonzero pointer to the object.  
  
> [!NOTE]
>  Microsoft C++ Component Extensions provides support for the <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> keyword to add vtable slot entries. For more information, see [new (new slot in vtable) (C++ Component Extensions)](../vs140/new--new-slot-in-vtable----c---component-extensions-.md)  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Remarks  
 If unsuccessful, **new** returns zero or throws an exception; see [The new and delete Operators](../vs140/new-and-delete-operators.md) for more information. You can change this default behavior by writing a custom exception-handling routine and calling the [_set_new_handler](../vs140/_set_new_handler.md) run-time library function with your function name as its argument.  
  
 For information on how to create an object on the managed heap, see [gcnew](../vs140/ref-new--gcnew---c---component-extensions-.md).  
  
 When **new** is used to allocate memory for a C++ class object, the object's constructor is called after the memory is allocated.  
  
 Use the [delete](../vs140/delete-operator--c---.md) operator to deallocate the memory allocated with the **new** operator.  
  
 The following example allocates and then frees a two-dimensional array of characters of size <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> by 10. When allocating a multidimensional array, all dimensions except the first must be constant expressions that evaluate to positive values; the leftmost array dimension can be any expression that evaluates to a positive value. When allocating an array using the **new** operator, the first dimension can be zero — the **new** operator returns a unique pointer.  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 The *type-name* cannot contain **const**, <CodeContentPlaceHolder>11\</CodeContentPlaceHolder>, class declarations, or enumeration declarations. Therefore, the following expression is illegal:  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 The **new** operator does not allocate reference types because they are not objects.  
  
 The **new** operator cannot be used to allocate a function, but it can be used to allocate pointers to functions. The following example allocates and then frees an array of seven pointers to functions that return integers.  
  
<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 If you use the operator **new** without any extra arguments, and compile with the [/GX](../vs140/-gx--enable-exception-handling-.md), [/EHa](../vs140/-eh--exception-handling-model-.md), or [/EHs](../vs140/-eh--exception-handling-model-.md) option, the compiler will generate code to call operator **delete** if the constructor throws an exception.  
  
 The following list describes the grammar elements of **new**:  
  
 *placement*  
 Provides a way of passing additional arguments if you overload **new**.  
  
 *type-name*  
 Specifies type to be allocated; it can be either a built-in or user-defined type. If the type specification is complicated, it can be surrounded by parentheses to force the order of binding.  
  
 *initializer*  
 Provides a value for the initialized object. Initializers cannot be specified for arrays. The **new** operator will create arrays of objects only if the class has a default constructor.  
  
## Example  
 The following code example allocates a character array and an object of class <CodeContentPlaceHolder>12\</CodeContentPlaceHolder> and then frees them.  
  
<CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
## Example  
 If you use the placement new form of the **new** operator, the form with arguments in addition to the size of the allocation, the compiler does not support a placement form of the **delete** operator if the constructor throws an exception. For example:  
  
<CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
## Initializing object allocated with new  
 An optional *initializer* field is included in the grammar for the **new** operator. This allows new objects to be initialized with user-defined constructors. For more information about how initialization is done, see [Initializers](../vs140/initializers.md). The following example illustrates how to use an initialization expression with the **new** operator:  
  
<CodeContentPlaceHolder>6\</CodeContentPlaceHolder>  
 In this example, the object <CodeContentPlaceHolder>13\</CodeContentPlaceHolder> is allocated using the **new** operator, but no default initialization is specified. Therefore, the default constructor for the class, <CodeContentPlaceHolder>14\</CodeContentPlaceHolder>, is called. Then the object <CodeContentPlaceHolder>15\</CodeContentPlaceHolder> is allocated the same way, except that it is explicitly initialized to 34.98. Because 34.98 is of type **double**, the constructor that takes an argument of that type is called to handle the initialization. Finally, the nonclass type <CodeContentPlaceHolder>16\</CodeContentPlaceHolder> is initialized to 43.0.  
  
 If an object is of a class type and that class has constructors (as in the preceding example), the object can be initialized by the **new** operator only if one of these conditions is met:  
  
-   The arguments provided in the initializer agree with those of a constructor.  
  
-   The class has a default constructor (a constructor that can be called with no arguments).  
  
 Access control and ambiguity control are performed on <CodeContentPlaceHolder>17\</CodeContentPlaceHolder> and on the constructors according to the rules set forth in [Ambiguity](assetId:///0b399cab-40a7-4e79-9278-05f40139a0e1) and [Initialization Using Special Member Functions](assetId:///82223d73-64cb-4923-b678-78f9568ff3ca).  
  
 No explicit per-element initialization can be done when allocating arrays using the **new** operator; only the default constructor, if present, is called. See [Default Arguments](../vs140/default-arguments.md) for more information.  
  
 If the memory allocation fails (<CodeContentPlaceHolder>18\</CodeContentPlaceHolder> returns a value of 0), no initialization is performed. This protects against attempts to initialize data that does not exist.  
  
 As with function calls, the order in which initialized expressions are evaluated is not defined. Furthermore, you should not rely on these expressions being completely evaluated before the memory allocation is performed. If the memory allocation fails and the **new** operator returns zero, some expressions in the initializer may not be completely evaluated.  
  
## Lifetime of objects allocated with new  
 Objects allocated with the **new** operator are not destroyed when the scope in which they are defined is exited. Because the **new** operator returns a pointer to the objects it allocates, the program must define a pointer with suitable scope to access those objects. For example:  
  
<CodeContentPlaceHolder>7\</CodeContentPlaceHolder>  
 Once the pointer <CodeContentPlaceHolder>19\</CodeContentPlaceHolder> goes out of scope in the example, the object can no longer be deleted.  
  
## How new works  
 The *allocation-expression* — the expression containing the **new** operator — does three things:  
  
-   Locates and reserves storage for the object or objects to be allocated. When this stage is complete, the correct amount of storage is allocated, but it is not yet an object.  
  
-   Initializes the object(s). Once initialization is complete, enough information is present for the allocated storage to be an object.  
  
-   Returns a pointer to the object(s) of a pointer type derived from *new-type-name* or *type-name*. The program uses this pointer to access the newly allocated object.  
  
 The **new** operator invokes the function <CodeContentPlaceHolder>20\</CodeContentPlaceHolder>. For arrays of any type, and for objects that are not of **class**, <CodeContentPlaceHolder>21\</CodeContentPlaceHolder>, or **union** types, a global function, **::operator new**, is called to allocate storage. Class-type objects can define their own <CodeContentPlaceHolder>22\</CodeContentPlaceHolder> static member function on a per-class basis.  
  
 When the compiler encounters the **new** operator to allocate an object of type <CodeContentPlaceHolder>23\</CodeContentPlaceHolder>, it issues a call to <CodeContentPlaceHolder>24\</CodeContentPlaceHolder>**::operator new( sizeof(** <CodeContentPlaceHolder>25\</CodeContentPlaceHolder> **) )** or, if no user-defined <CodeContentPlaceHolder>26\</CodeContentPlaceHolder> is defined, **::operator new( sizeof(** <CodeContentPlaceHolder>27\</CodeContentPlaceHolder> **) )**. Therefore, the **new** operator can allocate the correct amount of memory for the object.  
  
> [!NOTE]
>  The argument to <CodeContentPlaceHolder>28\</CodeContentPlaceHolder> is of type **size_t**. This type is defined in DIRECT.H, MALLOC.H, MEMORY.H, SEARCH.H, STDDEF.H, STDIO.H, STDLIB.H, STRING.H, and TIME.H.  
  
 An option in the grammar allows specification of *placement* (see the Grammar for [new Operator](../vs140/new-operator--c---.md)). The *placement* parameter can be used only for user-defined implementations of <CodeContentPlaceHolder>29\</CodeContentPlaceHolder>; it allows extra information to be passed to <CodeContentPlaceHolder>30\</CodeContentPlaceHolder>. An expression with a *placement* field such as <CodeContentPlaceHolder>31\</CodeContentPlaceHolder> is translated to <CodeContentPlaceHolder>32\</CodeContentPlaceHolder> if class T has member operator new, otherwise to <CodeContentPlaceHolder>33\</CodeContentPlaceHolder>.  
  
 The original intention of the *placement* field was to allow hardware-dependent objects to be allocated at user-specified addresses.  
  
> [!NOTE]
>  Although the preceding example shows only one argument in the *placement* field, there is no restriction on how many extra arguments can be passed to <CodeContentPlaceHolder>34\</CodeContentPlaceHolder> this way.  
  
 Even when <CodeContentPlaceHolder>35\</CodeContentPlaceHolder> has been defined for a class type, the global operator can be used by using the form of this example:  
  
<CodeContentPlaceHolder>8\</CodeContentPlaceHolder>  
 The scope-resolution operator (<CodeContentPlaceHolder>36\</CodeContentPlaceHolder>) forces use of the global **new** operator.  
  
## See Also  
 [Expressions with Unary Operators](../vs140/expressions-with-unary-operators.md)   
 [Keywords](../vs140/keywords--c---.md)   
 [operator new Function](../vs140/operator-new-function.md)