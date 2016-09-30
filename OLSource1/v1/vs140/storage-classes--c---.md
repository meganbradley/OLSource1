---
title: "Storage classes (C++)"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-cpp"
ms.tgt_pltfrm: na
ms.topic: "language-reference"
f1_keywords: 
  - "thread_local_cpp"
  - "external_cpp"
  - "static_cpp"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "storage classes, basic concepts"
ms.assetid: f10e1c56-6249-4eb6-b08f-09ab1eef1992
caps.latest.revision: 15
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Storage classes (C++)
A *storage class* in the context of C++ variable declarations is a type specifier that governs the lifetime, linkage, and memory location of objects and. A given object can have only one storage class. Variables defined within a block have automatic storage unless otherwise specified using the <CodeContentPlaceHolder>7\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>8\</CodeContentPlaceHolder>, or <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> specifiers. Automatic objects and variables have no linkage; they are not visible to code outside the block.  
  
 **Notes**  
  
1.  The [mutable](../vs140/mutable-data-members--c---.md) keyword may be considered a storage class specifier. However, it is only available in the member list of a class definition.  
  
2.  Starting with [!INCLUDE[cpp_dev10_long](../vs140/includes/cpp_dev10_long_md.md)], the <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> keyword is no longer a C++ storage-class specifier, and the <CodeContentPlaceHolder>11\</CodeContentPlaceHolder> keyword is deprecated.  
  
