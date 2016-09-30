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
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 Type: [nativeptr](../vs140/core.nativeptr--t--type--fsharp-.md)<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
  
 The input pointer.  
  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 Type: [int](../vs140/core.int-type-abbreviation--fsharp-.md)  
  
 The index by which to offset the pointer.  
  
## Return Value  
 A typed pointer.  
  
## Remarks  
 The pointer address is offset by <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
  
 This function is named <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> in compiled assemblies. If you are accessing the function from a language other than F#, or through reflection, use this name.  
  
## Platforms  
 Windows 8, Windows 7, Windows Server 2012, Windows Server 2008 R2  
  
## Version Information  
 **F# Core Library Versions**  
  
 Supported in: 2.0, 4.0, Portable  
  
## See Also  
 [NativeInterop.NativePtr Module (F#)](../vs140/nativeinterop.nativeptr-module--fsharp-.md)   
 [Microsoft.FSharp.NativeInterop Namespace (F#)](../vs140/microsoft.fsharp.nativeinterop-namespace--fsharp-.md)