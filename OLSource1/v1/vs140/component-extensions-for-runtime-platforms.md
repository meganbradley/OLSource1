---
title: "Component Extensions for Runtime Platforms"
ms.custom: na
ms.date: 09/22/2016
ms.prod: visual-studio-dev14
ms.reviewer: na
ms.suite: na
ms.technology: 
  - devlang-cpp
ms.tgt_pltfrm: na
ms.topic: language-reference
dev_langs: 
  - C++
helpviewer_keywords: 
  - what's new [C++], keywords
  - what's new [C++], language features
  - Visual C++, keywords
  - keywords [C++]
  - Managed Extensions for C++, replacement syntax
ms.assetid: 1e400ee6-3ac9-4910-a608-9d3d5993e423
caps.latest.revision: 81
translation.priority.ht: 
  - de-de
  - ja-jp
---
# Component Extensions for Runtime Platforms
Visual C++ provides language extensions to help you program against runtime platforms. By using [!INCLUDE[cppwrt](../vs140/includes/cppwrt_md.md)] ([!INCLUDE[cppwrt_short](../vs140/includes/cppwrt_short_md.md)]), you can program [!INCLUDE[win8_appname_long](../vs140/includes/win8_appname_long_md.md)] apps and components that compile to native code. Although you can create [!INCLUDE[win8_appname_long](../vs140/includes/win8_appname_long_md.md)] apps by programming directly against the [!INCLUDE[wrt](../vs140/includes/wrt_md.md)] COM interfaces, by using [!INCLUDE[cppwrt_short](../vs140/includes/cppwrt_short_md.md)], you can work with constructors, exceptions, and other modern C++ programming idioms. To enable C++ programming in a managed execution environment on the .NET platform, you can use [!INCLUDE[cppcli](../vs140/includes/cppcli_md.md)].  
  
 **Two runtimes, one set of extensions**  
  
 [!INCLUDE[cppwrt_short](../vs140/includes/cppwrt_short_md.md)] is a subset of [!INCLUDE[cppcli](../vs140/includes/cppcli_md.md)]. For extensions that are common to [!INCLUDE[cppwrt_short](../vs140/includes/cppwrt_short_md.md)] and [!INCLUDE[cppcli](../vs140/includes/cppcli_md.md)], the semantics depend on whether you are targeting the common language runtime (CLR) or the [!INCLUDE[wrt](../vs140/includes/wrt_md.md)]. To compile your app to run on the [!INCLUDE[wrt](../vs140/includes/wrt_md.md)], specify the **/ZW** compiler option. To compile it to run on the CLR, specify the **/clr** compiler option. These switches are set automatically when you use Visual Studio to create a project.  
  
 For more information about how to create [!INCLUDE[win8_appname_long](../vs140/includes/win8_appname_long_md.md)] apps in C++, see [Roadmap for Windows Runtime apps using C++](http://msdn.microsoft.com/library/windows/apps/hh700360.aspx).  
  
 [!INCLUDE[cppcli](../vs140/includes/cppcli_md.md)] extends the ISO/ANSI C++ standard, and is defined under the Ecma [!INCLUDE[cppcli](../vs140/includes/cppcli_md.md)] Standard. For more information, see [.NET Programming in Visual C++](../vs140/.net-programming-with-c---cli--visual-c---.md).  
  
## Data Type Keywords  
 The language extensions include *aggregate keywords*, which are keywords that consist of two tokens separated by white space. The tokens might have one meaning when they are used separately, and another meaning when they are used together. For example, the word "ref" is an ordinary identifier, and the word "class" is a keyword that declares a native class. But when these words are combined to form `ref class`, the resulting aggregate keyword declares an entity that is known as a *runtime class*.  
  
 The extensions also include *context-sensitive* keywords. A keyword is treated as context-sensitive depending on the kind of statement that contains it, and its placement in that statement. For example, the token "property" can be an identifier, or it can declare a special kind of public class member.  
  
 The following table lists keywords in the C++ language extension.  
  
|Keyword|Context sensitive|Purpose|Reference|  
|-------------|-----------------------|-------------|---------------|  
|`ref class`<br /><br /> `ref struct`|No|Declares a class.|[Classes and Structs](../vs140/classes-and-structs---c---component-extensions-.md)|  
|`value class`<br /><br /> `value struct`|No|Declares a value class.|[Classes and Structs](../vs140/classes-and-structs---c---component-extensions-.md)|  
|`interface class`<br /><br /> `interface struct`|No|Declares an interface.|[interface class](../vs140/interface-class---c---component-extensions-.md)|  
|`enum class`<br /><br /> `enum struct`|No|Declares an enumeration.|[enum class](../vs140/enum-class---c---component-extensions-.md)|  
|`property`|Yes|Declares a property.|[property](../vs140/property---c---component-extensions-.md)|  
|`delegate`|Yes|Declares a delegate.|[delegate  (C++ Component Extensions)](../vs140/delegate---c---component-extensions-.md)|  
|`event`|Yes|Declares an event.|[event](../vs140/event---c---component-extensions-.md)|  
  
## Override Specifiers  
 You can use the following keywords to qualify override behavior for derivation. Although the `new` keyword is not an extension of C++, it is listed here because it can be used in an additional context. Some specifiers are also valid for native programming. For more information, see [How to: Declare Override Specifiers in Native Compilations](../vs140/how-to--declare-override-specifiers-in-native-compilations--c---cli-.md).  
  
|Keyword|Context Sensitive|Purpose|Reference|  
|-------------|-----------------------|-------------|---------------|  
|`abstract`|Yes|Indicates that functions or classes are abstract.|[abstract](../vs140/abstract---c---component-extensions-.md)|  
|`new`|No|Indicates that a function is not an override of a base class version.|[new (new slot in vtable)](../vs140/new--new-slot-in-vtable----c---component-extensions-.md)|  
|`override`|Yes|Indicates that a method must be an override of a base-class version.|[override](../vs140/override---c---component-extensions-.md)|  
|`sealed`|Yes|Prevents classes from being used as base classes.|[sealed](../vs140/sealed---c---component-extensions-.md)|  
  
## Keywords for Generics  
 The following keywords have been added to support generic types. For more information, see [generics](../vs140/generics---c---component-extensions-.md).  
  
|Keyword|Context sensitive|Purpose|  
|-------------|-----------------------|-------------|  
|`generic`|No|Declares a generic type.|  
|`where`|Yes|Specifies the constraints that are applied to a generic type parameter.|  
  
## Miscellaneous Keywords  
 The following keywords have been added to the C++ extensions.  
  
|Keyword|Context sensitive|Purpose|Reference|  
|-------------|-----------------------|-------------|---------------|  
|`finally`|Yes|Indicates default exception handlings behavior.|[Exception Handling under /clr](../vs140/exception-handling---c---component-extensions-.md)|  
|`for each, in`|No|Enumerates elements of a collection.|[for each, in](../vs140/for-each--in.md)|  
|`gcnew`|No|Allocates types on the garbage-collected heap. Use instead of `new` and `delete`.|[ref new, gcnew](../vs140/ref-new--gcnew---c---component-extensions-.md)|  
|`ref new`|Yes|Allocates a [!INCLUDE[wrt](../vs140/includes/wrt_md.md)] type. Use instead of `new` and `delete`.|[ref new, gcnew](../vs140/ref-new--gcnew---c---component-extensions-.md)|  
|`initonly`|Yes|Indicates that a member can only be initialized at declaration or in a static constructor.|[initonly (C++/CLI)](../vs140/initonly--c---cli-.md)|  
|`literal`|Yes|Creates a literal variable.|[literal](../vs140/literal--c---component-extensions-.md)|  
|`nullptr`|No|Indicates that a handle or pointer does not point at an object.|[nullptr](../vs140/nullptr---c---component-extensions-.md)|  
  
## Template Constructs  
 The following language constructs are implemented as templates, instead of as keywords. If you specify the **/ZW** compiler option, they are defined in the `lang` namespace. If you specify the **/clr** compiler option, they are defined in the `cli` namespace.  
  
|Keyword|Purpose|Reference|  
|-------------|-------------|---------------|  
|`array`|Declares an array.|[array](../vs140/arrays--c---component-extensions-.md)|  
|`interior_ptr`|(CLR only) Points to data in a reference type.|[interior_ptr (C++/CLI)](../vs140/interior_ptr--c---cli-.md)|  
|`pin_ptr`|(CLR only) Points to CLR reference types to temporarily suppress the garbage-collection system.|[pin_ptr (C++/CLI)](../vs140/pin_ptr--c---cli-.md)|  
|`safe_cast`|Determines and executes the optimal casting method for a runtime type.|[safe_cast](../vs140/safe_cast--c---component-extensions-.md)|  
|`typeid`|(CLR only) Retrieves a <xref:System.Type?qualifyHint=True> object that describes the given type or object.|[typeid](../vs140/typeid---c---component-extensions-.md)|  
  
## Declarators  
 The following type declarators instruct the runtime to automatically manage the lifetime and deletion of allocated objects.  
  
|Operator|Purpose|Reference|  
|--------------|-------------|---------------|  
|`^`|Declares a handle to an object; that is, a pointer to a [!INCLUDE[wrt](../vs140/includes/wrt_md.md)] or CLR object that is automatically deleted when it is no longer usable.|[Handle to Object Operator (^)](../vs140/handle-to-object-operator--^----c---component-extensions-.md)|  
|`%`|Declares a tracking reference; that is, a reference to a [!INCLUDE[wrt](../vs140/includes/wrt_md.md)] or CLR object that is automatically deleted when it is no longer usable.|[% (Tracking Reference)](../vs140/tracking-reference-operator--c---component-extensions-.md)|  
  
## Additional Constructs and Related Topics  
 This section lists additional programming constructs, and topics that pertain to the CLR.  
  
|Topic|Description|  
|-----------|-----------------|  
|[__identifier](../vs140/__identifier--c---cli-.md)|([!INCLUDE[wrt](../vs140/includes/wrt_md.md)] and CLR) Enables the use of keywords as identifiers.|  
|[... (Variable Argument Lists)](../vs140/variable-argument-lists--...---c---cli-.md)|([!INCLUDE[wrt](../vs140/includes/wrt_md.md)] and CLR) Enables a function to take a variable number of arguments.|  
|[.NET Framework Equivalents to C++ Native Types](../vs140/.net-framework-equivalents-to-c---native-types--c---cli-.md)|Lists the CLR types that are used in place of C++ integral types.|  
|[appdomain](../vs140/appdomain.md) `__declspec` modifier|`__declspec` modifier that mandates that static and global variables exist per appdomain.|  
|[C-Style Casts with /clr](../vs140/c-style-casts-with--clr--c---cli-.md)|Describes how C-style casts are interpreted.|  
|[__clrcall](../vs140/__clrcall.md) calling convention|Indicates the CLR-compliant calling convention.|  
|`__cplusplus_cli`|[Predefined Macros](../vs140/predefined-macros.md)|  
|[Custom Attributes (C++)](../vs140/custom-attributes--c---.md)|Describes how to define your own CLR attributes.|  
|[Exception Handling under /clr](../vs140/exception-handling---c---component-extensions-.md)|Provides an overview of exception handling.|  
|[Explicit Overrides](../vs140/explicit-overrides---c---component-extensions-.md)|Demonstrates how member functions can override arbitrary members.|  
|[Friend Assemblies](../vs140/friend-assemblies--c---.md)|Discusses how a client assembly can access all types in an assembly component.|  
|[Implicit Boxing](../vs140/boxing---c---component-extensions-.md)|Demonstrates the conditions in which values types are boxed.|  
|[Intrinsic Support for Type Traits](../vs140/compiler-support-for-type-traits--c---component-extensions-.md)|Discusses how to detect characteristics of types at compile time.|  
|[managed, unmanaged](../vs140/managed--unmanaged.md) pragmas|Demonstrates how managed and unmanaged functions can co-exist in the same module.|  
|[process](../vs140/process.md) `__declspec` modifier|`__declspec` modifier that mandates that static and global variables exist per process.|  
|[Reflection](../vs140/reflection--c---cli-.md)|Demonstrates the CLR version of run-time type information.|  
|[Strings (C++)](../vs140/string---c---component-extensions-.md)|Discusses compiler conversion of string literals to <xref:System.String?qualifyHint=False>.|  
|[Type Forwarding](../vs140/type-forwarding--c---cli-.md)|Enables the movement of a type in a shipping assembly to another assembly so that client code does not have to be recompiled.|  
|[User-Defined Attributes](../vs140/user-defined-attributes---c---component-extensions-.md)|Demonstrates user-defined attributes.|  
|[The #using Directive](../vs140/sharpusing-directive--c---.md)|Imports external assemblies.|  
|[XML Documentation (C++)](../vs140/xml-documentation--visual-c---.md)|Explains XML-based code documentation by using [/doc (Process Documentation Comments) (C/C++)](../vs140/-doc--process-documentation-comments---c-c---.md)|  
  
## See Also  
 [.NET Programming in C++](../vs140/.net-programming-with-c---cli--visual-c---.md)   
 [Native/.NET Interop in C++](../vs140/native-and-.net-interoperability.md)