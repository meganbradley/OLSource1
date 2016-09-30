---
title: "How to: Create a Lambda Expression (Visual Basic)"
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
  - "lambda expressions [Visual Basic]"
  - "expressions [Visual Basic], lambda"
ms.assetid: 3279bd5c-80f7-410a-a7ba-f7085ed36aa5
caps.latest.revision: 31
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# How to: Create a Lambda Expression (Visual Basic)
A *lambda expression* is a function or subroutine that does not have a name. A lambda expression can be used wherever a delegate type is valid.  
  
### To create a single-line lambda expression function  
  
1.  In any situation where a delegate type could be used, type the keyword <CodeContentPlaceHolder>0\</CodeContentPlaceHolder>, as in the following example:  
  
     <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>   <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
  
2.  In parentheses, directly after <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>, type the parameters of the function. Notice that you do not specify a name after <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>.  
  
     <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>   <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>  
  
3.  Following the parameter list, type a single expression as the body of the function. The value that the expression evaluates to is the value returned by the function. You do not use an <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> clause to specify the return type.  
  
     [!code[VbVbalrLambdas#1](../vs140/codesnippet/VisualBasic/how-to--create-a-lambda-expression--visual-basic-_1.vb)]  
  
     You call the lambda expression by passing in an integer argument.  
  
     [!code[VbVbalrLambdas#2](../vs140/codesnippet/VisualBasic/how-to--create-a-lambda-expression--visual-basic-_2.vb)]  
  
4.  Alternatively, the same result is accomplished by the following example:  
  
     [!code[VbVbalrLambdas#3](../vs140/codesnippet/VisualBasic/how-to--create-a-lambda-expression--visual-basic-_3.vb)]  
  
### To create a single-line lambda expression subroutine  
  
1.  In any situation where a delegate type could be used, type the keyword <CodeContentPlaceHolder>8\</CodeContentPlaceHolder>, as shown in the following example.  
  
     <CodeContentPlaceHolder>9\</CodeContentPlaceHolder>   <CodeContentPlaceHolder>10\</CodeContentPlaceHolder>  
  
2.  In parentheses, directly after <CodeContentPlaceHolder>11\</CodeContentPlaceHolder>, type the parameters of the subroutine. Notice that you do not specify a name after <CodeContentPlaceHolder>12\</CodeContentPlaceHolder>.  
  
     <CodeContentPlaceHolder>13\</CodeContentPlaceHolder>   <CodeContentPlaceHolder>14\</CodeContentPlaceHolder>  
  
3.  Following the parameter list, type a single statement as the body of the subroutine.  
  
     [!code[VbVbalrLambdas#17](../vs140/codesnippet/VisualBasic/how-to--create-a-lambda-expression--visual-basic-_4.vb)]  
  
     You call the lambda expression by passing in a string argument.  
  
     [!code[VbVbalrLambdas#18](../vs140/codesnippet/VisualBasic/how-to--create-a-lambda-expression--visual-basic-_5.vb)]  
  
### To create a multiline lambda expression function  
  
1.  In any situation where a delegate type could be used, type the keyword <CodeContentPlaceHolder>15\</CodeContentPlaceHolder>, as shown in the following example.  
  
     <CodeContentPlaceHolder>16\</CodeContentPlaceHolder>   <CodeContentPlaceHolder>17\</CodeContentPlaceHolder>  
  
2.  In parentheses, directly after <CodeContentPlaceHolder>18\</CodeContentPlaceHolder>, type the parameters of the function. Notice that you do not specify a name after <CodeContentPlaceHolder>19\</CodeContentPlaceHolder>.  
  
     <CodeContentPlaceHolder>20\</CodeContentPlaceHolder>   <CodeContentPlaceHolder>21\</CodeContentPlaceHolder>  
  
3.  Press ENTER. The <CodeContentPlaceHolder>22\</CodeContentPlaceHolder> statement is automatically added.  
  
4.  Within the body of the function, add the following code to create an expression and return the value. You do not use an <CodeContentPlaceHolder>23\</CodeContentPlaceHolder> clause to specify the return type.  
  
     [!code[VbVbalrLambdas#19](../vs140/codesnippet/VisualBasic/how-to--create-a-lambda-expression--visual-basic-_6.vb)]  
  
     You call the lambda expression by passing in an integer argument.  
  
     [!code[VbVbalrLambdas#20](../vs140/codesnippet/VisualBasic/how-to--create-a-lambda-expression--visual-basic-_7.vb)]  
  
### To create a multiline lambda expression subroutine  
  
1.  In any situation where a delegate type could be used, type the keyword <CodeContentPlaceHolder>24\</CodeContentPlaceHolder>, as shown in the following example:  
  
     <CodeContentPlaceHolder>25\</CodeContentPlaceHolder>   <CodeContentPlaceHolder>26\</CodeContentPlaceHolder>  
  
2.  In parentheses, directly after <CodeContentPlaceHolder>27\</CodeContentPlaceHolder>, type the parameters of the subroutine. Notice that you do not specify a name after <CodeContentPlaceHolder>28\</CodeContentPlaceHolder>.  
  
     <CodeContentPlaceHolder>29\</CodeContentPlaceHolder>  <CodeContentPlaceHolder>30\</CodeContentPlaceHolder>  
  
3.  Press ENTER. The <CodeContentPlaceHolder>31\</CodeContentPlaceHolder> statement is automatically added.  
  
4.  Within the body of the function, add the following code to execute when the subroutine is invoked.  
  
     [!code[VbVbalrLambdas#21](../vs140/codesnippet/VisualBasic/how-to--create-a-lambda-expression--visual-basic-_8.vb)]  
  
     You call the lambda expression by passing in a string argument.  
  
     [!code[VbVbalrLambdas#22](../vs140/codesnippet/VisualBasic/how-to--create-a-lambda-expression--visual-basic-_9.vb)]  
  
## Example  
 A common use of lambda expressions is to define a function that can be passed in as the argument for a parameter whose type is <CodeContentPlaceHolder>32\</CodeContentPlaceHolder>. In the following example, the \<xref:System.Diagnostics.Process.GetProcesses*> method returns an array of the processes running on the local computer. The \<xref:System.Linq.Enumerable.Where*> method from the \<xref:System.Linq.Enumerable*> class requires a <CodeContentPlaceHolder>33\</CodeContentPlaceHolder> delegate as its argument. The lambda expression in the example is used for that purpose. It returns <CodeContentPlaceHolder>34\</CodeContentPlaceHolder> for each process that has only one thread, and those are selected in <CodeContentPlaceHolder>35\</CodeContentPlaceHolder>.  
  
 [!code[VbVbalrLambdas#10](../vs140/codesnippet/VisualBasic/how-to--create-a-lambda-expression--visual-basic-_10.vb)]  
  
 The previous example is equivalent to the following code, which is written in [!INCLUDE[vbteclinqext](../vs140/includes/vbteclinqext_md.md)] syntax:  
  
 [!code[VbVbalrLambdas#11](../vs140/codesnippet/VisualBasic/how-to--create-a-lambda-expression--visual-basic-_11.vb)]  
  
## See Also  
 \<xref:System.Linq.Enumerable*>   
 [Lambda Expressions](../vs140/lambda-expressions--visual-basic-.md)   
 [Function Statement](../vs140/function-statement--visual-basic-.md)   
 [Sub Statement (Visual Basic)](../vs140/sub-statement--visual-basic-.md)   
 [Delegates (Visual Basic)](../vs140/delegates--visual-basic-.md)   
 [How to: Pass Procedures to Another Procedure in Visual Basic](../vs140/how-to--pass-procedures-to-another-procedure-in-visual-basic.md)   
 [Delegate Statement](../vs140/delegate-statement.md)   
 [Introduction to LINQ in Visual Basic](../vs140/introduction-to-linq-in-visual-basic.md)