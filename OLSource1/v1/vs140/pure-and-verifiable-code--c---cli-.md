---
title: "Pure and Verifiable Code (C++-CLI)"
ms.custom: na
ms.date: 09/22/2016
ms.prod: visual-studio-dev14
ms.reviewer: na
ms.suite: na
ms.technology: 
  - devlang-cpp
ms.tgt_pltfrm: na
ms.topic: article
H1: Pure and Verifiable Code (C++/CLI)
dev_langs: 
  - C++
helpviewer_keywords: 
  - /clr compiler option [C++], verifiable assemblies
  - /clr compiler option [C++], mixed assemblies
  - pure MSIL [C++]
  - verifiable assemblies [C++]
  - verifiably type-safe code [C++]
  - /clr compiler option [C++], pure assemblies
  - .NET Framework [C++], pure and verifiable code
  - assemblies [C++], mixed code
  - verifiable assemblies [C++], about verifiable assemblies
  - mixed assemblies [C++], about mixed assemblies
  - pure MSIL [C++], about pure code
  - assemblies [C++], verifiable code
  - mixed assemblies [C++]
  - assemblies [C++], pure code
ms.assetid: 9050e110-fa11-4356-b56c-665187ff871c
caps.latest.revision: 35
translation.priority.ht: 
  - de-de
  - ja-jp
---
# Pure and Verifiable Code (C++-CLI)
For .NET Programming, Visual C++ supports the creation of three distinct types of components and applications: mixed, pure, and verifiable. All three are available through the [/clr (Common Language Runtime Compilation)](../vs140/-clr--common-language-runtime-compilation-.md) compiler option.  
  
## Remarks  
 For more information about verifiable assemblies, see:  
  
-   [Mixed, Pure, and Verifiable Feature Comparison](../vs140/mixed--pure--and-verifiable-feature-comparison--c---cli-.md)  
  
-   [How to: Migrate to /clr:pure](../vs140/how-to--migrate-to--clr-pure--c---cli-.md)  
  
-   [How to: Create Verifiable C++ Projects](../vs140/how-to--create-verifiable-c---projects--c---cli-.md)  
  
-   [Migrating to /clr:Safe](../vs140/how-to--migrate-to--clr-safe--c---cli-.md)  
  
-   [Using Verifiable Assemblies with SQL Server](../vs140/using-verifiable-assemblies-with-sql-server--c---cli-.md)  
  
-   [Securing Applications in C++ (.NET Programming)](../vs140/security-best-practices-for-c--.md)  
  
-   [Converting Projects from Mixed Mode to Pure Intermediate Language](../vs140/converting-projects-from-mixed-mode-to-pure-intermediate-language.md)  
  
## Mixed (/clr)  
 Mixed assemblies (compiled with **/clr**), contain both unmanaged and managed parts, making it possible for them to use .NET features, but still contain unmanaged code. This allows applications and components to be updated to use .NET features without requiring that the entire project be rewritten. Using Visual C++ to mix managed and unmanaged code in this fashion is called C++ Interop. For more information, see [Mixed Assemblies in C++](../vs140/mixed--native-and-managed--assemblies.md) and [Native/.NET Interop in C++](../vs140/native-and-.net-interoperability.md).  
  
## Pure (/clr:pure)  
 Pure assemblies (compiled with **/clr:pure**) can contain both native and managed data types, but only managed functions. Like mixed assemblies, pure assemblies allow interop with native DLLs through P/Invoke (see [Using PInvoke in C++](../vs140/using-explicit-pinvoke-in-c----dllimport-attribute-.md)), but C++ Interop features are not available. Moreover, pure assemblies cannot export functions that are callable from native functions because entry points in a pure assembly use the [__clrcall](../vs140/__clrcall.md) calling convention.  
  
### Advantages of /clr:pure  
  
-   Better Performance: Because pure assemblies contain only MSIL, there are no native functions, and therefore no managed/unmanaged transitions are necessary. (Function calls made through P/Invoke are an exception to this rule.)  
  
