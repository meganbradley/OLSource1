---
title: "Option.map&lt;&#39;T,&#39;U&gt; Function (F#)"
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
  - "Option.map<'T,'U>"
apilocation: 
  - "FSharp.Core.dll"
apitype: "Assembly"
f1_keywords: 
  - "Microsoft.FSharp.Core.OptionModule.Map``2"
dev_langs: 
  - "FSharp"
helpviewer_keywords: 
  - "map function [F#]"
  - "Option.map function [F#]"
ms.assetid: 91a20385-7e73-40c2-9adc-635e86d6a622
caps.latest.revision: 22
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Option.map&lt;&#39;T,&#39;U&gt; Function (F#)
Transforms an option value by using a specified mapping function.  
  
 **Namespace/Module Path**: Microsoft.FSharp.Core.Option  
  
 **Assembly**: FSharp.Core (in FSharp.Core.dll)  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 Type: <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
  
 A function to apply to the option value.  
  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 Type: <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> [option](../vs140/core.option--t--union--fsharp-.md)  
  
 The input option.  
  
## Return Value  
 An option of the result of applying the mapping function, or <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> if the input is <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>.  
  
## Remarks  
 The expression <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> evaluates to <CodeContentPlaceHolder>8\</CodeContentPlaceHolder>.  
  
 This function is named <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> in compiled assemblies. If you are accessing the function from a language other than F#, or through reflection, use this name.  
  
## Platforms  
 Windows 8, Windows 7, Windows Server 2012, Windows Server 2008 R2  
  
## Version Information  
 **F# Core Library Versions**  
  
 Supported in: 2.0, 4.0, Portable, Portable  
  
## See Also  
 [Core.Option Module (F#)](../vs140/core.option-module--fsharp-.md)   
 [Microsoft.FSharp.Core Namespace (F#)](../vs140/microsoft.fsharp.core-namespace--fsharp-.md)