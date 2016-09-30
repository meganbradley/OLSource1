---
title: "_STATIC_ASSERT Macro"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-cpp"
ms.tgt_pltfrm: na
ms.topic: "article"
apilocation: 
  - "msvcr120.dll"
  - "msvcr110_clr0400.dll"
  - "msvcr80.dll"
  - "msvcr110.dll"
  - "msvcr100.dll"
  - "msvcr90.dll"
apitype: "DLLExport"
f1_keywords: 
  - "_STATIC_ASSERT"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "_STATIC_ASSERT macro"
ms.assetid: 89b0350c-2c2f-4be6-9786-8b1f0780a5da
caps.latest.revision: 10
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# _STATIC_ASSERT Macro
Evaluate an expression at compile time and generate an error when the result is <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 Expression (including pointers) that evaluates to nonzero (<CodeContentPlaceHolder>4\</CodeContentPlaceHolder>) or 0 (<CodeContentPlaceHolder>5\</CodeContentPlaceHolder>).  
  
## Remarks  
 This macro resembles the [_ASSERT and _ASSERTE macros](../vs140/_assert--_asserte--_assert_expr-macros.md), except that <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> is evaluated at compile time instead of at runtime. If <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> evaluates to <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> (0), [Compiler Error C2466](../vs140/compiler-error-c2466.md) is generated.  
  
## Example  
 In this example, we check whether the <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> an <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> is larger than or equal to 2 bytes and whether the <CodeContentPlaceHolder>11\</CodeContentPlaceHolder> a <CodeContentPlaceHolder>12\</CodeContentPlaceHolder> is 1 byte. The program will not compile and it will generate [Compiler Error C2466](../vs140/compiler-error-c2466.md) because a <CodeContentPlaceHolder>13\</CodeContentPlaceHolder> is larger than 1 byte.  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
## Requirements  
  
|Macro|Required header|  
|-----------|---------------------|  
|<CodeContentPlaceHolder>14\</CodeContentPlaceHolder>|\<crtdbg.h>|  
  
## .NET Framework Equivalent  
 [System::Diagnostics::Debug::Assert](https://msdn.microsoft.com/en-us/library/system.diagnostics.debug.assert.aspx)  
  
## See Also  
 [Alphabetical Function Reference](../vs140/crt-alphabetical-function-reference.md)   
 [_ASSERT, _ASSERTE Macros](../vs140/_assert--_asserte--_assert_expr-macros.md)