---
title: "auto Keyword"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-cpp"
ms.tgt_pltfrm: na
ms.topic: "language-reference"
f1_keywords: 
  - "auto"
  - "auto_cpp"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "automatic storage class, auto keyword"
  - "auto keyword"
ms.assetid: 744a41c0-2510-4140-a1be-96257e722908
caps.latest.revision: 18
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# auto Keyword
The `auto` keyword is a declaration specifier. However, the C++ standard defines an original and a revised meaning for this keyword. Before [!INCLUDE[cpp_dev10_long](../vs140/includes/cpp_dev10_long_md.md)], the `auto` keyword declares a variable in the *automatic* storage class; that is, a variable that has a local lifetime. Starting with [!INCLUDE[cpp_dev10_long](../vs140/includes/cpp_dev10_long_md.md)], the`auto` keyword declares a variable whose type is deduced from the initialization expression in its declaration. The [/Zc:auto&#91;-&#93;](../vs140/-zc-auto--deduce-variable-type-.md) compiler option controls the meaning of the `auto` keyword.  
  
## Syntax  
  
```cpp  
auto declarator ;  
auto declarator initializer;  
```  
  
## Remarks  
 The definition of the `auto` keyword changes in the C++ programming language, but not in the C programming language.  
  
 The following topics describe the `auto` keyword and the corresponding compiler option:  
  
-   [auto Keyword (Type Deduction)](../vs140/auto--c---.md) describes the new definition of the `auto` keyword.  
  
-   [(NOTINBUILD)auto Keyword (Storage-Class Specifier)](assetId:///c7d0cecf-393d-4058-a6e6-b39e31d9edb0) describes the original definition of the `auto` keyword.  
  
-   [/Zc:auto (Deduce Variable Type)](../vs140/-zc-auto--deduce-variable-type-.md) describes the compiler option that tells the compiler which definition of the `auto` keyword to use.  
  
## See Also  
 [(NOTINBUILD)Storage-Class Specifiers](assetId:///10b3d22d-cb40-450b-994b-08cf9a211b6c)   
 [Keywords](../vs140/keywords--c---.md)