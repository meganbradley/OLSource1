---
title: "Compiler Error CS0463"
ms.custom: na
ms.date: "09/21/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-csharp"
ms.tgt_pltfrm: na
ms.topic: "article"
f1_keywords: 
  - "CS0463"
dev_langs: 
  - "CSharp"
helpviewer_keywords: 
  - "CS0463"
ms.assetid: 0cb4be4e-86ea-4ade-8817-b17d4cacd4d5
caps.latest.revision: 15
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Compiler Error CS0463
Evaluation of the decimal constant expression failed with error: 'error'  
  
 This errors occurs when a constant decimal expression overflows at compile time.  
  
 Typically you get overflow errors at run time. In this case, you defined the constant expression in such a way that the compiler could evaluate the result and know that an overflow would happen.  
  
## Example  
 The following code generates error CS0463.  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>