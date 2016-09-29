---
title: "Compiler Error CS1509"
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
  - "CS1509"
dev_langs: 
  - "CSharp"
helpviewer_keywords: 
  - "CS1509"
ms.assetid: 51a475c3-f085-49cb-89b0-c6582b68653f
caps.latest.revision: 11
author: ""
ms.author: ""
manager: ""
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Compiler Error CS1509
Referenced file 'file' is not an assembly; use '/addmodule' option instead  
  
 An output file (output file 1), produced in a compilation that used [/target:module](../vs140/-target-module--csharp-compiler-options-.md) (does not have an assembly manifest), was specified to [/reference](../vs140/-reference--csharp-compiler-options-.md). So, rather than appending an assembly to the assembly for the current program, the metadata information in output file 1 will be added to the assembly for the current program.