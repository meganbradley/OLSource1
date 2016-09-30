---
title: "for Statement (C)"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-cpp"
ms.tgt_pltfrm: na
ms.topic: "article"
dev_langs: 
  - "C++"
  - "C"
helpviewer_keywords: 
  - "for keyword [C]"
ms.assetid: 560a8de4-19db-4868-9f18-dbe51b17900d
caps.latest.revision: 13
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# for Statement (C)
The <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> statement lets you repeat a statement or compound statement a specified number of times. The body of a <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> statement is executed zero or more times until an optional condition becomes false. You can use optional expressions within the <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> statement to initialize and change values during the <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> statement's execution.  
  
## Syntax  
 *iteration-statement*:  
 <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> ( <CodeContentPlaceHolder>8\</CodeContentPlaceHolder>opt ; <CodeContentPlaceHolder>9\</CodeContentPlaceHolder>opt ; <CodeContentPlaceHolder>10\</CodeContentPlaceHolder>opt )<CodeContentPlaceHolder>11\</CodeContentPlaceHolder>  
  
 Execution of a <CodeContentPlaceHolder>12\</CodeContentPlaceHolder> statement proceeds as follows:  
  
1.  The <CodeContentPlaceHolder>13\</CodeContentPlaceHolder>, if any, is evaluated. This specifies the initialization for the loop. There is no restriction on the type of <CodeContentPlaceHolder>14\</CodeContentPlaceHolder>.  
  
2.  The <CodeContentPlaceHolder>15\</CodeContentPlaceHolder>, if any, is evaluated. This expression must have arithmetic or pointer type. It is evaluated before each iteration. Three results are possible:  
  
    -   If <CodeContentPlaceHolder>16\</CodeContentPlaceHolder> is true (nonzero), <CodeContentPlaceHolder>17\</CodeContentPlaceHolder> is executed; then <CodeContentPlaceHolder>18\</CodeContentPlaceHolder>, if any, is evaluated. The <CodeContentPlaceHolder>19\</CodeContentPlaceHolder> is evaluated after each iteration. There is no restriction on its type. Side effects will execute in order. The process then begins again with the evaluation of <CodeContentPlaceHolder>20\</CodeContentPlaceHolder>.  
  
    -   If <CodeContentPlaceHolder>21\</CodeContentPlaceHolder> is omitted, <CodeContentPlaceHolder>22\</CodeContentPlaceHolder> is considered true, and execution proceeds exactly as described in the previous paragraph. A <CodeContentPlaceHolder>23\</CodeContentPlaceHolder> statement without a <CodeContentPlaceHolder>24\</CodeContentPlaceHolder> argument terminates only when a <CodeContentPlaceHolder>25\</CodeContentPlaceHolder> or <CodeContentPlaceHolder>26\</CodeContentPlaceHolder> statement within the statement body is executed, or when a <CodeContentPlaceHolder>27\</CodeContentPlaceHolder> (to a labeled statement outside the <CodeContentPlaceHolder>28\</CodeContentPlaceHolder> statement body) is executed.  
  
    -   If <CodeContentPlaceHolder>29\</CodeContentPlaceHolder> is <CodeContentPlaceHolder>30\</CodeContentPlaceHolder> (0), execution of the <CodeContentPlaceHolder>31\</CodeContentPlaceHolder> statement terminates and control passes to the next statement in the program.  
  
 A <CodeContentPlaceHolder>32\</CodeContentPlaceHolder> statement also terminates when a <CodeContentPlaceHolder>33\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>34\</CodeContentPlaceHolder>, or <CodeContentPlaceHolder>35\</CodeContentPlaceHolder> statement within the statement body is executed. A <CodeContentPlaceHolder>36\</CodeContentPlaceHolder> statement in a <CodeContentPlaceHolder>37\</CodeContentPlaceHolder> loop causes <CodeContentPlaceHolder>38\</CodeContentPlaceHolder> to be evaluated. When a <CodeContentPlaceHolder>39\</CodeContentPlaceHolder> statement is executed inside a <CodeContentPlaceHolder>40\</CodeContentPlaceHolder> loop, <CodeContentPlaceHolder>41\</CodeContentPlaceHolder> is not evaluated or executed. This statement  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
 is the customary way to produce an infinite loop which can only be exited with a <CodeContentPlaceHolder>42\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>43\</CodeContentPlaceHolder>, or <CodeContentPlaceHolder>44\</CodeContentPlaceHolder> statement.  
  
## Code  
 This example illustrates the <CodeContentPlaceHolder>45\</CodeContentPlaceHolder> statement:  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
## Output  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
## See Also  
 [Statements (C)](../vs140/statements--c-.md)