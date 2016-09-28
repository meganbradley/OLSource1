---
title: "Expression Evaluator Error CXX0052"
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
  - "CXX0052"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "CXX0052"
  - "CAN0052"
ms.assetid: 5060d479-d0a4-4682-b858-c8b9a4f324e6
caps.latest.revision: 10
author: ""
ms.author: ""
manager: ""
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Expression Evaluator Error CXX0052
member function not present  
  
 A member function was specified as a breakpoint but could not be found. Setting a breakpoint at a function that has been inlined can cause this error.  
  
 Recompile the file with inlining forced off (/Ob0) to set a breakpoint in this function.  
  
 An expression called a function that was not defined.  
  
 This error is identical to CAN0052.