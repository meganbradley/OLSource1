---
title: "Compiler Error C2019"
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
  - "C2019"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "C2019"
ms.assetid: 4f37b1e1-9eca-418f-a4c3-141e8512d7b6
caps.latest.revision: 11
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Compiler Error C2019
expected preprocessor directive, found 'character'  
  
 The character followed a `#` sign but it is not the first letter of a preprocessor directive.  
  
 The following sample generates C2019:  
  
```  
// C2019.cpp  
#!define TRUE 1   // C2019  
```  
  
 Possible resolution:  
  
```  
// C2019b.cpp  
// compile with: /c  
#define TRUE 1  
```