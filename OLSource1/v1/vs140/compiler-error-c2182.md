---
title: "Compiler Error C2182"
ms.custom: na
ms.date: 09/22/2016
ms.prod: visual-studio-dev14
ms.reviewer: na
ms.suite: na
ms.technology: 
  - devlang-csharp
ms.tgt_pltfrm: na
ms.topic: article
f1_keywords: 
  - C2182
dev_langs: 
  - C++
helpviewer_keywords: 
  - C2182
ms.assetid: dfd8d47d-9606-496e-bd96-4bf41ba1f857
caps.latest.revision: 12
translation.priority.ht: 
  - de-de
  - ja-jp
---
# Compiler Error C2182
'identifier' : illegal use of type 'void'  
  
 A variable is declared type `void`.  
  
 The following sample generates C2182:  
  
```  
// C2182.cpp  
// compile with: /c  
int main() {  
   int i = 10;  
   void &ir = i;   // C2182 cannot have a reference to type void  
   int &ir = i;   // OK  
}  
```