---
title: "#If...Then...#Else Directives"
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
  - "vb.#EndIf"
  - "#End If"
  - "#Then"
  - "#ElseIf"
  - "vb.#ElseIf"
  - "vb.#Else"
  - "vb.#If"
dev_langs: 
  - "VB"
helpviewer_keywords: 
  - "Visual Basic code, compiling"
  - "#If directive [Visual Basic]"
  - "conditional compilation, directives"
  - "#End if directive [Visual Basic]"
  - "selective compiling"
  - "else directive (#else)"
  - "#Else directive [Visual Basic]"
ms.assetid: 10bba104-e3fd-451b-b672-faa472530502
caps.latest.revision: 18
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# #If...Then...#Else Directives
Conditionally compiles selected blocks of Visual Basic code.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Parts  
 <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 Required for <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> statements, optional elsewhere. Any expression, consisting exclusively of one or more conditional compiler constants, literals, and operators, that evaluates to <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> or <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>.  
  
 <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>  
 Required for <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> statement block, optional elsewhere. Visual Basic program lines or compiler directives that are compiled if the associated expression evaluates to <CodeContentPlaceHolder>8\</CodeContentPlaceHolder>.  
  
 <CodeContentPlaceHolder>9\</CodeContentPlaceHolder>  
 Terminates the <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> statement block.  
  
## Remarks  
 On the surface, the behavior of the <CodeContentPlaceHolder>11\</CodeContentPlaceHolder> directives appears the same as that of the <CodeContentPlaceHolder>12\</CodeContentPlaceHolder> statements. However, the <CodeContentPlaceHolder>13\</CodeContentPlaceHolder> directives evaluate what is compiled by the compiler, whereas the <CodeContentPlaceHolder>14\</CodeContentPlaceHolder> statements evaluate conditions at run time.  
  
 Conditional compilation is typically used to compile the same program for different platforms. It is also used to prevent debugging code from appearing in an executable file. Code excluded during conditional compilation is completely omitted from the final executable file, so it has no effect on size or performance.  
  
 Regardless of the outcome of any evaluation, all expressions are evaluated using <CodeContentPlaceHolder>15\</CodeContentPlaceHolder>. The <CodeContentPlaceHolder>16\</CodeContentPlaceHolder> statement does not affect expressions in <CodeContentPlaceHolder>17\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>18\</CodeContentPlaceHolder> statements.  
  
> [!NOTE]
>  No single-line form of the <CodeContentPlaceHolder>19\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>20\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>21\</CodeContentPlaceHolder>, and <CodeContentPlaceHolder>22\</CodeContentPlaceHolder> directives exists. No other code can appear on the same line as any of the directives.  
  
## Example  
 This example uses the <CodeContentPlaceHolder>23\</CodeContentPlaceHolder> construct to determine whether to compile certain statements.  
  
 [!code[VbVbalrConditionalComp#1](../vs140/codesnippet/VisualBasic/sharpif...then...sharpelse-directives_1.vb)]  
  
## See Also  
 [#Const Directive](../vs140/sharpconst-directive.md)   
 [If...Then...Else Statement](../vs140/if...then...else-statement--visual-basic-.md)   
 [Conditional Compilation](../vs140/conditional-compilation-in-visual-basic.md)