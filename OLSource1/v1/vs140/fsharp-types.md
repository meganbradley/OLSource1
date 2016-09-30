---
title: "F# Types"
ms.custom: na
ms.date: "09/23/2016"
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
  - "type system [F#]"
  - "types [F#]"
ms.assetid: ad925524-aca1-4594-a707-038bb7cc0978
caps.latest.revision: 27
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# F# Types
This topic describes the types that are used in F# and how F# types are named and described.  
  
## Summary of F# Types  
 Some types are considered *primitive types*, such as the Boolean type <CodeContentPlaceHolder>0\</CodeContentPlaceHolder> and integral and floating point types of various sizes, which include types for bytes and characters. These types are described in [Primitive Types (F#)](../vs140/primitive-types--fsharp-.md).  
  
 Other types that are built into the language include tuples, lists, arrays, sequences, records, and discriminated unions. If you have experience with other .NET languages and are learning F#, you should read the topics for each of these types. Links to more information about these types are included in the [Related Topics](#rel) section of this topic. These F#-specific types support styles of programming that are common to functional programming languages. Many of these types have associated modules in the F# library that support common operations on these types.  
  
 The type of a function includes information about the parameter types and return type.  
  
 The [!INCLUDE[dnprdnshort](../vs140/includes/dnprdnshort_md.md)] is the source of object types, interface types, delegate types, and others. You can define your own object types just as you can in any other .NET language.  
  
 Also, F# code can define aliases, which are named *type abbreviations*, that are alternative names for types. You might use type abbreviations when the type might change in the future and you want to avoid changing the code that depends on the type. Or, you might use a type abbreviation as a friendly name for a type that can make code easier to read and understand.  
  
 F# provides useful collection types that are designed with functional programming in mind. Using these collection types helps you write code that is more functional in style. For more information, see [F# Collection Types](../vs140/fsharp-collection-types.md).  
  
## Syntax for Types  
 In F# code, you often have to write out the names of types. Every type has a syntactic form, and you use these syntactic forms in type annotations, abstract method declarations, delegate declarations, signatures, and other constructs. Whenever you declare a new program construct in the interpreter, the interpreter prints the name of the construct and the syntax for its type. This syntax might be just an identifier for a user-defined type or a built-in identifier such as for <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> or <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>, but for more complex types, the syntax is more complex.  
  
 The following table shows aspects of the type syntax for F# types.  
  
|Type|Type syntax|Examples|  
|----------|-----------------|--------------|  
|primitive type|<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>4\</CodeContentPlaceHolder>\<br />\<br /> <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>\<br />\<br /> <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>|  
|aggregate type (class, structure, union, record, enum, and so on)|<CodeContentPlaceHolder>7\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>8\</CodeContentPlaceHolder>\<br />\<br /> <CodeContentPlaceHolder>9\</CodeContentPlaceHolder>|  
|type abbreviation|<CodeContentPlaceHolder>10\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>11\</CodeContentPlaceHolder>|  
|fully qualified type|<CodeContentPlaceHolder>12\</CodeContentPlaceHolder>\<br />\<br /> or\<br />\<br /> <CodeContentPlaceHolder>13\</CodeContentPlaceHolder>\<br />\<br /> or\<br />\<br /> <CodeContentPlaceHolder>14\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>15\</CodeContentPlaceHolder>|  
|array|<CodeContentPlaceHolder>16\</CodeContentPlaceHolder>[] or\<br />\<br /> <CodeContentPlaceHolder>17\</CodeContentPlaceHolder> array|<CodeContentPlaceHolder>18\</CodeContentPlaceHolder>\<br />\<br /> <CodeContentPlaceHolder>19\</CodeContentPlaceHolder>\<br />\<br /> <CodeContentPlaceHolder>20\</CodeContentPlaceHolder>|  
|two-dimensional array|<CodeContentPlaceHolder>21\</CodeContentPlaceHolder>[,]|<CodeContentPlaceHolder>22\</CodeContentPlaceHolder>\<br />\<br /> <CodeContentPlaceHolder>23\</CodeContentPlaceHolder>|  
|three-dimensional array|<CodeContentPlaceHolder>24\</CodeContentPlaceHolder>[,,]|<CodeContentPlaceHolder>25\</CodeContentPlaceHolder>|  
|tuple|<CodeContentPlaceHolder>26\</CodeContentPlaceHolder> * <CodeContentPlaceHolder>27\</CodeContentPlaceHolder> ...|For example, <CodeContentPlaceHolder>28\</CodeContentPlaceHolder> has type <CodeContentPlaceHolder>29\</CodeContentPlaceHolder>|  
|generic type|<CodeContentPlaceHolder>30\</CodeContentPlaceHolder> <CodeContentPlaceHolder>31\</CodeContentPlaceHolder>\<br />\<br /> or\<br />\<br /> <CodeContentPlaceHolder>32\</CodeContentPlaceHolder><<CodeContentPlaceHolder>33\</CodeContentPlaceHolder>>|<CodeContentPlaceHolder>34\</CodeContentPlaceHolder>\<br />\<br /> <CodeContentPlaceHolder>35\</CodeContentPlaceHolder>\<br />\<br /> <CodeContentPlaceHolder>36\</CodeContentPlaceHolder>|  
|constructed type (a generic type that has a specific type argument supplied)|<CodeContentPlaceHolder>37\</CodeContentPlaceHolder> <CodeContentPlaceHolder>38\</CodeContentPlaceHolder>\<br />\<br /> or\<br />\<br /> <CodeContentPlaceHolder>39\</CodeContentPlaceHolder><<CodeContentPlaceHolder>40\</CodeContentPlaceHolder>>|<CodeContentPlaceHolder>41\</CodeContentPlaceHolder>\<br />\<br /> <CodeContentPlaceHolder>42\</CodeContentPlaceHolder>\<br />\<br /> <CodeContentPlaceHolder>43\</CodeContentPlaceHolder>\<br />\<br /> <CodeContentPlaceHolder>44\</CodeContentPlaceHolder>\<br />\<br /> <CodeContentPlaceHolder>45\</CodeContentPlaceHolder>\<br />\<br /> <CodeContentPlaceHolder>46\</CodeContentPlaceHolder>\<br />\<br /> <CodeContentPlaceHolder>47\</CodeContentPlaceHolder>|  
|function type that has a single parameter|<CodeContentPlaceHolder>48\</CodeContentPlaceHolder> -> <CodeContentPlaceHolder>49\</CodeContentPlaceHolder>|A function that takes an <CodeContentPlaceHolder>50\</CodeContentPlaceHolder> and returns a <CodeContentPlaceHolder>51\</CodeContentPlaceHolder> has type <CodeContentPlaceHolder>52\</CodeContentPlaceHolder>|  
|function type that has multiple parameters|<CodeContentPlaceHolder>53\</CodeContentPlaceHolder> -> <CodeContentPlaceHolder>54\</CodeContentPlaceHolder> -> ... -> <CodeContentPlaceHolder>55\</CodeContentPlaceHolder>|A function that takes an <CodeContentPlaceHolder>56\</CodeContentPlaceHolder> and a <CodeContentPlaceHolder>57\</CodeContentPlaceHolder> and returns a <CodeContentPlaceHolder>58\</CodeContentPlaceHolder> has type <CodeContentPlaceHolder>59\</CodeContentPlaceHolder>|  
|higher order function as a parameter|(<CodeContentPlaceHolder>60\</CodeContentPlaceHolder>)|<CodeContentPlaceHolder>61\</CodeContentPlaceHolder> has type <CodeContentPlaceHolder>62\</CodeContentPlaceHolder>|  
|delegate|delegate of <CodeContentPlaceHolder>63\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>64\</CodeContentPlaceHolder>|  
|flexible type|#<CodeContentPlaceHolder>65\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>66\</CodeContentPlaceHolder>\<br />\<br /> <CodeContentPlaceHolder>67\</CodeContentPlaceHolder>|  
  
##  \<a name="rel">\</a> Related Topics  
  
|Topic|Description|  
|-----------|-----------------|  
|[Primitive Types (F#)](../vs140/primitive-types--fsharp-.md)|Describes built-in simple types such as integral types, the Boolean type, and character types.|  
|[Unit Type](../vs140/unit-type--fsharp-.md)|Describes the <CodeContentPlaceHolder>68\</CodeContentPlaceHolder> type, a type that has one value and that is indicated by (); equivalent to <CodeContentPlaceHolder>69\</CodeContentPlaceHolder> in C# and <CodeContentPlaceHolder>70\</CodeContentPlaceHolder> in [!INCLUDE[vbprvb](../vs140/includes/vbprvb_md.md)].|  
|[Tuples](../vs140/tuples--fsharp-.md)|Describes the tuple type, a type that consists of associated values of any type grouped in pairs, triples, quadruples, and so on.|  
|[Options](../vs140/options--fsharp-.md)|Describes the option type, a type that may either have a value or be empty.|  
|[Lists](../vs140/lists--fsharp-.md)|Describes lists, which are ordered, immutable series of elements all of the same type.|  
|[Arrays](../vs140/arrays--fsharp-.md)|Describes arrays, which are ordered sets of mutable elements of the same type that occupy a contiguous block of memory and are of fixed size.|  
|[Sequences](../vs140/sequences--fsharp-.md)|Describes the sequence type, which represents a logical series of values; individual values are computed only as necessary.|  
|[Records](../vs140/records--fsharp-.md)|Describes the record type, a small aggregate of named values.|  
|[Discriminated Unions](../vs140/discriminated-unions--fsharp-.md)|Describes the discriminated union type, a type whose values can be any one of a set of possible types.|  
|[Functions](../vs140/functions--fsharp-.md)|Describes function values.|  
|[Classes](../vs140/classes--fsharp-.md)|Describes the class type, an object type that corresponds to a .NET reference type. Class types can contain members, properties, implemented interfaces, and a base type.|  
|[Structures](../vs140/structures--fsharp-.md)|Describes the <CodeContentPlaceHolder>71\</CodeContentPlaceHolder> type, an object type that corresponds to a .NET value type. The <CodeContentPlaceHolder>72\</CodeContentPlaceHolder> type usually represents a small aggregate of data.|  
|[Interfaces](../vs140/interfaces--fsharp-.md)|Describes interface types, which are types that represent a set of members that provide certain functionality but that contain no data. An interface type must be implemented by an object type to be useful.|  
|[Delegates](../vs140/delegates--fsharp-.md)|Describes the delegate type, which represents a function as an object.|  
|[Enumerations](../vs140/enumerations--fsharp-.md)|Describes enumeration types, whose values belong to a set of named values.|  
|[Attributes](../vs140/attributes--fsharp-.md)|Describes attributes, which are used to specify metadata for another type.|  
|[Exception Types](../vs140/exception-types--fsharp-.md)|Describes exceptions, which specify error information.|