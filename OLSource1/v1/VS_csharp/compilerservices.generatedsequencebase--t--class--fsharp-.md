---
title: "CompilerServices.GeneratedSequenceBase&lt;&#39;T&gt; Class (F#)"
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
  - "CompilerServices.GeneratedSequenceBase<'T>"
apilocation: 
  - "FSharp.Core.dll"
apitype: "Assembly"
f1_keywords: 
  - "Microsoft.FSharp.Core.CompilerServices.GeneratedSequenceBase`1"
dev_langs: 
  - "FSharp"
helpviewer_keywords: 
  - "GeneratedSequenceBase class [F#]"
ms.assetid: 5a3e7bd5-1414-4eeb-9b5c-7c17e6401556
caps.latest.revision: 23
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CompilerServices.GeneratedSequenceBase&lt;&#39;T&gt; Class (F#)
The F# compiler emits implementations of this type for compiled sequence expressions.  
  
 **Namespace/Module Path:** Microsoft.FSharp.Core.CompilerServices  
  
 **Assembly:** FSharp.Core (in FSharp.Core.dll)  
  
## Syntax  
  
```  
[<AbstractClass>]  
type GeneratedSequenceBase<'T> =  
 class  
  interface IEnumerator  
  interface IEnumerator  
  interface IEnumerable  
  interface IEnumerable  
  new GeneratedSequenceBase : unit -> GeneratedSequenceBase<'T>  
  abstract this.Close : unit -> unit  
  abstract this.GenerateNext : byref<IEnumerable<'T>> -> int  
  abstract this.GetFreshEnumerator : unit -> IEnumerator<'T>  
  abstract this.CheckClose :  bool  
  abstract this.LastGenerated :  'T  
 end  
```  
  
## Remarks  
  
## Constructors  
  
|Member|Description|  
|------------|-----------------|  
|[new](../VS_csharp/compilerservices.generatedsequencebase--t--constructor--fsharp-.md)|The F# compiler emits implementations of this type for compiled sequence expressions.|  
  
## Instance Members  
  
|Member|Description|  
|------------|-----------------|  
|[CheckClose](../VS_csharp/generatedsequencebase.checkclose--t--property--fsharp-.md)|The F# compiler emits implementations of this type for compiled sequence expressions.|  
|[Close](../VS_csharp/generatedsequencebase.close--t--method--fsharp-.md)|The F# compiler emits implementations of this type for compiled sequence expressions.|  
|[GenerateNext](../VS_csharp/generatedsequencebase.generatenext--t--method--fsharp-.md)|The F# compiler emits implementations of this type for compiled sequence expressions.|  
|[GetFreshEnumerator](../VS_csharp/generatedsequencebase.getfreshenumerator--t--method--fsharp-.md)|The F# compiler emits implementations of this type for compiled sequence expressions.|  
|[LastGenerated](../VS_csharp/generatedsequencebase.lastgenerated--t--property--fsharp-.md)|The F# compiler emits implementations of this type for compiled sequence expressions.|  
  
## Platforms  
 Windows 8, Windows 7, Windows Server 2012, Windows Server 2008 R2  
  
## Version Information  
 **F# Core Library Versions**  
  
 Supported in: 2.0, 4.0, Portable  
  
## See Also  
 [Microsoft.FSharp.Core.CompilerServices Namespace (F#)](../VS_csharp/microsoft.fsharp.core.compilerservices-namespace--fsharp-.md)