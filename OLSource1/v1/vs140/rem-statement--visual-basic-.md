---
title: "REM Statement (Visual Basic)"
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
  - "vb.'"
  - "vb.Rem"
  - "Rem"
  - "'"
dev_langs: 
  - "VB"
helpviewer_keywords: 
  - "REM statement"
  - "comments, Visual Basic code"
  - "code comments, Visual Basic"
  - "Visual Basic code, comments"
  - "' comment marker character [Visual Basic]"
ms.assetid: 34126d7f-e0f9-476d-91e6-b31b398615dc
caps.latest.revision: 15
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# REM Statement (Visual Basic)
Used to include explanatory remarks in the source code of a program.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Parts  
 <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 Optional. The text of any comment you want to include. A space is required between the <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> keyword and <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>.  
  
## Remarks  
 You can put a <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> statement alone on a line, or you can put it on a line following another statement. The <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> statement must be the last statement on the line. If it follows another statement, the <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> must be separated from that statement by a space.  
  
 You can use a single quotation mark (<CodeContentPlaceHolder>7\</CodeContentPlaceHolder>) instead of <CodeContentPlaceHolder>8\</CodeContentPlaceHolder>. This is true whether your comment follows another statement on the same line or sits alone on a line.  
  
> [!NOTE]
>  You cannot continue a <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> statement by using a line-continuation sequence (<CodeContentPlaceHolder>10\</CodeContentPlaceHolder>). Once a comment begins, the compiler does not examine the characters for special meaning. For a multiple-line comment, use another <CodeContentPlaceHolder>11\</CodeContentPlaceHolder> statement or a comment symbol (<CodeContentPlaceHolder>12\</CodeContentPlaceHolder>) on each line.  
  
## Example  
 The following example illustrates the <CodeContentPlaceHolder>13\</CodeContentPlaceHolder> statement, which is used to include explanatory remarks in a program. It also shows the alternative of using the single quotation-mark character (<CodeContentPlaceHolder>14\</CodeContentPlaceHolder>) instead of <CodeContentPlaceHolder>15\</CodeContentPlaceHolder>.  
  
 [!code[VbVbalrStatements#6](../vs140/codesnippet/VisualBasic/rem-statement--visual-basic-_1.vb)]  
  
## See Also  
 [Comments in Code](../vs140/comments-in-code--visual-basic-.md)   
 [How to: Break and Combine Statements in Code](../vs140/how-to--break-and-combine-statements-in-code--visual-basic-.md)