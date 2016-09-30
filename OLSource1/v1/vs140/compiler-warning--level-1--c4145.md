---
title: "Compiler Warning (level 1) C4145"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-csharp"
ms.tgt_pltfrm: na
ms.topic: "article"
f1_keywords: 
  - "C4145"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "C4145"
ms.assetid: 0440777a-cca2-4159-aff5-e67a254ad64a
caps.latest.revision: 11
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Compiler Warning (level 1) C4145
'expression1' : relational expression as switch expression; possible confusion with 'expression2'  
  
 A <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> statement uses a relational expression as its control expression, which results in a Boolean value for the **case** statements. Did you mean *expression2*?  
  
## Example  
 The following sample generates C4145:  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>