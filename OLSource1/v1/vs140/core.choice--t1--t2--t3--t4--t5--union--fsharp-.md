---
title: "Core.Choice&lt;&#39;T1,&#39;T2,&#39;T3,&#39;T4,&#39;T5&gt; Union (F#)"
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
  - "Core.Choice<'T1,'T2,'T3,'T4,'T5> Union (F#)"
apilocation: 
  - "FSharp.Core.dll"
apitype: "Assembly"
f1_keywords: 
  - "Microsoft.FSharp.Core.FSharpChoice`5"
dev_langs: 
  - "FSharp"
helpviewer_keywords: 
  - "Choice5of5 union case [F#]"
  - "FSharpChoice union [F#]"
  - "Choice3of5 union case [F#]"
  - "Choice4of5 union case [F#]"
  - "Choice union [F#]"
  - "Choice2of5 union case [F#]"
  - "Choice1of5 union case [F#]"
ms.assetid: 7ffee923-d523-478b-96b5-3b960f604c9f
caps.latest.revision: 22
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Core.Choice&lt;&#39;T1,&#39;T2,&#39;T3,&#39;T4,&#39;T5&gt; Union (F#)
Helper types for active patterns with five choices.  
  
 **Namespace/Module Path:** Microsoft.FSharp.Core  
  
 **Assembly:** FSharp.Core (in FSharp.Core.dll)  
  
## Syntax  
  
```  
[<StructuralEquality>]  
[<StructuralComparison>]  
type Choice<'T1,'T2,'T3,'T4,'T5> =  
| Choice1Of5 of 'T1  
| Choice2Of5 of 'T2  
| Choice3Of5 of 'T3  
| Choice4Of5 of 'T4  
| Choice5Of5 of 'T5  
 with  
  interface IStructuralEquatable  
  interface IComparable  
  interface IComparable  
  interface IStructuralComparable  
 end  
```  
  
## Remarks  
  
## Union Cases  
  
|Case|Description|  
|----------|-----------------|  
|Choice1Of5 of 'T1|The first choice.|  
|Choice2Of5 of 'T2|The second choice.|  
|Choice3Of5 of 'T3|The third choice.|  
|Choice4Of5 of 'T4|The fourth choice.|  
|Choice5Of5 of 'T5|The fifth choice.|  
  
## Platforms  
 Windows 8, Windows 7, Windows Server 2012, Windows Server 2008 R2  
  
## Version Information  
 **F# Core Library Versions**  
  
 Supported in: 2.0, 4.0, Portable  
  
## See Also  
 [Microsoft.FSharp.Core Namespace (F#)](../vs140/microsoft.fsharp.core-namespace--fsharp-.md)