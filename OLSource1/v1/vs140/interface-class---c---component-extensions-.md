---
title: "interface class  (C++ Component Extensions)"
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
  - "interface_CPP"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "interface class keyword"
  - "interface struct keyword"
ms.assetid: 3ccea701-f50b-4da7-ad6b-f0ee1203e2b9
caps.latest.revision: 32
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# interface class  (C++ Component Extensions)
Declares an interface.  For information on native interfaces, see [__interface](../vs140/__interface.md).  
  
## All Runtimes  
 **Syntax**  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
 **Parameters**  
  
 *interface_access*  
 The accessibility of an interface outside the assembly.  Possible values are **public** and <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>.  <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> is the default.  Nested interfaces cannot have an *interface_access* specifier.  
  
 *name*  
 The name of the interface.  
  
 *inherit_access*  
 The accessibility of *base_interface*.  The only permitted accessibility for a base interface is <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> (the default).  
  
 *base_interface* (optional)  
 A base interface for interface *name*.  
  
 **Remarks**  
  
 **interface struct** is equivalent to **interface class**.  
  
 An interface can contain declarations for functions, events, and properties.  All interface members have public accessibility. An interface can also contain static data members, functions, events, and properties, and these static members must be defined in the interface.  
  
 An interface defines how a class may be implemented. An interface is not a class and classes can only implement interfaces. When a class defines a function declared in an interface, the function is implemented, not overridden. Therefore, name lookup does not include interface members.  
  
 A class or struct that derives from an interface must implement all members of the interface. When implementing interface *name* you must also implement the interfaces in the <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> list.  
  
 For more information, see:  
  
-   [Interface Static Constructor](../vs140/how-to--define-an-interface-static-constructor--c---cli-.md)  
  
-   [Generic Interfaces (C++)](../vs140/generic-interfaces--visual-c---.md)  
  
 For information on other CLR types, see [Classes and Structs](../vs140/classes-and-structs---c---component-extensions-.md).  
  
 You can detect at compile time if a type is an interface with <CodeContentPlaceHolder>7\</CodeContentPlaceHolder>. For more information, see [Intrinsic Support for Type Traits](../vs140/compiler-support-for-type-traits--c---component-extensions-.md).  
  
 In the development environment, you can get F1 help on these keywords by highlighting the keyword, (<CodeContentPlaceHolder>8\</CodeContentPlaceHolder>, for example) and pressing F1.  
  
## [!INCLUDE[wrt](../vs140/includes/wrt_md.md)]  
 **Remarks**  
  
 (There are no remarks for this language feature that apply to only the Windows Runtime.)  
  
### Requirements  
 Compiler option: **/ZW**  
  
## [!INCLUDE[clr_for_headings](../vs140/includes/clr_for_headings_md.md)]  
 **Remarks**  
  
 (There are no remarks for this language feature that apply to only the common language runtime.)  
  
### Requirements  
 Compiler option: **/clr**  
  
### Examples  
 **Example**  
  
 The following code example demonstrates how an interface can define the behavior of a clock function.  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 **Output**  
  
 **in Function_3**   
 **in Function_2**   
 **in Function_1**   
 **8**   
 **OnClick: 7, 3.14159**   
 **in Function_1** **Example**  
  
 The following code sample shows two ways to implement functions with the same signature declared in multiple interfaces and where those interfaces are used by a class.  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
## See Also  
 [Language Extensions for Runtime Platforms](../vs140/component-extensions-for-runtime-platforms.md)