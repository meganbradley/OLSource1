---
title: "System.Tuple&lt;&#39;T1,&#39;T2,&#39;T3,&#39;T4,&#39;T5,&#39;T6&gt; Class (F#)"
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
  - System.Tuple<'T1,'T2,'T3,'T4,'T5,'T6>
apilocation: 
  - FSharp.Core.dll
apitype: Assembly
f1_keywords: 
  - System.Tuple`6
dev_langs: 
  - FSharp
helpviewer_keywords: 
  - Tuple class [F#]
ms.assetid: 3e4a07fc-8f49-4e17-9e75-a11c5ca71707
caps.latest.revision: 22
translation.priority.ht: 
  - de-de
  - ja-jp
---
# System.Tuple&lt;&#39;T1,&#39;T2,&#39;T3,&#39;T4,&#39;T5,&#39;T6&gt; Class (F#)
**Namespace/Module Path**: System  
  
 **Assembly**: FSharp.Core (in FSharp.Core.dll)  
  
## Syntax  
  
```  
type Tuple<'T1,'T2,'T3,'T4,'T5,'T6> =  
 class  
  interface IComparable  
  interface IStructuralComparable  
  interface IStructuralEquatable  
  new Tuple : 'T1 * 'T2 * 'T3 * 'T4 * 'T5 * 'T6 -> Tuple<'T1,'T2,'T3,'T4,'T5,'T6>  
  member this.Item1 :  'T1  
  member this.Item2 :  'T2  
  member this.Item3 :  'T3  
  member this.Item4 :  'T4  
  member this.Item5 :  'T5  
  member this.Item6 :  'T6  
 end  
```  
  
## Remarks  
 This type is provided for use only with the F# Core Library Versions that targets .NET Framework 2.0. If you are using .NET Framework 4, use the .NET Framework 4 type with the same name, <xref:System.Tuple`6?qualifyHint=False>.  
  
## Constructors  
  
|Member|Description|  
|------------|-----------------|  
|[new](../vs140/system.tuple--t1--t2--t3--t4--t5--t6--constructor--fsharp-.md)||  
  
## Instance Members  
  
|Member|Description|  
|------------|-----------------|  
|[Item1](../vs140/tuple.item1--t1--t2--t3--t4--t5--t6--property--fsharp-.md)||  
|[Item2](../vs140/tuple.item2--t1--t2--t3--t4--t5--t6--property--fsharp-.md)||  
|[Item3](../vs140/tuple.item3--t1--t2--t3--t4--t5--t6--property--fsharp-.md)||  
|[Item4](../vs140/tuple.item4--t1--t2--t3--t4--t5--t6--property--fsharp-.md)||  
|[Item5](../vs140/tuple.item5--t1--t2--t3--t4--t5--t6--property--fsharp-.md)||  
|[Item6](../vs140/tuple.item6--t1--t2--t3--t4--t5--t6--property--fsharp-.md)||  
  
## Platforms  
 Windows 8, Windows 7, Windows Server 2012, Windows Server 2008 R2  
  
## Version Information  
 **F# Core Library Versions**  
  
 Supported in: 2.0  
  
## See Also  
 [System Namespace (F#)](../vs140/system-namespace--fsharp-.md)