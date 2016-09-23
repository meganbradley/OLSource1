---
title: "-resource (C# Compiler Options)"
ms.custom: na
ms.date: 09/22/2016
ms.prod: visual-studio-dev14
ms.reviewer: na
ms.suite: na
ms.technology: 
  - devlang-csharp
ms.tgt_pltfrm: na
ms.topic: article
H1: /resource (C# Compiler Options)
f1_keywords: 
  - /resource
dev_langs: 
  - CSharp
helpviewer_keywords: 
  - -resource compiler option [C#]
  - /resource compiler option [C#]
  - -res compiler option [C#]
  - /res compiler option [C#]
  - res compiler option [C#]
  - resource compiler option [C#]
ms.assetid: 5212666e-98ab-47e4-a497-b5545ab15c7f
caps.latest.revision: 18
translation.priority.ht: 
  - de-de
  - ja-jp
---
# -resource (C# Compiler Options)
Embeds the specified resource into the output file.  
  
## Syntax  
  
```  
/resource:filename[,identifier[,accessibility-modifier]]  
```  
  
## Arguments  
 `filename`  
 The .NET Framework resource file that you want to embed in the output file.  
  
 `identifier` (optional)  
 The logical name for the resource; the name that is used to load the resource. The default is the name of the file name.  
  
 `accessibility-modifier` (optional)  
 The accessibility of the resource: public or private. The default is public.  
  
## Remarks  
 Use [/linkresource](../vs140/-linkresource--csharp-compiler-options-.md) to link a resource to an assembly and not add the resource file to the output file.  
  
 By default, resources are public in the assembly when they are created by using the C# compiler. To make the resources private, specify `private` as the accessibility modifier. No other accessibility other than `public` or `private` is allowed.  
  
 If `filename` is a .NET Framework resource file created, for example, by [Resgen.exe](assetId:///8ef159de-b660-4bec-9213-c3fbc4d1c6f4) or in the development environment, it can be accessed with members in the <xref:System.Resources?qualifyHint=False> namespace. For more information, see <xref:System.Resources.ResourceManager?qualifyHint=True>. For all other resources, use the `GetManifestResource`* methods in the <xref:System.Reflection.Assembly?qualifyHint=False> class to access the resource at run time.  
  
 **/res** is the short form of **/resource**.  
  
 The order of the resources in the output file is determined from the order specified on the command line.  
  
### To set this compiler option in the Visual Studio development environment  
  
1.  Add a resource file to your project.  
  
2.  Select the file that you want to embed in **Solution Explorer**.  
  
3.  Select **Build Action** for the file in the **Properties** window.  
  
4.  Set **Build Action** to **Embedded Resource**.  
  
 For information about how to set this compiler option programmatically, see <xref:VSLangProj80.FileProperties2.BuildAction?qualifyHint=False>.  
  
## Example  
 Compile `in.cs` and attach resource file `rf.resource`:  
  
```  
csc /resource:rf.resource in.cs  
```  
  
## See Also  
 [C# Compiler Options](../vs140/csharp-compiler-options.md)   
 [NIB How to: Modify Project Properties and Configuration Settings](assetId:///e7184bc5-2f2b-4b4f-aa9a-3ecfcbc48b67)