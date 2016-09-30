---
title: "Continue Statement (Visual Basic)"
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
  - "vb.continue"
dev_langs: 
  - "VB"
helpviewer_keywords: 
  - "Continue statement [Visual Basic]"
  - "loops, transferring to next iteration"
ms.assetid: 3ad00103-358b-4af3-a3a8-1b9ea0e995d3
caps.latest.revision: 25
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Continue Statement (Visual Basic)
Transfers control immediately to the next iteration of a loop.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Remarks  
 You can transfer from inside a <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>, or <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> loop to the next iteration of that loop. Control passes immediately to the loop condition test, which is equivalent to transferring to the <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> or <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> statement, or to the <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> or <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> statement that contains the <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> or <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> clause.  
  
 You can use <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> at any location in the loop that allows transfers. The rules allowing transfer of control are the same as with the [GoTo Statement](../vs140/goto-statement.md).  
  
 For example, if a loop is totally contained within a <CodeContentPlaceHolder>11\</CodeContentPlaceHolder> block, a <CodeContentPlaceHolder>12\</CodeContentPlaceHolder> block, or a <CodeContentPlaceHolder>13\</CodeContentPlaceHolder> block, you can use <CodeContentPlaceHolder>14\</CodeContentPlaceHolder> to transfer out of the loop. If, on the other hand, the <CodeContentPlaceHolder>15\</CodeContentPlaceHolder>...<CodeContentPlaceHolder>16\</CodeContentPlaceHolder> structure is contained within the loop, you cannot use <CodeContentPlaceHolder>17\</CodeContentPlaceHolder> to transfer control out of the <CodeContentPlaceHolder>18\</CodeContentPlaceHolder> block, and you can use it to transfer out of a <CodeContentPlaceHolder>19\</CodeContentPlaceHolder> or <CodeContentPlaceHolder>20\</CodeContentPlaceHolder> block only if you transfer completely out of the <CodeContentPlaceHolder>21\</CodeContentPlaceHolder>...<CodeContentPlaceHolder>22\</CodeContentPlaceHolder> structure.  
  
 If you have nested loops of the same type, for example a <CodeContentPlaceHolder>23\</CodeContentPlaceHolder> loop within another <CodeContentPlaceHolder>24\</CodeContentPlaceHolder> loop, a <CodeContentPlaceHolder>25\</CodeContentPlaceHolder> statement skips to the next iteration of the innermost <CodeContentPlaceHolder>26\</CodeContentPlaceHolder> loop that contains it. You cannot use <CodeContentPlaceHolder>27\</CodeContentPlaceHolder> to skip to the next iteration of a containing loop of the same type.  
  
 If you have nested loops of different types, for example a <CodeContentPlaceHolder>28\</CodeContentPlaceHolder> loop within a <CodeContentPlaceHolder>29\</CodeContentPlaceHolder> loop, you can skip to the next iteration of either loop by using either <CodeContentPlaceHolder>30\</CodeContentPlaceHolder> or <CodeContentPlaceHolder>31\</CodeContentPlaceHolder>.  
  
## Example  
 The following code example uses the <CodeContentPlaceHolder>32\</CodeContentPlaceHolder> statement to skip to the next column of an array if a divisor is zero. The <CodeContentPlaceHolder>33\</CodeContentPlaceHolder> is inside a <CodeContentPlaceHolder>34\</CodeContentPlaceHolder> loop. It transfers to the <CodeContentPlaceHolder>35\</CodeContentPlaceHolder> statement, which is the next iteration of the innermost <CodeContentPlaceHolder>36\</CodeContentPlaceHolder> loop that contains the <CodeContentPlaceHolder>37\</CodeContentPlaceHolder> loop.  
  
 [!code[VbVbalrStatements#14](../vs140/codesnippet/VisualBasic/continue-statement--visual-basic-_1.vb)]  
  
## See Also  
 [Do...Loop Statement](../vs140/do...loop-statement--visual-basic-.md)   
 [For...Next Statement](../vs140/for...next-statement--visual-basic-.md)   
 [While...End While Statement](../vs140/while...end-while-statement--visual-basic-.md)   
 [Try...Catch...Finally Statement (Visual Basic)](../vs140/try...catch...finally-statement--visual-basic-.md)