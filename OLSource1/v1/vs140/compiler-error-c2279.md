---
title: "Compiler Error C2279"
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
  - "C2279"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "C2279"
ms.assetid: 1b5c88ef-2336-49b8-9ddb-d61f97c73e14
caps.latest.revision: 15
author: ""
ms.author: ""
manager: ""
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Compiler Error C2279
exception specification cannot appear in a typedef declaration  
  
 Under **/Za**, [exception specifications](../vs140/exception-specifications--throw---c---.md) are not allowed in a typedef declaration.  
  
 The following sample generates C2279:  
  
```  
// C2279.cpp  
// compile with: /Za /c  
typedef int (*xy)() throw(...);   // C2279  
typedef int (*xyz)();   // OK  
```