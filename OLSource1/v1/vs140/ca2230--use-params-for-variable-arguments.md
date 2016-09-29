---
title: "CA2230: Use params for variable arguments"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "vs-devops-test"
ms.tgt_pltfrm: na
ms.topic: "article"
f1_keywords: 
  - "UseParamsForVariableArguments"
  - "CA2230"
helpviewer_keywords: 
  - "CA2230"
  - "UseParamsForVariableArguments"
ms.assetid: bf98b733-4855-4110-9f16-eba5a9e79421
caps.latest.revision: 17
author: ""
ms.author: ""
manager: ""
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CA2230: Use params for variable arguments
|||  
|-|-|  
|TypeName|UseParamsForVariableArguments|  
|CheckId|CA2230|  
|Category|Microsoft.Usage|  
|Breaking Change|Breaking|  
  
## Cause  
 A public or protected type contains a public or protected method that uses the `VarArgs` calling convention.  
  
## Rule Description  
 The `VarArgs` calling convention is used with certain method definitions that take a variable number of parameters. A method using the `VarArgs` calling convention is not Common Language Specification (CLS) compliant and might not be accessible across programming languages.  
  
 In C#, the `VarArgs` calling convention is used when a method's parameter list ends with the `__arglist` keyword. Visual Basic does not support the `VarArgs` calling convention, and Visual C++  allows its use only in unmanaged code that uses the ellipse `...` notation.  
  
## How to Fix Violations  
 To fix a violation of this rule in C#, use the [params](../vs140/params--csharp-reference-.md) keyword instead of `__arglist`.  
  
## When to Suppress Warnings  
 Do not suppress a warning from this rule.  
  
## Example  
 The following example shows two methods, one that violates the rule and one that satisfies the rule.  
  
 [!code[FxCop.Usage.UseParams#1](../vs140/codesnippet/CSharp/ca2230--use-params-for-variable-arguments_1.cs)]  
  
## See Also  
 <xref:System.Reflection.CallingConventions*?displayProperty=fullName>   
 [Common Language Specification](assetId:///4f0b77d0-4844-464f-af73-6e06bedeafc6)