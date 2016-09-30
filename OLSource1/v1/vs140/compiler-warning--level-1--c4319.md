---
title: "Compiler Warning (level 1) C4319"
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
  - "C4319"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "C4319"
ms.assetid: 1fac8048-9bd6-4552-a21c-192c67772bb9
caps.latest.revision: 11
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Compiler Warning (level 1) C4319
'operator' : zero extending 'type' to 'type' of greater size  
  
 The result of the ~ (bitwise complement) operator is unsigned and then zero-extended when it is converted to a larger type.  
  
 In the following example, ~(a - 1) is evaluated as a 32-bit unsigned long expression and then converted to 64 bits by zero extension. This could lead to unexpected operation results.  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>