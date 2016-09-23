---
title: "Core.Choice&lt;&#39;T1,&#39;T2,&#39;T3,&#39;T4,&#39;T5,&#39;T6&gt; Union (F#)"
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
  - Core.Choice<'T1,'T2,'T3,'T4,'T5,'T6> Union (F#)
apilocation: 
  - FSharp.Core.dll
apitype: Assembly
f1_keywords: 
  - Microsoft.FSharp.Core.FSharpChoice`6
dev_langs: 
  - FSharp
helpviewer_keywords: 
  - Choice1of6 union case [F#]
  - FSharpChoice union [F#]
  - Choice4of6 union case [F#]
  - Choice5of6 union case [F#]
  - Choice union [F#]
  - Choice3of6 union case [F#]
  - Choice2of6 union case [F#]
  - Choice6of6 union case [F#]
ms.assetid: 5964378a-8181-4cdc-bc91-b301ea442e57
caps.latest.revision: 22
translation.priority.ht: 
  - de-de
  - ja-jp
---
# Core.Choice&lt;&#39;T1,&#39;T2,&#39;T3,&#39;T4,&#39;T5,&#39;T6&gt; Union (F#)
Helper types for active patterns with six choices.  
  
 **Namespace/Module Path:** Microsoft.FSharp.Core  
  
 **Assembly:** FSharp.Core (in FSharp.Core.dll)  
  
## Syntax  
  
```  
[<StructuralEquality>]  
[<StructuralComparison>]  
type Choice<'T1,'T2,'T3,'T4,'T5,'T6> =  
| Choice1Of6 of 'T1  
| Choice2Of6 of 'T2  
| Choice3Of6 of 'T3  
| Choice4Of6 of 'T4  
| Choice5Of6 of 'T5  
| Choice6Of6 of 'T6  
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
|Choice1Of6 of 'T1|The first choice.|  
|Choice2Of6 of 'T2|The second choice.|  
|Choice3Of6 of 'T3|The third choice.|  
|Choice4Of6 of 'T4|The fourth choice.|  
|Choice5Of6 of 'T5|The fifth choice.|  
|Choice6Of6 of 'T6|The sixth choice.|  
  
## Platforms  
 Windows 8, Windows 7, Windows Server 2012, Windows Server 2008 R2  
  
## Version Information  
 **F# Core Library Versions**  
  
 Supported in: 2.0, 4.0, Portable  
  
## See Also  
 [Microsoft.FSharp.Core Namespace (F#)](../vs140/microsoft.fsharp.core-namespace--fsharp-.md)