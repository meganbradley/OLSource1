---
title: "Compiler Error CS2020"
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
  - "CS2020"
dev_langs: 
  - "CSharp"
helpviewer_keywords: 
  - "CS2020"
ms.assetid: b2db7a05-5965-4a9b-86c3-0c4792b29a6c
caps.latest.revision: 11
author: ""
ms.author: ""
manager: ""
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Compiler Error CS2020
Only the first set of input files can build a target other than 'module'  
  
 In a multi-output compilation, the first output file must be built with [/target:exe](../vs140/-target-exe--csharp-compiler-options-.md), [/target:winexe](../vs140/-target-winexe--csharp-compiler-options-.md), or [/target:library](../vs140/-target-library--csharp-compiler-options-.md). Any subsequent output files must be built with [/target:module](../vs140/-target-module--csharp-compiler-options-.md).