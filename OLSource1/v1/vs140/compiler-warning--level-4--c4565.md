---
title: "Compiler Warning (level 4) C4565"
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
  - "C4565"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "C4565"
ms.assetid: a71f1341-a4a1-4060-ad1e-9322531883ed
caps.latest.revision: 10
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Compiler Warning (level 4) C4565
'function' : redefinition; the symbol was previously declared with __declspec(modifier)  
  
 A symbol was redefined or redeclared and the second definition or declaration, unlike the first definition or declaration, did not have a `__declspec` modifier (***modifier***). This warning is informational. To fix this warning, delete one of the definitions.  
  
 The following sample generates C4565:  
  
```  
// C4565.cpp  
// compile with: /W4 /LD  
__declspec(noalias) void f();  
void f();   // C4565  
```