-   AppDomain Awareness: Managed functions and CLR data types exist inside `Application Domains`, which affects their visibility and accessibility. Pure assemblies are domain-aware (__declspec([appdomain](../vs140/appdomain.md)) is implied for each type) so accessing their types and functionality from other .NET components is easier and safer. As a result, pure assemblies interoperate more easily with other .NET components than mixed assemblies.  
  
-   Non-disk loading: Pure assemblies can be loaded in-memory and even streamed. This is essential for using .NET assemblies as stored procedures. This differs from mixed assemblies, which due to a dependency on the Windows loading mechanisms, must exist on disk in order to execute.  
  
-   Reflection: It is not possible to reflect over mixed executables, whereas pure assemblies provide full reflection support. For more information, see [Reflection in C++](../vs140/reflection--c---cli-.md).  
  
-   Host Controllability: Because pure assemblies contain only MSIL, they behave more predictably and flexibly than mixed assemblies when used in applications that host the CLR and modify its default behavior.  
  
### Limitations of /clr:pure  
 This section covers features not currently supported by **/clr:pure**.  
  
-   Pure assemblies cannot be called by unmanaged functions. Therefore pure assemblies cannot implement COM interfaces or expose native callbacks. Pure assemblies cannot export functions via __declspec(dllexport) or .DEF files. Also, functions declared with the \__clrcall convention cannot be imported via \__declspec(dllimport). Functions in a native module can be called from a pure assembly, but pure assemblies cannot expose native-callable functions, so exposing functionality in a pure assembly must be done through managed functions in a mixed assembly. See [Migrating to /clr:pure](../vs140/how-to--migrate-to--clr-pure--c---cli-.md) for more information.  
  
-   ATL and MFC libraries are not supported by pure mode compilation in Visual C++.  
  
-   Pure .netmodules are not accepted as input to the Visual C++ linker. However, pure .obj files are accepted by the linker, and .obj files contain a superset of information contained in netmodules. See [.netmodule Files as Linker Input](../vs140/.netmodule-files-as-linker-input.md) for more information.  
  
-   Compiler COM support (#import) is not supported, as this would introduce unmanaged instructions into the pure assembly.  
  
-   Floating point options for alignment and exception-handling are not adjustable for pure assemblies. As a result, __declspec(align) cannot be used. This renders some header files, such as fpieee.h, incompatible with /clr:pure.  
  
-   The GetLastError function in the PSDK can give undefined behavior when compiling with **/clr:pure**.  
  
## Verifiable (/clr:safe)  
 The **/clr:safe** compiler option generates verifiable assemblies, like those written in Visual Basic and C#, conforming to requirements that allow the common language runtime (CLR) to guarantee that the code does not violate current security settings. For example, if security settings prohibit a component from writing to disk, the CLR can determine if a verifiable component meets this criterion before executing any of the code. There is no CRT support for verifiable assemblies. (CRT support is available to pure assemblies through a Pure MSIL version of the C Runtime library.)  
  
 Verifiable assemblies offer these advantages over pure and mixed assemblies:  
  
-   Increased security.  
  
-   Some situations require it (SQL components, for example).  
  
-   Future versions of Windows will increasingly require components and applications to be verifiable.  
  
 One disadvantage is that C++ interop features are not available. Verifiable assemblies cannot contain any unmanaged functions or native data types, even if they are not referenced by the managed code.  
  
 Despite the use of the word "safe", compiling applications with **/clr:safe** does not mean there are no bugs; it just means that the CLR can verify the security settings at run time.  
  
 Regardless of assembly type, calls made from managed assemblies to native DLLs via P/Invoke will compile, but may fail at runtime depending on security settings.  
  
> [!NOTE]
>  There is one coding scenario that will pass the compiler but that will result in an unverifiable assembly: calling a virtual function through an object instance using the scope resolution operator.  For example: `MyObj -> A::VirtualFunction();`.  
  
## See Also  
 [.NET Programming in C++](../vs140/.net-programming-with-c---cli--visual-c---.md)