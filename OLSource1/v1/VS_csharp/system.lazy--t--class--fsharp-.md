---
title: "System.Lazy&lt;&#39;T&gt; Class (F#)"
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
  - "System.Lazy<'T>"
apilocation: 
  - "FSharp.Core.dll"
apitype: "Assembly"
f1_keywords: 
  - "System.Lazy`1"
dev_langs: 
  - "FSharp"
helpviewer_keywords: 
  - "Lazy class [F#]"
ms.assetid: 0ad70644-137c-4a59-b125-163c489c07a6
caps.latest.revision: 23
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# System.Lazy&lt;&#39;T&gt; Class (F#)
Encapsulates a lazily computed value.  
  
 **Namespace/Module Path**: System  
  
 **Assembly**: FSharp.Core (in FSharp.Core.dll)  
  
## Syntax  
  
```  
[<AllowNullLiteral>]  
type Lazy<'T> =  
 class  
  member this.IsValueCreated :  bool  
  member this.Value :  'T  
 end  
```  
  
## Remarks  
 This type is provided for use only with the F# Core Library Versions that targets .NET Framework 2.0. If you are using .NET Framework 4, use the .NET Framework 4 type with the same name, <xref:System.Lazy`1*>.  
  
## Instance Members  
  
|Member|Description|  
|------------|-----------------|  
|[IsValueCreated](../VS_csharp/lazy.isvaluecreated--t--property--fsharp-.md)|Is true if the value is ready to be accessed.|  
|[Value](../VS_csharp/lazy.value--t--property--fsharp-.md)|The value contained in the Lazy.|  
  
## Platforms  
 Windows 8, Windows 7, Windows Server 2012, Windows Server 2008 R2  
  
## Version Information  
 **F# Core Library Versions**  
  
 Supported in: 2.0  
  
## See Also  
 [System Namespace (F#)](../VS_csharp/system-namespace--fsharp-.md)