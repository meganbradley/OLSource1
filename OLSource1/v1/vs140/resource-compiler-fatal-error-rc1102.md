---
title: "Resource Compiler Fatal Error RC1102"
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
  - "RC1102"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "RC1102"
ms.assetid: bd2091f8-ef5e-4151-a8d6-98043e9422b6
caps.latest.revision: 10
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Resource Compiler Fatal Error RC1102
internal error : too many arguments to RCPP  
  
 Too many arguments were passed to the Resource Compiler preprocessor. Reduce the number of symbols defined with the Define Symbols (/d) option by defining them in your source. This error can also be caused by specifying too many include file search paths using the Include Search Path option (/i).