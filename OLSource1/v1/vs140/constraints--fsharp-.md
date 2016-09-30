---
title: "Constraints (F#)"
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
  - "generic constraints [F#]"
  - "when keyword [F#]"
  - "generics [F#], constraints"
  - "type parameters [F#], constraints"
  - "generics, constraints [F#]"
  - "constraints [F#]"
ms.assetid: 60ab9a9b-5b9f-4193-af1e-5f06131fac07
caps.latest.revision: 24
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Constraints (F#)
This topic describes constraints that you can apply to generic type parameters to specify the requirements for a type argument in a generic type or function.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Remarks  
 There are several different constraints you can apply to limit the types that can be used in a generic type. The following table lists and describes these constraints.  
  
|Constraint|Syntax|Description|  
|----------------|------------|-----------------|  
|Type Constraint|<CodeContentPlaceHolder>2\</CodeContentPlaceHolder> :> <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>|The provided type must be equal to or derived from the type specified, or, if the type is an interface, the provided type must implement the interface.|  
|Null Constraint|<CodeContentPlaceHolder>4\</CodeContentPlaceHolder> : null|The provided type must support the null literal. This includes all .NET object types but not F# list, tuple, function, class, record, or union types.|  
|Explicit Member Constraint|[(]<CodeContentPlaceHolder>5\</CodeContentPlaceHolder> [or ... or <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>)] : (<CodeContentPlaceHolder>7\</CodeContentPlaceHolder> )|At least one of the type arguments provided must have a member that has the specified signature; not intended for common use.|  
|Constructor Constraint|<CodeContentPlaceHolder>8\</CodeContentPlaceHolder> : ( new : unit -> 'a )|The provided type must have a default constructor.|  
|Value Type Constraint|: struct|The provided type must be a .NET value type.|  
|Reference Type Constraint|: not struct|The provided type must be a .NET reference type.|  
|Enumeration Type Constraint|: enum<<CodeContentPlaceHolder>9\</CodeContentPlaceHolder>>|The provided type must be an enumerated type that has the specified underlying type; not intended for common use.|  
|Delegate Constraint|: delegate<<CodeContentPlaceHolder>10\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>11\</CodeContentPlaceHolder>>|The provided type must be a delegate type that has the specified arguments and return value; not intended for common use.|  
|Comparison Constraint|: comparison|The provided type must support comparison.|  
|Equality Constraint|: equality|The provided type must support equality.|  
|Unmanaged Constraint|: unmanaged|The provided type must be an unmanaged type. Unmanaged types are either certain primitive types (<CodeContentPlaceHolder>12\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>13\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>14\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>15\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>16\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>17\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>18\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>19\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>20\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>21\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>22\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>23\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>24\</CodeContentPlaceHolder>, or <CodeContentPlaceHolder>25\</CodeContentPlaceHolder>), enumeration types, <CodeContentPlaceHolder>26\</CodeContentPlaceHolder>, or a non-generic structure whose fields are all unmanaged types.|  
  
 You have to add a constraint when your code has to use a feature that is available on the constraint type but not on types in general. For example, if you use the type constraint to specify a class type, you can use any one of the methods of that class in the generic function or type.  
  
 Specifying constraints is sometimes required when writing type parameters explicitly, because without a constraint, the compiler has no way of verifying that the features that you are using will be available on any type that might be supplied at run time for the type parameter.  
  
 The most common constraints you use in F# code are type constraints that specify base classes or interfaces. The other constraints are either used by the F# library to implement certain functionality, such as the explicit member constraint, which is used to implement operator overloading for arithmetic operators, or are provided mainly because F# supports the complete set of constraints that is supported by the common language runtime.  
  
 During the type inference process, some constraints are inferred automatically by the compiler. For example, if you use the <CodeContentPlaceHolder>27\</CodeContentPlaceHolder> operator in a function, the compiler infers an explicit member constraint on variable types that are used in the expression.  
  
 The following code illustrates some constraint declarations.  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
## See Also  
 [Generics (F#)](../vs140/generics--fsharp-.md)   
 [Automatic Generalization](../vs140/constraints--fsharp-.md)