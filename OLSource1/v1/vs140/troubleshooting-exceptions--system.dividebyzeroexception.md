---
title: "Troubleshooting Exceptions: System.DivideByZeroException"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-csharp"
ms.tgt_pltfrm: na
ms.topic: "article"
dev_langs: 
  - "JScript"
  - "VB"
  - "CSharp"
  - "C++"
helpviewer_keywords: 
  - "DivideByZeroException class"
ms.assetid: ddc79201-3ba1-455f-8496-edaad792ccf1
caps.latest.revision: 18
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Troubleshooting Exceptions: System.DivideByZeroException
A \<xref:System.DivideByZeroException*> exception is thrown when there is an attempt to divide an integer or decimal value by zero.  
  
## Associated Tips  
 **Make sure the value of the denominator is not zero before you perform a division operation.**  
 Dividing a floating-point value by zero results in either positive infinity, negative infinity, or Not a Number (NaN), according to the rules of IEEE arithmetic. Floating-point operations never throw an exception.  
  
## See Also  
 \<xref:System.DivideByZeroException*>   
 [Arithmetic Operators in Visual Basic](../vs140/arithmetic-operators-in-visual-basic.md)   
 [How to: Find Out More About an Exception with the Exception Assistant](../vs140/how-to--use-the-exception-assistant.md)