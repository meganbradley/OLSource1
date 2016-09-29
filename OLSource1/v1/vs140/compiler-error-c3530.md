---
title: "Compiler Error C3530"
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
  - "C3530"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "C3530"
ms.assetid: 21be81ce-b699-4c74-81bc-80a0c34d2d5a
caps.latest.revision: 9
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Compiler Error C3530
'auto' cannot be combined with any other type-specifier  
  
 A type specifier is used with the `auto` keyword.  
  
### To correct this error  
  
1.  Do not use a type specifier in a variable declaration that uses the `auto` keyword.  
  
## Example  
 The following example yields C3530 because variable `x` is declared with both the `auto` keyword and type `int`, and because the example is compiled with **/Zc:auto**.  
  
```  
// C3530.cpp  
// Compile with /Zc:auto  
int main()  
{  
   auto int x;   // C3530  
   return 0;  
}  
```  
  
## See Also  
 [auto Keyword](../vs140/auto-keyword.md)