---
title: "Compiler Error C2904"
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
  - "C2904"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "C2904"
ms.assetid: d5802f2e-d3fc-473d-aa04-36957b4eaca5
caps.latest.revision: 11
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Compiler Error C2904
'identifier' : name already used for a template in the current scope  
  
 Check the code for duplicate names.  
  
 The following sample generates C2904:  
  
```  
// C2904.cpp  
// compile with: /c  
void X();  // X is declared as a function  
template<class T> class X{};  // C2904  
```