---
title: "Loops: for...to Expression (F#)"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-fsharp"
ms.tgt_pltfrm: na
ms.topic: "reference"
dev_langs: 
  - "FSharp"
helpviewer_keywords: 
  - "loops [F#]"
  - "to keyword [F#]"
  - "for keyword [F#]"
ms.assetid: bbefda86-6785-40bc-ac02-fe4faf96aac2
caps.latest.revision: 22
author: ""
ms.author: ""
manager: ""
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Loops: for...to Expression (F#)
The `for...to` expression is used to iterate in a loop over a range of values of a loop variable.  
  
## Syntax  
  
```  
for identifier = start [ to | downto ] finish do  
   body-expression  
```  
  
## Remarks  
 The type of the identifier is inferred from the type of the *start* and *finish* expressions. Types for these expressions must be 32-bit integers.  
  
 Although technically an expression, `for...to` is more like a traditional statement in an imperative programming language. The return type for the *body-expression* must be `unit`. The following examples show various uses of the `for...to` expression.  
  
 [!code[FsLangRef2#5101](../vs140/codesnippet/FSharp/loops--for...to-expression--fsharp-_1.fs)]  
  
 The output of the previous code is as follows.  
  
```  
1 2 3 4 5 6 7 8 9 10  
10 9 8 7 6 5 4 3 2 1  
2 3 4 5 6 7 8 9 10 11 12 13 14 15 16 17 18  
```  
  
## See Also  
 [F# Language Reference](../vs140/fsharp-language-reference.md)   
 [Loops: for .. in Expression](../vs140/loops--for...in-expression--fsharp-.md)   
 [Loops: while...do Expression](../vs140/loops--while...do-expression--fsharp-.md)