---
title: "How to: Migrate to -clr:safe (C++-CLI)"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-cpp"
ms.tgt_pltfrm: na
ms.topic: "article"
H1: "How to: Migrate to /clr:safe (C++/CLI)"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "migration [C++], verifiable assemblies"
  - "upgrading Visual C++ applications, verifiable assemblies"
  - "verifiable assemblies [C++], migrating to"
  - "/clr compiler option [C++], migrating to /clr:safe"
ms.assetid: 75f9aae9-1dcc-448a-aa11-2d96f972f9d2
caps.latest.revision: 19
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# How to: Migrate to -clr:safe (C++-CLI)
Visual C++ can generate verifiable components by using **/clr:safe**, which causes the compiler to generate errors for each non-verifiable code construct.  
  
## Remarks  
 The following issues generate verifiability errors:  
  
-   Native types. Even if it isn't used, the declaration of native classes, structures, pointers, or arrays will prevent compilation.  
  
-   Global variables  
  
-   Function calls into any unmanaged library, including common language runtime function calls  
  
-   A verifiable function cannot contain a [static_cast Operator](../vs140/static_cast-operator.md) for down-casting. The [static_cast Operator](../vs140/static_cast-operator.md) can be used for casting between primitive types, but for down-casting, [safe_cast](../vs140/safe_cast--c---component-extensions-.md) or a C-Style cast (which is implemented as a [safe_cast](../vs140/safe_cast--c---component-extensions-.md)) must be used.  
  
-   A verifiable function cannot contain a [reinterpret_cast Operator](../vs140/reinterpret_cast-operator.md) (or any C-style cast equivalent).  
  
-   A verifiable function cannot perform arithmetic on an [interior_ptr](../vs140/interior_ptr--c---cli-.md). It may only assign to it and dereference it.  
  
-   A verifiable function can only throw or catch pointers to reference types, so value types must be boxed before throwing.  
  
-   A verifiable function can only call verifiable functions (such that calls to the common language runtime are not allowed, include `AtEntry`/`AtExit`, and so global constructors are disallowed).  
  
-   A verifiable class cannot use <xref:System.Runtime.InteropServices.LayoutKind.Explicit*>.  
  
-   If building an EXE, a main function cannot declare any parameters, so <xref:System.Environment.GetCommandLineArgs*> must be used to retrieve command-line arguments.  
  
-   Making a non-virtual call to a virtual function. For example:  
  
    ```  
    // not_verifiable.cpp  
    // compile with: /clr  
    ref struct A {  
       virtual void Test() {}  
    };  
  
    ref struct B : A {};  
  
    int main() {  
       B^ b1 = gcnew B;  
       b1->A::Test();   // Non-virtual call to virtual function  
    }  
    ```  
  
 Also, the following keywords cannot be used in verifiable code:  
  
-   [unmanaged](../vs140/managed--unmanaged.md) and [pack](../vs140/pack.md) pragmas  
  
-   [naked](../vs140/naked--c---.md) and [align](../vs140/align--c---.md) [__declspec](../vs140/__declspec.md) modifiers  
  
-   [__asm](../vs140/__asm.md)  
  
-   [__based](../vs140/__based-grammar.md)  
  
-   [__try](../vs140/try-except-statement.md) and `__except`  
  
## See Also  
 [Pure / Verifiable](../vs140/pure-and-verifiable-code--c---cli-.md)