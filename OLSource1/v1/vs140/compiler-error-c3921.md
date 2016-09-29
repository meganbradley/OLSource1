---
title: "Compiler Error C3921"
ms.custom: na
ms.date: "09/21/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-cpp"
ms.tgt_pltfrm: na
ms.topic: "error-reference"
f1_keywords: 
  - "C3921"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "C3921"
ms.assetid: 2424fa74-2833-4cc7-867d-c6ca685b75a9
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Compiler Error C3921
Use of S-prefixed strings requires /clr:oldSyntax command line option  
  
 You do not need to explicitly specify that a string is a CLR string.  
  
## Example  
 The following sample generates C3921.  
  
```  
// C3921.cpp  
// compile with: /clr  
using namespace System;  
  
int main() {  
   String ^ s = S"CLR string literal";   // C3921  
  
   // try the following line instead  
   String ^ s2 = "CLR string literal";  
}  
```