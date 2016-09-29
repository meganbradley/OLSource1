---
title: "Compiler Warning (level 1) C4552"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-cpp"
ms.tgt_pltfrm: na
ms.topic: "error-reference"
f1_keywords: 
  - "C4552"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "C4552"
ms.assetid: ebbbb5ee-1c19-45bd-b386-41a19630fc76
caps.latest.revision: 10
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Compiler Warning (level 1) C4552
'operator' : operator has no effect; expected operator with side-effect  
  
 If an expression statement has an operator with no side effect as the top of the expression, it's probably a mistake.  
  
 To override this warning, put the expression in parentheses.  
  
 The following sample generates C4552:  
  
```  
// C4552.cpp  
// compile with: /W1  
int main() {  
   int i, j;  
   i + j;   // C4552  
   // try the following line instead  
   // (i + j);  
}  
```