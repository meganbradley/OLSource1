---
title: "Compiler Warning (level 1) C4074"
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
  - "C4074"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "C4074"
ms.assetid: cd510e66-c338-4a86-a4d7-bfa1df9b16c3
caps.latest.revision: 11
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Compiler Warning (level 1) C4074
initializers put in compiler reserved initialization area  
  
 The compiler initialization area, which is specified by [#pragma init_seg](../vs140/init_seg.md), is reserved by Microsoft. Code in this area may be executed before initialization of the C run-time library.  
  
 The following sample generates C4074:  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>