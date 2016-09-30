---
title: "Threading.CancellationTokenSource Class (F#)"
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
  - "Threading.CancellationTokenSource"
apilocation: 
  - "FSharp.Core.dll"
apitype: "Assembly"
f1_keywords: 
  - "System.Threading.CancellationTokenSource"
dev_langs: 
  - "FSharp"
helpviewer_keywords: 
  - "CancellationTokenSource class [F#]"
ms.assetid: 0aba0101-26eb-41d9-bffc-8b536b1581e8
caps.latest.revision: 23
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Threading.CancellationTokenSource Class (F#)
Signals to a `CancellationToken` that it should be cancelled.  
  
 **Namespace/Module Path**: System.Threading  
  
 **Assembly**: FSharp.Core (in FSharp.Core.dll)  
  
## Syntax  
  
```  
[<Sealed>]  
[<AllowNullLiteral>]  
type CancellationTokenSource =  
 class  
  interface IDisposable  
  new CancellationTokenSource : unit -> CancellationTokenSource  
  member this.Cancel : unit -> unit  
  static member CreateLinkedTokenSource : CancellationToken * CancellationToken -> CancellationTokenSource  
  member this.Dispose : unit -> unit  
  member this.Token :  CancellationToken  
 end  
```  
  
## Remarks  
 This type is provided for use only with the F# Core Library Versions that targets .NET Framework 2.0. If you are using .NET Framework 4, use the .NET Framework 4 type with the same name, \<xref:System.Threading.CancellationTokenSource*>.  
  
## Constructors  
  
|Member|Description|  
|------------|-----------------|  
|[new](../vs140/threading.cancellationtokensource-constructor--fsharp-.md)|Creates a new cancellation capability.|  
  
## Instance Members  
  
|Member|Description|  
|------------|-----------------|  
|[Cancel](../vs140/cancellationtokensource.cancel-method--fsharp-.md)|Cancels the operation.|  
|[Dispose](../vs140/cancellationtokensource.dispose-method--fsharp-.md)|Discards resources associated with this capability.|  
|[Token](../vs140/cancellationtokensource.token-property--fsharp-.md)|Fetches the token representing the capability to detect cancellation of an operation.|  
  
## Static Members  
  
|Member|Description|  
|------------|-----------------|  
|[CreateLinkedTokenSource](../vs140/cancellationtokensource.createlinkedtokensource-method--fsharp-.md)|Creates a cancellation capability linking two tokens.|  
  
## Platforms  
 Windows 8, Windows 7, Windows Server 2012, Windows Server 2008 R2  
  
## Version Information  
 **F# Core Library Versions**  
  
 Supported in: 2.0  
  
## See Also  
 [System.Threading Namespace (F#)](../vs140/system.threading-namespace--fsharp-.md)