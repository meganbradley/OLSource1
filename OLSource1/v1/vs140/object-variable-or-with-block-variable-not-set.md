---
title: "Object variable or With block variable not set"
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
  - "vbrID91"
dev_langs: 
  - "VB"
ms.assetid: 2f03e611-f0ed-465c-99a2-a816e034faa3
caps.latest.revision: 13
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Object variable or With block variable not set
An invalid object variable is being referenced.   This error can occur for several reasons:  
  
-   A variable was declared without specifying a type. If a variable is declared without specifying a type, it defaults to type <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>.  
  
     For example, a variable declared with <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> would be of type <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> a variable declared with <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> would be of type <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>.  
  
    > [!TIP]
    >  The <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> statement disallows implicit typing that results in an <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> type. If you omit the type, a compile-time error will occur. See [Option Strict Statement](../vs140/option-strict-statement.md).  
  
-   You are attempting to reference an object that has been set to <CodeContentPlaceHolder>8\</CodeContentPlaceHolder>  
  
     .  
  
-   You are attempting to access an element of an array variable that wasn't properly declared.  
  
     For example, an array declared as <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> will trigger the error if you try to reference an element of the array <CodeContentPlaceHolder>10\</CodeContentPlaceHolder>. The array has no elements and is treated as an object.  
  
-   You are attempting to access code within a <CodeContentPlaceHolder>11\</CodeContentPlaceHolder> block before the block has been initialized.   A <CodeContentPlaceHolder>12\</CodeContentPlaceHolder> block must be initialized by executing the <CodeContentPlaceHolder>13\</CodeContentPlaceHolder> statement entry point.  
  
> [!NOTE]
>  In earlier versions of Visual Basic or VBA this error was also triggered by assigning a value to a variable without using the <CodeContentPlaceHolder>14\</CodeContentPlaceHolder> keyword (<CodeContentPlaceHolder>15\</CodeContentPlaceHolder> instead of <CodeContentPlaceHolder>16\</CodeContentPlaceHolder>). The <CodeContentPlaceHolder>17\</CodeContentPlaceHolder> keyword is no longer valid in Visual Basic .Net.  
  
### To correct this error  
  
1.  Set <CodeContentPlaceHolder>18\</CodeContentPlaceHolder> to <CodeContentPlaceHolder>19\</CodeContentPlaceHolder> by adding the following code to the beginning of the file:  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
     When you run the project, a compiler error will appear in the **Error List** for any variable that was specified without a type.  
  
2.  If you don't want to enable <CodeContentPlaceHolder>20\</CodeContentPlaceHolder>, search your code for any variables that were specified without a type (<CodeContentPlaceHolder>21\</CodeContentPlaceHolder> instead of <CodeContentPlaceHolder>22\</CodeContentPlaceHolder>) and add the intended type to the declaration.  
  
3.  Make sure you aren't referring to  an object variable that has been set to <CodeContentPlaceHolder>23\</CodeContentPlaceHolder>.  Search your code for the keyword <CodeContentPlaceHolder>24\</CodeContentPlaceHolder>, and revise your code so that the object isn't set to <CodeContentPlaceHolder>25\</CodeContentPlaceHolder> until after you have referenced it.  
  
4.  Make sure that any array  variables are dimensioned before you access them. You can either assign a dimension when you first create the array (<CodeContentPlaceHolder>26\</CodeContentPlaceHolder> instead of <CodeContentPlaceHolder>27\</CodeContentPlaceHolder>), or use the <CodeContentPlaceHolder>28\</CodeContentPlaceHolder> keyword to set the dimensions of the array before you first access it.  
  
5.  Make sure your <CodeContentPlaceHolder>29\</CodeContentPlaceHolder> block is initialized by executing the <CodeContentPlaceHolder>30\</CodeContentPlaceHolder> statement entry point.  
  
## See Also  
 [Object Variable Declaration](../vs140/object-variable-declaration--visual-basic-.md)   
 [ReDim Statement (Visual Basic)](../vs140/redim-statement--visual-basic-.md)   
 [With...End With Statement](../vs140/with...end-with-statement--visual-basic-.md)