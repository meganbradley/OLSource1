---
title: "Compiler Error C2432"
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
  - "C2432"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "C2432"
ms.assetid: 0e3326e8-cab1-45a5-b48d-61edd33793e8
caps.latest.revision: 11
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Compiler Error C2432
illegal reference to 16-bit data in 'identifier'  
  
 A 16-bit register is used as an index or base register. The compiler does not support referencing 16-bit data. 16-bit registers cannot be used as index or base registers when compiling for 32-bit code.  
  
 The following sample generates C2432:  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>