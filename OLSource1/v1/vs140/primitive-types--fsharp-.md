---
title: "Primitive Types (F#)"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-fsharp"
ms.tgt_pltfrm: na
ms.topic: "reference"
dev_langs: 
  - "FSharp"
helpviewer_keywords: 
  - "char [F#]"
  - "int64 [F#]"
  - "void [F#]"
  - "unativeint [F#]"
  - "uint8 [F#]"
  - "uint16 [F#]"
  - "nativeptr [F#]"
  - "built-in types [F#]"
  - "byte [F#]"
  - "int8 [F#]"
  - "int16 [F#]"
  - "float [F#]"
  - "nativeint [F#]"
  - "sbyte [F#]"
  - "float32 [F#]"
  - "type system [F#], primitive types"
  - "integral types [F#]"
  - "bool [F#]"
  - "unit type [F#]"
  - "int [F#]"
  - "primitive types [F#]"
  - "single [F#]"
  - "uint64 [F#]"
  - "double [F#]"
  - "uint32 [F#]"
  - "string [F#]"
  - "types [F#], primitive types"
  - "decimal [F#]"
  - "int32 [F#]"
ms.assetid: 6d8252a8-3bfd-4a14-afc6-19a92e679bdb
caps.latest.revision: 23
author: ""
ms.author: ""
manager: ""
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Primitive Types (F#)
This topic lists the fundamental primitive types that are used in the F# language. It also provides the corresponding .NET types and the minimum and maximum values for each type.  
  
## Summary of Primitive Types  
 The following table summarizes the properties of the primitive F# types.  
  
|Type|.NET type|Description|  
|----------|---------------|-----------------|  
|`bool`|<xref:System.Boolean*>|Possible values are `true` and `false`.|  
|`byte`|<xref:System.Byte*>|Values from 0 to 255.|  
|`sbyte`|<xref:System.SByte*>|Values from -128 to 127.|  
|`int16`|<xref:System.Int16*>|Values from -32768 to 32767.|  
|`uint16`|<xref:System.UInt16*>|Values from 0 to 65535.|  
|`int`|<xref:System.Int32*>|Values from -2,147,483,648 to 2,147,483,647.|  
|`uint32`|<xref:System.UInt32*>|Values from 0 to 4,294,967,295.|  
|`int64`|<xref:System.Int64*>|Values from -9,223,372,036,854,775,808 to 9,223,372,036,854,775,807.|  
|`uint64`|<xref:System.UInt64*>|Values from 0 to 18,446,744,073,709,551,615.|  
|`nativeint`|<xref:System.IntPtr*>|A native pointer as a signed integer.|  
|`unativeint`|<xref:System.UIntPtr*>|A native pointer as an unsigned integer.|  
|`char`|<xref:System.Char*>|Unicode character values.|  
|`string`|<xref:System.String*>|Unicode text.|  
|`decimal`|<xref:System.Decimal*>|A floating point data type that has at least 28 significant digits.|  
|`unit`|not applicable|Indicates the absence of an actual value. The type has only one formal value, which is denoted (). The unit value, (), is often used as a placeholder where a value is needed but no real value is available or makes sense.|  
|`void`|<xref:System.Void*>|Indicates no type or value.|  
|`float32, single`|<xref:System.Single*>|A 32-bit floating point type.|  
|`float, double`|<xref:System.Double*>|A 64-bit floating point type.|  
  
> [!NOTE]
>  You can perform computations with integers too big for the 64-bit integer type by using the [bigint](../vs140/core.bigint-type-abbreviation--fsharp-.md) type. `bigint` is not considered a primitive type; it is an abbreviation for <xref:System.Numerics.BigInteger*>.  
  
## See Also  
 [F# Language Reference](../vs140/fsharp-language-reference.md)