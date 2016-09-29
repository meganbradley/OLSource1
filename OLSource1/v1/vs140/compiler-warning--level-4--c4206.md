---
title: "Compiler Warning (level 4) C4206"
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
  - "C4206"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "C4206"
ms.assetid: 3df97812-3ed7-4003-9769-057acf97ce3c
caps.latest.revision: 10
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Compiler Warning (level 4) C4206
**nonstandard extension used : translation unit is empty**  
  
 The file was empty after preprocessing.  
  
 This extension can prevent your code from being portable to other compilers. It generates an error under ANSI compatibility ([/Za](../vs140/-za---ze--disable-language-extensions-.md)) and only applies to C source code.