-   [Static](#static)  
  
-   [extern](#extern)  
  
-   [thread_local](#thread_local)  
  
## static  
 The <CodeContentPlaceHolder>12\</CodeContentPlaceHolder> keyword can be used to declare variables and functions at global scope, namespace scope, and class scope. Static variables can also be declared at local scope.  
  
 Static duration means that the object or variable is allocated when the program starts and is deallocated when the program ends. External linkage means that the name of the variable is visible from outside the file in which the variable is declared. Conversely, internal linkage means that the name is not visible outside the file in which the variable is declared. By default, an object or variable that is defined in the global namespace has static duration and external linkage. The <CodeContentPlaceHolder>13\</CodeContentPlaceHolder> keyword can be used in the following situations.  
  
1.  When you declare a variable or function at file scope (global and/or namespace scope), the <CodeContentPlaceHolder>14\</CodeContentPlaceHolder> keyword specifies that the variable or function has internal linkage. When you declare a variable, the variable has static duration and the compiler initializes it to 0 unless you specify another value.  
  
2.  When you declare a variable in a function, the <CodeContentPlaceHolder>15\</CodeContentPlaceHolder> keyword specifies that the variable retains its state between calls to that function.  
  
3.  When you declare a data member in a class declaration, the <CodeContentPlaceHolder>16\</CodeContentPlaceHolder> keyword specifies that one copy of the member is shared by all instances of the class. A static data member must be defined at file scope. An integral data member that you declare as <CodeContentPlaceHolder>17\</CodeContentPlaceHolder> can have an initializer.  
  
4.  When you declare a member function in a class declaration, the <CodeContentPlaceHolder>18\</CodeContentPlaceHolder> keyword specifies that the function is shared by all instances of the class. A static member function cannot access an instance member because the function does not have an implicit <CodeContentPlaceHolder>19\</CodeContentPlaceHolder> pointer. To access an instance member, declare the function with a parameter that is an instance pointer or reference.  
  
5.  You cannot declare the members of a union as static. However, a globally declared anonymous union must be explicitly declared <CodeContentPlaceHolder>20\</CodeContentPlaceHolder>.  
  
 The following example shows how a variable declared <CodeContentPlaceHolder>21\</CodeContentPlaceHolder> in a function retains its state between calls to that function.  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
 **nStatic is 0**  
**nStatic is 1**  
**nStatic is 3**  
**nStatic is 6**  
**nStatic is 10** The following example shows the use of <CodeContentPlaceHolder>22\</CodeContentPlaceHolder> in a class.  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 **0**  
**0**  
**1**  
**1**  
**2**  
**2**  
**3**  
**3** The following example shows a local variable declared <CodeContentPlaceHolder>23\</CodeContentPlaceHolder> in a member function. The static variable is available to the whole program; all instances of the type share the same copy of the static variable.  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 **var != value**  
**var == value** Starting in C++11, a static local variable initialization is guaranteed to be thread-safe. This feature is sometimes called *magic statics*. However, in a multithreaded application all subsequent assignments must be synchronized. The thread-safe statics feature can be disabled by using the /Zc:threadSafeInit- flag to avoid taking a dependency on the CRT.  
  
## extern  
 Objects and variables declared as <CodeContentPlaceHolder>24\</CodeContentPlaceHolder> declare an object that is defined in another translation unit or in an enclosing scope as having external linkage.  
  
 Declaration of **const** variables with the <CodeContentPlaceHolder>25\</CodeContentPlaceHolder> storage class forces the variable to have external linkage. An initialization of an **extern const** variable is allowed in the defining translation unit. Initializations in translation units other than the defining translation unit produce undefined results. For more information, see [Using extern to Specify Linkage](../vs140/using-extern-to-specify-linkage.md)  
  
 The following code shows two <CodeContentPlaceHolder>26\</CodeContentPlaceHolder> declarations, <CodeContentPlaceHolder>27\</CodeContentPlaceHolder> (which refers to a name defined in a different translation unit) and <CodeContentPlaceHolder>28\</CodeContentPlaceHolder> (which refers to a name defined in an enclosing scope):  
  
<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
## thread_local (C++11)  
 A variable declared with the <CodeContentPlaceHolder>29\</CodeContentPlaceHolder> specifier is accessible only on the thread on which it is created. The variable is created when the thread is created, and destroyed when the thread is destroyed. Each thread has its own copy of the variable. On Windows, <CodeContentPlaceHolder>30\</CodeContentPlaceHolder> is functionally equivalent to the Microsoft-specific [__declspec( thread )](../vs140/thread.md) attribute.  
  
<CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
1.  The thread_local specifier may be combined with <CodeContentPlaceHolder>31\</CodeContentPlaceHolder> or <CodeContentPlaceHolder>32\</CodeContentPlaceHolder>.  
  
2.  You can apply <CodeContentPlaceHolder>33\</CodeContentPlaceHolder> only to data declarations and definitions; **thread_local** cannot be used on function declarations or definitions.  
  
3.  The use of <CodeContentPlaceHolder>34\</CodeContentPlaceHolder> may interfere with [delay loading](../vs140/linker-support-for-delay-loaded-dlls.md) of DLL imports**.**  
  
4.  On XP systems, <CodeContentPlaceHolder>35\</CodeContentPlaceHolder> may not function correctly if a DLL uses <CodeContentPlaceHolder>36\</CodeContentPlaceHolder> data and it is loaded dynamically via LoadLibrary.  
  
5.  You can specify <CodeContentPlaceHolder>37\</CodeContentPlaceHolder> only on data items with static storage duration. This includes global data objects (both **static** and <CodeContentPlaceHolder>38\</CodeContentPlaceHolder>), local static objects, and static data members of classes. You cannot declare automatic data objects with **thread_local**.  
  
6.  You must specify <CodeContentPlaceHolder>39\</CodeContentPlaceHolder> for both the declaration and the definition of a thread local object, whether the declaration and definition occur in the same file or separate files.  
  
 On Windows, <CodeContentPlaceHolder>40\</CodeContentPlaceHolder> is functionally equivalent to  [__declspec(thread)](../vs140/thread.md) except that __declspec(thread) can be applied to a type definition and is valid in C code. Whenever possible, use <CodeContentPlaceHolder>41\</CodeContentPlaceHolder> because it is part of the C++ standard and is therefore more portable.  
  
 For more information, see [Thread Local Storage (TLS)](../vs140/thread-local-storage--tls-.md).  
  
## register  
 In C++11, the **register** keyword is deprecated. It specifies that the variable is to be stored in a machine register, if possible. Only function arguments and local variables can be declared with the register storage class.  
  
<CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
 Like automatic variables, register variables persist only until the end of the block in which they are declared.  
  
 The compiler does not honor user requests for register variables; instead, it makes its own register choices when global optimizations are on. However, all other semantics associated with the [register](assetId:///5b66905a-2f7f-4918-bb55-5e66d4bc50f9) keyword are honored by the compiler.  
  
 If the address-of operator (**&**) is used on an object that is declared with register, the compiler must put the object in memory rather than a register.  
  
## Example: automatic vs. static initialization  
 A local automatic object or variable is initialized every time the flow of control reaches its definition. A local static object or variable is initialized the first time the flow of control reaches its definition.  
  
 Consider the following example, which defines a class that logs initialization and destruction of objects and then defines three objects, <CodeContentPlaceHolder>42\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>43\</CodeContentPlaceHolder>, and <CodeContentPlaceHolder>44\</CodeContentPlaceHolder>:  
  
<CodeContentPlaceHolder>6\</CodeContentPlaceHolder>  
 **Initializing: Auto I1**  
**In block.**  
**Initializing: Auto I2**  
**Initializing: Static I3**  
**Destroying: Auto I2**  
**Exited block.**  
**Destroying: Auto I1**  
**Destroying: Static I3** The preceding code demonstrates how and when the objects <CodeContentPlaceHolder>45\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>46\</CodeContentPlaceHolder>, and <CodeContentPlaceHolder>47\</CodeContentPlaceHolder> are initialized and when they are destroyed.  
  
 There are several points to note about the program.  
  
 First, <CodeContentPlaceHolder>48\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>49\</CodeContentPlaceHolder> are automatically destroyed when the flow of control exits the block in which they are defined.  
  
 Second, in C++, it is not necessary to declare objects or variables at the beginning of a block. Furthermore, these objects are initialized only when the flow of control reaches their definitions. (<CodeContentPlaceHolder>50\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>51\</CodeContentPlaceHolder> are examples of such definitions.) The output shows exactly when they are initialized.  
  
 Finally, static local variables such as <CodeContentPlaceHolder>52\</CodeContentPlaceHolder> retain their values for the duration of the program, but are destroyed as the program terminates.  
  
## See Also  
 [Declarations and Definitions (C++)](../vs140/declarations-and-definitions--c---.md)