---
title: "Core.Ref&lt;&#39;T&gt; Record (F#)"
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
  - "Core.Ref<'T>"
apilocation: 
  - "FSharp.Core.dll"
apitype: "Assembly"
f1_keywords: 
  - "Microsoft.FSharp.Core.FSharpRef`1"
dev_langs: 
  - "FSharp"
helpviewer_keywords: 
  - "FSharpRef record [F#]"
  - "Ref record [F#]"
ms.assetid: d816cd68-043d-4f2f-a8a1-01c3bb78f93d
caps.latest.revision: 26
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Core.Ref&lt;&#39;T&gt; Record (F#)
The type of mutable references. Use the operators  `:=` and `!` to get and set values of this type.  
  
 **Namespace/Module Path:** Microsoft.FSharp.Core  
  
 **Assembly:** FSharp.Core (in FSharp.Core.dll)  
  
## Syntax  
  
```  
[<StructuralEquality>]  
[<StructuralComparison>]  
type Ref<'T> =  
 { mutable contents : 'T }  
 with  
  interface IStructuralEquatable  
  interface IComparable  
  interface IComparable  
  interface IStructuralComparable  
  member this.Value :  'T with get, set  
 end  
```  
  
## Remarks  
 For an overview of reference cells, see [Reference Cells (F#)](../vs140/reference-cells--fsharp-.md).  
  
 This type is named `FSharpRef` in compiled assemblies. If you are accessing the type from a language other than F#, or through reflection, use this name.  
  
## Fields  
  
|Field|Description|  
|-----------|-----------------|  
|`contents`|**Type**: `'T`<br /><br /> The current value of the reference cell.|  
  
## Instance Members  
  
|Member|Description|  
|------------|-----------------|  
|[Value](../vs140/ref.value--t--property--fsharp-.md)|The current value of the reference cell|  
  
## Platforms  
 Windows 8, Windows 7, Windows Server 2012, Windows Server 2008 R2  
  
## Version Information  
 **F# Core Library Versions**  
  
 Supported in: 2.0, 4.0, Portable  
  
## See Also  
 [Microsoft.FSharp.Core Namespace (F#)](../vs140/microsoft.fsharp.core-namespace--fsharp-.md)