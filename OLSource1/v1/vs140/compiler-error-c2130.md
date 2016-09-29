---
title: "Compiler Error C2130"
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
  - "C2130"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "C2130"
ms.assetid: c6fd5a7e-8f28-4f67-99d1-95a13b0dff90
caps.latest.revision: 14
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Compiler Error C2130
\#line expected a string containing the filename, found 'token'  
  
 The optional file name token following [#line](../vs140/sharpline-directive--c-c---.md) `linenumber` must be a string.  
  
 The following sample generates C2130:  
  
```  
// C2130.cpp  
int main() {  
   #line 1000 test   // C2130  
   #line 1000 "test"   // OK  
}  
```