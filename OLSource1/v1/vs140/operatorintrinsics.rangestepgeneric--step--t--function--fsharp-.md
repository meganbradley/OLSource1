---
title: "OperatorIntrinsics.RangeStepGeneric&lt;&#39;Step,&#39;T&gt; Function (F#)"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-fsharp"
ms.tgt_pltfrm: na
ms.topic: "reference"
apilocation: 
  - "FSharp.Core.dll"
apitype: "Assembly"
f1_keywords: 
  - "Microsoft.FSharp.Core.Operators.OperatorIntrinsics.RangeStepGeneric"
dev_langs: 
  - "FSharp"
helpviewer_keywords: 
  - "RangeStepGeneric function [F#]"
ms.assetid: f3faecb8-24d4-435a-b59c-69c039397084
caps.latest.revision: 15
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# OperatorIntrinsics.RangeStepGeneric&lt;&#39;Step,&#39;T&gt; Function (F#)
Generates a range of values using the given zero, add, start, step and stop values.  
  
 **Namespace/Module Path:** Microsoft.FSharp.Core.Operators.OperatorIntrinsics  
  
 **Assembly:** FSharp.Core (in FSharp.Core.dll)  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 Type: <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
  
 The zero value for the step type.  
  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 Type: <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
  
 An addition function that adds a value and the step to produce another value.  
  
 <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
 Type: <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>  
  
 The starting value.  
  
 <CodeContentPlaceHolder>7\</CodeContentPlaceHolder>  
 Type: <CodeContentPlaceHolder>8\</CodeContentPlaceHolder>  
  
 The increment to the value on each iteration.  
  
 <CodeContentPlaceHolder>9\</CodeContentPlaceHolder>  
 Type: <CodeContentPlaceHolder>10\</CodeContentPlaceHolder>  
  
 The final value.  
  
## Return Value  
 An enumerable sequence of values starting with <CodeContentPlaceHolder>11\</CodeContentPlaceHolder>, incrementing by <CodeContentPlaceHolder>12\</CodeContentPlaceHolder>, and ending with <CodeContentPlaceHolder>13\</CodeContentPlaceHolder>.  
  
## Remarks  
 This function is for use by compiled F# code and should not be used directly.  
  
## Platforms  
 Windows 8, Windows 7, Windows Server 2012, Windows Server 2008 R2  
  
## Version Information  
 **F# Core Library Versions**  
  
 Supported in: 2.0, 4.0, Portable, Portable  
  
## See Also  
 [Operators.OperatorIntrinsics Module (F#)](../vs140/operators.operatorintrinsics-module--fsharp-.md)   
 [Microsoft.FSharp.Core.Operators Namespace (F#)](../vs140/core.operators-module--fsharp-.md)