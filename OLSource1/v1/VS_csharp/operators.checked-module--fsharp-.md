---
title: "Operators.Checked Module (F#)"
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
  - "Operators.Checked"
apilocation: 
  - "FSharp.Core.dll"
apitype: "Assembly"
f1_keywords: 
  - "Microsoft.FSharp.Core.Operators.Checked"
dev_langs: 
  - "FSharp"
helpviewer_keywords: 
  - "Checked module [F#]"
ms.assetid: 6e3326ec-0f93-4ab9-ae33-235ab6eb0028
caps.latest.revision: 26
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Operators.Checked Module (F#)
This module contains the basic arithmetic operations with overflow checks.  
  
 **Namespace/Module Path:** Microsoft.FSharp.Core.Operators  
  
 **Assembly:** FSharp.Core (in FSharp.Core.dll)  
  
## Syntax  
  
```  
module Checked  
```  
  
## Remarks  
  
## Values  
  
|Value|Description|  
|-----------|-----------------|  
|[( * )](../VS_csharp/checked.------^t1-^t2-^t3--function--fsharp-.md)  `: ^T1 -> ^T2 -> ^T3`|Overloaded multiplication operator (checks for overflow).|  
|[( + )](../VS_csharp/checked.------^t1-^t2-^t3--function--fsharp-.md)  `: ^T1 -> 'T2 -> 'T3`|Overloaded addition operator (checks for overflow).|  
|[( - )](../VS_csharp/checked.------^t1-^t2-^t3--function--fsharp-.md)  `: ^T1 -> ^T2 -> ^T3`|Overloaded subtraction operator (checks for overflow).|  
|[( ~- )](../VS_csharp/checked.--~----^t--function--fsharp-.md)  `: ^T -> ^T`|Overloaded unary negation (checks for overflow).|  
|[byte](../VS_csharp/checked.byte-^t--function--fsharp-.md)  `: ^T -> byte`|Converts the argument to `byte`. This is a direct, checked conversion for all primitive numeric types. For strings, the input is converted using <xref:System.Byte.Parse*> with <xref:System.Globalization.CultureInfo.InvariantCulture*> settings. Otherwise the operation requires an appropriate static conversion method on the input type.|  
|[char](../VS_csharp/checked.char-^t--function--fsharp-.md)  `: ^T -> char`|Converts the argument to `char`. Numeric inputs are converted using a checked conversion according to the UTF-16 encoding for characters. String inputs must be exactly one character long. For other input types the operation requires an appropriate static conversion method on the input type.|  
|[int](../VS_csharp/checked.int-^t--function--fsharp-.md)  `: ^T -> int`|Converts the argument to `int`. This is a direct, checked conversion for all primitive numeric types. For strings, the input is converted using <xref:System.Int32.Parse*> with <xref:System.Globalization.CultureInfo.InvariantCulture*> settings. Otherwise the operation requires an appropriate static conversion method on the input type.|  
|[int16](../VS_csharp/checked.int16-^t--function--fsharp-.md)  `: ^T -> int16`|Converts the argument to `int16`. This is a direct, checked conversion for all primitive numeric types. For strings, the input is converted using <xref:System.Int16.Parse*> with <xref:System.Globalization.CultureInfo.InvariantCulture*> settings. Otherwise the operation requires an appropriate static conversion method on the input type.|  
|[int32](../VS_csharp/checked.int32-^t--function--fsharp-.md)  `: ^T -> int32`|Converts the argument to `int32`. This is a direct, checked conversion for all primitive numeric types. For strings, the input is converted using <xref:System.Int32.Parse*> with <xref:System.Globalization.CultureInfo.InvariantCulture*> settings. Otherwise the operation requires an appropriate static conversion method on the input type.|  
|[int64](../VS_csharp/checked.int64-^t--function--fsharp-.md)  `: ^T -> int64`|Converts the argument to `int64`. This is a direct, checked conversion for all primitive numeric types. For strings, the input is converted using <xref:System.Int64.Parse*> with <xref:System.Globalization.CultureInfo.InvariantCulture*> settings. Otherwise the operation requires an appropriate static conversion method on the input type.|  
|[nativeint](../VS_csharp/checked.nativeint-^t--function--fsharp-.md)  `: ^T -> nativeint`|Converts the argument to `nativeint`. This is a direct, checked conversion for all primitive numeric types. Otherwise the operation requires an appropriate static conversion method on the input type.|  
|[sbyte](../VS_csharp/checked.sbyte-^t--function--fsharp-.md)  `: ^T -> sbyte`|Converts the argument to `sbyte`. This is a direct, checked conversion for all primitive numeric types. For strings, the input is converted using <xref:System.SByte.Parse*> with <xref:System.Globalization.CultureInfo.InvariantCulture*> settings. Otherwise the operation requires an appropriate static conversion method on the input type.|  
|[uint16](../VS_csharp/checked.uint16-^t--function--fsharp-.md)  `: ^T -> uint16`|Converts the argument to `uint16`. This is a direct, checked conversion for all primitive numeric types. For strings, the input is converted using <xref:System.UInt16.Parse*> with <xref:System.Globalization.CultureInfo.InvariantCulture*> settings. Otherwise the operation requires an appropriate static conversion method on the input type.|  
|[uint32](../VS_csharp/checked.uint32-^t--function--fsharp-.md)  `: ^T -> uint32`|Converts the argument to `uint32`. This is a direct, checked conversion for all primitive numeric types. For strings, the input is converted using <xref:System.UInt32.Parse*> with <xref:System.Globalization.CultureInfo.InvariantCulture*> settings. Otherwise the operation requires an appropriate static conversion method on the input type.|  
|[uint64](../VS_csharp/checked.uint64-^t--function--fsharp-.md)  `: ^T -> uint64`|Converts the argument to `uint64`. This is a direct, checked conversion for all primitive numeric types. For strings, the input is converted using <xref:System.UInt64.Parse*> with <xref:System.Globalization.CultureInfo.InvariantCulture*> settings. Otherwise the operation requires an appropriate static conversion method on the input type.|  
|[unativeint](../VS_csharp/checked.unativeint-^t--function--fsharp-.md)  `: ^T -> unvativeint`|Converts the argument to `unativeint`. This is a direct, checked conversion for all primitive numeric types. Otherwise the operation requires an appropriate static conversion method on the input type.|  
  
## Platforms  
 Windows 8, Windows 7, Windows Server 2012, Windows Server 2008 R2  
  
## Version Information  
 **F# Core Library Versions**  
  
 Supported in: 2.0, 4.0, Portable  
  
## See Also  
 [Microsoft.FSharp.Core.Operators Namespace (F#)](../VS_csharp/core.operators-module--fsharp-.md)