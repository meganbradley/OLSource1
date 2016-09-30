---
title: "Compiler Warning (level 1) C4177"
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
  - "C4177"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "C4177"
ms.assetid: 2b05a5b3-696e-4f21-818e-227b9335e748
caps.latest.revision: 11
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Compiler Warning (level 1) C4177
\#pragma pragma should be at global scope  
  
 The [pragma](../vs140/pragma-directives-and-the-__pragma-keyword.md) pragma should not be used within a local scope. The **pragma** will not be valid until global scope is encountered after the current scope.  
  
 The following sample generates C4177:  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>