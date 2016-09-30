---
title: "Compiler Error CS0734"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-csharp"
ms.tgt_pltfrm: na
ms.topic: "article"
f1_keywords: 
  - "CS0734"
dev_langs: 
  - "CSharp"
helpviewer_keywords: 
  - "CS0734"
ms.assetid: 9e1b0e49-bfc3-400c-9fd1-37e3c827e656
caps.latest.revision: 11
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Compiler Error CS0734
The /moduleassemblyname option may only be specified when building a target type of 'module'  
  
 The compiler option **/moduleassemblyname** should only be used when building a .netmodule. See [/moduleassemblyname (Specify Friend Assembly for Module) (C# Compiler Option)](../vs140/-moduleassemblyname--csharp-compiler-option-.md) for more information.  
  
 For more information on building a .netmodule, see [/target:module (Create Module to Add to Assembly) (C# Compiler Options)](../vs140/-target-module--csharp-compiler-options-.md).  
  
## Example  
 The following sample generates CS0734. To resolve, add **/target:module** to the compilation.  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>