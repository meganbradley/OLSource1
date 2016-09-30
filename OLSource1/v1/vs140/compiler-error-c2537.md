---
title: "Compiler Error C2537"
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
  - "C2537"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "C2537"
ms.assetid: aee81d8e-300e-4a8b-b6c4-b3828398b34e
caps.latest.revision: 12
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Compiler Error C2537
'specifier' : illegal linkage specification  
  
 Possible causes:  
  
1.  The linkage specifier is not supported. Only the "C" linkage specifier is supported.  
  
2.  "C" linkage is specified for more than one function in a set of overloaded functions. This is not allowed.  
  
 The following sample generates C2537:  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>