---
title: "Linq.Nullable Module (F#)"
ms.custom: na
ms.date: 09/22/2016
ms.prod: visual-studio-dev14
ms.reviewer: na
ms.suite: na
ms.technology: 
  - devlang-fsharp
ms.tgt_pltfrm: na
ms.topic: reference
apilocation: 
  - FSharp.Core.dll
apitype: Assembly
f1_keywords: 
  - Microsoft.FSharp.Linq.Nullable
dev_langs: 
  - FSharp
ms.assetid: e7a4ea13-28cc-462e-bc3a-33131ace976e
caps.latest.revision: 13
translation.priority.ht: 
  - de-de
  - ja-jp
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
 For more information about nullable types and nullable operators, see <xref:System.Nullable`1?qualifyHint=False> and [Nullable Operators (F#)](../vs140/nullable-operators--fsharp-.md).  
  
## Values  
  
|Value|Description|  
|-----------|-----------------|  
|[byte](../vs140/nullable.byte-^t--function--fsharp-.md) : System.Nullable<'T> -> System.Nullable<byte\>|Converts the argument to nullable byte, Nullable<[byte](../vs140/core.byte-type-abbreviation--fsharp-.md)>. This is a direct conversion for all primitive numeric types. The operation requires an appropriate static conversion method on the input type.|  
|[char](../vs140/nullable.char-^t--function--fsharp-.md) : System.Nullable<'T> -> System.Nullable<char\>|Converts the argument to a nullable character, Nullable<[char](../vs140/core.char-type-abbreviation--fsharp-.md)>. Numeric inputs are converted according to the UTF-16 encoding for characters. The operation requires an appropriate static conversion method on the input type.|  
|[decimal](../vs140/nullable.decimal-^t--function--fsharp-.md) : System.Nullable<'T> -> System.Nullable<System.Decimal>|Converts the argument to a nullable decimal, Nullable<<xref:System.Decimal?qualifyHint=False>> using a direct conversion for all primitive numeric types. The operation requires an appropriate static conversion method on the input type.|  
|[enum](../vs140/nullable.enum-^u--function--fsharp-.md) : System.Nullable<'T> -> System.Nullable<'U when 'U : enum>|Converts the argument to a particular nullable enum type.|  
|[float](../vs140/nullable.float-^t--function--fsharp-.md) : System.Nullable<'T> -> System.Nullable<float\>|Converts the argument to a nullable 64-bit float, Nullable<[float](../vs140/core.float-type-abbreviation--fsharp-.md)>. This is a direct conversion for all primitive numeric types. The operation requires an appropriate static conversion method on the input type.|  
|[float32](../vs140/nullable.float32-^t--function--fsharp-.md) : System.Nullable<'T> -> System.Nullable<float32\>|Converts the argument to a nullable 32-bit float, Nullable<[float32](../vs140/core.float32-type-abbreviation--fsharp-.md)>. This is a direct conversion for all primitive numeric types. The operation requires an appropriate static conversion method on the input type.|  
|[int](../vs140/nullable.int-^t--function--fsharp-.md) : System.Nullable<'T> -> System.Nullable<int\>|Converts the argument to nullable signed 32-bit integer, Nullable<[int](../vs140/core.int-type-abbreviation--fsharp-.md)>. This is a direct conversion for all primitive numeric types. The operation requires an appropriate static conversion method on the input type.|  
|[int16](../vs140/nullable.int16-^t--function--fsharp-.md) : System.Nullable<'T> -> System.Nullable<int16\>|Converts the argument to a nullable signed 16-bit integer, Nullable<[int16](../vs140/core.int16-type-abbreviation--fsharp-.md)>. This is a direct conversion for all primitive numeric types. The operation requires an appropriate static conversion method on the input type.|  
|[int32](../vs140/nullable.int32-^t--function--fsharp-.md) : System.Nullable<'T> -> System.Nullable<int32\>|Converts the argument to a nullable signed 32-bit integer, Nullable<[int32](../vs140/core.int32-type-abbreviation--fsharp-.md)>. This is a direct conversion for all primitive numeric types. The operation requires an appropriate static conversion method on the input type.|  
|[int64](../vs140/nullable.int64-^t--function--fsharp-.md): System.Nullable<'T> -> System.Nullable<int64\>|Converts the argument to a nullable signed 64-bit integer, Nullable<[int64](../vs140/core.int64-type-abbreviation--fsharp-.md)>. This is a direct conversion for all primitive numeric types. The operation requires an appropriate static conversion method on the input type.|  
|[nativeint](../vs140/nullable.nativeint-^t--function--fsharp-.md) : System.Nullable<'T> -> System.Nullable<nativeint\>|Converts the argument to a nullable signed native integer, Nullable<[nativeint](../vs140/checked.nativeint-^t--function--fsharp-.md)>. This is a direct conversion for all primitive numeric types. Otherwise the operation requires an appropriate static conversion method on the input type.|  
|[sbyte](../vs140/nullable.sbyte-^t--function--fsharp-.md) : System.Nullable<'T> -> System.Nullable<sbyte\>|Converts the argument to a nullable signed byte, Nullable<[sbyte](../vs140/core.sbyte-type-abbreviation--fsharp-.md)>. This is a direct conversion for all primitive numeric types. The operation requires an appropriate static conversion method on the input type.|  
|[uint16](../vs140/nullable.uint16-^t--function--fsharp-.md): System.Nullable<'T> -> System.Nullable<uint16\>|Converts the argument to a nullable unsigned 16-bit integer, Nullable<[uint16](../vs140/core.uint16-type-abbreviation--fsharp-.md)>. This is a direct conversion for all primitive numeric types. The operation requires an appropriate static conversion method on the input type.|  
|[uint32](../vs140/nullable.uint32-^t--function--fsharp-.md) : System.Nullable<'T> -> System.Nullable<uint32\>|Converts the argument to a nullable unsigned 32-bit integer, Nullable<[uint32](../vs140/core.uint32-type-abbreviation--fsharp-.md)>. This is a direct conversion for all primitive numeric types. The operation requires an appropriate static conversion method on the input type.|  
|[uint64](../vs140/nullable.uint64-^t--function--fsharp-.md) : System.Nullable<'T> -> System.Nullable<uint64\>|Converts the argument to a nullable unsigned 64-bit integer, Nullable<[uint64](../vs140/core.uint64-type-abbreviation--fsharp-.md)>. This is a direct conversion for all primitive numeric types. The operation requires an appropriate static conversion method on the input type.|  
|[unativeint](../vs140/nullable.unativeint-^t--function--fsharp-.md) : System.Nullable<'T> -> System.Nullable<unativeint\>|Converts the argument to a nullable unsigned native integer, Nullable<[unativeint](../vs140/core.unativeint-type-abbreviation--fsharp-.md)>, using a direct conversion for all primitive numeric types. Otherwise, the operation requires an appropriate static conversion method on the input type.|  
  
## Platforms  
 Windows 8, Windows 7, Windows Server 2012, Windows Server 2008 R2  
  
## Version Information  
 **F# Core Library Versions**  
  
 Supported in: 4.0, Portable  
  
## See Also  
 [Microsoft.FSharp.Linq Namespace (F#)](../vs140/microsoft.fsharp.linq-namespace--fsharp-.md)