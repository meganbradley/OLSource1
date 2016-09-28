---
title: "Core.Choice&lt;&#39;T1,&#39;T2,&#39;T3,&#39;T4&gt; Union (F#)"
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
  - "Core.Choice<'T1,'T2,'T3,'T4> Union (F#)"
apilocation: 
  - "FSharp.Core.dll"
apitype: "Assembly"
f1_keywords: 
  - "Microsoft.FSharp.Core.FSharpChoice`4"
dev_langs: 
  - "FSharp"
helpviewer_keywords: 
  - "Choice1of4 union case [F#]"
  - "FSharpChoice union [F#]"
  - "Choice2of4 union case [F#]"
  - "Choice4of4 union case [F#]"
  - "Choice union [F#]"
  - "Choice3of4 union case [F#]"
ms.assetid: 26cf61c5-4ed8-44d2-a6a4-7b2618b8c9d5
caps.latest.revision: 22
author: ""
ms.author: ""
manager: ""
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Core.Choice&lt;&#39;T1,&#39;T2,&#39;T3,&#39;T4&gt; Union (F#)
Helper types for active patterns with four choices.  
  
 **Namespace/Module Path:** Microsoft.FSharp.Core  
  
 **Assembly:** FSharp.Core (in FSharp.Core.dll)  
  
## Syntax  
  
```  
[<StructuralEquality>]  
[<StructuralComparison>]  
type Choice<'T1,'T2,'T3,'T4> =  
| Choice1Of4 of 'T1  
| Choice2Of4 of 'T2  
| Choice3Of4 of 'T3  
| Choice4Of4 of 'T4  
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
|Choice1Of4 of 'T1|The first choice.|  
|Choice2Of4 of 'T2|The second choice.|  
|Choice3Of4 of 'T3|The third choice.|  
|Choice4Of4 of 'T4|The fourth choice.|  
  
## Platforms  
 Windows 8, Windows 7, Windows Server 2012, Windows Server 2008 R2  
  
## Version Information  
 **F# Core Library Versions**  
  
 Supported in: 2.0, 4.0, Portable  
  
## See Also  
 [Microsoft.FSharp.Core Namespace (F#)](../vs140/microsoft.fsharp.core-namespace--fsharp-.md)