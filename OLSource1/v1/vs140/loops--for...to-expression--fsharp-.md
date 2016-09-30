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
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Loops: for...to Expression (F#)
The <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> expression is used to iterate in a loop over a range of values of a loop variable.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Remarks  
 The type of the identifier is inferred from the type of the *start* and *finish* expressions. Types for these expressions must be 32-bit integers.  
  
 Although technically an expression, <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> is more like a traditional statement in an imperative programming language. The return type for the *body-expression* must be <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>. The following examples show various uses of the <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> expression.  
  
 [!code[FsLangRef2#5101](../vs140/codesnippet/FSharp/loops--for...to-expression--fsharp-_1.fs)]  
  
 The output of the previous code is as follows.  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
## See Also  
 [F# Language Reference](../vs140/fsharp-language-reference.md)   
 [Loops: for .. in Expression](../vs140/loops--for...in-expression--fsharp-.md)   
 [Loops: while...do Expression](../vs140/loops--while...do-expression--fsharp-.md)