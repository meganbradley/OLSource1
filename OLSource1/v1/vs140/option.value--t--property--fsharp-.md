---
title: "Option.Value&lt;&#39;T&gt; Property (F#)"
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
  - "Option.Value<'T>"
apilocation: 
  - "FSharp.Core.dll"
apitype: "Assembly"
f1_keywords: 
  - "Microsoft.FSharp.Core.FSharpOption`1.Value"
dev_langs: 
  - "FSharp"
helpviewer_keywords: 
  - "Option.Value property [F#]"
  - "Value property [F#]"
ms.assetid: c79f68e8-11fd-45b1-a053-e8fc38b56df7
caps.latest.revision: 22
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Option.Value&lt;&#39;T&gt; Property (F#)
Get the value of a `Some` option. A \<xref:System.NullReferenceException*> is raised if the option is `None`.  
  
 **Namespace/Module Path:** Microsoft.FSharp.Core  
  
 **Assembly:** FSharp.Core (in FSharp.Core.dll)  
  
## Syntax  
  
```  
// Signature:  
member this.Value :  'T  
  
// Usage:  
option.Value  
```  
  
## Return Value  
  
## Remarks  
 This function is for use by compiled F# code and should not be used directly.  
  
## Platforms  
 Windows 8, Windows 7, Windows Server 2012, Windows Server 2008 R2  
  
## Version Information  
 **F# Core Library Versions**  
  
 Supported in: 2.0, 4.0, Portable  
  
## See Also  
 [Core.Option\<'T> Union (F#)](../vs140/core.option--t--union--fsharp-.md)   
 [Microsoft.FSharp.Core Namespace (F#)](../vs140/microsoft.fsharp.core-namespace--fsharp-.md)