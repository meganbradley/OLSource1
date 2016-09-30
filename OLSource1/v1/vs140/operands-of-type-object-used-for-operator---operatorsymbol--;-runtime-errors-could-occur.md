---
title: "Operands of type Object used for operator &#39;&lt;operatorsymbol&gt;&#39;; runtime errors could occur"
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
  - "BC42019"
  - "vbc42019"
helpviewer_keywords: 
  - "BC42019"
ms.assetid: f61944ba-863b-4a82-aae4-249bda52ec8d
caps.latest.revision: 14
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Operands of type Object used for operator &#39;&lt;operatorsymbol&gt;&#39;; runtime errors could occur
An expression uses an operator for which one or both operands are of the [Object Data Type](../vs140/object-data-type.md).  
  
 When a variable or expression evaluates to <CodeContentPlaceHolder>0\</CodeContentPlaceHolder>, the compiler must perform *late binding*, which causes extra operations at run time. It also exposes your application to potential run-time errors. For example, suppose you assign a \<xref:System.Windows.Forms.Form*> to an <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> variable and then try to use it with the [/ Operator (Visual Basic)](../vs140/--operator--visual-basic-3.md). If you do this, the runtime throws an \<xref:System.InvalidCastException*> because Visual Basic cannot convert a \<xref:System.Windows.Forms.Form*> object to a numeric value.  
  
 By default, this message is a warning. For information on hiding warnings or treating warnings as errors, see [Configuring Warnings in Visual Basic](../vs140/configuring-warnings-in-visual-basic.md).  
  
 **Error ID:** BC42019  
  
### To correct this error  
  
-   If possible, arrange the operands to evaluate to data types for which the operator is defined.  
  
## See Also  
 [Arithmetic Operators in Visual Basic](../vs140/arithmetic-operators-in-visual-basic.md)