---
title: "Preprocessor Grammar"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-cpp"
ms.tgt_pltfrm: na
ms.topic: "article"
dev_langs: 
  - "C++"
  - "C"
helpviewer_keywords: 
  - "preprocessor"
  - "grammar, preprocessor"
  - "preprocessor, grammar"
ms.assetid: 6cd33fad-0b08-4592-9be8-7359c43e24e9
caps.latest.revision: 11
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Preprocessor Grammar
**#define**  *identifier* *token-string*opt  
  
 *#* **define**  *identifier*[**(** *identifier*opt**,** *...* **,** *identifier*opt **)**] *token-string*opt  
  
 **defined(**  *identifier* **)**  
  
 **defined**  *identifier*  
  
 `#include` **"***path-spec***"**  
  
 `#include` **<***path-spec***>**  
  
 **#line**  *digit-sequence*  **"** *filename* **"**opt  
  
 *#* **undef**  *identifier*  
  
 **#error**  *token-string*  
  
 **#pragma**  *token-string*  
  
 *conditional* :  
 *if-part elif-parts*opt*else-part*opt*endif-line*  
  
 *if-part* :  
 *if-linetext*  
  
 *if-line* :  
 **#if**  *constant-expression*  
  
 **#ifdef**  *identifier*  
  
 **#ifndef**  *identifier*  
  
 *elif-parts* :  
 *elif-line text*  
  
 *elif-parts elif-line text*  
  
 *elif-line* :  
 **#elif**  *constant-expression*  
  
 *else-part* :  
 *else-linetext*  
  
 *else-line* :  
 `#else`  
  
 *endif-line* :  
 `#endif`  
  
 *digit-sequence* :  
 *digit*  
  
 *digit-sequence digit*  
  
 *digit* : one of  
 **0 1 2 3 4 5 6 7 8 9**  
  
 *token-string* :  
 String of tokens  
  
 *token* :  
 *keyword*  
  
 *identifier*  
  
 *constant*  
  
 *operator*  
  
 `punctuator`  
  
 *filename* :  
 Legal operating system filename  
  
 *path-spec* :  
 Legal file path  
  
 *text* :  
 Any sequence of text  
  
> [!NOTE]
>  The following nonterminals are expanded in Appendix A, [Grammar Summary](../vs140/grammar-summary--c---.md), of the *C++ Language Reference*: `constant`, `constant`-*expression*, *identifier*, *keyword*, `operator`, and `punctuator`.  
  
## See Also  
 [Grammar Summary (C/C++)](../vs140/grammar-summary--c-c---.md)