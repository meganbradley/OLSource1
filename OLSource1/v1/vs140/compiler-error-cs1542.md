---
title: "Compiler Error CS1542"
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
  - "CS1542"
dev_langs: 
  - "CSharp"
helpviewer_keywords: 
  - "CS1542"
ms.assetid: d7f60aa2-6645-472c-ac12-fa57a09fbd87
caps.latest.revision: 11
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Compiler Error CS1542
'dll' cannot be added to this assembly because it already is an assembly; use '/R' option instead  
  
 The file that was referenced with the [/addmodule](../vs140/-addmodule--csharp-compiler-options-.md) compiler option was not built with [/target:module](../vs140/-target-module--csharp-compiler-options-.md); use [/reference](../vs140/-reference--csharp-compiler-options-.md) to reference the file in this compilation.