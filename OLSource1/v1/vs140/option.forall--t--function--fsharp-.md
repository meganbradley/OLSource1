---
title: "Option.forall&lt;&#39;T&gt; Function (F#)"
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
  - "Option.forall<'T>"
apilocation: 
  - "FSharp.Core.dll"
apitype: "Assembly"
f1_keywords: 
  - "Microsoft.FSharp.Core.OptionModule.ForAll``1"
dev_langs: 
  - "FSharp"
helpviewer_keywords: 
  - "Option.forall function [F#]"
  - "forall function [F#]"
ms.assetid: ba884586-5eae-49c5-9e36-05481c1c3428
caps.latest.revision: 25
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Option.forall&lt;&#39;T&gt; Function (F#)
Evaluates the equivalent of [List.forall](../vs140/list.forall--t--function--fsharp-.md) for an option type.  
  
 **Namespace/Module Path**: Microsoft.FSharp.Core.Option  
  
 **Assembly**: FSharp.Core (in FSharp.Core.dll)  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 Type: <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>[bool](../vs140/core.bool-type-abbreviation--fsharp-.md)  
  
 A function that evaluates to a Boolean when given a value from the option type.  
  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 Type: <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>[option](../vs140/core.option--t--union--fsharp-.md)  
  
 The input option.  
  
## Return Value  
 <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> if the option is <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>, otherwise it returns the result of applying the predicate to the option value.  
  
## Remarks  
 The expression <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> evaluates to <CodeContentPlaceHolder>8\</CodeContentPlaceHolder>.  
  
 This function is named <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> in compiled assemblies. If you are accessing the function from a language other than F#, or through reflection, use this name.  
  
## Example  
 The following code illustrates the use of <CodeContentPlaceHolder>10\</CodeContentPlaceHolder>.  
  
 [!code[FsOptions#6](../vs140/codesnippet/FSharp/option.forall--t--function--fsharp-_1.fs)]  
  
 **Output**  
  
 **truetruefalsefalsetruefalse**   
## Platforms  
 Windows 8, Windows 7, Windows Server 2012, Windows Server 2008 R2  
  
## Version Information  
 **F# Core Library Versions**  
  
 Supported in: 2.0, 4.0, Portable  
  
## See Also  
 [Core.Option Module (F#)](../vs140/core.option-module--fsharp-.md)   
 [Microsoft.FSharp.Core Namespace (F#)](../vs140/microsoft.fsharp.core-namespace--fsharp-.md)