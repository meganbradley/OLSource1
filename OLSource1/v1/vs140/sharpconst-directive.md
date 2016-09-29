---
title: "#Const Directive"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-visual-basic"
ms.tgt_pltfrm: na
ms.topic: "article"
f1_keywords: 
  - "vb.#Const"
  - "#vb.Const"
  - "#Const"
dev_langs: 
  - "VB"
helpviewer_keywords: 
  - "#Const directive"
  - "conditional compilation, directives"
  - "Const directive (#Const)"
  - "Visual Basic compiler, compiler directives"
  - "constants, Const directive"
  - "constants, declaring"
  - "Const statement [Visual Basic], directive (#Const)"
  - "declaring constants, #const directive"
ms.assetid: 707669e5-23f9-4f17-8622-a0d534429386
caps.latest.revision: 21
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# #Const Directive
Defines conditional compiler constants for Visual Basic.  
  
## Syntax  
  
```  
#Const constname = expression  
```  
  
## Parts  
 `constname`  
 Required. Name of the constant being defined.  
  
 `expression`  
 Required. Literal, other conditional compiler constant, or any combination that includes any or all arithmetic or logical operators except `Is`.  
  
## Remarks  
 Conditional compiler constants are always private to the file in which they appear. You cannot create public compiler constants using the `#Const` directive; you can create them only in the user interface or with the `/define` compiler option.  
  
 You can use only conditional compiler constants and literals in `expression`. Using a standard constant defined with `Const` causes an error. Conversely, you can use constants defined with the `#Const` keyword only for conditional compilation. Constants can also be undefined, in which case they have a value of `Nothing`.  
  
## Example  
 This example uses the `#Const` directive.  
  
 [!code[VbVbalrConditionalComp#3](../vs140/codesnippet/VisualBasic/sharpconst-directive_1.vb)]  
  
## See Also  
 [/define (Visual Basic)](../vs140/-define--visual-basic-.md)   
 [#If...Then...#Else Directives](../vs140/sharpif...then...sharpelse-directives.md)   
 [Const Statement](../vs140/const-statement--visual-basic-.md)   
 [Conditional Compilation in Visual Basic](../vs140/conditional-compilation-in-visual-basic.md)   
 [If...Then...Else Statement (Visual Basic)](../vs140/if...then...else-statement--visual-basic-.md)