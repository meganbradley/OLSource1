---
title: "Compiler Warning (Level 1) C4733"
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
  - "C4733"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "C4733"
ms.assetid: 7ef4f577-772d-4b66-a7bf-8958a6b250bc
caps.latest.revision: 12
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Compiler Warning (Level 1) C4733
Inline asm assigning to 'FS:0' : handler not registered as safe handler  
  
 A function modifying the value at FS:0 to add a new exception handler may not work with Safe Exceptions, because the handler may not be registered as a valid exception handler (see [/SAFESEH](../vs140/-safeseh--image-has-safe-exception-handlers-.md)).  
  
 To resolve this warning, either remove the FS:0 definition or turn off this warning and use [.SAFESEH](../vs140/.safeseh.md) to specify the safe exception handlers.  
  
 The following sample generates C4733:  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>