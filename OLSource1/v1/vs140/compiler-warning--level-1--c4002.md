---
title: "Compiler Warning (level 1) C4002"
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
  - "C4002"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "C4002"
ms.assetid: 6bda1dfe-e2e4-4771-9794-5a404c466dd5
caps.latest.revision: 12
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Compiler Warning (level 1) C4002
too many actual parameters for macro 'identifier'  
  
 The number of actual parameters in the macro exceeds the number of formal parameters in the macro definition. The preprocessor collects the extra parameters but ignores them during macro expansion.  
  
 C4002 can occur when incorrectly using [Variadic Macros](../vs140/variadic-macros.md).  
  
 The following sample generates C4002:  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
 This error can also be generated as a result of compiler conformance work that was done for Visual Studio .NET 2003: extra commas in macro no longer accepted.  
  
 The compiler will no longer accept extra commas in a macro. For code to be valid in both the Visual Studio .NET 2003 and Visual Studio .NET versions of Visual C++, remove the extra commas.  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>