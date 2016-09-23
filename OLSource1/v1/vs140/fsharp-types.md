---
title: "F# Types"
ms.custom: na
ms.date: 09/23/2016
ms.prod: visual-studio-dev14
ms.reviewer: na
ms.suite: na
ms.technology: 
  - devlang-fsharp
ms.tgt_pltfrm: na
ms.topic: reference
dev_langs: 
  - FSharp
helpviewer_keywords: 
  - type system [F#]
  - types [F#]
ms.assetid: ad925524-aca1-4594-a707-038bb7cc0978
caps.latest.revision: 27
translation.priority.ht: 
  - de-de
  - ja-jp
---
# F# Types
This topic describes the types that are used in F# and how F# types are named and described.  
  
## Summary of F# Types  
 Some types are considered *primitive types*, such as the Boolean type `bool` and integral and floating point types of various sizes, which include types for bytes and characters. These types are described in [Primitive Types (F#)](../vs140/primitive-types--fsharp-.md).  
  
 Other types that are built into the language include tuples, lists, arrays, sequences, records, and discriminated unions. If you have experience with other .NET languages and are learning F#, you should read the topics for each of these types. Links to more information about these types are included in the [Related Topics](#rel) section of this topic. These F#-specific types support styles of programming that are common to functional programming languages. Many of these types have associated modules in the F# library that support common operations on these types.  
  
 The type of a function includes information about the parameter types and return type.  
  
 The [!INCLUDE[dnprdnshort](../vs140/includes/dnprdnshort_md.md)] is the source of object types, interface types, delegate types, and others. You can define your own object types just as you can in any other .NET language.  
  
 Also, F# code can define aliases, which are named *type abbreviations*, that are alternative names for types. You might use type abbreviations when the type might change in the future and you want to avoid changing the code that depends on the type. Or, you might use a type abbreviation as a friendly name for a type that can make code easier to read and understand.  
  
 F# provides useful collection types that are designed with functional programming in mind. Using these collection types helps you write code that is more functional in style. For more information, see [F# Collection Types](../vs140/fsharp-collection-types.md).  
  
## Syntax for Types  
 In F# code, you often have to write out the names of types. Every type has a syntactic form, and you use these syntactic forms in type annotations, abstract method declarations, delegate declarations, signatures, and other constructs. Whenever you declare a new program construct in the interpreter, the interpreter prints the name of the construct and the syntax for its type. This syntax might be just an identifier for a user-defined type or a built-in identifier such as for `int` or `string`, but for more complex types, the syntax is more complex.  
  
 The following table shows aspects of the type syntax for F# types.  
  
|Type|Type syntax|Examples|  
|----------|-----------------|--------------|  
|primitive type|`type-name`|`int`<br /><br /> `float`<br /><br /> `string`|  
|aggregate type (class, structure, union, record, enum, and so on)|`type-name`|`System.DateTime`<br /><br /> `Color`|  
|type abbreviation|`type-abbreviation-name`|`bigint`|  
|fully qualified type|`namespaces.type-name`<br /><br /> or<br /><br /> `modules.type-name`<br /><br /> or<br /><br /> `namespaces.modules.type-name`|`System.IO.StreamWriter`|  
|array|`type-name`[] or<br /><br /> `type-name` array|`int[]`<br /><br /> `array<int>`<br /><br /> `int array`|  
|two-dimensional array|`type-name`[,]|`int[,]`<br /><br /> `float[,]`|  
|three-dimensional array|`type-name`[,,]|`float[,,]`|  
|tuple|`type-name1` * `type-name2` ...|For example, `(1,'b',3)` has type `int * char * int`|  
|generic type|`type-parameter` `generic-type-name`<br /><br /> or<br /><br /> `generic-type-name`<`type-parameter-list`>|`'a list`<br /><br /> `list<'a>`<br /><br /> `Dictionary<'key, 'value>`|  
|constructed type (a generic type that has a specific type argument supplied)|`type-argument` `generic-type-name`<br /><br /> or<br /><br /> `generic-type-name`<`type-argument-list`>|`int option`<br /><br /> `string list`<br /><br /> `int ref`<br /><br /> `option<int>`<br /><br /> `list<string>`<br /><br /> `ref<int>`<br /><br /> `Dictionary<int, string>`|  
|function type that has a single parameter|`parameter-type1` -> `return-type`|A function that takes an `int` and returns a `string` has type `int -> string`|  
|function type that has multiple parameters|`parameter-type1` -> `parameter-type2` -> ... -> `return-type`|A function that takes an `int` and a `float` and returns a `string` has type `int -> float -> string`|  
|higher order function as a parameter|(`function-type`)|`List.map` has type `('a -> 'b) -> 'a list -> 'b list`|  
|delegate|delegate of `function-type`|`delegate of unit -> int`|  
|flexible type|#`type-name`|`#System.Windows.Forms.Control`<br /><br /> `#seq<int>`|  
  
##  <a name="rel"></a> Related Topics  
  
|Topic|Description|  
|-----------|-----------------|  
|[Primitive Types (F#)](../vs140/primitive-types--fsharp-.md)|Describes built-in simple types such as integral types, the Boolean type, and character types.|  
|[Unit Type](../vs140/unit-type--fsharp-.md)|Describes the `unit` type, a type that has one value and that is indicated by (); equivalent to `void` in C# and `Nothing` in [!INCLUDE[vbprvb](../vs140/includes/vbprvb_md.md)].|  
|[Tuples](../vs140/tuples--fsharp-.md)|Describes the tuple type, a type that consists of associated values of any type grouped in pairs, triples, quadruples, and so on.|  
|[Options](../vs140/options--fsharp-.md)|Describes the option type, a type that may either have a value or be empty.|  
|[Lists](../vs140/lists--fsharp-.md)|Describes lists, which are ordered, immutable series of elements all of the same type.|  
|[Arrays](../vs140/arrays--fsharp-.md)|Describes arrays, which are ordered sets of mutable elements of the same type that occupy a contiguous block of memory and are of fixed size.|  
|[Sequences](../vs140/sequences--fsharp-.md)|Describes the sequence type, which represents a logical series of values; individual values are computed only as necessary.|  
|[Records](../vs140/records--fsharp-.md)|Describes the record type, a small aggregate of named values.|  
|[Discriminated Unions](../vs140/discriminated-unions--fsharp-.md)|Describes the discriminated union type, a type whose values can be any one of a set of possible types.|  
|[Functions](../vs140/functions--fsharp-.md)|Describes function values.|  
|[Classes](../vs140/classes--fsharp-.md)|Describes the class type, an object type that corresponds to a .NET reference type. Class types can contain members, properties, implemented interfaces, and a base type.|  
|[Structures](../vs140/structures--fsharp-.md)|Describes the `struct` type, an object type that corresponds to a .NET value type. The `struct` type usually represents a small aggregate of data.|  
|[Interfaces](../vs140/interfaces--fsharp-.md)|Describes interface types, which are types that represent a set of members that provide certain functionality but that contain no data. An interface type must be implemented by an object type to be useful.|  
|[Delegates](../vs140/delegates--fsharp-.md)|Describes the delegate type, which represents a function as an object.|  
|[Enumerations](../vs140/enumerations--fsharp-.md)|Describes enumeration types, whose values belong to a set of named values.|  
|[Attributes](../vs140/attributes--fsharp-.md)|Describes attributes, which are used to specify metadata for another type.|  
|[Exception Types](../vs140/exception-types--fsharp-.md)|Describes exceptions, which specify error information.|