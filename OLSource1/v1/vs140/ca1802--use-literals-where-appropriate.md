---
title: "CA1802: Use Literals Where Appropriate"
ms.custom: na
ms.date: "09/21/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "vs-devops-test"
ms.tgt_pltfrm: na
ms.topic: "article"
f1_keywords: 
  - "UseLiteralsWhereAppropriate"
  - "CA1802"
helpviewer_keywords: 
  - "UseLiteralsWhereAppropriate"
  - "CA1802"
ms.assetid: 2515e4cd-9e61-486d-b067-58ba1a743ce4
caps.latest.revision: 21
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CA1802: Use Literals Where Appropriate
|||  
|-|-|  
|TypeName|UseLiteralsWhereAppropriate|  
|CheckId|CA1802|  
|Category|Microsoft.Performance|  
|Breaking Change|Non-breaking|  
  
## Cause  
 A field is declared <CodeContentPlaceHolder>0\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> (<CodeContentPlaceHolder>2\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> in [!INCLUDE[vbprvb](../vs140/includes/vbprvb_md.md)]), and is initialized with a value that is computable at compile time.  
  
## Rule Description  
 The value of a <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> field is computed at runtime when the static constructor for the declaring type is called. If the <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> field is initialized when it is declared and a static constructor is not declared explicitly, the compiler emits a static constructor to initialize the field.  
  
 The value of a <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> field is computed at compile time and stored in the metadata, which increases runtime performance when it is compared to a <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> field.  
  
 Because the value assigned to the targeted field is computable at compile time, change the declaration to a <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> field so that the value is computed at compile time instead of at runtime.  
  
## How to Fix Violations  
 To fix a violation of this rule, replace the <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> modifiers with the <CodeContentPlaceHolder>11\</CodeContentPlaceHolder> modifier.  
  
## When to Suppress Warnings  
 It is safe to suppress a warning from this rule, or disable the rule, if performance is not of concern.  
  
## Example  
 The following example shows a type, <CodeContentPlaceHolder>12\</CodeContentPlaceHolder>, that violates the rule and a type, <CodeContentPlaceHolder>13\</CodeContentPlaceHolder>, that satisfies the rule.  
  
 [!code[FxCop.Performance.UseLiterals#1](../vs140/codesnippet/VisualBasic/ca1802--use-literals-where-appropriate_1.vb)]
[!code[FxCop.Performance.UseLiterals#1](../vs140/codesnippet/CSharp/ca1802--use-literals-where-appropriate_1.cs)]