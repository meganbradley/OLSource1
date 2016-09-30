---
title: "Compiler Warning (level 1) CS1699"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-csharp"
ms.tgt_pltfrm: na
ms.topic: "error-reference"
f1_keywords: 
  - "CS1699"
dev_langs: 
  - "CSharp"
helpviewer_keywords: 
  - "CS1699"
ms.assetid: acf4b57d-8534-4417-9324-65415b5676ae
caps.latest.revision: 16
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Compiler Warning (level 1) CS1699
Use command line option "compiler_option" or appropriate project settings instead of "attribute_name"  
  
 In order to sign an assembly, it is necessary to specify a key file. Prior to [!INCLUDE[csprcsext](../vs140/includes/csprcsext_md.md)], you specified the key file using CLR attributes in source code. These attributes are now deprecated.  
  
 Beginning in [!INCLUDE[csprcsext](../vs140/includes/csprcsext_md.md)], you should use the **Signing Page** of the **Project Designer** or the Assembly Linker to specify the key file.  
  
 The **Signing Page** of the **Project Designer** is the preferred method; for more information, see [Signing Page, Project Designer](../vs140/signing-page--project-designer.md) and [Managing Assembly and Manifest Signing](../vs140/managing-assembly-and-manifest-signing.md).  
  
 The [Assembly Linker (Al.exe)](assetId:///2c30799a-a826-46b4-a25d-c584027a6c67) uses the following compiler options:  
  
-   [/keyfile (Specify Strong Name Key File) (C# Compiler Options)](../vs140/-keyfile--csharp-compiler-options-.md) instead of the \<xref:System.Reflection.AssemblyKeyFileAttribute*> attribute.  
  
-   [/keycontainer (Specify Strong Name Key Container) (C# Compiler Options)](../vs140/-keycontainer--csharp-compiler-options-.md) instead of\<xref:System.Reflection.AssemblyKeyNameAttribute*>.  
  
-   [/delaysign (Delay Sign the Assembly) (C# Compiler Options)](../vs140/-delaysign--csharp-compiler-options-.md) instead of \<xref:System.Reflection.AssemblyDelaySignAttribute*>.  
  
 These attributes have been deprecated for the following reasons:  
  
-   There were security issues due to the attributes being embedded in the binary files produced by the compiler. Everyone who had your binary also had the keys stored in it.  
  
-   There were usability issues due to the fact that the path specified in the attributes was relative to the current working directory, which could change in the integrated development environment (IDE), or to the output directory. Thus, most times the key file is likely to be ..\\\\..\\\mykey.snk. Attributes also make it more difficult for the project system to properly sign satellite assemblies. When you use the compiler options instead of these attributes, you can use a fully qualified path and file name for the key without anything being embedded in the output file; the project system and source code control system can properly manipulate that full path when projects are moved around; the project system can maintain a project-relative path to the key file, and still pass a full path to the compiler; other build programs can more easily sign outputs by passing the proper path directly to the compiler instead of generating a source file with the correct attributes.  
  
-   Using attributes with friend assemblies can hamper compiler efficiency. When you use attributes, the compiler does not know what the key is when it has to decide whether or not to grant friendship and so it has to guess. At the end of compilation, the compiler is able to verify the guess once it finally knows the key. When the key file is specified with a compiler option, the compiler can immediately decide whether to grant friendship.  
  
## Example  
 The following sample generates CS1699. To resolve the error, remove the attribute and compile with **/delaysign**.  
  
```  
// CS1699.cs  
// compile with: /target:library  
[assembly:System.Reflection.AssemblyDelaySign(true)]   // CS1699  
```  
  
## See Also  
 [Signing Page, Project Designer](../vs140/signing-page--project-designer.md)   
 [Managing Assembly and Manifest Signing](../vs140/managing-assembly-and-manifest-signing.md)   
 [Assembly Linker (Al.exe)](assetId:///2c30799a-a826-46b4-a25d-c584027a6c67)