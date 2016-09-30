---
title: "Optional Parameters (Visual Basic)"
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
  - "parameters, optional"
  - "Visual Basic code, procedures"
  - "procedures, optional arguments"
  - "optional arguments"
  - "named arguments, and optional arguments"
  - "optional parameters"
  - "Optional keyword, optional arguments"
  - "arguments [Visual Basic], optional"
  - "optional arguments, and named arguments"
ms.assetid: 398d2845-1069-4e94-b934-a73b545c8b87
caps.latest.revision: 22
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Optional Parameters (Visual Basic)
You can specify that a procedure parameter is optional and no argument has to be supplied for it when the procedure is called. *Optional parameters* are indicated by the <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> keyword in the procedure definition. The following rules apply:  
  
-   Every optional parameter in the procedure definition must specify a default value.  
  
-   The default value for an optional parameter must be a constant expression.  
  
-   Every parameter following an optional parameter in the procedure definition must also be optional.  
  
 The following syntax shows a procedure declaration with an optional parameter:  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Calling Procedures with Optional Parameters  
 When you call a procedure with an optional parameter, you can choose whether to supply the argument. If you do not, the procedure uses the default value declared for that parameter.  
  
 When you omit one or more optional arguments in the argument list, you use successive commas to mark their positions. The following example call supplies the first and fourth arguments but not the second or third:  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 The following example makes several calls to the <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> function. <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> has one required parameter and two optional parameters.  
  
 The first call to <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> supplies all three arguments in the order that <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> defines them. The second call supplies only the required argument. The third and fourth calls supply the first and third arguments. The third call does this by position, and the fourth call does it by name.  
  
 [!code[VbVbcnProcedures#47](../vs140/codesnippet/VisualBasic/optional-parameters--visual-basic-_1.vb)]  
  
## Determining Whether an Optional Argument Is Present  
 A procedure cannot detect at run time whether a given argument has been omitted or the calling code has explicitly supplied the default value. If you need to make this distinction, you can set an unlikely value as the default. The following procedure defines the optional parameter <CodeContentPlaceHolder>7\</CodeContentPlaceHolder>, and tests for its default value, <CodeContentPlaceHolder>8\</CodeContentPlaceHolder>, to see if it has been omitted in the call:  
  
 [!code[VbVbcnProcedures#46](../vs140/codesnippet/VisualBasic/optional-parameters--visual-basic-_2.vb)]  
  
 If the optional parameter is a reference type such as a <CodeContentPlaceHolder>9\</CodeContentPlaceHolder>, you can use <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> as the default value, provided this is not an expected value for the argument.  
  
## Optional Parameters and Overloading  
 Another way to define a procedure with optional parameters is to use overloading. If you have one optional parameter, you can define two overloaded versions of the procedure, one accepting the parameter and one without it. This approach becomes more complicated as the number of optional parameters increases. However, its advantage is that you can be absolutely sure whether the calling program supplied each optional argument.  
  
## See Also  
 [Procedures in Visual Basic](../vs140/procedures-in-visual-basic.md)   
 [Procedure Parameters and Arguments](../vs140/procedure-parameters-and-arguments--visual-basic-.md)   
 [Argument Passing By Value and By Reference](../vs140/passing-arguments-by-value-and-by-reference--visual-basic-.md)   
 [Passing Arguments by Position and by Name](../vs140/passing-arguments-by-position-and-by-name--visual-basic-.md)   
 [Parameter Arrays](../vs140/parameter-arrays--visual-basic-.md)   
 [Procedure Overloading](../vs140/procedure-overloading--visual-basic-.md)   
 [Optional](../vs140/optional--visual-basic-.md)   
 [ParamArray](../vs140/paramarray--visual-basic-.md)