---
title: "Compiler Warning (Level 2) CS1927"
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
  - "CS1927"
dev_langs: 
  - "CSharp"
helpviewer_keywords: 
  - "CS1927"
ms.assetid: 32b4e58f-668c-4596-9529-7f3a293ff4ac
caps.latest.revision: 9
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Compiler Warning (Level 2) CS1927
Ignoring /win32manifest for module because it only applies to assemblies.  
  
 A win32 manifest is only applied at the assembly level. Your module will compile but it will not have a manifest.  
  
### To correct this error  
  
1.  Remove the **/win32manifest option**.  
  
2.  Compile the code as an assembly.  
  
## Example  
 The following example generates CS1927 when it is compiled with both the **/target:module** and **/win32manifest** compiler options.  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## See Also  
 [/win32manifest (Import a Custom Win32 Manifest File) (C# Compiler Options)](../vs140/-win32manifest--csharp-compiler-options-.md)   
 [/target:module (Create Module to Add to Assembly) (C# Compiler Options)](../vs140/-target-module--csharp-compiler-options-.md)