---
title: "Compiler Warning (level 1) C4606"
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
  - "C4606"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "C4606"
ms.assetid: c1b45fb6-672b-42eb-9e1c-c67b3e4150d3
caps.latest.revision: 10
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Compiler Warning (level 1) C4606
\#pragma warning : 'warning_number' ignored; Code Analysis warnings are not associated with warning levels  
  
 For Code Analysis warnings, only `error`, `once`, and `default` are supported with the [warning](../vs140/warning.md) pragma.  
  
## Example  
 The following sample generates C4606.  
  
```  
// C4606.cpp  
// compile with: /c /W1  
#pragma warning(1: 6001)   // C4606  
#pragma warning(once: 6001)   // OK  
```