---
title: "-reference (Visual Basic)"
ms.custom: na
ms.date: 09/22/2016
ms.prod: visual-studio-dev14
ms.reviewer: na
ms.suite: na
ms.technology: 
  - devlang-visual-basic
ms.tgt_pltfrm: na
ms.topic: article
H1: /reference (Visual Basic)
dev_langs: 
  - VB
helpviewer_keywords: 
  - /reference compiler option [Visual Basic]
  - r compiler option [Visual Basic]
  - -reference compiler option [Visual Basic]
  - /r compiler option [Visual Basic]
  - reference compiler option [Visual Basic]
  - -r compiler option [Visual Basic]
ms.assetid: 66bdfced-bbf6-43d1-a554-bc0990315737
caps.latest.revision: 20
translation.priority.ht: 
  - de-de
  - ja-jp
---
# -reference (Visual Basic)
Causes the compiler to make type information in the specified assemblies available to the project you are currently compiling.  
  
## Syntax  
  
```  
/reference:fileList  
' -or-  
/r:fileList  
```  
  
## Arguments  
  
|||  
|-|-|  
|Term|Definition|  
|`fileList`|Required. Comma-delimited list of assembly file names. If the file name contains a space, enclose the name in quotation marks.|  
  
## Remarks  
 The file(s) you import must contain assembly metadata. Only public types are visible outside the assembly. The [/addmodule](../vs140/-addmodule.md) option imports metadata from a module.  
  
 If you reference an assembly (Assembly A) which itself references another assembly (Assembly B), you need to reference Assembly B if:  
  
-   A type from Assembly A inherits from a type or implements an interface from Assembly B.  
  
-   A field, property, event, or method that has a return type or parameter type from Assembly B is invoked.  
  
 Use [/libpath](../vs140/-libpath.md) to specify the directory in which one or more of your assembly references is located.  
  
 For the compiler to recognize a type in an assembly (not a module), it must be forced to resolve the type. One example of how you can do this is to define an instance of the type. Other ways are available to resolve type names in an assembly for the compiler. For example, if you inherit from a type in an assembly, the type name then becomes known to the compiler.  
  
 The Vbc.rsp response file, which references commonly used [!INCLUDE[dnprdnshort](../vs140/includes/dnprdnshort_md.md)] assemblies, is used by default. Use `/noconfig` if you do not want the compiler to use Vbc.rsp.  
  
 The short form of `/reference` is `/r`.  
  
## Example  
 The following code compiles source file I`nput.vb` and reference assemblies from M`etad1.dll` and M`etad2.dll` to produce O`ut.exe`.  
  
```  
vbc /reference:metad1.dll,metad2.dll /out:out.exe input.vb  
```  
  
## See Also  
 [Visual Basic Command-Line Compiler](../vs140/visual-basic-command-line-compiler.md)   
 [/noconfig](../vs140/-noconfig.md)   
 [/target (Visual Basic)](../vs140/-target--visual-basic-.md)   
 [Public](../vs140/public--visual-basic-.md)   
 [Sample Compilation Command Lines](../vs140/sample-compilation-command-lines--visual-basic-.md)