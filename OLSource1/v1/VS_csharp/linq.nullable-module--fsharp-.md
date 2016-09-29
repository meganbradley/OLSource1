---
title: "Linq.Nullable Module (F#)"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-fsharp"
ms.tgt_pltfrm: na
ms.topic: "reference"
apilocation: 
  - "FSharp.Core.dll"
apitype: "Assembly"
f1_keywords: 
  - "Microsoft.FSharp.Linq.Nullable"
dev_langs: 
  - "FSharp"
ms.assetid: e7a4ea13-28cc-462e-bc3a-33131ace976e
caps.latest.revision: 13
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Linq.Nullable Module (F#)
Functions for converting nullable values into nullable values of another type.  
  
 **Namespace/Module Path**: Microsoft.FSharp.Linq  
  
 **Assembly**: FSharp.Core (in FSharp.Core.dll)  
  
## Syntax  
  
```  
module Nullable  
```  
  
## Remarks  
 For more information about nullable types and nullable operators, see <xref:System.Nullable`1*> and [Nullable Operators (F#)](../VS_csharp/nullable-operators--fsharp-.md).  
  
## Values  
  
|Value|Description|  
|-----------|-----------------|  
|[byte](../VS_csharp/nullable.byte-^t--function--fsharp-.md) : System.Nullable<'T> -> System.Nullable<byte\>|Converts the argument to nullable byte, Nullable<[byte](../VS_csharp/core.byte-type-abbreviation--fsharp-.md)>. This is a direct conversion for all primitive numeric types. The operation requires an appropriate static conversion method on the input type.|  
|[char](../VS_csharp/nullable.char-^t--function--fsharp-.md) : System.Nullable<'T> -> System.Nullable<char\>|Converts the argument to a nullable character, Nullable<[char](../VS_csharp/core.char-type-abbreviation--fsharp-.md)>. Numeric inputs are converted according to the UTF-16 encoding for characters. The operation requires an appropriate static conversion method on the input type.|  
|[decimal](../VS_csharp/nullable.decimal-^t--function--fsharp-.md) : System.Nullable<'T> -> System.Nullable<System.Decimal>|Converts the argument to a nullable decimal, Nullable<<xref:System.Decimal*>> using a direct conversion for all primitive numeric types. The operation requires an appropriate static conversion method on the input type.|  
|[enum](../VS_csharp/nullable.enum-^u--function--fsharp-.md) : System.Nullable<'T> -> System.Nullable<'U when 'U : enum>|Converts the argument to a particular nullable enum type.|  
|[float](../VS_csharp/nullable.float-^t--function--fsharp-.md) : System.Nullable<'T> -> System.Nullable<float\>|Converts the argument to a nullable 64-bit float, Nullable<[float](../VS_csharp/core.float-type-abbreviation--fsharp-.md)>. This is a direct conversion for all primitive numeric types. The operation requires an appropriate static conversion method on the input type.|  
|[float32](../VS_csharp/nullable.float32-^t--function--fsharp-.md) : System.Nullable<'T> -> System.Nullable<float32\>|Converts the argument to a nullable 32-bit float, Nullable<[float32](../VS_csharp/core.float32-type-abbreviation--fsharp-.md)>. This is a direct conversion for all primitive numeric types. The operation requires an appropriate static conversion method on the input type.|  
|[int](../VS_csharp/nullable.int-^t--function--fsharp-.md) : System.Nullable<'T> -> System.Nullable<int\>|Converts the argument to nullable signed 32-bit integer, Nullable<[int](../VS_csharp/core.int-type-abbreviation--fsharp-.md)>. This is a direct conversion for all primitive numeric types. The operation requires an appropriate static conversion method on the input type.|  
|[int16](../VS_csharp/nullable.int16-^t--function--fsharp-.md) : System.Nullable<'T> -> System.Nullable<int16\>|Converts the argument to a nullable signed 16-bit integer, Nullable<[int16](../VS_csharp/core.int16-type-abbreviation--fsharp-.md)>. This is a direct conversion for all primitive numeric types. The operation requires an appropriate static conversion method on the input type.|  
|[int32](../VS_csharp/nullable.int32-^t--function--fsharp-.md) : System.Nullable<'T> -> System.Nullable<int32\>|Converts the argument to a nullable signed 32-bit integer, Nullable<[int32](../VS_csharp/core.int32-type-abbreviation--fsharp-.md)>. This is a direct conversion for all primitive numeric types. The operation requires an appropriate static conversion method on the input type.|  
|[int64](../VS_csharp/nullable.int64-^t--function--fsharp-.md): System.Nullable<'T> -> System.Nullable<int64\>|Converts the argument to a nullable signed 64-bit integer, Nullable<[int64](../VS_csharp/core.int64-type-abbreviation--fsharp-.md)>. This is a direct conversion for all primitive numeric types. The operation requires an appropriate static conversion method on the input type.|  
|[nativeint](../VS_csharp/nullable.nativeint-^t--function--fsharp-.md) : System.Nullable<'T> -> System.Nullable<nativeint\>|Converts the argument to a nullable signed native integer, Nullable<[nativeint](../VS_csharp/checked.nativeint-^t--function--fsharp-.md)>. This is a direct conversion for all primitive numeric types. Otherwise the operation requires an appropriate static conversion method on the input type.|  
|[sbyte](../VS_csharp/nullable.sbyte-^t--function--fsharp-.md) : System.Nullable<'T> -> System.Nullable<sbyte\>|Converts the argument to a nullable signed byte, Nullable<[sbyte](../VS_csharp/core.sbyte-type-abbreviation--fsharp-.md)>. This is a direct conversion for all primitive numeric types. The operation requires an appropriate static conversion method on the input type.|  
|[uint16](../VS_csharp/nullable.uint16-^t--function--fsharp-.md): System.Nullable<'T> -> System.Nullable<uint16\>|Converts the argument to a nullable unsigned 16-bit integer, Nullable<[uint16](../VS_csharp/core.uint16-type-abbreviation--fsharp-.md)>. This is a direct conversion for all primitive numeric types. The operation requires an appropriate static conversion method on the input type.|  
|[uint32](../VS_csharp/nullable.uint32-^t--function--fsharp-.md) : System.Nullable<'T> -> System.Nullable<uint32\>|Converts the argument to a nullable unsigned 32-bit integer, Nullable<[uint32](../VS_csharp/core.uint32-type-abbreviation--fsharp-.md)>. This is a direct conversion for all primitive numeric types. The operation requires an appropriate static conversion method on the input type.|  
|[uint64](../VS_csharp/nullable.uint64-^t--function--fsharp-.md) : System.Nullable<'T> -> System.Nullable<uint64\>|Converts the argument to a nullable unsigned 64-bit integer, Nullable<[uint64](../VS_csharp/core.uint64-type-abbreviation--fsharp-.md)>. This is a direct conversion for all primitive numeric types. The operation requires an appropriate static conversion method on the input type.|  
|[unativeint](../VS_csharp/nullable.unativeint-^t--function--fsharp-.md) : System.Nullable<'T> -> System.Nullable<unativeint\>|Converts the argument to a nullable unsigned native integer, Nullable<[unativeint](../VS_csharp/core.unativeint-type-abbreviation--fsharp-.md)>, using a direct conversion for all primitive numeric types. Otherwise, the operation requires an appropriate static conversion method on the input type.|  
  
## Platforms  
 Windows 8, Windows 7, Windows Server 2012, Windows Server 2008 R2  
  
## Version Information  
 **F# Core Library Versions**  
  
 Supported in: 4.0, Portable  
  
## See Also  
 [Microsoft.FSharp.Linq Namespace (F#)](../VS_csharp/microsoft.fsharp.linq-namespace--fsharp-.md)