---
title: "Sub Procedures (Visual Basic)"
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
  - "Sub procedures, about Sub procedures"
  - "statement blocks"
  - "Sub procedures, calling"
  - "procedures, calling"
  - "Sub procedures, syntax"
  - "Sub procedures"
  - "procedures, Sub"
  - "syntax, Sub procedures"
ms.assetid: 6a0a4958-ed0a-4d3d-8d31-0772c82bda58
caps.latest.revision: 25
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Sub Procedures (Visual Basic)
A <CodeContentPlaceHolder>0\</CodeContentPlaceHolder> procedure is a series of [!INCLUDE[vbprvb](../vs140/includes/vbprvb_md.md)] statements enclosed by the <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> statements. The <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> procedure performs a task and then returns control to the calling code, but it does not return a value to the calling code.  
  
 Each time the procedure is called, its statements are executed, starting with the first executable statement after the <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> statement and ending with the first <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>, or <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> statement encountered.  
  
 You can define a <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> procedure in modules, classes, and structures. By default, it is <CodeContentPlaceHolder>9\</CodeContentPlaceHolder>, which means you can call it from anywhere in your application that has access to the module, class, or structure in which you defined it. The term, *method*, describes a <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> or <CodeContentPlaceHolder>11\</CodeContentPlaceHolder> procedure that is accessed from outside its defining module, class, or structure. For more information, see [Procedures in Visual Basic](../vs140/procedures-in-visual-basic.md).  
  
 A <CodeContentPlaceHolder>12\</CodeContentPlaceHolder> procedure can take arguments, such as constants, variables, or expressions, which are passed to it by the calling code.  
  
## Declaration Syntax  
 The syntax for declaring a <CodeContentPlaceHolder>13\</CodeContentPlaceHolder> procedure is as follows:  
  
 <CodeContentPlaceHolder>14\</CodeContentPlaceHolder> *modifiers* <CodeContentPlaceHolder>15\</CodeContentPlaceHolder>  *subname* <CodeContentPlaceHolder>16\</CodeContentPlaceHolder> *parameterlist* <CodeContentPlaceHolder>17\</CodeContentPlaceHolder>  
  
 <CodeContentPlaceHolder>18\</CodeContentPlaceHolder>  
  
 <CodeContentPlaceHolder>19\</CodeContentPlaceHolder>  
  
 The <CodeContentPlaceHolder>20\</CodeContentPlaceHolder> can specify access level and information about overloading, overriding, sharing, and shadowing. For more information, see [Sub Statement](../vs140/sub-statement--visual-basic-.md).  
  
## Parameter Declaration  
 You declare each procedure parameter similarly to how you declare a variable, specifying the parameter name and data type. You can also specify the passing mechanism, and whether the parameter is optional or a parameter array.  
  
 The syntax for each parameter in the parameter list is as follows:  
  
 <CodeContentPlaceHolder>21\</CodeContentPlaceHolder>  *parametername*  <CodeContentPlaceHolder>22\</CodeContentPlaceHolder>  *datatype*  
  
 If the parameter is optional, you must also supply a default value as part of its declaration. The syntax for specifying a default value is as follows:  
  
 <CodeContentPlaceHolder>23\</CodeContentPlaceHolder>  *parametername*  <CodeContentPlaceHolder>24\</CodeContentPlaceHolder>  *datatype*  <CodeContentPlaceHolder>25\</CodeContentPlaceHolder>  *defaultvalue*  
  
### Parameters as Local Variables  
 When control passes to the procedure, each parameter is treated as a local variable. This means that its lifetime is the same as that of the procedure, and its scope is the whole procedure.  
  
## Calling Syntax  
 You invoke a <CodeContentPlaceHolder>26\</CodeContentPlaceHolder> procedure explicitly with a stand-alone calling statement. You cannot call it by using its name in an expression. You must provide values for all arguments that are not optional, and you must enclose the argument list in parentheses. If no arguments are supplied, you can optionally omit the parentheses. The use of the <CodeContentPlaceHolder>27\</CodeContentPlaceHolder> keyword is optional but not recommended.  
  
 The syntax for a call to a <CodeContentPlaceHolder>28\</CodeContentPlaceHolder> procedure is as follows:  
  
 <CodeContentPlaceHolder>29\</CodeContentPlaceHolder>  *subname* <CodeContentPlaceHolder>30\</CodeContentPlaceHolder> *argumentlist* <CodeContentPlaceHolder>31\</CodeContentPlaceHolder>  
  
 You can call a <CodeContentPlaceHolder>32\</CodeContentPlaceHolder> method from outside the class that defines it. First, you have to use the <CodeContentPlaceHolder>33\</CodeContentPlaceHolder> keyword to create an instance of the class, or call a method that returns an instance of the class. For more information, see [New Operator (Visual Basic)](../vs140/new-operator--visual-basic-.md). Then, you can use the following syntax to call the <CodeContentPlaceHolder>34\</CodeContentPlaceHolder> method on the instance object:  
  
 *Object*.*methodname*<CodeContentPlaceHolder>35\</CodeContentPlaceHolder>*argumentlist*<CodeContentPlaceHolder>36\</CodeContentPlaceHolder>  
  
### Illustration of Declaration and Call  
 The following <CodeContentPlaceHolder>37\</CodeContentPlaceHolder> procedure tells the computer operator which task the application is about to perform, and also displays a time stamp. Instead of duplicating this code at the start of every task, the application just calls <CodeContentPlaceHolder>38\</CodeContentPlaceHolder> from various locations. Each call passes a string in the <CodeContentPlaceHolder>39\</CodeContentPlaceHolder> argument that identifies the task being started.  
  
 [!code[VbVbcnProcedures#2](../vs140/codesnippet/VisualBasic/sub-procedures--visual-basic-_1.vb)]  
  
 The following example shows a typical call to <CodeContentPlaceHolder>40\</CodeContentPlaceHolder>.  
  
 [!code[VbVbcnProcedures#3](../vs140/codesnippet/VisualBasic/sub-procedures--visual-basic-_2.vb)]  
  
## See Also  
 [Procedures in Visual Basic](../vs140/procedures-in-visual-basic.md)   
 [Function Procedures](../vs140/function-procedures--visual-basic-.md)   
 [Property Procedures](../vs140/property-procedures--visual-basic-.md)   
 [Operator Procedures](../vs140/operator-procedures--visual-basic-.md)   
 [Procedure Parameters and Arguments](../vs140/procedure-parameters-and-arguments--visual-basic-.md)   
 [Sub Statement](../vs140/sub-statement--visual-basic-.md)   
 [How to: Call a Procedure that Does Not Return a Value](../vs140/how-to--call-a-procedure-that-does-not-return-a-value--visual-basic-.md)   
 [How to: Call an Event Handler in Visual Basic](../vs140/how-to--call-an-event-handler-in-visual-basic.md)