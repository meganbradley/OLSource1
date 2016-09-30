---
title: "Linker Tools Warning LNK4227"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-cpp"
ms.tgt_pltfrm: na
ms.topic: "error-reference"
f1_keywords: 
  - "LNK4227"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "LNK4227"
ms.assetid: 941a0414-9964-4e02-8487-f9daa42ef7f9
caps.latest.revision: 15
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Linker Tools Warning LNK4227
metadata operation warning (HRESULT) : warning_message  
  
 The linker detected metadata differences when merging:  
  
-   One or more referenced assemblies with the assembly currently being built.  
  
-   One or more source code files in a compilation.  
  
 For example, LNK4227 may be caused if you have two global functions with the same name but parameter information declared differently (declarations are not consistent in all compilands). Use ildasm.exe /TEXT /METADATA <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> on each .obj file and you should see how the types differ.  
  
 LNK4227 also reports problems that originate with another tool. For example, al.exe; see [Al.exe Tool Errors and Warnings](assetId:///7f125d49-0a03-47a6-9ba9-d61a679a7d4b).  
  
 The metadata problems must be fixed to resolve the warning.  
  
 For example, LNK4227 is generated when a referenced assembly was signed differently than the assembly that references it.  
  
 The following sample generates LNK4227:  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
 and then,  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 The following sample generates LNK4227:  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 and then,  
  
<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 LNK4227 can also be generated when version numbers in the wrong format are passed to assembly attributes.  The '*' notation is specific to the AssemblyVersionAttribute.  To resolve this warning, use only numbers in the version attributes other than AssemblyVersionAttribute.  
  
 The following sample generates LNK4227:  
  
<CodeContentPlaceHolder>4\</CodeContentPlaceHolder>