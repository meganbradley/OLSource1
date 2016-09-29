---
title: "Compiler Error C3198"
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
  - "C3198"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "C3198"
ms.assetid: ec4ecf61-0067-4aa4-b443-a91013a1e59d
caps.latest.revision: 12
author: ""
ms.author: ""
manager: ""
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Compiler Error C3198
invalid use of floating-point pragmas: fenv_access pragma operates only in precise mode  
  
 [fenv_access](../vs140/fenv_access.md) pragma was used under an [/fp](../vs140/-fp--specify-floating-point-behavior-.md) setting other than **/fp:precise**.  
  
 The following sample generates C3198:  
  
```  
// C3198.cpp  
// compile with: /fp:fast  
#pragma fenv_access(on)   // C3198  
```