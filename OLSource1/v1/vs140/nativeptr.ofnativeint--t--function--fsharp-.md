---
title: "NativePtr.ofNativeInt&lt;&#39;T&gt; Function (F#)"
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
  - NativePtr.of_nativeint<'T>
apilocation: 
  - FSharp.Core.dll
apitype: Assembly
f1_keywords: 
  - Microsoft.FSharp.NativeInterop.NativePtrModule.OfNativeIntInlined``1
dev_langs: 
  - FSharp
helpviewer_keywords: 
  - NativePtr.FromNativeIntInlined function [F#]
  - NativePtr.ofNativeInt function [F#]
  - FromNativeIntInlined function [F#]
  - ofNativeInt function [F#]
ms.assetid: e813513b-cf42-41e9-ba08-e1a4def9fe8c
caps.latest.revision: 20
translation.priority.ht: 
  - de-de
  - ja-jp
---
# NativePtr.ofNativeInt&lt;&#39;T&gt; Function (F#)
Returns a typed native pointer for a given machine address.  
  
 **Namespace/Module Path:** Microsoft.FSharp.NativeInterop.NativePtr  
  
 **Assembly:** FSharp.Core (in FSharp.Core.dll)  
  
## Syntax  
  
```  
// Signature:  
NativePtr.ofNativeInt : nativeint -> nativeptr<'T> (requires unmanaged)  
  
// Usage:  
NativePtr.ofNativeInt address  
```  
  
#### Parameters  
 `address`  
 Type: [nativeint](../vs140/core.nativeint-type-abbreviation--fsharp-.md)  
  
 The pointer address.  
  
## Return Value  
 A typed pointer.  
  
## Remarks  
 This function is named `OfNativeIntInlined` in compiled assemblies. If you are accessing the member from a language other than F#, or through reflection, use this name.  
  
## Platforms  
 Windows 8, Windows 7, Windows Server 2012, Windows Server 2008 R2  
  
## Version Information  
 **F# Core Library Versions**  
  
 Supported in: 2.0, 4.0, Portable  
  
## See Also  
 [NativeInterop.NativePtr Module (F#)](../vs140/nativeinterop.nativeptr-module--fsharp-.md)   
 [Microsoft.FSharp.NativeInterop Namespace (F#)](../vs140/microsoft.fsharp.nativeinterop-namespace--fsharp-.md)