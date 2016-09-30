---
title: "Compiler Warning (level 1) C4313"
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
  - "C4313"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "C4313"
ms.assetid: bcf64191-e2cf-452e-97b4-423fcec2d07c
caps.latest.revision: 14
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Compiler Warning (level 1) C4313
'function' : 'format specifier' in format string conflicts with argument number of type 'type'  
  
 There is a conflict between the format specified and the value that you are passing. For example, you passed a 64-bit parameter to an unqualified %d format specifier, which expects a 32-bit integer parameter. This warning is only in effect when the code is compiled for 64-bit targets.  
  
## Example  
 The following code sample generates C4313 when it is compiled for a 64-bit target.  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>