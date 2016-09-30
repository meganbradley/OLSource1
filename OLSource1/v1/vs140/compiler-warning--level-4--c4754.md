---
title: "Compiler Warning (level 4) C4754"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-cpp"
ms.tgt_pltfrm: na
ms.topic: "error-reference"
f1_keywords: 
  - "C4754"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "C4754"
ms.assetid: e0e4606a-754a-4f42-a274-21a34978d21d
caps.latest.revision: 8
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Compiler Warning (level 4) C4754
Conversion rules for arithmetic operations in a comparison mean that one branch cannot be executed.  
  
 The C4754 warning is issued because the result of the comparison is always the same. This indicates that one of the branches of the condition is never executed, most likely because the associated integer expression is incorrect. This code defect often occurs in incorrect integer overflow checks on 64-bit architectures.  
  
 Integer conversion rules are complex and there are many subtle pitfalls. As an alternative to fixing each C4754 warning, you can update the code to use the [SafeInt Library](../vs140/safeint-library.md).  
  
## Example  
 This sample generates C4754:  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
 The addition <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> could cause an arithmetic overflow before the result is upcast to a 64-bit value and assigned to the 64-bit variable <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>. This means that the check on <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> is redundant and will never catch an overflow. In this case, the compiler emits this warning:  
  
 **Warning C4754: Conversion rules for arithmetic operations in the comparison at C4754a.cpp (7) mean that one branch cannot be executed. Cast '(a + ...)' to 'ULONG64' (or similar type of 8 bytes).** To eliminate the warning, you can change the assignment statement to cast the operands to 8-byte values:  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
## Example  
 The next sample also generates C4754.  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 The <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> operator returns a <CodeContentPlaceHolder>9\</CodeContentPlaceHolder>, whose size is architecture-dependent. The example code works on 32-bit architectures where a <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> is a 32-bit type. However, on 64-bit architectures, <CodeContentPlaceHolder>11\</CodeContentPlaceHolder> is a 64-bit type. The conversion rules for integers mean that <CodeContentPlaceHolder>12\</CodeContentPlaceHolder> is upcast to a 64-bit value in the expression <CodeContentPlaceHolder>13\</CodeContentPlaceHolder> as if it were written <CodeContentPlaceHolder>14\</CodeContentPlaceHolder>. When <CodeContentPlaceHolder>15\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>16\</CodeContentPlaceHolder> are 32-bit integers, the 64-bit addition operation can never overflow, and the constraint never holds. As a result, the code never detects an integer overflow condition on 64-bit architectures. This example causes the compiler to emit this warning:  
  
 **Warning C4754: Conversion rules for arithmetic operations in the comparison at C4754b.cpp (7) mean that one branch cannot be executed. Cast '4' to 'ULONG' (or similar type of 4 bytes).** Notice that the warning message explicitly lists the constant value 4 instead of the original source string—by the time the warning analysis encounters the offending code, <CodeContentPlaceHolder>17\</CodeContentPlaceHolder> has already been converted to a constant. Therefore, you may have to track down which expression in the source code is associated with the constant value in the warning message. The most common sources of code resolved to constants in C4754 warning messages are expressions such as <CodeContentPlaceHolder>18\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>19\</CodeContentPlaceHolder>.  
  
 In this case, the fixed code would resemble this:  
  
<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 **Note** The line number referred to in compiler warnings is the last line of a statement. In a warning message about a complex conditional statement that's spread over multiple lines, the line that has the code defect may be several lines before the line that's reported. For example:  
  
<CodeContentPlaceHolder>4\</CodeContentPlaceHolder>