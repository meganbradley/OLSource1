---
title: "Using the iteration variable in a lambda expression may have unexpected results"
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
  - "vbc42324"
  - "bc42324"
dev_langs: 
  - "VB"
helpviewer_keywords: 
  - "BC42324"
ms.assetid: b5c2c4bd-3b2a-4a73-aaeb-55728eb03b68
caps.latest.revision: 12
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Using the iteration variable in a lambda expression may have unexpected results
Using the iteration variable in a lambda expression may have unexpected results. Instead, create a local variable within the loop and assign it the value of the iteration variable.  
  
 This warning appears when you use a loop iteration variable in a lambda expression that is declared inside the loop. For example, the following example causes the warning to appear.  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
 The following example shows the unexpected results that might occur.  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 The <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> loop creates an array of lambda expressions, each of which returns the value of the loop iteration variable <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>. When the lambda expressions are evaluated in the <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> loop, you might expect to see 0, 1, 2, 3, and 4 displayed, the successive values of <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> in the <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> loop. Instead, you see the final value of <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> displayed five times:  
  
 <CodeContentPlaceHolder>9\</CodeContentPlaceHolder>  
  
 <CodeContentPlaceHolder>10\</CodeContentPlaceHolder>  
  
 <CodeContentPlaceHolder>11\</CodeContentPlaceHolder>  
  
 <CodeContentPlaceHolder>12\</CodeContentPlaceHolder>  
  
 <CodeContentPlaceHolder>13\</CodeContentPlaceHolder>  
  
 By default, this message is a warning. For more information about hiding warnings or treating warnings as errors, see [Configuring Warnings in Visual Basic](../vs140/configuring-warnings-in-visual-basic.md).  
  
 **Error ID:** BC42324  
  
### To correct this error  
  
-   Assign the value of the iteration variable to a local variable, and use the local variable in the lambda expression.  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
## See Also  
 [Lambda Expressions](../vs140/lambda-expressions--visual-basic-.md)