---
title: "Explicit Fields: The val Keyword (F#)"
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
  - "explicit fields [F#]"
  - "val keyword [F#]"
ms.assetid: a58c4413-16c7-4e1a-8995-0ccc6e044157
caps.latest.revision: 31
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Explicit Fields: The val Keyword (F#)
The <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> keyword is used to declare a location to store a value in a class or structure type, without initializing it. Storage locations declared in this manner are called *explicit fields*. Another use of the <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> keyword is in conjunction with the <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> keyword to declare an auto-implemented property. For more information on auto-implemented properties, see [Properties (F#)](../vs140/properties--fsharp-.md).  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Remarks  
 The usual way to define fields in a class or structure type is to use a <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> binding. However, <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> bindings must be initialized as part of the class constructor, which is not always possible, necessary, or desirable. You can use the <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> keyword when you want a field that is uninitialized.  
  
 Explicit fields can be static or non-static. The <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> can be <CodeContentPlaceHolder>8\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>9\</CodeContentPlaceHolder>, or <CodeContentPlaceHolder>10\</CodeContentPlaceHolder>. By default, explicit fields are public. This differs from <CodeContentPlaceHolder>11\</CodeContentPlaceHolder> bindings in classes, which are always private.  
  
 The [DefaultValue](../vs140/core.defaultvalueattribute-class--fsharp-.md) attribute is required on explicit fields in class types that have a primary constructor. This attribute specifies that the field is initialized to zero. The type of the field must support zero-initialization. A type supports zero-initialization if it is one of the following:  
  
-   A primitive type that has a zero value.  
  
-   A type that supports a null value, either as a normal value, as an abnormal value, or as a representation of a value. This includes classes, tuples, records, functions, interfaces, .NET reference types, the <CodeContentPlaceHolder>12\</CodeContentPlaceHolder> type, and discriminated union types.  
  
-   A .NET value type.  
  
-   A structure whose fields all support a default zero value.  
  
 For example, an immutable field called <CodeContentPlaceHolder>13\</CodeContentPlaceHolder> has a backing field in the .NET compiled representation with the name <CodeContentPlaceHolder>14\</CodeContentPlaceHolder>, and you access the stored value using a property named <CodeContentPlaceHolder>15\</CodeContentPlaceHolder>.  
  
 For a mutable field, the .NET compiled representation is a .NET field.  
  
> [!WARNING]
>  **Note** The .NET Framework namespace \<xref:System.ComponentModel*> contains an attribute that has the same name. For information about this attribute, see \<xref:System.ComponentModel.DefaultValueAttribute*>.  
  
 The following code shows the use of explicit fields and, for comparison, a <CodeContentPlaceHolder>16\</CodeContentPlaceHolder> binding in a class that has a primary constructor. Note that the <CodeContentPlaceHolder>17\</CodeContentPlaceHolder>-bound field <CodeContentPlaceHolder>18\</CodeContentPlaceHolder> is private. When the <CodeContentPlaceHolder>19\</CodeContentPlaceHolder>-bound field <CodeContentPlaceHolder>20\</CodeContentPlaceHolder> is referenced from a member method, the self identifier <CodeContentPlaceHolder>21\</CodeContentPlaceHolder> is not required. But when you are referencing the explicit fields <CodeContentPlaceHolder>22\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>23\</CodeContentPlaceHolder>, the self identifier is required.  
  
 [!code[FsLangRef2#6701](../vs140/codesnippet/FSharp/explicit-fields--the-val-keyword--fsharp-_1.fs)]  
  
 The output is as follows:  
  
 <CodeContentPlaceHolder>24\</CodeContentPlaceHolder>  
  
 <CodeContentPlaceHolder>25\</CodeContentPlaceHolder>  
  
 The following code shows the use of explicit fields in a class that does not have a primary constructor. In this case, the <CodeContentPlaceHolder>26\</CodeContentPlaceHolder> attribute is not required, but all the fields must be initialized in the constructors that are defined for the type.  
  
 [!code[FsLangRef2#6702](../vs140/codesnippet/FSharp/explicit-fields--the-val-keyword--fsharp-_2.fs)]  
  
 The output is <CodeContentPlaceHolder>27\</CodeContentPlaceHolder>.  
  
 The following code shows the use of explicit fields in a structure. Because a structure is a value type, it automatically has a default constructor that sets the values of its fields to zero. Therefore, the <CodeContentPlaceHolder>28\</CodeContentPlaceHolder> attribute is not required.  
  
 [!code[FsLangRef2#6703](../vs140/codesnippet/FSharp/explicit-fields--the-val-keyword--fsharp-_3.fs)]  
  
 The output is <CodeContentPlaceHolder>29\</CodeContentPlaceHolder>.  
  
 Explicit fields are not intended for routine use. In general, when possible you should use a <CodeContentPlaceHolder>30\</CodeContentPlaceHolder> binding in a class instead of an explicit field. Explicit fields are useful in certain interoperability scenarios, such as when you need to define a structure that will be used in a platform invoke call to a native API, or in COM interop scenarios. For more information, see [External Functions](../vs140/external-functions--fsharp-.md). Another situation in which an explicit field might be necessary is when you are working with an F# code generator which emits classes without a primary constructor. Explicit fields are also useful for thread-static variables or similar constructs. For more information, see \<xref:System.ThreadStaticAttribute*>.  
  
 When the keywords <CodeContentPlaceHolder>31\</CodeContentPlaceHolder> appear together in a type definition, it is a definition of an automatically implemented property. For more information, see [Properties (F#)](../vs140/properties--fsharp-.md).  
  
## See Also  
 [Properties (F#)](../vs140/properties--fsharp-.md)   
 [Members (F#)](../vs140/members--fsharp-.md)   
 [let Bindings in Classes (F#)](../vs140/let-bindings-in-classes--fsharp-.md)