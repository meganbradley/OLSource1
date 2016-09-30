---
title: "for Statement (C++)"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-cpp"
ms.tgt_pltfrm: na
ms.topic: "language-reference"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "for keyword [C++]"
ms.assetid: 6c7d01b3-c4c1-4c6a-aa58-e2d198f33d4a
caps.latest.revision: 19
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# for Statement (C++)
Executes a statement repeatedly until the condition becomes false. For information on the range-based for statement, see [Range-based for Statement (C++)](../vs140/range-based-for-statement--c---.md).  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Remarks  
 Use the <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> statement to construct loops that must execute a specified number of times.  
  
 The <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> statement consists of three optional parts, as shown in the following table.  
  
### for Loop Elements  
  
|Syntax Name|When Executed|Description|  
|-----------------|-------------------|-----------------|  
|<CodeContentPlaceHolder>9\</CodeContentPlaceHolder>|Before any other element of the **for** statement, <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> is executed only once. Control then passes to <CodeContentPlaceHolder>11\</CodeContentPlaceHolder>.|Often used to initialize loop indices. It can contain expressions or declarations.|  
|<CodeContentPlaceHolder>12\</CodeContentPlaceHolder>|Before execution of each iteration of <CodeContentPlaceHolder>13\</CodeContentPlaceHolder>, including the first iteration. <CodeContentPlaceHolder>14\</CodeContentPlaceHolder> is executed only if <CodeContentPlaceHolder>15\</CodeContentPlaceHolder> evaluates to true (nonzero).|An expression that evaluates to an integral type or a class type that has an unambiguous conversion to an integral type. Normally used to test for loop-termination criteria.|  
|<CodeContentPlaceHolder>16\</CodeContentPlaceHolder>|At the end of each iteration of <CodeContentPlaceHolder>17\</CodeContentPlaceHolder>. After <CodeContentPlaceHolder>18\</CodeContentPlaceHolder> is executed, <CodeContentPlaceHolder>19\</CodeContentPlaceHolder> is evaluated.|Normally used to increment loop indices.|  
  
 The following examples show different ways to use the <CodeContentPlaceHolder>20\</CodeContentPlaceHolder> statement.  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 <CodeContentPlaceHolder>21\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>22\</CodeContentPlaceHolder> can contain multiple statements separated by commas. For example:  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 <CodeContentPlaceHolder>23\</CodeContentPlaceHolder> can be incremented or decremented, or modified in other ways.  
  
<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 A <CodeContentPlaceHolder>24\</CodeContentPlaceHolder> loop terminates when a [break](../vs140/break-statement--c---.md), [return](../vs140/return-statement--c---.md), or [goto](../vs140/goto-statement--c---.md) (to a labeled statement outside the **for** loop) within <CodeContentPlaceHolder>25\</CodeContentPlaceHolder> is executed. A [continue](../vs140/continue-statement--c---.md) statement in a <CodeContentPlaceHolder>26\</CodeContentPlaceHolder> loop terminates only the current iteration.  
  
 If <CodeContentPlaceHolder>27\</CodeContentPlaceHolder> is omitted, it is considered true and the **for** loop will not terminate without a <CodeContentPlaceHolder>28\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>29\</CodeContentPlaceHolder>, or <CodeContentPlaceHolder>30\</CodeContentPlaceHolder> within <CodeContentPlaceHolder>31\</CodeContentPlaceHolder>.  
  
 Although the three fields of the <CodeContentPlaceHolder>32\</CodeContentPlaceHolder> statement are normally used for initialization, testing for termination, and incrementing, they are not restricted to these uses. For example, the following code prints the numbers 0 through 4. In this case, <CodeContentPlaceHolder>33\</CodeContentPlaceHolder> is the null statement:  
  
<CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
## for Loops and the C++ Standard  
 The C++ standard says that a variable declared in a <CodeContentPlaceHolder>34\</CodeContentPlaceHolder> loop shall go out of scope after the <CodeContentPlaceHolder>35\</CodeContentPlaceHolder> loop ends. For example:  
  
<CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
 By default, under [/Ze](../vs140/-za---ze--disable-language-extensions-.md), a variable declared in a <CodeContentPlaceHolder>36\</CodeContentPlaceHolder> loop remains in scope until the <CodeContentPlaceHolder>37\</CodeContentPlaceHolder> loop's enclosing scope ends.  
  
 [/Zc:forScope](../vs140/-zc-forscope--force-conformance-in-for-loop-scope-.md) enables standard behavior of variables declared in for loops without needing to specify /Za.  
  
 It is also possible to use the scoping differences of the <CodeContentPlaceHolder>38\</CodeContentPlaceHolder> loop to redeclare variables under /Ze as follows:  
  
<CodeContentPlaceHolder>6\</CodeContentPlaceHolder>  
 This more closely mimics the standard behavior of a variable declared in a <CodeContentPlaceHolder>39\</CodeContentPlaceHolder> loop, which requires variables declared in a <CodeContentPlaceHolder>40\</CodeContentPlaceHolder> loop to go out of scope after the loop is done. When a variable is declared in a <CodeContentPlaceHolder>41\</CodeContentPlaceHolder> loop, the compiler internally promotes it to a local variable in the <CodeContentPlaceHolder>42\</CodeContentPlaceHolder> loop's enclosing scope even if there is already a local variable with the same name.  
  
## See Also  
 [Iteration Statements](../vs140/iteration-statements--c---.md)   
 [Keywords](../vs140/keywords--c---.md)   
 [while Statement (C++)](../vs140/while-statement--c---.md)   
 [do-while Statement (C++)](../vs140/do-while-statement--c---.md)   
 [Range-based for Statement (C++)](../vs140/range-based-for-statement--c---.md)