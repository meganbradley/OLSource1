---
title: "Core.Choice&lt;&#39;T1,&#39;T2,&#39;T3&gt; Union (F#)"
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
  - "Core.Choice<'T1,'T2,'T3> Union (F#)"
apilocation: 
  - "FSharp.Core.dll"
apitype: "Assembly"
f1_keywords: 
  - "Microsoft.FSharp.Core.FSharpChoice`3"
dev_langs: 
  - "FSharp"
helpviewer_keywords: 
  - "Choice2of3 union case [F#]"
  - "FSharpChoice union [F#]"
  - "Choice3of3 union case [F#]"
  - "Choice1of3 union case [F#]"
  - "Choice union [F#]"
ms.assetid: 481a9fd9-e117-41b6-b53e-362ecd820cbc
caps.latest.revision: 22
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Core.Choice&lt;&#39;T1,&#39;T2,&#39;T3&gt; Union (F#)
Helper types for active patterns with three choices.  
  
 **Namespace/Module Path:** Microsoft.FSharp.Core  
  
 **Assembly:** FSharp.Core (in FSharp.Core.dll)  
  
## Syntax  
  
```  
[<StructuralEquality>]  
[<StructuralComparison>]  
type Choice<'T1,'T2,'T3> =  
| Choice1Of3 of 'T1  
| Choice2Of3 of 'T2  
| Choice3Of3 of 'T3  
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
|Choice1Of3 of 'T1|The first choice.|  
|Choice2Of3 of 'T2|The second choice.|  
|Choice3Of3 of 'T3|The third choice.|  
  
## Platforms  
 Windows 8, Windows 7, Windows Server 2012, Windows Server 2008 R2  
  
## Version Information  
 **F# Core Library Versions**  
  
 Supported in: 2.0, 4.0, Portable  
  
## See Also  
 [Microsoft.FSharp.Core Namespace (F#)](../VS_csharp/microsoft.fsharp.core-namespace--fsharp-.md)