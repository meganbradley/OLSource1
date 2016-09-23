---
title: "Core.Choice&lt;&#39;T1,&#39;T2&gt; Union (F#)"
ms.custom: na
ms.date: 09/22/2016
ms.prod: visual-studio-dev14
ms.reviewer: na
ms.suite: na
ms.technology: 
  - devlang-fsharp
ms.tgt_pltfrm: na
ms.topic: reference
apiname: 
  - Core.Choice<'T1,'T2> Union (F#)
apilocation: 
  - FSharp.Core.dll
apitype: Assembly
f1_keywords: 
  - Microsoft.FSharp.Core.FSharpChoice`2
dev_langs: 
  - FSharp
helpviewer_keywords: 
  - FSharpChoice union [F#]
  - Choice1of2 union case [F#]
  - Choice union [F#]
  - Choice2of2 union case [F#]
ms.assetid: 2ab2513e-e307-4360-96cd-8b682a8d64f0
caps.latest.revision: 22
translation.priority.ht: 
  - de-de
  - ja-jp
---
# Core.Choice&lt;&#39;T1,&#39;T2&gt; Union (F#)
Helper types for active patterns with two choices.  
  
 **Namespace/Module Path**: Microsoft.FSharp.Core  
  
 **Assembly**: FSharp.Core (in FSharp.Core.dll)  
  
## Syntax  
  
```  
[<StructuralEquality>]  
[<StructuralComparison>]  
type Choice<'T1,'T2> =  
| Choice1Of2 of 'T1  
| Choice2Of2 of 'T2  
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
|Choice1Of2 of 'T1|The first choice.|  
|Choice2Of2 of 'T2|The second choice.|  
  
## Platforms  
 Windows 8, Windows 7, Windows Server 2012, Windows Server 2008 R2  
  
## Version Information  
 **F# Core Library Versions**  
  
 Supported in: 2.0, 4.0, Portable  
  
## See Also  
 [Microsoft.FSharp.Core Namespace (F#)](../vs140/microsoft.fsharp.core-namespace--fsharp-.md)