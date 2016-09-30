---
title: "Attributes (F#)"
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
  - "attributes [F#]"
ms.assetid: 101c31d6-aced-4419-b5e4-ff1df582f91f
caps.latest.revision: 25
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Attributes (F#)
Attributes enable metadata to be applied to a programming construct.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Remarks  
 In the previous syntax, the <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> is optional and, if present, specifies the kind of program entity that the attribute applies to. Valid values for <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> are shown in the table that appears later in this document.  
  
 The <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> refers to the name (possibly qualified with namespaces) of a valid attribute type, with or without the suffix <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> that is usually used in attribute type names. For example, the type <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> can be shortened to just <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> in this context.  
  
 The <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> are the arguments to the constructor for the attribute type. If an attribute has a default constructor, the argument list and parentheses can be omitted. Attributes support both positional arguments and named arguments. *Positional arguments* are arguments that are used in the order in which they appear. Named arguments can be used if the attribute has public properties. You can set these by using the following syntax in the argument list.  
  
 <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> = <CodeContentPlaceHolder>9\</CodeContentPlaceHolder>  
  
 Such property initializations can be in any order, but they must follow any positional arguments. Following is an example of an attribute that uses positional arguments and property initializations.  
  
 [!code[FsLangRef2#6202](../vs140/codesnippet/FSharp/attributes--fsharp-_1.fs)]  
  
 In this example, the attribute is <CodeContentPlaceHolder>10\</CodeContentPlaceHolder>, here used in shortened form. The first argument is a positional parameter and the second is a property.  
  
 Attributes are a .NET programming construct that enables an object known as an *attribute* to be associated with a type or other program element. The program element to which an attribute is applied is known as the *attribute target*. The attribute usually contains metadata about its target. In this context, metadata could be any data about the type other than its fields and members.  
  
 Attributes in F# can be applied to the following programming constructs: functions, methods, assemblies, modules, types (classes, records, structures, interfaces, delegates, enumerations, unions, and so on), constructors, properties, fields, parameters, type parameters, and return values. Attributes are not allowed on <CodeContentPlaceHolder>11\</CodeContentPlaceHolder> bindings inside classes, expressions, or workflow expressions.  
  
 Typically, the attribute declaration appears directly before the declaration of the attribute target. Multiple attribute declarations can be used together, as follows.  
  
 [!code[FsLangRef2#6603](../vs140/codesnippet/FSharp/attributes--fsharp-_2.fs)]  
  
 You can query attributes at run time by using .NET reflection.  
  
 You can declare multiple attributes individually, as in the previous code example, or you can declare them in one set of brackets if you use a semicolon to separate the individual attributes and constructors, as shown here.  
  
 [!code[FsLangRef2#6604](../vs140/codesnippet/FSharp/attributes--fsharp-_3.fs)]  
  
 Typically encountered attributes include the <CodeContentPlaceHolder>12\</CodeContentPlaceHolder> attribute, attributes for security considerations, attributes for COM support, attributes that relate to ownership of code, and attributes indicating whether a type can be serialized. The following example demonstrates the use of the <CodeContentPlaceHolder>13\</CodeContentPlaceHolder> attribute.  
  
 [!code[FsLangRef2#6605](../vs140/codesnippet/FSharp/attributes--fsharp-_4.fs)]  
  
 For the attribute targets <CodeContentPlaceHolder>14\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>15\</CodeContentPlaceHolder>, you apply the attributes to a top-level <CodeContentPlaceHolder>16\</CodeContentPlaceHolder> binding in your assembly. You can include the word <CodeContentPlaceHolder>17\</CodeContentPlaceHolder> or <CodeContentPlaceHolder>18\</CodeContentPlaceHolder> in the attribute declaration, as follows.  
  
 [!code[FsLangRef2#6606](../vs140/codesnippet/FSharp/attributes--fsharp-_5.fs)]  
  
 If you omit the attribute target for an attribute applied to a <CodeContentPlaceHolder>19\</CodeContentPlaceHolder> binding, the F# compiler attempts to determine the attribute target that makes sense for that attribute. Many attribute classes have an attribute of type \<xref:System.AttributeUsageAttribute*> that includes information about the possible targets supported for that attribute. If the \<xref:System.AttributeUsageAttribute*> indicates that the attribute supports functions as targets, the attribute is taken to apply to the main entry point of the program. If the \<xref:System.AttributeUsageAttribute*> indicates that the attribute supports assemblies as targets, the compiler takes the attribute to apply to the assembly. Most attributes do not apply to both functions and assemblies, but in cases where they do, the attribute is taken to apply to the program's main function. If the attribute target is specified explicitly, the attribute is applied to the specified target.  
  
 Although you do not usually need to specify the attribute target explicitly, valid values for <CodeContentPlaceHolder>20\</CodeContentPlaceHolder> in an attribute are shown in the following table, along with examples of usage.  
  
|Attribute target|Example|  
|----------------------|-------------|  
|assembly|<CodeContentPlaceHolder>21\</CodeContentPlaceHolder>|  
|return|<CodeContentPlaceHolder>22\</CodeContentPlaceHolder>|  
|field|<CodeContentPlaceHolder>23\</CodeContentPlaceHolder>|  
|property|<CodeContentPlaceHolder>24\</CodeContentPlaceHolder>|  
|param|<CodeContentPlaceHolder>25\</CodeContentPlaceHolder>|  
|type|<CodeContentPlaceHolder>26\</CodeContentPlaceHolder>\<br />\<br /> <CodeContentPlaceHolder>27\</CodeContentPlaceHolder>\<br />\<br /> <CodeContentPlaceHolder>28\</CodeContentPlaceHolder>\<br />\<br /> <CodeContentPlaceHolder>29\</CodeContentPlaceHolder>\<br />\<br /> <CodeContentPlaceHolder>30\</CodeContentPlaceHolder>\<br />\<br /> <CodeContentPlaceHolder>31\</CodeContentPlaceHolder>|  
  
## See Also  
 [F# Language Reference](../vs140/fsharp-language-reference.md)