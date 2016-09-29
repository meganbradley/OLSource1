---
title: "Compiler Error C2111"
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
  - "C2111"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "C2111"
ms.assetid: 38fd42ec-1480-4a44-aaca-ae4593ed5f50
caps.latest.revision: 13
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Compiler Error C2111
'+' : pointer addition requires integral operand  
  
 An attempt was made to add a nonintegral value to a pointer using the plus ( `+` ) operator.  
  
 The following sample generates C2111:  
  
```  
// C2111.cpp  
int main() {  
   int *a = 0, *pa = 0, b = 0;  
   double d = 0.00;  
  
   a = pa + d;   // C2111  
   a = pa + b;   // OK  
}  
```