---
title: "Threading.CancellationToken Structure (F#)"
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
  - "Threading.CancellationToken"
apilocation: 
  - "FSharp.Core.dll"
apitype: "Assembly"
f1_keywords: 
  - "System.Threading.CancellationToken"
dev_langs: 
  - "FSharp"
helpviewer_keywords: 
  - "CancellationToken structure [F#]"
ms.assetid: 31a3eafe-b61b-46c4-927d-bc9a3ae357c2
caps.latest.revision: 22
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Threading.CancellationToken Structure (F#)
Represents a capability to detect cancellation of an operation.  
  
 **Namespace/Module Path**: System.Threading  
  
 **Assembly**: FSharp.Core (in FSharp.Core.dll)  
  
## Syntax  
  
```  
[<CustomEquality>]  
[<NoComparison>]  
type CancellationToken =  
 struct  
  member this.Equals : CancellationToken -> bool  
  member this.Register : Action<obj> * obj -> CancellationTokenRegistration  
  member this.IsCancellationRequested :  bool  
  static member ( = ) : CancellationToken * CancellationToken -> bool  
  static member ( <> ) : CancellationToken * CancellationToken -> bool  
 end  
```  
  
## Remarks  
 This type is provided for use only with the F# Core Library Versions that targets .NET Framework 2.0. If you are using .NET Framework 4, use the .NET Framework 4 type with the same name, <xref:System.Threading.CancellationToken*>.  
  
## Instance Members  
  
|Member|Description|  
|------------|-----------------|  
|[Equals](../vs140/cancellationtoken.equals-method--fsharp-.md)|Equality comparison against another token.|  
|[IsCancellationRequested](../vs140/cancellationtoken.iscancellationrequested-property--fsharp-.md)|Flags whether an operation should be cancelled.|  
|[Register](../vs140/cancellationtoken.register-method--fsharp-.md)|Registers an action to perform with the CancellationToken.|  
  
## Static Members  
  
|Member|Description|  
|------------|-----------------|  
|[( <> )](../vs140/cancellationtoken.-------method--fsharp-.md)|Inequality operator for tokens.|  
|[( = )](../vs140/cancellationtoken.--=---method--fsharp-.md)|Equality operator for tokens.|  
  
## Platforms  
 Windows 8, Windows 7, Windows Server 2012, Windows Server 2008 R2  
  
## Version Information  
 **F# Core Library Versions**  
  
 Supported in: 2.0  
  
## See Also  
 [System.Threading Namespace (F#)](../vs140/system.threading-namespace--fsharp-.md)