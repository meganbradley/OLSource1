---
title: "Compiler Error C3199"
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
  - "C3199"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "C3199"
ms.assetid: e7a478d3-115a-40a3-991b-c7454fd2e28e
caps.latest.revision: 11
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Compiler Error C3199
invalid use of floating-point pragmas: exceptions are not supported in non-precise mode  
  
 The [float_control](../vs140/float_control.md) pragma was used to specify floating-point exception model under an [/fp](../vs140/-fp--specify-floating-point-behavior-.md) setting other than **/fp:precise**.  
  
 The following sample generates C3199:  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>