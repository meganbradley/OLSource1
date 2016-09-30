---
title: "Compiler Error CS0234"
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
  - "CS0234"
dev_langs: 
  - "CSharp"
helpviewer_keywords: 
  - "CS0234"
ms.assetid: 413774cc-b63e-472b-8fe7-cf23ca970a5f
caps.latest.revision: 16
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Compiler Error CS0234
The type or namespace name 'name' does not exist in the namespace 'namespace' (are you missing an assembly reference?)  
  
 A type was expected. Possible causes for this error include the following:  
  
-   An assembly that contains the definition of a type was not referenced in the compilation; use [/reference (Import Metadata)](../vs140/-reference--csharp-compiler-options-.md) to specify the assembly  
  
-   You passed a variable name to the [typeof](../vs140/typeof--csharp-reference-.md) operator.  
  
-   You tried to reference an assembly that is not part of your target .NET Framework profile. For more information, see [Troubleshooting .NET Framework Targeting Errors](../vs140/troubleshooting-.net-framework-targeting-errors.md).  
  
 If you see this error after moving code from one development machine to another, make sure that the project on the new machine has the correct references, and that the versions of the assemblies are the same as on the old machine. You can also use the Object Browser to inspect an assembly and verify whether it contains the types that you expect it to contain.  
  
 The following sample generates CS0234:  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>