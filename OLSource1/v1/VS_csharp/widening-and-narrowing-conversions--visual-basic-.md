---
title: "Widening and Narrowing Conversions (Visual Basic)"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-visual-basic"
ms.tgt_pltfrm: na
ms.topic: "article"
dev_langs: 
  - "VB"
helpviewer_keywords: 
  - "widening conversions"
  - "narrowing conversions"
  - "conversions, type"
  - "data types [Visual Basic], changing"
  - "variables [Visual Basic], changing data type"
  - "conversions, exceptions during conversion"
  - "type conversion, exceptions during conversion"
  - "conversions, data type"
  - "conversions, narrowing"
  - "type conversion, narrowing"
  - "data type conversion, widening"
  - "data type conversion, narrowing"
  - "changing data types"
  - "type conversion, widening"
  - "data type conversion, exceptions during conversion"
  - "conversions, widening"
ms.assetid: 058c3152-6c28-4268-af44-2209e774f0bd
caps.latest.revision: 31
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Widening and Narrowing Conversions (Visual Basic)
An important consideration with a type conversion is whether the result of the conversion is within the range of the destination data type.  
  
 A *widening conversion* changes a value to a data type that can allow for any possible value of the original data.  Widening conversions preserve the source value but can change its representation. This occurs if you convert from an integral type to `Decimal`, or from `Char` to `String`.  
  
 A *narrowing conversion* changes a value to a data type that might not be able to hold some of the possible values. For example, a fractional value is rounded when it is converted to an integral type, and a numeric type being converted to `Boolean` is reduced to either `True` or `False`.  
  
## Widening Conversions  
 The following table shows the standard widening conversions.  
  
|||  
|-|-|  
|Data type|Widens to data types <sup>1</sup>|  
|[SByte](../VS_csharp/sbyte-data-type--visual-basic-.md)|`SByte`, `Short`, `Integer`, `Long`, `Decimal`, `Single`, `Double`|  
|[Byte](../VS_csharp/byte-data-type--visual-basic-.md)|`Byte`, `Short`, `UShort`, `Integer`, `UInteger`, `Long`, `ULong`, `Decimal`, `Single`, `Double`|  
|[Short](../VS_csharp/short-data-type--visual-basic-.md)|`Short`, `Integer`, `Long`, `Decimal`, `Single`, `Double`|  
|[UShort](../VS_csharp/ushort-data-type--visual-basic-.md)|`UShort`, `Integer`, `UInteger`, `Long`, `ULong`, `Decimal`, `Single`, `Double`|  
|[Integer](../VS_csharp/integer-data-type--visual-basic-.md)|`Integer`, `Long`, `Decimal`, `Single`, `Double`<sup>2</sup>|  
|[UInteger](../VS_csharp/uinteger-data-type.md)|`UInteger`, `Long`, `ULong`, `Decimal`, `Single`, `Double`<sup>2</sup>|  
|[Long](../VS_csharp/long-data-type--visual-basic-.md)|`Long`, `Decimal`, `Single`, `Double`<sup>2</sup>|  
|[ULong](../VS_csharp/ulong-data-type--visual-basic-.md)|`ULong`, `Decimal`, `Single`, `Double`<sup>2</sup>|  
|[Decimal](../VS_csharp/decimal-data-type--visual-basic-.md)|`Decimal`, `Single`, `Double`<sup>2</sup>|  
|[Single](../VS_csharp/single-data-type--visual-basic-.md)|`Single`, `Double`|  
|[Double](../VS_csharp/double-data-type--visual-basic-.md)|`Double`|  
|Any enumerated type ([Enum](../VS_csharp/enum-statement--visual-basic-.md))|Its underlying integral type and any type to which the underlying type widens.|  
|[Char](../VS_csharp/char-data-type--visual-basic-.md)|`Char`, `String`|  
|`Char` array|`Char` array, `String`|  
|Any type|[Object](../VS_csharp/object-data-type.md)|  
|Any derived type|Any base type from which it is derived <sup>3</sup>.|  
|Any type|Any interface it implements.|  
|[Nothing](../VS_csharp/nothing--visual-basic-.md)|Any data type or object type.|  
  
 <sup>1</sup> By definition, every data type widens to itself.  
  
 <sup>2</sup> Conversions from `Integer`, `UInteger`, `Long`, `ULong`, or `Decimal` to `Single` or `Double` might result in loss of precision, but never in loss of magnitude. In this sense they do not incur information loss.  
  
 <sup>3</sup> It might seem surprising that a conversion from a derived type to one of its base types is widening. The justification is that the derived type contains all the members of the base type, so it qualifies as an instance of the base type. In the opposite direction, the base type does not contain any new members defined by the derived type.  
  
 Widening conversions always succeed at run time and never incur data loss. You can always perform them implicitly, whether the [Option Strict Statement](../VS_csharp/option-strict-statement.md) sets the type checking switch to `On` or to `Off`.  
  
