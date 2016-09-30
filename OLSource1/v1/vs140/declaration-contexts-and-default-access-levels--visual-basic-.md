---
title: "Declaration Contexts and Default Access Levels (Visual Basic)"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-visual-basic"
ms.tgt_pltfrm: na
ms.topic: "article"
dev_langs: 
  - "VB"
helpviewer_keywords: 
  - "module level, defined"
  - "declaration contexts, Visual Basic"
  - "procedure level, defined"
  - "namespace level, defined"
  - "access levels, Visual Basic"
  - "access levels, default levels"
ms.assetid: bf63b96e-e825-4745-88c8-5dae222728db
caps.latest.revision: 12
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Declaration Contexts and Default Access Levels (Visual Basic)
This topic describes which Visual Basic types can be declared within which other types, and what their access levels default to if not specified.  
  
## Declaration Context Levels  
 The *declaration context* of a programming element is the region of code in which it is declared. This is often another programming element, which is then called the *containing element*.  
  
 The levels for declaration contexts are the following:  
  
-   *Namespace level* — within a source file or namespace but not within a class, structure, module, or interface  
  
-   *Module level* — within a class, structure, module, or interface but not within a procedure or block  
  
-   *Procedure level* — within a procedure or block (such as <CodeContentPlaceHolder>0\</CodeContentPlaceHolder> or <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>)  
  
 The following table shows the default access levels for various declared programming elements, depending on their declaration contexts.  
  
|Declared element|Namespace level|Module level|Procedure level|  
|----------------------|---------------------|------------------|---------------------|  
|Variable ([Dim Statement](../vs140/dim-statement--visual-basic-.md))|Not allowed|<CodeContentPlaceHolder>2\</CodeContentPlaceHolder> (<CodeContentPlaceHolder>3\</CodeContentPlaceHolder> in <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>, not allowed in <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>)|<CodeContentPlaceHolder>6\</CodeContentPlaceHolder>|  
|Constant ([Const Statement (Visual Basic)](../vs140/const-statement--visual-basic-.md))|Not allowed|<CodeContentPlaceHolder>7\</CodeContentPlaceHolder> (<CodeContentPlaceHolder>8\</CodeContentPlaceHolder> in <CodeContentPlaceHolder>9\</CodeContentPlaceHolder>, not allowed in <CodeContentPlaceHolder>10\</CodeContentPlaceHolder>)|<CodeContentPlaceHolder>11\</CodeContentPlaceHolder>|  
|Enumeration ([Enum Statement (Visual Basic)](../vs140/enum-statement--visual-basic-.md))|<CodeContentPlaceHolder>12\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>13\</CodeContentPlaceHolder>|Not allowed|  
|Class ([Class Statement (Visual Basic)](../vs140/class-statement--visual-basic-.md))|<CodeContentPlaceHolder>14\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>15\</CodeContentPlaceHolder>|Not allowed|  
|Structure ([Structure Statement](../vs140/structure-statement.md))|<CodeContentPlaceHolder>16\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>17\</CodeContentPlaceHolder>|Not allowed|  
|Module ([Module Statement](../vs140/module-statement.md))|<CodeContentPlaceHolder>18\</CodeContentPlaceHolder>|Not allowed|Not allowed|  
|Interface ([Interface Statement](../vs140/interface-statement--visual-basic-.md))|<CodeContentPlaceHolder>19\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>20\</CodeContentPlaceHolder>|Not allowed|  
|Procedure ([Function Statement (Visual Basic)](../vs140/function-statement--visual-basic-.md), [Sub Statement (Visual Basic)](../vs140/sub-statement--visual-basic-.md))|Not allowed|<CodeContentPlaceHolder>21\</CodeContentPlaceHolder>|Not allowed|  
|External reference ([Declare Statement](../vs140/declare-statement.md))|Not allowed|<CodeContentPlaceHolder>22\</CodeContentPlaceHolder> (not allowed in <CodeContentPlaceHolder>23\</CodeContentPlaceHolder>)|Not allowed|  
|Operator ([Operator Statement](../vs140/operator-statement.md))|Not allowed|<CodeContentPlaceHolder>24\</CodeContentPlaceHolder> (not allowed in <CodeContentPlaceHolder>25\</CodeContentPlaceHolder> or <CodeContentPlaceHolder>26\</CodeContentPlaceHolder>)|Not allowed|  
|Property ([Property Statement](../vs140/property-statement.md))|Not allowed|<CodeContentPlaceHolder>27\</CodeContentPlaceHolder>|Not allowed|  
|Default property ([Default (Visual Basic)](../vs140/default--visual-basic-.md))|Not allowed|<CodeContentPlaceHolder>28\</CodeContentPlaceHolder> (not allowed in <CodeContentPlaceHolder>29\</CodeContentPlaceHolder>)|Not allowed|  
|Event ([Event Statement](../vs140/event-statement.md))|Not allowed|<CodeContentPlaceHolder>30\</CodeContentPlaceHolder>|Not allowed|  
|Delegate ([Delegate Statement](../vs140/delegate-statement.md))|<CodeContentPlaceHolder>31\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>32\</CodeContentPlaceHolder>|Not allowed|  
  
 For more information, see [Access Levels in Visual Basic](../vs140/access-levels-in-visual-basic.md).  
  
## See Also  
 [Friend (Visual Basic)](../vs140/friend--visual-basic-.md)   
 [Private (Visual Basic)](../vs140/private--visual-basic-.md)   
 [Public (Visual Basic)](../vs140/public--visual-basic-.md)