---
title: "PARSEFLAGS"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "vs-ide-sdk"
ms.tgt_pltfrm: na
ms.topic: "article"
f1_keywords: 
  - "PARSEFLAGS"
helpviewer_keywords: 
  - "PARSEFLAGS enumeration"
ms.assetid: 47943f0a-54cb-4493-a62e-5dba97bd4c35
caps.latest.revision: 13
ms.author: "gregvanl"
translation.priority.mt: 
  - "de-de"
  - "ja-jp"
---
# PARSEFLAGS
Specifies how to parse an expression.  
  
## Syntax  
  
```cpp#  
enum enum_PARSEFLAGS {   
   PARSE_EXPRESSION            = 0x0001,  
   PARSE_FUNCTION_AS_ADDRESS   = 0x0002,  
   PARSE_DESIGN_TIME_EXPR_EVAL = 0x1000  
};  
typedef DWORD PARSEFLAGS;  
```  
  
```c#  
public enum enum_PARSEFLAGS {   
   PARSE_EXPRESSION            = 0x0001,  
   PARSE_FUNCTION_AS_ADDRESS   = 0x0002,  
   PARSE_DESIGN_TIME_EXPR_EVAL = 0x1000  
};  
```  
  
## Members  
 PARSE_EXPRESSION  
 Indicates that the expression is not a statement.  
  
 PARSE_FUNCTION_AS_ADDRESS  
 Indicates that the expression is to be parsed (and later evaluated) as an address.  
  
 PARSE_DESIGN_TIME_EXPR_EVAL  
 Indicates that the expression is being parsed during design time (that is, when a designer is open).  
  
## Remarks  
 Passed as a parameter to the [ParseText](../vs140/idebugexpressioncontext2--parsetext.md) and [IDebugExpressionEvaluator::Parse](../vs140/idebugexpressionevaluator--parse.md) methods.  
  
## Requirements  
 Header: msdbg.h  
  
 Namespace: Microsoft.VisualStudio.Debugger.Interop  
  
 Assembly: Microsoft.VisualStudio.Debugger.Interop.dll  
  
## See Also  
 [Enumerations (Visual Studio Debugging SDK)](../vs140/enumerations--visual-studio-debugging-.md)   
 [ParseText](../vs140/idebugexpressioncontext2--parsetext.md)   
 [IDebugExpressionEvaluator::Parse](../vs140/idebugexpressionevaluator--parse.md)