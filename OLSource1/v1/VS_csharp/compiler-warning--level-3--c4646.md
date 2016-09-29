---
title: "Compiler Warning (level 3) C4646"
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
  - "C4646"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "C4646"
ms.assetid: 23677e8e-603e-40e0-b99a-2e4894a1278e
caps.latest.revision: 11
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Compiler Warning (level 3) C4646
function declared with __declspec(noreturn) has non-void return type  
  
 A function marked with the [noreturn](../VS_csharp/noreturn.md) `__declspec` modifier should have a [void](../VS_csharp/void--c---.md) return type.  
  
 The following sample generates C4646:  
  
```  
// C4646.cpp  
// compile with: /W3 /WX  
int __declspec(noreturn) TestFunction()  
{   // C4646  make return type void  
}  
```