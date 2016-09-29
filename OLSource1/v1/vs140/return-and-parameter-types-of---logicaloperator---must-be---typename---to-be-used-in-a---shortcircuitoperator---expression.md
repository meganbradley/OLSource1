---
title: "Return and parameter types of &#39;&lt;logicaloperator&gt;&#39; must be &#39;&lt;typename&gt;&#39; to be used in a &#39;&lt;shortcircuitoperator&gt;&#39; expression"
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
  - "vbc33034"
  - "bc33034"
helpviewer_keywords: 
  - "BC33034"
ms.assetid: 94cd52dc-5d48-4673-b0b8-38a1954483c6
caps.latest.revision: 16
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Return and parameter types of &#39;&lt;logicaloperator&gt;&#39; must be &#39;&lt;typename&gt;&#39; to be used in a &#39;&lt;shortcircuitoperator&gt;&#39; expression
An `And` operator or an `Or` operator is declared with unsuitable parameters or return type for use in an [AndAlso Operator](../vs140/andalso-operator--visual-basic-.md) or an [OrElse Operator](../vs140/orelse-operator--visual-basic-.md).  
  
 Because you do not define a short-circuiting operator (`AndAlso` or `OrElse`) directly, you must define the corresponding logical and determinant operators. The following table shows the required operators.  
  
|Short-circuiting operator|Logical operator|Determinant operator|  
|--------------------------------|----------------------|--------------------------|  
|`AndAlso`|[And Operator](../vs140/and-operator--visual-basic-.md)|[IsFalse Operator](../vs140/isfalse-operator--visual-basic-.md)|  
|`OrElse`|[Or Operator](../vs140/or-operator--visual-basic-.md)|[IsTrue Operator](../vs140/istrue-operator--visual-basic-.md)|  
  
 [!INCLUDE[vbprvb](../vs140/includes/vbprvb_md.md)] uses these logical and determinant operators to construct the short-circuiting logic for `AndAlso` or `OrElse`. For this to work properly, both operands and the return value of your `And` or `Or` definition must be of the containing type, that is, the type of the class or structure in which you are defining `And` or `Or`.  
  
 **Error ID:** BC33034  
  
### To correct this error  
  
-   Change the type of both operands and the return value to the type of the class or structure in which you are defining this operator.  
  
     -or-  
  
-   Do not use the corresponding short-circuiting operator (`AndAlso` or `OrElse`) with operands of the type of the class or structure in which you are defining this `And` or `Or` operator.  
  
## See Also  
 [Operator Procedures](../vs140/operator-procedures--visual-basic-.md)   
 [Operator Statement](../vs140/operator-statement.md)   
 [How to: Define an Operator](../vs140/how-to--define-an-operator--visual-basic-.md)   
 [How to: Define a Conversion Operator](../vs140/how-to--define-a-conversion-operator--visual-basic-.md)   
 [Logical and Bitwise Operators in Visual Basic](../vs140/logical-and-bitwise-operators-in-visual-basic.md)