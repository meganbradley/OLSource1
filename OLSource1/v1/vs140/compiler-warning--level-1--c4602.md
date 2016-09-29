---
title: "Compiler Warning (level 1) C4602"
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
  - "C4602"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "C4602"
ms.assetid: c1f0300f-e2a2-4c9e-a7c3-4c7318d10509
caps.latest.revision: 12
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Compiler Warning (level 1) C4602
\#pragma pop_macro : 'macro name' no previous #pragma push_macro for this identifier  
  
 If you use [pop_macro](../vs140/pop_macro.md) for a particular macro, you must first have passed that macro name to [push_macro](../vs140/push_macro.md). For example, the following sample generates C4602:  
  
```  
// C4602.cpp  
// compile with: /W1  
int main()  
{  
   #pragma pop_macro("x")   // C4602 x is not on the stack  
}  
```