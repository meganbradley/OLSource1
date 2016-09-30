---
title: "Troubleshooting Exceptions: System.OverflowException"
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
  - "OverflowException class"
ms.assetid: bd380db7-5d05-4d7f-be5b-e654fdadf14c
caps.latest.revision: 17
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Troubleshooting Exceptions: System.OverflowException
An \<xref:System.OverflowException*> exception is thrown when an arithmetic, casting, or conversion operation in a checked context results in an overflow. An overflow occurs when an operation produces a value too large for the destination type, infinity, or Not a Number (NaN).  
  
## Associated Tips  
 **When casting from a number, the value must be a valid number less than infinity.**  
 A source value cannot be infinity or Not a Number.  
  
 **Make sure you are not dividing by zero.**  
 Dividing by zero will typically yield this exception.  
  
## Remarks  
 In languages that detect overflow, \<xref:System.OverflowException*> is the exception that is thrown when overflow occurs. For example, in C#, the `checked` keyword is used to detect overflow conditions. An \<xref:System.OverflowException*> exception occurs only in a checked context.  
  
 For a result from an integral or decimal-type arithmetic operation or conversion that is outside the range of the destination type:  
  
-   In a checked context, a compile-time error occurs if the operation is a constant expression. Otherwise, an \<xref:System.OverflowException*> exception is thrown if the operation is performed at run time.  
  
-   In an unchecked context, the result is truncated by discarding any high-order bits that do not fit in the destination type.  
  
 For information about the value ranges of data types, see [Data Type Summary (Visual Basic)](../vs140/data-type-summary--visual-basic-.md), [Integral Types Table (C# Reference)](../vs140/integral-types-table--csharp-reference-.md), or [Floating-Point Types Table (C# Reference)](../vs140/floating-point-types-table--csharp-reference-.md).  
  
## See Also  
 \<xref:System.OverflowException*>   
 [How to: Find Out More About an Exception with the Exception Assistant](../vs140/how-to--use-the-exception-assistant.md)