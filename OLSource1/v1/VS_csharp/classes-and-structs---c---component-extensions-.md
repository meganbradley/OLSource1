---
title: "Classes and Structs  (C++ Component Extensions)"
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
  - "public"
  - "ref struct"
  - "value_CPP"
  - "ref class"
  - "value struct"
  - "ref struct_cpp"
  - "ref class_cpp"
  - "value class_cpp"
  - "value struct_cpp"
  - "value class"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "ref class keyword [C++]"
  - "value class keyword [C++]"
  - "value struct keyword [C++]"
  - "ref struct keyword [C++]"
ms.assetid: 5c360764-b229-49c6-9357-66213afbc372
caps.latest.revision: 36
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Classes and Structs  (C++ Component Extensions)
Declares a class or struct whose *object lifetime* is administered automatically. When the object is no longer accessible or goes out of scope, Visual C++ automatically discards the memory that is allocated to the object.  
  
## All Runtimes  
 **Syntax**  
  
```  
  
      class_access  
      ref class  
      name  
      modifier :  inherit_accessbase_type {};  
class_accessref structnamemodifier :  inherit_accessbase_type {};  
class_accessvalue classnamemodifier :  inherit_accessbase_type {};  
class_accessvalue structnamemodifier :  inherit_accessbase_type {};  
  
```  
  
 **Parameters**  
  
 *class_access* (optional)  
 The accessibility of the class or struct outside the assembly. Possible values are **public** and `private` (`private` is the default). Nested classes or structs cannot have a *class_access* specifier.  
  
 *name*  
 The name of the class or struct.  
  
 *modifier* (optional)  
 [abstract](../VS_csharp/abstract---c---component-extensions-.md) and [sealed](../VS_csharp/sealed---c---component-extensions-.md) are valid modifiers.  
  
 *inherit_access* (optional)  
 The accessibility of `base_type`. The only permitted accessibility is `public` (`public` is the default).  
  
 *base_type* (optional)  
 A base type. However, a value type cannot act as a base type.  
  
 For more information, see the language-specific descriptions of this parameter in the [!INCLUDE[wrt](../VS_csharp/includes/wrt_md.md)] and [!INCLUDE[clr_for_headings](../VS_csharp/includes/clr_for_headings_md.md)] sections.  
  
 **Remarks**  
  
 The default member accessibility of an object declared with **ref class** or **value class** is `private`. And the default member accessibility of an object declared with **ref struct** or **value struct** is `public`.  
  
 When a reference type inherits from another reference type, virtual functions in the base class must explicitly be overridden (with [override](../VS_csharp/override---c---component-extensions-.md)) or hidden (with [new (new slot in vtable)](../VS_csharp/new--new-slot-in-vtable----c---component-extensions-.md)). The derived class functions must also be explicitly marked as `virtual`.  
  
 To detect at compile time whether a type is a `ref class` or `ref struct`, or a `value class` or `value struct`, use `__is_ref_class (``type``)`, `__is_value_class (``type``)`, or `__is_simple_value_class (``type``)`. For more information, see [Intrinsic Support for Type Traits](../VS_csharp/compiler-support-for-type-traits--c---component-extensions-.md).  
  
 For more information on classes and structs, see  
  
-   [Instantiating Classes and Structs](../VS_csharp/how-to--define-and-consume-classes-and-structs--c---cli-.md)  
  
-   [Semantics of the this Pointer in Value and Reference Types](../Topic/Semantics%20of%20the%20this%20Pointer%20in%20Value%20and%20Reference%20Types.md)  
  
-   [Automatic Storage for Reference Types](../VS_csharp/c---stack-semantics-for-reference-types.md)  
  
-   [Classes, Structures, and Unions](../VS_csharp/classes-and-structs--c---.md)  
  
-   [public and private on Native Classes](../Topic/How%20to:%20Declare%20public%20and%20private%20on%20Native%20Classes.md)  
  
-   [Implicitly Abstract Classes](../Topic/Implicitly%20Abstract%20Classes.md)  
  
-   [Define Static Constructors in a Class or Struct](../Topic/How%20to:%20Define%20Static%20Constructors%20in%20a%20Class%20or%20Struct.md)  
  
-   [Copy Constructor May not Be Generated](../Topic/Copy%20Constructor%20May%20Not%20Be%20Generated.md)  
  
-   [Hide-by-Signature Functions in Reference Types](../Topic/Hide-by-Signature%20Functions%20in%20Reference%20Types.md)  
  
-   [Destructors and Finalizers](../Topic/Destructors%20and%20Finalizers%20in%20Visual%20C++.md)  
  
-   [Type and Member Visibility](../Topic/Type%20and%20Member%20Visibility.md)  
  
-   [User-Defined Operators](../VS_csharp/user-defined-operators--c---cli-.md)  
  
-   [User-Defined Conversions](../VS_csharp/user-defined-conversions--c---cli-.md)  
  
-   [How to: Wrap Native Class for Use by C#](../VS_csharp/how-to--wrap-native-class-for-use-by-csharp.md)  
  
-   [Generic Classes (C++)](../VS_csharp/generic-classes--c---cli-.md)  
  
## [!INCLUDE[wrt](../VS_csharp/includes/wrt_md.md)]  
 **Remarks**  
  
 See [Ref classes and structs](http://msdn.microsoft.com/library/windows/apps/hh699870.aspx) and [Value classes and structs](http://msdn.microsoft.com/library/windows/apps/hh699861.aspx).  
  
 **Parameters**  
  
 *base_type* (optional)  
 A base type. A `ref class` or `ref struct` can inherit from zero or more interfaces and zero or one `ref` types. A `value class` or `value struct` can only inherit from zero or more interfaces.  
  
 When you declare an object by using the `ref class` or `ref struct` keywords, the object is accessed by a handle to an object; that is, a reference-counter pointer to the object. When the declared variable goes out of scope, the compiler automatically deletes the underlying object. When the object is  used as a parameter in a call or is stored in a variable, a handle to the object is actually passed or stored.  
  
 When you declare an object by using the `value class` or `value struct` keywords, the object lifetime of the declared object is not supervised. The object is like any other standard C++ class or struct.  
  
### Requirements  
 Compiler option: **/ZW**  
  
## [!INCLUDE[clr_for_headings](../VS_csharp/includes/clr_for_headings_md.md)]  
 **Remarks**  
  
 The following table lists differences from the syntax shown in the **All Runtimes** section that are specific to C++/CLI.  
  
 **Parameters**  
  
 *base_type* (optional)  
 A base type. A `ref class` or `ref struct` can inherit from zero or more managed interfaces and zero or one ref types. A `value class` or `value struct` can only inherit from zero or more managed interfaces.  
  
 The `ref class` and `ref struct` keywords tell the compiler that the class or structure is to be allocated on the heap. When the object is  used as a parameter in a call or is stored in a variable, a reference to the object is actually passed or stored.  
  
 The `value class` and `value struct` keywords tells the compiler that the value of the allocated class or structure is passed to functions or stored in members.  
  
### Requirements  
 Compiler option: **/clr**  
  
## See Also  
 [Language Extensions for Runtime Platforms](../VS_csharp/component-extensions-for-runtime-platforms.md)