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
The <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> expression is a debugging feature that you can use to test an expression. Upon failure in Debug mode, an assertion generates a system error dialog box.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Remarks  
 The <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> expression has type <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>.  
  
 In the previous syntax, <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> represents a Boolean expression that is to be tested. If the expression evaluates to <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>, execution continues unaffected. If it evaluates to <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>, a system error dialog box is generated. The error dialog box has a caption that contains the string **Assertion Failed**. The dialog box contains a stack trace that indicates where the assertion failure occurred.  
  
 Assertion checking is enabled only when you compile in Debug mode; that is, if the constant <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> is defined. In the project system, by default, the <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> constant is defined in the Debug configuration but not in the Release configuration.  
  
 The assertion failure error cannot be caught by using F# exception handling.  
  
> [!NOTE]
>  The <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> function resolves to <CodeContentPlaceHolder>10\</CodeContentPlaceHolder>. For more information, see \<xref:System.Diagnostics.Debug.Assert*>.  
  
 The following code example illustrates the use of the <CodeContentPlaceHolder>11\</CodeContentPlaceHolder> expression.  
  
 [!code[FsLangRef2#5401](../vs140/codesnippet/FSharp/assertions--fsharp-_1.fs)]  
  
## See Also  
 [F# Language Reference](../vs140/fsharp-language-reference.md)