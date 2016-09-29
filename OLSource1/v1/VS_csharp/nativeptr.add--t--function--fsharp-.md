---
title: "NativePtr.add&lt;&#39;T&gt; Function (F#)"
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
  - "NativePtr.add<'T>"
apilocation: 
  - "FSharp.Core.dll"
apitype: "Assembly"
f1_keywords: 
  - "Microsoft.FSharp.NativeInterop.NativePtrModule.AddPointerInlined``1"
dev_langs: 
  - "FSharp"
helpviewer_keywords: 
  - "add function [F#]"
  - "NativePtr.AddPointerInlined function [F#]"
  - "AddPointerInlined function [F#]"
  - "NativePtr.add function [F#]"
ms.assetid: 851d713a-4b8d-42d6-961a-930355b038fe
caps.latest.revision: 20
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# NativePtr.add&lt;&#39;T&gt; Function (F#)
Returns a typed native pointer by adding an offset to the given input pointer.  
  
 **Namespace/Module Path:** Microsoft.FSharp.NativeInterop.NativePtr  
  
 **Assembly:** FSharp.Core (in FSharp.Core.dll)  
  
## Syntax  
  
```  
// Signature:  
NativePtr.add : nativeptr<'T> -> int -> nativeptr<'T> (requires unmanaged)  
  
// Usage:  
NativePtr.add address index  
```  
  
#### Parameters  
 `address`  
 Type: [nativeptr](../VS_csharp/core.nativeptr--t--type--fsharp-.md)`<'T>`  
  
 The input pointer.  
  
 `index`  
 Type: [int](../VS_csharp/core.int-type-abbreviation--fsharp-.md)  
  
 The index by which to offset the pointer.  
  
## Return Value  
 A typed pointer.  
  
## Remarks  
 The pointer address is offset by `index * sizeof<'T>.`  
  
 This function is named `AddPointerInlined` in compiled assemblies. If you are accessing the function from a language other than F#, or through reflection, use this name.  
  
## Platforms  
 Windows 8, Windows 7, Windows Server 2012, Windows Server 2008 R2  
  
## Version Information  
 **F# Core Library Versions**  
  
 Supported in: 2.0, 4.0, Portable  
  
## See Also  
 [NativeInterop.NativePtr Module (F#)](../VS_csharp/nativeinterop.nativeptr-module--fsharp-.md)   
 [Microsoft.FSharp.NativeInterop Namespace (F#)](../VS_csharp/microsoft.fsharp.nativeinterop-namespace--fsharp-.md)