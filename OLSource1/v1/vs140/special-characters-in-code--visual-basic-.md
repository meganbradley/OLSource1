---
title: "Special Characters in Code (Visual Basic)"
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
  - "vb.)"
  - "vb.("
  - "vb.colon"
  - "vb.!"
  - "vb.."
  - "vb.:"
dev_langs: 
  - "VB"
helpviewer_keywords: 
  - "special characters, in code"
  - "parentheses, using in code"
  - "colons (:)"
  - "period character in code"
  - "dot operator (.)"
  - "dictionary access operator"
  - "concatenation operators, special characters in code"
  - "concatenation operators, vs. addition operator"
  - "! operator"
  - "separators, using in code"
  - "operators [Visual Basic], dictionary access"
  - ": separator character"
  - "member access operator"
  - "addition operator"
  - "operators [Visual Basic], member access"
  - ". operator"
  - "exclamation points"
  - "separators"
  - "exclamation point operator (!)"
  - "Visual Basic code, special characters"
ms.assetid: 310dce0c-45b5-4e0d-83e9-32df258d2a3e
caps.latest.revision: 25
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Special Characters in Code (Visual Basic)
Sometimes you have to use special characters in your code, that is, characters that are not alphabetical or numeric. The punctuation and special characters in the [!INCLUDE[vbprvb](../vs140/includes/vbprvb_md.md)] character set have various uses, from organizing program text to defining the tasks that the compiler or the compiled program performs. They do not specify an operation to be performed.  
  
## Parentheses  
 Use parentheses when you define a procedure, such as a <CodeContentPlaceHolder>0\</CodeContentPlaceHolder> or <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>. You must enclose all procedure argument lists in parentheses. You also use parentheses for putting variables or arguments into logical groups, especially to override the default order of operator precedence in a complex expression. The following example illustrates this.  
  
 [!code[VbVbcnConventions#11](../vs140/codesnippet/VisualBasic/special-characters-in-code--visual-basic-_1.vb)]  
  
 Following execution of the previous code, the value of <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> is 8.225 and the value of <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> is 3. The calculation for <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> uses the default precedence of <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> over <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> and is equivalent to <CodeContentPlaceHolder>7\</CodeContentPlaceHolder>. The parentheses in the calculation for <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> override the default precedence.  
  
## Separators  
 Separators do what their name suggests: they separate sections of code. In [!INCLUDE[vbprvb](../vs140/includes/vbprvb_md.md)], the separator character is the colon (<CodeContentPlaceHolder>9\</CodeContentPlaceHolder>). Use separators when you want to include multiple statements on a single line instead of separate lines. This saves space and improves the readability of your code. The following example shows three statements separated by colons.  
  
 [!code[VbVbcnConventions#12](../vs140/codesnippet/VisualBasic/special-characters-in-code--visual-basic-_2.vb)]  
  
 For more information, see [How to: Break and Combine Statements in Code](../vs140/how-to--break-and-combine-statements-in-code--visual-basic-.md).  
  
 The colon (<CodeContentPlaceHolder>10\</CodeContentPlaceHolder>) character is also used to identify a statement label. For more information, see [How to: Label Statements](../vs140/how-to--label-statements--visual-basic-.md).  
  
## Concatenation  
 Use the <CodeContentPlaceHolder>11\</CodeContentPlaceHolder> operator for *concatenation*, or linking strings together. Do not confuse it with the <CodeContentPlaceHolder>12\</CodeContentPlaceHolder> operator, which adds together numeric values. If you use the <CodeContentPlaceHolder>13\</CodeContentPlaceHolder> operator to concatenate when you operate on numeric values, you can obtain incorrect results. The following example demonstrates this.  
  
 [!code[VbVbcnConventions#13](../vs140/codesnippet/VisualBasic/special-characters-in-code--visual-basic-_3.vb)]  
  
 Following execution of the previous code, the value of <CodeContentPlaceHolder>14\</CodeContentPlaceHolder> is 21.01 and the value of <CodeContentPlaceHolder>15\</CodeContentPlaceHolder> is "10.0111".  
  
## Member Access Operators  
 To access a member of a type, you use the dot (<CodeContentPlaceHolder>16\</CodeContentPlaceHolder>) or exclamation point (<CodeContentPlaceHolder>17\</CodeContentPlaceHolder>) operator between the type name and the member name.  
  
### Dot (.) Operator  
 Use the <CodeContentPlaceHolder>18\</CodeContentPlaceHolder> operator on a class, structure, interface, or enumeration as a member access operator. The member can be a field, property, event, or method. The following example illustrates this.  
  
 [!code[VbVbcnConventions#14](../vs140/codesnippet/VisualBasic/special-characters-in-code--visual-basic-_4.vb)]  
  
### Exclamation Point (!) Operator  
 Use the <CodeContentPlaceHolder>19\</CodeContentPlaceHolder> operator only on a class or interface as a dictionary access operator. The class or interface must have a default property that accepts a single <CodeContentPlaceHolder>20\</CodeContentPlaceHolder> argument. The identifier immediately following the <CodeContentPlaceHolder>21\</CodeContentPlaceHolder> operator becomes the argument value passed to the default property as a string. The following example demonstrates this.  
  
 [!code[VbVbcnConventions#15](../vs140/codesnippet/VisualBasic/special-characters-in-code--visual-basic-_5.vb)]  
  
 The three output lines of <CodeContentPlaceHolder>22\</CodeContentPlaceHolder> all display the value <CodeContentPlaceHolder>23\</CodeContentPlaceHolder>. The first line uses the traditional access to property <CodeContentPlaceHolder>24\</CodeContentPlaceHolder>, the second makes use of the fact that <CodeContentPlaceHolder>25\</CodeContentPlaceHolder> is the default property of class <CodeContentPlaceHolder>26\</CodeContentPlaceHolder>, and the third uses dictionary access to the class.  
  
 Note that the second operand of the <CodeContentPlaceHolder>27\</CodeContentPlaceHolder> operator must be a valid Visual Basic identifier not enclosed in double quotation marks (<CodeContentPlaceHolder>28\</CodeContentPlaceHolder>). In other words, you cannot use a string literal or string variable. The following change to the last line of the <CodeContentPlaceHolder>29\</CodeContentPlaceHolder> call generates an error because <CodeContentPlaceHolder>30\</CodeContentPlaceHolder> is an enclosed string literal.  
  
 <CodeContentPlaceHolder>31\</CodeContentPlaceHolder>  
  
> [!NOTE]
>  References to default collections must be explicit. In particular, you cannot use the <CodeContentPlaceHolder>32\</CodeContentPlaceHolder> operator on a late-bound variable.  
  
 The <CodeContentPlaceHolder>33\</CodeContentPlaceHolder> character is also used as the <CodeContentPlaceHolder>34\</CodeContentPlaceHolder> type character.  
  
## See Also  
 [Program Structure and Code Conventions](../vs140/program-structure-and-code-conventions--visual-basic-.md)   
 [Type Characters](../vs140/type-characters--visual-basic-.md)