---
title: "-moduleassemblyname (C# Compiler Option)"
ms.custom: na
ms.date: 09/22/2016
ms.prod: visual-studio-dev14
ms.reviewer: na
ms.suite: na
ms.technology: 
  - devlang-csharp
ms.tgt_pltfrm: na
ms.topic: article
H1: /moduleassemblyname (C# Compiler Option)
f1_keywords: 
  - /moduleassemblyname
dev_langs: 
  - CSharp
helpviewer_keywords: 
  - moduleassemblyname compiler option [C#]
  - /moduleassemblyname compiler option [C#]
  - .moduleassemblyname compiler option [C#]
ms.assetid: d464d9b9-f18d-423b-95e9-66c7878fd53a
caps.latest.revision: 14
translation.priority.ht: 
  - de-de
  - ja-jp
---
# -moduleassemblyname (C# Compiler Option)
Specifies an assembly whose non-public types a .netmodule can access.  
  
## Syntax  
  
```  
/moduleassemblyname:assembly_name  
```  
  
## Arguments  
 `assembly_name`  
 The name of the assembly whose non-public types the .netmodule can access.  
  
## Remarks  
 **/moduleassemblyname** should be used when building a .netmodule, and where the following conditions are true:  
  
-   The .netmodule needs access to non-public types in an existing assembly.  
  
-   You know the name of the assembly into which the .netmodule will be built.  
  
-   The existing assembly has granted friend assembly access to the assembly into which the .netmodule will be built.  
  
 For more information on building a .netmodule, see [/target:module (Create Module to Add to Assembly) (C# Compiler Options)](../vs140/-target-module--csharp-compiler-options-.md).  
  
 For more information on friend assemblies, see [Friend Assemblies (C# Programmer's Reference)](../vs140/friend-assemblies--csharp-and-visual-basic-.md).  
  
 This option is not available from within the development environment; it is only available when compiling from the command line.  
  
 This compiler option is unavailable in Visual Studio and cannot be changed programmatically.  
  
## Example  
 This sample builds an assembly with a private type, and that gives friend assembly access to an assembly called csman_an_assembly.  
  
```  
// moduleassemblyname_1.cs  
// compile with: /target:library  
using System;  
using System.Runtime.CompilerServices;  
  
[assembly:InternalsVisibleTo ("csman_an_assembly")]  
  
class An_Internal_Class   
{  
    public void Test()   
    {   
        Console.WriteLine("An_Internal_Class.Test called");   
    }  
}  
```  
  
## Example  
 This sample builds a .netmodule that accesses a non-public type in the assembly moduleassemblyname_1.dll. By knowing that this .netmodule will be built into an assembly called csman_an_assembly, we can specify **/moduleassemblyname**, allowing the .netmodule to access non-public types in an assembly that has granted friend assembly access to csman_an_assembly.  
  
```  
// moduleassemblyname_2.cs  
// compile with: /moduleassemblyname:csman_an_assembly /target:module /reference:moduleassemblyname_1.dll  
class B {  
    public void Test() {  
        An_Internal_Class x = new An_Internal_Class();  
        x.Test();  
    }  
}  
```  
  
## Example  
 This code sample builds the assembly csman_an_assembly, referencing the previously-built assembly and .netmodule.  
  
```  
// csman_an_assembly.cs  
// compile with: /addmodule:moduleassemblyname_2.netmodule /reference:moduleassemblyname_1.dll  
class A {  
    public static void Main() {  
        B bb = new B();  
        bb.Test();  
    }  
}  
```  
  
 **An_Internal_Class.Test called**   
## See Also  
 [C# Compiler Options](../vs140/csharp-compiler-options.md)   
 [NIB How to: Modify Project Properties and Configuration Settings](assetId:///e7184bc5-2f2b-4b4f-aa9a-3ecfcbc48b67)