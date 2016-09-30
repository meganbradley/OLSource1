---
title: "Return Statement (Visual Basic)"
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
  - "vb.Return"
dev_langs: 
  - "VB"
helpviewer_keywords: 
  - "Return statement, syntax"
  - "control flow, returning control to expressions"
  - "Return statement"
  - "expressions [Visual Basic], returning control to"
ms.assetid: ac86e7f0-5a67-42c3-9834-0e0381efa3ec
caps.latest.revision: 19
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Return Statement (Visual Basic)
Returns control to the code that called a <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>, or <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> procedure.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Part  
 <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>  
 Required in a <CodeContentPlaceHolder>7\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>8\</CodeContentPlaceHolder>, or <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> procedure. Expression that represents the value to be returned to the calling code.  
  
## Remarks  
 In a <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> or <CodeContentPlaceHolder>11\</CodeContentPlaceHolder> procedure, the <CodeContentPlaceHolder>12\</CodeContentPlaceHolder> statement is equivalent to an <CodeContentPlaceHolder>13\</CodeContentPlaceHolder> or <CodeContentPlaceHolder>14\</CodeContentPlaceHolder> statement, and <CodeContentPlaceHolder>15\</CodeContentPlaceHolder> must not be supplied.  
  
 In a <CodeContentPlaceHolder>16\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>17\</CodeContentPlaceHolder>, or <CodeContentPlaceHolder>18\</CodeContentPlaceHolder> procedure, the <CodeContentPlaceHolder>19\</CodeContentPlaceHolder> statement must include <CodeContentPlaceHolder>20\</CodeContentPlaceHolder>, and <CodeContentPlaceHolder>21\</CodeContentPlaceHolder> must evaluate to a data type that is convertible to the return type of the procedure. In a <CodeContentPlaceHolder>22\</CodeContentPlaceHolder> or <CodeContentPlaceHolder>23\</CodeContentPlaceHolder> procedure, you also have the alternative of assigning an expression to the procedure name to serve as the return value, and then executing an <CodeContentPlaceHolder>24\</CodeContentPlaceHolder> or <CodeContentPlaceHolder>25\</CodeContentPlaceHolder> statement. In an <CodeContentPlaceHolder>26\</CodeContentPlaceHolder> procedure, you must use <CodeContentPlaceHolder>27\</CodeContentPlaceHolder>.  
  
 You can include as many <CodeContentPlaceHolder>28\</CodeContentPlaceHolder> statements as appropriate in the same procedure.  
  
> [!NOTE]
>  The code in a <CodeContentPlaceHolder>29\</CodeContentPlaceHolder> block runs after a <CodeContentPlaceHolder>30\</CodeContentPlaceHolder> statement in a <CodeContentPlaceHolder>31\</CodeContentPlaceHolder> or <CodeContentPlaceHolder>32\</CodeContentPlaceHolder> block is encountered, but before that <CodeContentPlaceHolder>33\</CodeContentPlaceHolder> statement executes. A <CodeContentPlaceHolder>34\</CodeContentPlaceHolder> statement cannot be included in a <CodeContentPlaceHolder>35\</CodeContentPlaceHolder> block.  
  
## Example  
 The following example uses the <CodeContentPlaceHolder>36\</CodeContentPlaceHolder> statement several times to return to the calling code when the procedure does not have to do anything else.  
  
 [!code[VbVbalrStatements#53](../vs140/codesnippet/VisualBasic/return-statement--visual-basic-_1.vb)]  
  
## See Also  
 [Function Statement](../vs140/function-statement--visual-basic-.md)   
 [Sub Statement](../vs140/sub-statement--visual-basic-.md)   
 [Get Statement](../vs140/get-statement.md)   
 [Set Statement (Visual Basic)](../vs140/set-statement--visual-basic-.md)   
 [Operator Statement](../vs140/operator-statement.md)   
 [Property Statement](../vs140/property-statement.md)   
 [Exit Statement (Visual Basic)](../vs140/exit-statement--visual-basic-.md)   
 [Try...Catch...Finally Statement (Visual Basic)](../vs140/try...catch...finally-statement--visual-basic-.md)