---
title: "Data Types of Operator Results (Visual Basic)"
ms.custom: na
ms.date: "10/10/2016"
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
  - "data types [Visual Basic], operator result data types"
  - "result data types"
  - "operator result data types"
  - "operators [Visual Basic], data types"
  - "data types [Visual Basic], ranges"
  - "operators [Visual Basic], result data types"
ms.assetid: 9d524533-e1a1-4aa8-b1b8-622068173d06
caps.latest.revision: 27
ms.author: "shoag"
manager: "wpickett"
translation.priority.ht: 
  - "cs-cz"
  - "de-de"
  - "es-es"
  - "fr-fr"
  - "it-it"
  - "ja-jp"
  - "ko-kr"
  - "pl-pl"
  - "pt-br"
  - "ru-ru"
  - "tr-tr"
  - "zh-cn"
  - "zh-tw"
---
# Data Types of Operator Results (Visual Basic)
[!INCLUDE[vbprvb](../VS_visualbasic/includes/vbprvb_md.md)] determines the result data type of an operation based on the data types of the operands. In some cases this might be a data type with a greater range than that of either operand.  
  
## Data Type Ranges  
 The ranges of the relevant data types, in order from smallest to largest, are as follows:  
  
-   [Boolean](../VS_visualbasic/boolean-data-type--visual-basic-.md) — two possible values  
  
-   [SByte](../VS_visualbasic/sbyte-data-type--visual-basic-.md), [Byte](../VS_visualbasic/byte-data-type--visual-basic-.md) — 256 possible integral values  
  
-   [Short](../VS_visualbasic/short-data-type--visual-basic-.md), [UShort](../VS_visualbasic/ushort-data-type--visual-basic-.md) — 65,536 (6.5...E+4) possible integral values  
  
-   [Integer](../VS_visualbasic/integer-data-type--visual-basic-.md), [UInteger](../VS_visualbasic/uinteger-data-type.md) — 4,294,967,296 (4.2...E+9) possible integral values  
  
-   [Long](../VS_visualbasic/long-data-type--visual-basic-.md), [ULong](../VS_visualbasic/ulong-data-type--visual-basic-.md) — 18,446,744,073,709,551,615 (1.8...E+19) possible integral values  
  
-   [Decimal](../VS_visualbasic/decimal-data-type--visual-basic-.md) — 1.5...E+29 possible integral values, maximum range 7.9...E+28 (absolute value)  
  
-   [Single](../VS_visualbasic/single-data-type--visual-basic-.md) — maximum range 3.4...E+38 (absolute value)  
  
-   [Double](../VS_visualbasic/double-data-type--visual-basic-.md) — maximum range 1.7...E+308 (absolute value)  
  
 For more information on [!INCLUDE[vbprvb](../VS_visualbasic/includes/vbprvb_md.md)] data types, see [Data Types](../VS_visualbasic/data-type-summary--visual-basic-.md).  
  
 If an operand evaluates to [Nothing](../VS_visualbasic/nothing--visual-basic-.md), the [!INCLUDE[vbprvb](../VS_visualbasic/includes/vbprvb_md.md)] arithmetic operators treat it as zero.  
  
## Decimal Arithmetic  
 Note that the [Decimal](../VS_visualbasic/decimal-data-type--visual-basic-.md) data type is neither floating-point nor integer.  
  
 If either operand of a `+`, `–`, `*`, `/`, or `Mod` operation is `Decimal` and the other is not `Single` or `Double`, [!INCLUDE[vbprvb](../VS_visualbasic/includes/vbprvb_md.md)] widens the other operand to `Decimal`. It performs the operation in `Decimal`, and the result data type is `Decimal`.  
  
## Floating-Point Arithmetic  
 [!INCLUDE[vbprvb](../VS_visualbasic/includes/vbprvb_md.md)] performs most floating-point arithmetic in [Double](../VS_visualbasic/double-data-type--visual-basic-.md), which is the most efficient data type for such operations. However, if one operand is [Single](../VS_visualbasic/single-data-type--visual-basic-.md) and the other is not `Double`, [!INCLUDE[vbprvb](../VS_visualbasic/includes/vbprvb_md.md)] performs the operation in `Single`. It widens each operand as necessary to the appropriate data type before the operation, and the result has that data type.  
  
