---
title: "Compiler Error CS1557"
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
  - "CS1557"
dev_langs: 
  - "CSharp"
helpviewer_keywords: 
  - "CS1557"
ms.assetid: 1615e028-aeb7-4788-bd87-8e49e502d698
caps.latest.revision: 12
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Compiler Error CS1557
Cannot use 'class' for Main method because it is in a different output file  
  
 The [/main](../vs140/-main--csharp-compiler-options-.md) compiler option was specified for one output file in a multi-output file compilation. However, the class was not found in the source code for the /main compilation; it was found in a source code file for one of the other output files in the compilation.