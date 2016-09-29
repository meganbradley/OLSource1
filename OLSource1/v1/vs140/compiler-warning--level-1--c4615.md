---
title: "Compiler Warning (level 1) C4615"
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
  - "C4615"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "C4615"
ms.assetid: 7b107c01-0da2-4e01-8b40-93813e30b94c
caps.latest.revision: 11
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Compiler Warning (level 1) C4615
\#pragma warning : unknown user warning type  
  
 An invalid warning specifier was used with **pragma** [warning](../vs140/warning.md). To resolve the error, use a valid warning specifier.  
  
 The following sample generates C4615:  
  
```  
// C4615.cpp  
// compile with: /W1 /LD  
#pragma warning(enable : 4401)   // C4615, 'enable' not valid specifier  
  
// use the code below to resolve the error  
// #pragma warning(default : 4401)  
```