### / and ^ Operators  
 The `/` operator is defined only for the [Decimal](../VS_visualbasic/decimal-data-type--visual-basic-.md), [Single](../VS_visualbasic/single-data-type--visual-basic-.md), and [Double](../VS_visualbasic/double-data-type--visual-basic-.md) data types. [!INCLUDE[vbprvb](../VS_visualbasic/includes/vbprvb_md.md)] widens each operand as necessary to the appropriate data type before the operation, and the result has that data type.  
  
 The following table shows the result data types for the `/` operator. Note that this table is symmetric; for a given combination of operand data types, the result data type is the same regardless of the order of the operands.  
  
||||||  
|-|-|-|-|-|  
||`Decimal`|`Single`|`Double`|Any integer type|  
|`Decimal`|Decimal|Single|Double|Decimal|  
|`Single`|Single|Single|Double|Single|  
|`Double`|Double|Double|Double|Double|  
|Any integer type|Decimal|Single|Double|Double|  
  
 The `^` operator is defined only for the `Double` data type. [!INCLUDE[vbprvb](../VS_visualbasic/includes/vbprvb_md.md)] widens each operand as necessary to `Double` before the operation, and the result data type is always `Double`.  
  
## Integer Arithmetic  
 The result data type of an integer operation depends on the data types of the operands. In general, [!INCLUDE[vbprvb](../VS_visualbasic/includes/vbprvb_md.md)] uses the following policies for determining the result data type:  
  
-   If both operands of a binary operator have the same data type, the result has that data type. An exception is `Boolean`, which is forced to `Short`.  
  
-   If an unsigned operand participates with a signed operand, the result has a signed type with at least as large a range as either operand.  
  
-   Otherwise, the result usually has the larger of the two operand data types.  
  
 Note that the result data type might not be the same as either operand data type.  
  
> [!NOTE]
>  The result data type is not always large enough to hold all possible values resulting from the operation. An \<xref:System.OverflowException> exception can occur if the value is too large for the result data type.  
  
### Unary + and – Operators  
 The following table shows the result data types for the two unary operators, `+` and `–`.  
  
|||||||||||  
|-|-|-|-|-|-|-|-|-|-|  
||`Boolean`|`SByte`|`Byte`|`Short`|`UShort`|`Integer`|`UInteger`|`Long`|`ULong`|  
|Unary `+`|Short|SByte|Byte|Short|UShort|Integer|UInteger|Long|ULong|  
|Unary `–`|Short|SByte|Short|Short|Integer|Integer|Long|Long|Decimal|  
  
### <\< and >> Operators  
 The following table shows the result data types for the two bit-shift operators, `<<` and `>>`. [!INCLUDE[vbprvb](../VS_visualbasic/includes/vbprvb_md.md)] treats each bit-shift operator as a unary operator on its left operand (the bit pattern to be shifted).  
  
|||||||||||  
|-|-|-|-|-|-|-|-|-|-|  
||`Boolean`|`SByte`|`Byte`|`Short`|`UShort`|`Integer`|`UInteger`|`Long`|`ULong`|  
|`<<`, `>>`|Short|SByte|Byte|Short|UShort|Integer|UInteger|Long|ULong|  
  
 If the left operand is `Decimal`, `Single`, `Double`, or `String`, [!INCLUDE[vbprvb](../VS_visualbasic/includes/vbprvb_md.md)] attempts to convert it to `Long` before the operation, and the result data type is `Long`. The right operand (the number of bit positions to shift) must be `Integer` or a type that widens to `Integer`.  
  
### Binary +, –, *, and Mod Operators  
 The following table shows the result data types for the binary `+` and `–` operators and the `*` and `Mod` operators. Note that this table is symmetric; for a given combination of operand data types, the result data type is the same regardless of the order of the operands.  
  
