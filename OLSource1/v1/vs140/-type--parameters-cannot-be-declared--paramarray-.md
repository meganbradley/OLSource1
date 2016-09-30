---
title: "&lt;type&gt; parameters cannot be declared &#39;ParamArray&#39;"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-csharp"
ms.tgt_pltfrm: na
ms.topic: "article"
f1_keywords: 
  - "bc33009"
  - "vbc33009"
helpviewer_keywords: 
  - "BC33009"
ms.assetid: faba9aef-ca4e-4c4d-934c-a3e3d3fa3c3e
caps.latest.revision: 12
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# &lt;type&gt; parameters cannot be declared &#39;ParamArray&#39;
A definition of a delegate, event, or operator declares a [ParamArray](../vs140/paramarray--visual-basic-.md) parameter.  
  
 <CodeContentPlaceHolder>0\</CodeContentPlaceHolder> parameters are allowed only on <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>, and <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> parameters.  
  
 **Error ID:** BC33009  
  
### To correct this error  
  
-   Remove the <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> keyword from the parameter list.  
  
-   If you are defining an operator, you might be able to achieve the <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> functionality with a series of overloads.  
  
-   If you are defining a delegate or event, you must rework the overall logic of this part of your application. You cannot use [Optional (Visual Basic)](../vs140/optional--visual-basic-.md) or <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> parameters, or overloaded versions, on delegate or event parameters.  
  
## See Also  
 [Overloads](../vs140/overloads--visual-basic-.md)   
 [Operator Procedures](../vs140/operator-procedures--visual-basic-.md)   
 [Operator Statement](../vs140/operator-statement.md)