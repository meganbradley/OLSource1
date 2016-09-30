---
title: "NativeInterop.NativePtr Module (F#)"
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
  - "NativeInterop.NativePtr"
apilocation: 
  - "FSharp.Core.dll"
apitype: "Assembly"
f1_keywords: 
  - "Microsoft.FSharp.NativeInterop.NativePtrModule"
dev_langs: 
  - "FSharp"
helpviewer_keywords: 
  - "NativePtr module [F#]"
  - "NativePtrModule module [F#]"
ms.assetid: 8d26f532-a190-4139-9722-c44f920c5e11
caps.latest.revision: 25
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# NativeInterop.NativePtr Module (F#)
Contains operations on native pointers. Use of these operators may result in the generation of unverifiable code.  
  
 **Namespace/Module Path:** Microsoft.FSharp.NativeInterop  
  
 **Assembly:** FSharp.Core (in FSharp.Core.dll)  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Remarks  
  
## Values  
  
|Value|Description|  
|-----------|-----------------|  
|[add](../vs140/nativeptr.add--t--function--fsharp-.md)  <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>|Returns a typed native pointer by adding an offset to the given input pointer.|  
|[get](../vs140/nativeptr.get--t--function--fsharp-.md)  <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>|Dereferences the typed native pointer computed by adding an offset to the given input pointer.|  
|[ofNativeInt](../vs140/nativeptr.ofnativeint--t--function--fsharp-.md)  <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>|Returns a typed native pointer for a given machine address.|  
|[read](../vs140/nativeptr.read--t--function--fsharp-.md)  <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>|Dereferences the given typed native pointer.|  
|[set](../vs140/nativeptr.set--t--function--fsharp-.md)  <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>|Assigns a value into the memory location referenced by the typed native pointer computed by adding an offset to the given input pointer.|  
|[stackalloc](../vs140/nativeptr.stackalloc--t--function--fsharp-.md)  <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>|Allocates a region of memory on the stack.|  
|[toNativeInt](../vs140/nativeptr.tonativeint--t--function--fsharp-.md)  <CodeContentPlaceHolder>7\</CodeContentPlaceHolder>|Returns a machine address for a given typed native pointer.|  
|[write](../vs140/nativeptr.write--t--function--fsharp-.md)  <CodeContentPlaceHolder>8\</CodeContentPlaceHolder>|Assigns a value into the memory location referenced by the given typed native pointer.|  
  
## Platforms  
 Windows 8, Windows 7, Windows Server 2012, Windows Server 2008 R2  
  
## Version Information  
 **F# Core Library Versions**  
  
 Supported in: 2.0, 4.0, Portable  
  
## See Also  
 [Microsoft.FSharp.NativeInterop Namespace (F#)](../vs140/microsoft.fsharp.nativeinterop-namespace--fsharp-.md)