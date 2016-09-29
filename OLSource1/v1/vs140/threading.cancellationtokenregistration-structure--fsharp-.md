---
title: "Threading.CancellationTokenRegistration Structure (F#)"
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
  - "Threading.CancellationTokenRegistration"
apilocation: 
  - "FSharp.Core.dll"
apitype: "Assembly"
f1_keywords: 
  - "System.Threading.CancellationTokenRegistration"
dev_langs: 
  - "FSharp"
helpviewer_keywords: 
  - "CancellationTokenRegistration structure [F#]"
ms.assetid: 9696e15c-a160-4336-9c5c-6277eaa1e1d1
caps.latest.revision: 22
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Threading.CancellationTokenRegistration Structure (F#)
Represents a registration to a Cancellation token source.  
  
 **Namespace/Module Path**: System.Threading  
  
 **Assembly**: FSharp.Core (in FSharp.Core.dll)  
  
## Syntax  
  
```  
[<CustomEquality>]  
[<NoComparison>]  
type CancellationTokenRegistration =  
 struct  
  interface IDisposable  
  member this.Dispose : unit -> unit  
  member this.Equals : CancellationTokenRegistration -> bool  
  static member ( = ) : CancellationTokenRegistration * CancellationTokenRegistration -> bool  
  static member ( <> ) : CancellationTokenRegistration * CancellationTokenRegistration -> bool  
 end  
```  
  
## Remarks  
 This type is provided for use only with the F# Core Library Versions that targets .NET Framework 2.0. If you are using .NET Framework 4, use the .NET Framework 4 type with the same name, <xref:System.Threading.CancellationTokenRegistration*>.  
  
## Instance Members  
  
|Member|Description|  
|------------|-----------------|  
|[Dispose](../vs140/cancellationtokenregistration.dispose-method--fsharp-.md)|Frees resources associated with the registration.|  
|[Equals](../vs140/cancellationtokenregistration.equals-method--fsharp-.md)|Equality comparison against another registration.|  
  
## Static Members  
  
|Member|Description|  
|------------|-----------------|  
|[( <> )](../vs140/cancellationtokenregistration.-------method--fsharp-.md)|Inequality operator for registrations.|  
|[( = )](../vs140/cancellationtokenregistration.--=---method--fsharp-.md)|Equality operator for registrations.|  
  
## Platforms  
 Windows 8, Windows 7, Windows Server 2012, Windows Server 2008 R2  
  
## Version Information  
 **F# Core Library Versions**  
  
 Supported in: 2.0  
  
## See Also  
 [System.Threading Namespace (F#)](../vs140/system.threading-namespace--fsharp-.md)