---
title: "System.Tuple&lt;&#39;T1,&#39;T2,&#39;T3,&#39;T4,&#39;T5,&#39;T6,&#39;T7,&#39;TRest&gt; Class (F#)"
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
  - "System.Tuple<'T1,'T2,'T3,'T4,'T5,'T6,'T7,'TRest>"
apilocation: 
  - "FSharp.Core.dll"
apitype: "Assembly"
f1_keywords: 
  - "System.Tuple`8"
dev_langs: 
  - "FSharp"
helpviewer_keywords: 
  - "Tuple class [F#]"
ms.assetid: 8e191b64-0a93-4b47-973c-b92ac5726116
caps.latest.revision: 22
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# System.Tuple&lt;&#39;T1,&#39;T2,&#39;T3,&#39;T4,&#39;T5,&#39;T6,&#39;T7,&#39;TRest&gt; Class (F#)
**Namespace/Module Path**: System  
  
 **Assembly**: FSharp.Core (in FSharp.Core.dll)  
  
## Syntax  
  
```  
type Tuple<'T1,'T2,'T3,'T4,'T5,'T6,'T7,'TRest> =  
 class  
  interface IComparable  
  interface IStructuralComparable  
  interface IStructuralEquatable  
  new Tuple : 'T1 * 'T2 * 'T3 * 'T4 * 'T5 * 'T6 * 'T7 * 'TRest -> Tuple<'T1,'T2,'T3,'T4,'T5,'T6,'T7,'TRest>  
  member this.Item1 :  'T1  
  member this.Item2 :  'T2  
  member this.Item3 :  'T3  
  member this.Item4 :  'T4  
  member this.Item5 :  'T5  
  member this.Item6 :  'T6  
  member this.Item7 :  'T7  
  member this.Rest :  'TRest  
 end  
```  
  
## Remarks  
 This type is provided for use only with the F# Core Library Versions that targets .NET Framework 2.0. If you are using .NET Framework 4, use the .NET Framework 4 type with the same name, <xref:System.Tuple`8*>.  
  
## Constructors  
  
|Member|Description|  
|------------|-----------------|  
|[new](../VS_csharp/system.tuple--t1--t2--t3--t4--t5--t6--t7--trest--constructor--fsharp-.md)||  
  
## Instance Members  
  
|Member|Description|  
|------------|-----------------|  
|[Item1](../VS_csharp/tuple.item1--t1--t2--t3--t4--t5--t6--t7--trest--property--fsharp-.md)||  
|[Item2](../VS_csharp/tuple.item2--t1--t2--t3--t4--t5--t6--t7--trest--property--fsharp-.md)||  
|[Item3](../VS_csharp/tuple.item3--t1--t2--t3--t4--t5--t6--t7--trest--property--fsharp-.md)||  
|[Item4](../VS_csharp/tuple.item4--t1--t2--t3--t4--t5--t6--t7--trest--property--fsharp-.md)||  
|[Item5](../VS_csharp/tuple.item5--t1--t2--t3--t4--t5--t6--t7--trest--property--fsharp-.md)||  
|[Item6](../VS_csharp/tuple.item6--t1--t2--t3--t4--t5--t6--t7--trest--property--fsharp-.md)||  
|[Item7](../VS_csharp/tuple.item7--t1--t2--t3--t4--t5--t6--t7--trest--property--fsharp-.md)||  
|[Rest](../VS_csharp/tuple.rest--t1--t2--t3--t4--t5--t6--t7--trest--property--fsharp-.md)||  
  
## Platforms  
 Windows 8, Windows 7, Windows Server 2012, Windows Server 2008 R2  
  
## Version Information  
 **F# Core Library Versions**  
  
 Supported in: 2.0  
  
## See Also  
 [System Namespace (F#)](../VS_csharp/system-namespace--fsharp-.md)