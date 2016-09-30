---
title: "Compiler Warning (level 1) CS3013"
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
  - "CS3013"
dev_langs: 
  - "CSharp"
helpviewer_keywords: 
  - "CS3013"
ms.assetid: 00b3bbe1-f2a0-465c-be0e-1af700c5753d
caps.latest.revision: 13
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Compiler Warning (level 1) CS3013
Added modules must be marked with the CLSCompliant attribute to match the assembly  
  
 A module that was compiled with the [/target:module](../vs140/-target-module--csharp-compiler-options-.md) compiler option was added to a compilation with [/addmodule](../vs140/-addmodule--csharp-compiler-options-.md). However, the module's compliance with the Common Language Specification (CLS) does not agree with the CLS state of the current compilation.  
  
 CLS compliance is indicated with the module attribute. For example, <CodeContentPlaceHolder>0\</CodeContentPlaceHolder> indicates that the module is CLS compliant, and <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> indicates that the module is not CLS compliant. The default is <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>. For more information on the CLS, see [What Is the Common Language Specification](assetId:///4f0b77d0-4844-464f-af73-6e06bedeafc6).