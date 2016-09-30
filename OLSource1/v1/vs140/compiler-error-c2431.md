---
title: "Compiler Error C2431"
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
  - "C2431"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "C2431"
ms.assetid: 88a5b648-c89f-47d1-a20e-63231ab4f0f7
caps.latest.revision: 10
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Compiler Error C2431
illegal index register in 'identifier'  
  
 The ESP register is scaled or used as both index and base register. The SIB encoding for the x86 processor does not allow either.  
  
 The following sample generates C2431:  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>