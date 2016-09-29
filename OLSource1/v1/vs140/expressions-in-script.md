---
title: "Expressions in Script"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "vs-ide-debug"
ms.tgt_pltfrm: na
ms.topic: "article"
dev_langs: 
  - "FSharp"
  - "VB"
  - "CSharp"
  - "C++"
  - "JScript"
  - "VBScript"
helpviewer_keywords: 
  - "scripts, debugging"
  - "debugging script, expressions"
  - "expression evaluation, script debugging"
  - "JScript, expression evaluator"
  - "debugging [JScript], expressions"
ms.assetid: 25f628a1-b4c8-4e9a-a3af-69637022c988
caps.latest.revision: 24
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Expressions in Script
The script expression evaluator accepts most expressions written in ASP-based JScript and VBScript. For JScript, it accepts most expressions, with a few exceptions:  
  
## Functions and Function Calls  
 The expression evaluator does not support the declaration of new functions or the dynamic creation of functions using new Function.  
  
 The expression evaluator supports function calls with By Value arguments but does not support function calls with By Reference arguments, objects, arrays, functions, and strings.  
  
## eval Method  
 The expression evaluator does not support expressions that use the `eval` method, such as:  
  
 `eval("mydate = new "+dateFn+";")`  
  
## Array Literals  
 The expression evaluator does not support array literals, such as:  
  
 `var al1 : Array = [1,2,"3"];`  
  
## Regular Expression Literals  
 The expression evaluator does not support regular expression literals, such as `data*.dat`.  
  
## See Also  
 [Expressions in the Debugger](../vs140/expressions-in-the-debugger.md)   
 [JScript .NET](assetId:///c7e636ee-c10f-45b1-85ec-fe2daca30bf5)