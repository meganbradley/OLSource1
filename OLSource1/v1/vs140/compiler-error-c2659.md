---
title: "Compiler Error C2659"
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
  - "C2659"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "C2659"
ms.assetid: b0883600-4d27-4ca7-a931-8ca6bd48654d
caps.latest.revision: 15
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Compiler Error C2659
'operator' : function as left operand  
  
 A function was on the left side of the specified operator. The most common reason for this error is that the compiler has parsed the identifier on the left side of the operator as a function when the developer intended it to be a variable. For more information, see Wikipedia article [Most vexing parse](http://en.wikipedia.org/wiki/Most_vexing_parse). This example shows a function declaration and a variable definition that are easily confused:  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
 To resolve this issue, change the declaration of the identifier so that it is not parsed as a function declaration.  
  
 Error C2659 can also occur when the function has a type that can’t be used in the expression on the left side of the specified operator. This example generates C2659 when the code assigns a function pointer to a function:  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>