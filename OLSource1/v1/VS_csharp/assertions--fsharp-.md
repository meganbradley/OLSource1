---
title: "Assertions (F#)"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-fsharp"
ms.tgt_pltfrm: na
ms.topic: "reference"
dev_langs: 
  - "FSharp"
helpviewer_keywords: 
  - "assert [F#]"
  - "assertions [F#]"
ms.assetid: 1e8b9af8-9912-4cbc-b5a0-6409d5a725e9
caps.latest.revision: 20
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Assertions (F#)
The `assert` expression is a debugging feature that you can use to test an expression. Upon failure in Debug mode, an assertion generates a system error dialog box.  
  
## Syntax  
  
```  
assert condition  
```  
  
## Remarks  
 The `assert` expression has type `bool -> unit`.  
  
 In the previous syntax, `condition` represents a Boolean expression that is to be tested. If the expression evaluates to `true`, execution continues unaffected. If it evaluates to `false`, a system error dialog box is generated. The error dialog box has a caption that contains the string **Assertion Failed**. The dialog box contains a stack trace that indicates where the assertion failure occurred.  
  
 Assertion checking is enabled only when you compile in Debug mode; that is, if the constant `DEBUG` is defined. In the project system, by default, the `DEBUG` constant is defined in the Debug configuration but not in the Release configuration.  
  
 The assertion failure error cannot be caught by using F# exception handling.  
  
> [!NOTE]
>  The `assert` function resolves to `System.Diagnostics.Debug.Assert`. For more information, see <xref:System.Diagnostics.Debug.Assert*>.  
  
 The following code example illustrates the use of the `assert` expression.  
  
 [!code[FsLangRef2#5401](../VS_csharp/codesnippet/FSharp/assertions--fsharp-_1.fs)]  
  
## See Also  
 [F# Language Reference](../VS_csharp/fsharp-language-reference.md)