|||||||||||  
|-|-|-|-|-|-|-|-|-|-|  
||`Boolean`|`SByte`|`Byte`|`Short`|`UShort`|`Integer`|`UInteger`|`Long`|`ULong`|  
|`Boolean`|Short|SByte|Short|Short|Integer|Integer|Long|Long|Decimal|  
|`SByte`|SByte|SByte|Short|Short|Integer|Integer|Long|Long|Decimal|  
|`Byte`|Short|Short|Byte|Short|UShort|Integer|UInteger|Long|ULong|  
|`Short`|Short|Short|Short|Short|Integer|Integer|Long|Long|Decimal|  
|`UShort`|Integer|Integer|UShort|Integer|UShort|Integer|UInteger|Long|ULong|  
|`Integer`|Integer|Integer|Integer|Integer|Integer|Integer|Long|Long|Decimal|  
|`UInteger`|Long|Long|UInteger|Long|UInteger|Long|UInteger|Long|ULong|  
|`Long`|Long|Long|Long|Long|Long|Long|Long|Long|Decimal|  
|`ULong`|Decimal|Decimal|ULong|Decimal|ULong|Decimal|ULong|Decimal|ULong|  
  
### \ Operator  
 The following table shows the result data types for the `\` operator. Note that this table is symmetric; for a given combination of operand data types, the result data type is the same regardless of the order of the operands.  
  
|||||||||||  
|-|-|-|-|-|-|-|-|-|-|  
||`Boolean`|`SByte`|`Byte`|`Short`|`UShort`|`Integer`|`UInteger`|`Long`|`ULong`|  
|`Boolean`|Short|SByte|Short|Short|Integer|Integer|Long|Long|Long|  
|`SByte`|SByte|SByte|Short|Short|Integer|Integer|Long|Long|Long|  
|`Byte`|Short|Short|Byte|Short|UShort|Integer|UInteger|Long|ULong|  
|`Short`|Short|Short|Short|Short|Integer|Integer|Long|Long|Long|  
|`UShort`|Integer|Integer|UShort|Integer|UShort|Integer|UInteger|Long|ULong|  
|`Integer`|Integer|Integer|Integer|Integer|Integer|Integer|Long|Long|Long|  
|`UInteger`|Long|Long|UInteger|Long|UInteger|Long|UInteger|Long|ULong|  
|`Long`|Long|Long|Long|Long|Long|Long|Long|Long|Long|  
|`ULong`|Long|Long|ULong|Long|ULong|Long|ULong|Long|ULong|  
  
 If either operand of the `\` operator is [Decimal](../VS_visualbasic/decimal-data-type--visual-basic-.md), [Single](../VS_visualbasic/single-data-type--visual-basic-.md), or [Double](../VS_visualbasic/double-data-type--visual-basic-.md), [!INCLUDE[vbprvb](../VS_visualbasic/includes/vbprvb_md.md)] attempts to convert it to [Long](../VS_visualbasic/long-data-type--visual-basic-.md) before the operation, and the result data type is `Long`.  
  
## Relational and Bitwise Comparisons  
 The result data type of a relational operation (`=`, `<>`, `<`, `>`, `<=`, `>=`) is always `Boolean`[Boolean Data Type](../VS_visualbasic/boolean-data-type--visual-basic-.md). The same is true for logical operations (`And`, `AndAlso`, `Not`, `Or`, `OrElse`, `Xor`) on `Boolean` operands.  
  
 The result data type of a bitwise logical operation depends on the data types of the operands. Note that `AndAlso` and `OrElse` are defined only for `Boolean`, and [!INCLUDE[vbprvb](../VS_visualbasic/includes/vbprvb_md.md)] converts each operand as necessary to `Boolean` before performing the operation.  
  
### =, <>, \<, >, \<=, and >= Operators  
 If both operands are `Boolean`, [!INCLUDE[vbprvb](../VS_visualbasic/includes/vbprvb_md.md)] considers `True` to be less than `False`. If a numeric type is compared with a `String`, [!INCLUDE[vbprvb](../VS_visualbasic/includes/vbprvb_md.md)] attempts to convert the `String` to `Double` before the operation. A `Char` or `Date` operand can be compared only with another operand of the same data type. The result data type is always `Boolean`.  
  
### Bitwise Not Operator  
 The following table shows the result data types for the bitwise `Not` operator.  
  
|||||||||||  
|-|-|-|-|-|-|-|-|-|-|  
||`Boolean`|`SByte`|`Byte`|`Short`|`UShort`|`Integer`|`UInteger`|`Long`|`ULong`|  
|`Not`|Boolean|SByte|Byte|Short|UShort|Integer|UInteger|Long|ULong|  
  
 If the operand is `Decimal`, `Single`, `Double`, or `String`, [!INCLUDE[vbprvb](../VS_visualbasic/includes/vbprvb_md.md)] attempts to convert it to `Long` before the operation, and the result data type is `Long`.  
  
### Bitwise And, Or, and Xor Operators  
 The following table shows the result data types for the bitwise `And`, `Or`, and `Xor` operators. Note that this table is symmetric; for a given combination of operand data types, the result data type is the same regardless of the order of the operands.  
  
|||||||||||  
|-|-|-|-|-|-|-|-|-|-|  
||`Boolean`|`SByte`|`Byte`|`Short`|`UShort`|`Integer`|`UInteger`|`Long`|`ULong`|  
|`Boolean`|Boolean|SByte|Short|Short|Integer|Integer|Long|Long|Long|  
|`SByte`|SByte|SByte|Short|Short|Integer|Integer|Long|Long|Long|  
|`Byte`|Short|Short|Byte|Short|UShort|Integer|UInteger|Long|ULong|  
|`Short`|Short|Short|Short|Short|Integer|Integer|Long|Long|Long|  
|`UShort`|Integer|Integer|UShort|Integer|UShort|Integer|UInteger|Long|ULong|  
|`Integer`|Integer|Integer|Integer|Integer|Integer|Integer|Long|Long|Long|  
|`UInteger`|Long|Long|UInteger|Long|UInteger|Long|UInteger|Long|ULong|  
|`Long`|Long|Long|Long|Long|Long|Long|Long|Long|Long|  
|`ULong`|Long|Long|ULong|Long|ULong|Long|ULong|Long|ULong|  
  
 If an operand is `Decimal`, `Single`, `Double`, or `String`, [!INCLUDE[vbprvb](../VS_visualbasic/includes/vbprvb_md.md)] attempts to convert it to `Long` before the operation, and the result data type is the same as if that operand had already been `Long`.  
  
## Miscellaneous Operators  
 The `&` operator is defined only for concatenation of `String` operands. [!INCLUDE[vbprvb](../VS_visualbasic/includes/vbprvb_md.md)] converts each operand as necessary to `String` before the operation, and the result data type is always `String`. For the purposes of the `&` operator, all conversions to `String` are considered to be widening, even if `Option Strict` is `On`.  
  
 The `Is` and `IsNot` operators require both operands to be of a reference type. The `TypeOf`...`Is` expression requires the first operand to be of a reference type and the second operand to be the name of a data type. In all these cases the result data type is `Boolean`.  
  
 The `Like` operator is defined only for pattern matching of `String` operands. [!INCLUDE[vbprvb](../VS_visualbasic/includes/vbprvb_md.md)] attempts to convert each operand as necessary to `String` before the operation. The result data type is always `Boolean`.  
  
## See Also  
 [Data Types](../VS_visualbasic/data-type-summary--visual-basic-.md)   
 [Operators and Expressions](../VS_visualbasic/operators-and-expressions-in-visual-basic.md)   
 [Arithmetic Operators in Visual Basic](../VS_visualbasic/arithmetic-operators-in-visual-basic.md)   
 [Comparison Operators in Visual Basic](../VS_visualbasic/comparison-operators-in-visual-basic.md)   
 [Operators](../VS_visualbasic/operators--visual-basic-.md)   
 [Operator Precedence in Visual Basic](../VS_visualbasic/operator-precedence-in-visual-basic.md)   
 [Operators Listed by Functionality](../VS_visualbasic/operators-listed-by-functionality--visual-basic-.md)   
 [Arithmetic Operators](../VS_visualbasic/arithmetic-operators--visual-basic-.md)   
 [Comparison Operators](../VS_visualbasic/comparison-operators--visual-basic-.md)   
 [Option Strict Statement](../VS_visualbasic/option-strict-statement.md)