---
title: "Compiler Error C2345"
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
  - "C2345"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "C2345"
ms.assetid: e1cc88b0-0223-4d07-975b-fa99956a82bd
caps.latest.revision: 13
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Compiler Error C2345
align(value) : illegal alignment value  
  
 You passed a value to the [align](../vs140/align--c---.md) keyword that is outside the allowable range.  
  
 The following code generates C2345  
  
```  
// C2345.cpp  
// compile with: /c  
__declspec(align(0)) int a;   // C2345  
__declspec(align(1)) int a;   // OK  
```