## Narrowing Conversions  
 The standard narrowing conversions include the following:  
  
-   The reverse directions of the widening conversions in the preceding table (except that every type widens to itself)  
  
-   Conversions in either direction between [Boolean](../VS_csharp/boolean-data-type--visual-basic-.md) and any numeric type  
  
-   Conversions from any numeric type to any enumerated type (`Enum`)  
  
-   Conversions in either direction between [String](../VS_csharp/string-data-type--visual-basic-.md) and any numeric type, `Boolean`, or [Date](../VS_csharp/date-data-type--visual-basic-.md)  
  
-   Conversions from a data type or object type to a type derived from it  
  
 Narrowing conversions do not always succeed at run time, and can fail or incur data loss. An error occurs if the destination data type cannot receive the value being converted. For example, a numeric conversion can result in an overflow. The compiler does not allow you to perform narrowing conversions implicitly unless the [Option Strict Statement](../VS_csharp/option-strict-statement.md) sets the type checking switch to `Off`.  
  
> [!NOTE]
>  The narrowing-conversion error is suppressed for conversions from the elements in a `For Each…Next` collection to the loop control variable. For more information and examples, see the "Narrowing Conversions" section in [For Each…Next Statement](../VS_csharp/for-each...next-statement--visual-basic-.md).  
  
### When to Use Narrowing Conversions  
 You use a narrowing conversion when you know the source value can be converted to the destination data type without error or data loss. For example, if you have a `String` that you know contains either "True" or "False," you can use the `CBool` keyword to convert it to `Boolean`.  
  
## Exceptions During Conversion  
 Because widening conversions always succeed, they do not throw exceptions. Narrowing conversions, when they fail, most commonly throw the following exceptions:  
  
-   <xref:System.InvalidCastException*> — if no conversion is defined between the two types  
  
-   <xref:System.OverflowException*> — (integral types only) if the converted value is too large for the target type  
  
 If a class or structure defines a [CType Function](../VS_csharp/ctype-function--visual-basic-.md) to serve as a conversion operator to or from that class or structure, that `CType` can throw any exception it deems appropriate. In addition, that `CType` might call [!INCLUDE[vbprvb](../VS_csharp/includes/vbprvb_md.md)] functions or [!INCLUDE[dnprdnshort](../VS_csharp/includes/dnprdnshort_md.md)] methods, which in turn could throw a variety of exceptions.  
  
## Changes During Reference Type Conversions  
 A conversion from a *reference type* copies only the pointer to the value. The value itself is neither copied nor changed in any way. The only thing that can change is the data type of the variable holding the pointer. In the following example, the data type is converted from the derived class to its base class, but the object that both variables now point to is unchanged.  
  
```  
' Assume class cSquare inherits from class cShape.  
Dim shape As cShape  
Dim square As cSquare = New cSquare  
' The following statement performs a widening  
' conversion from a derived class to its base class.  
shape = square  
```  
  
## See Also  
 [Data Types in Visual Basic](../VS_csharp/data-types-in-visual-basic.md)   
 [Type Conversions in Visual Basic](../VS_csharp/type-conversions-in-visual-basic.md)   
 [Implicit and Explicit Conversions](../VS_csharp/implicit-and-explicit-conversions--visual-basic-.md)   
 [Conversions Between Strings and Other Types](../VS_csharp/conversions-between-strings-and-other-types--visual-basic-.md)   
 [How to: Convert an Object to Another Type (Visual Basic)](../VS_csharp/how-to--convert-an-object-to-another-type-in-visual-basic.md)   
 [Array Conversions](../VS_csharp/array-conversions--visual-basic-.md)   
 [Data Types](../VS_csharp/data-type-summary--visual-basic-.md)   
 [Type Conversion Functions](../VS_csharp/type-conversion-functions--visual-basic-.md)