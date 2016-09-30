---
title: "Enumerations (F#)"
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
  - "enum keyword [F#]"
  - "underlying types [F#]"
  - "enumerations [F#]"
  - "enum type [F#]"
ms.assetid: 74192be5-bb8d-499d-b540-283cecd999cd
caps.latest.revision: 25
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Enumerations (F#)
*Enumerations*, also known as *enums*, , are integral types where labels are assigned to a subset of the values. You can use them in place of literals to make code more readable and maintainable.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Remarks  
 An enumeration looks much like a discriminated union that has simple values, except that the values can be specified. The values are typically integers that start at 0 or 1, or integers that represent bit positions. If an enumeration is intended to represent bit positions, you should also use the \<xref:System.FlagsAttribute*> attribute.  
  
 The underlying type of the enumeration is determined from the literal that is used, so that, for example, you can use literals with a suffix, such as <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>, and so on, for an unsigned integer (<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>) type.  
  
 When you refer to the named values, you must use the name of the enumeration type itself as a qualifier, that is, <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>, not just <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>. This behavior differs from that of discriminated unions. This is because enumerations always have the [RequireQualifiedAccess](../vs140/core.requirequalifiedaccessattribute-class--fsharp-.md) attribute.  
  
 The following code shows the declaration and use of an enumeration.  
  
 [!code[FsLangRef1#2101](../vs140/codesnippet/FSharp/enumerations--fsharp-_1.fs)]  
  
 You can easily convert enumerations to the underlying type by using the appropriate operator, as shown in the following code.  
  
 [!code[FsLangRef1#2102](../vs140/codesnippet/FSharp/enumerations--fsharp-_2.fs)]  
  
 Enumerated types can have one of the following underlying types: <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>7\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>8\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>9\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>10\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>11\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>12\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>13\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>14\</CodeContentPlaceHolder>, and <CodeContentPlaceHolder>15\</CodeContentPlaceHolder>. Enumeration types are represented in the .NET Framework as types that are inherited from \<xref:System.Enum*>, which in turn is inherited from \<xref:System.ValueType*>. Thus, they are value types that are located on the stack or inline in the containing object, and any value of the underlying type is a valid value of the enumeration. This is significant when pattern matching on enumeration values, because you have to provide a pattern that catches the unnamed values.  
  
 The <CodeContentPlaceHolder>16\</CodeContentPlaceHolder> function in the F# library can be used to generate an enumeration value, even a value other than one of the predefined, named values. You use the <CodeContentPlaceHolder>17\</CodeContentPlaceHolder> function as follows.  
  
 [!code[FsLangRef1#2103](../vs140/codesnippet/FSharp/enumerations--fsharp-_3.fs)]  
  
 The default <CodeContentPlaceHolder>18\</CodeContentPlaceHolder> function works with type <CodeContentPlaceHolder>19\</CodeContentPlaceHolder>. Therefore, it cannot be used with enumeration types that have other underlying types. Instead, use the following.  
  
 [!code[FsLangRef1#2104](../vs140/codesnippet/FSharp/enumerations--fsharp-_4.fs)]  
  
## See Also  
 [F# Language Reference](../vs140/fsharp-language-reference.md)   
 [Casting and Conversions](../vs140/casting-and-conversions--fsharp-.md)