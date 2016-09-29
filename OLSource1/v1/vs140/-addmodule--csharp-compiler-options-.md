---
title: "-addmodule (C# Compiler Options)"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-csharp"
ms.tgt_pltfrm: na
ms.topic: "article"
H1: "/addmodule (C# Compiler Options)"
f1_keywords: 
  - "/addmodule"
dev_langs: 
  - "CSharp"
helpviewer_keywords: 
  - "/addmodule compiler option [C#]"
  - "-addmodule compiler option [C#]"
  - "addmodule compiler option [C#]"
ms.assetid: ed604546-0dc2-4bd4-9a3e-610a8d973e58
caps.latest.revision: 17
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# -addmodule (C# Compiler Options)
This option adds a module that was created with the target:module switch to the current compilation.  
  
## Syntax  
  
```  
/addmodule:file[;file2]  
```  
  
## Arguments  
 `file`, `file2`  
 An output file that contains metadata. The file cannot contain an assembly manifest. To import more than one file, separate file names with either a comma or a semicolon.  
  
## Remarks  
 All modules added with **/addmodule** must be in the same directory as the output file at run time. That is, you can specify a module in any directory at compile time but the module must be in the application directory at run time. If the module is not in the application directory at run time, you will get a <xref:System.TypeLoadException*>.  
  
 `file` cannot contain an assembly. For example, if the output file was created with [/target:module](../vs140/-target-module--csharp-compiler-options-.md), its metadata can be imported with **/addmodule**.  
  
 If the output file was created with a **/target** option other than **/target:module**, its metadata cannot be imported with **/addmodule** but can be imported with [/reference](../vs140/-reference--csharp-compiler-options-.md).  
  
 This compiler option is unavailable in Visual Studio; a project cannot reference a module. In addition, this compiler option cannot be changed programmatically.  
  
## Example  
 Compile source file `input.cs` and add metadata from `metad1.netmodule` and `metad2.netmodule` to produce `out.exe`:  
  
```  
csc /addmodule:metad1.netmodule;metad2.netmodule /out:out.exe input.cs  
```  
  
## See Also  
 [C# Compiler Options](../vs140/csharp-compiler-options.md)   
 [NIB How to: Modify Project Properties and Configuration Settings](assetId:///e7184bc5-2f2b-4b4f-aa9a-3ecfcbc48b67)   
 [Multifile Assemblies](assetId:///13509e73-db77-4645-8165-aad8dfaedff6)   
 [How to: Build a Multifile Assembly](assetId:///261c5583-8a76-412d-bda7-9b8ee3b131e5)