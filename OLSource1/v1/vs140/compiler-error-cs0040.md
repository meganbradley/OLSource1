---
title: "Compiler Error CS0040"
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
  - "CS0040"
dev_langs: 
  - "CSharp"
helpviewer_keywords: 
  - "CS0040"
ms.assetid: 6a600166-0335-4b6d-b050-6821b4624c96
caps.latest.revision: 12
author: ""
ms.author: ""
manager: ""
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Compiler Error CS0040
Unexpected error creating debug information file — 'reason'  
  
 This error can occur when using the [/debug](../vs140/-debug--csharp-compiler-options-.md) compiler option and indicates that the compiler was unable to write to the .pdb file. Possible resolutions to this error include reinstalling Visual Studio, ensuring that the compiler has write access to a file or directory, or not compiling with /debug.