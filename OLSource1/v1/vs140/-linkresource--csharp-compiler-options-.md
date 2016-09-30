---
title: "-linkresource (C# Compiler Options)"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-csharp"
ms.tgt_pltfrm: na
ms.topic: "article"
H1: "/linkresource (C# Compiler Options)"
f1_keywords: 
  - "/linkresource"
dev_langs: 
  - "CSharp"
helpviewer_keywords: 
  - "/linkresource compiler option [C#]"
  - "linkres compiler option [C#]"
  - "/linkres compiler option [C#]"
  - "-linkres compiler option [C#]"
  - "-linkresource compiler option [C#]"
  - "linkresource compiler option [C#]"
ms.assetid: 440c26c2-77c1-4811-a0a3-57cce3f5fc96
caps.latest.revision: 21
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# -linkresource (C# Compiler Options)
Creates a link to a .NET Framework resource in the output file. The resource file is not added to the output file. This differs from the [/resource](../vs140/-resource--csharp-compiler-options-.md) option which does embed a resource file in the output file.  
  
## Syntax  
  
```  
/linkresource:filename[,identifier[,accessibility-modifier]]  
```  
  
## Arguments  
 `filename`  
 The .NET Framework resource file to which you want to link from the assembly.  
  
 `identifier` (optional)  
 The logical name for the resource; the name that is used to load the resource. The default is the name of the file.  
  
 `accessibility-modifier` (optional)  
 The accessibility of the resource: public or private. The default is public.  
  
## Remarks  
 By default, linked resources are public in the assembly when they are created with the C# compiler. To make the resources private, specify `private` as the accessibility modifier. No other modifier other than `public` or `private` is allowed.  
  
 **/linkresource** requires one of the [/target](../vs140/-target--csharp-compiler-options-.md) options other than **/target:module**.  
  
 If `filename` is a .NET Framework resource file created, for example, by [Resgen.exe](assetId:///8ef159de-b660-4bec-9213-c3fbc4d1c6f4) or in the development environment, it can be accessed with members in the \<xref:System.Resources*> namespace. For more information, see \<xref:System.Resources.ResourceManager*?displayProperty=fullName>. For all other resources, use the `GetManifestResource`* methods in the \<xref:System.Reflection.Assembly*> class to access the resource at run time.  
  
 The file specified in `filename` can be any format. For example, you may want to make a native DLL part of the assembly, so that it can be installed into the global assembly cache and accessed from managed code in the assembly. The second of the following examples shows how to do this. You can do the same thing in the Assembly Linker. The third of the following examples shows how to do this. For more information, see [Assembly Linker (Al.exe)](assetId:///b5382965-0053-47cf-b92f-862860275a01) and [Working with Assemblies and the Global Assembly Cache](assetId:///8a18e5c2-d41d-49ef-abcb-7c27e2469433).  
  
 **/linkres** is the short form of **/linkresource**.  
  
 This compiler option is unavailable in Visual Studio and cannot be changed programmatically.  
  
## Example  
 Compile `in.cs` and link to resource file `rf.resource`:  
  
```  
csc /linkresource:rf.resource in.cs  
```  
  
## Example  
 Compile `A.cs` into a DLL, link to a native DLL N.dll, and put the output in the Global Assembly Cache (GAC). In this example, both A.dll and N.dll will reside in the GAC.  
  
```  
csc /linkresource:N.dll /t:library A.cs  
gacutil -i A.dll  
```  
  
## Example  
 This example does the same thing as the previous one, but by using Assembly Linker options.  
  
```  
csc /t:module A.cs  
al /out:A.dll A.netmodule /link:N.dll   
gacutil -i A.dll  
```  
  
## See Also  
 [C# Compiler Options](../vs140/csharp-compiler-options.md)   
 [Assembly Linker (Al.exe)](assetId:///b5382965-0053-47cf-b92f-862860275a01)   
 [Working with Assemblies and the Global Assembly Cache](assetId:///8a18e5c2-d41d-49ef-abcb-7c27e2469433)   
 [NIB How to: Modify Project Properties and Configuration Settings](assetId:///e7184bc5-2f2b-4b4f-aa9a-3ecfcbc48b67)