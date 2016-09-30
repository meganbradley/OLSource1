---
title: "Unchecked.compare&lt;&#39;T&gt; Function (F#)"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-fsharp"
ms.tgt_pltfrm: na
ms.topic: "reference"
apiname: 
  - "Unchecked.compare<'T>"
apilocation: 
  - "FSharp.Core.dll"
apitype: "Assembly"
f1_keywords: 
  - "Microsoft.FSharp.Core.Operators.Unchecked.Compare``1"
dev_langs: 
  - "FSharp"
helpviewer_keywords: 
  - "Unchecked.compare function [F#]"
  - "compare function [F#]"
ms.assetid: 0d9da403-7b73-4222-b4e9-90953be16d2e
caps.latest.revision: 20
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Unchecked.compare&lt;&#39;T&gt; Function (F#)
Perform generic comparison on two values where the type of the values is not statically required to have the comparison constraint.  
  
 **Namespace/Module Path:** Microsoft.FSharp.Core.Operators.Unchecked  
  
 **Assembly:** FSharp.Core (in FSharp.Core.dll)  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 Type: <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
  
 The first value to compare.  
  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 Type: <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
  
 The second value to compare.  
  
## Return Value  
 The result of the comparison. The result follows the convention for comparison results: -1 if <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> is less then <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>; 1 if <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> is greater than <CodeContentPlaceHolder>8\</CodeContentPlaceHolder>; 0 if they are equal.  
  
## Remarks  
 This function is named <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> in compiled assemblies. If you are accessing the function from a language other than F#, or through reflection, use this name.  
  
## Platforms  
 Windows 8, Windows 7, Windows Server 2012, Windows Server 2008 R2  
  
## Version Information  
 **F# Core Library Versions**  
  
 Supported in: 2.0, 4.0, Portable, Portable  
  
## See Also  
 [Operators.Unchecked Module (F#)](../vs140/operators.unchecked-module--fsharp-.md)   
 [Microsoft.FSharp.Core.Operators Namespace (F#)](../vs140/core.operators-module--fsharp-.md)