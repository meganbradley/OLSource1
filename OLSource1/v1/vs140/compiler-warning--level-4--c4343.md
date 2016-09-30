---
title: "Compiler Warning (level 4) C4343"
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
  - "C4343"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "C4343"
ms.assetid: a721b710-e04f-4d15-b678-e4a2c8fd0181
caps.latest.revision: 12
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Compiler Warning (level 4) C4343
\#pragma optimize("g",off) overrides /Og option  
  
 This warning, only valid in the Itanium Processor Family (IPF) compiler, reports that a pragma [optimize](../vs140/optimize.md) overrode a [/Og](../vs140/-og--global-optimizations-.md) compiler option.  
  
 The following sample generates C4343:  
  
```  
// C4343.cpp  
// compile with: /Og /W4 /LD  
// processor: IPF  
#pragma optimize ("g", off)   // C4343  
```