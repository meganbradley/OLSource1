---
title: "Executing a Program in Preprocessing"
ms.custom: na
ms.date: 09/22/2016
ms.prod: visual-studio-dev14
ms.reviewer: na
ms.suite: na
ms.technology: 
  - devlang-cpp
ms.tgt_pltfrm: na
ms.topic: article
dev_langs: 
  - C++
helpviewer_keywords: 
  - program execution [C++]
ms.assetid: 5ecf123a-20e5-40cd-b8d8-dd5a9fdd4b24
caps.latest.revision: 11
translation.priority.ht: 
  - de-de
  - ja-jp
---
# Executing a Program in Preprocessing
To use a command's exit code during preprocessing, specify the command, with any arguments, within brackets ([ ]). Any macros are expanded before the command is executed. NMAKE replaces the command specification with the command's exit code, which can be used in an expression to control preprocessing.  
  
## See Also  
 [Expressions in Makefile Preprocessing](../vs140/expressions-in-makefile-preprocessing.md)