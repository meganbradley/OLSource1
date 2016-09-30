---
title: "Properties (F#)"
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
  - "get keyword [F#]"
  - "properties [F#]"
  - "set keyword [F#]"
  - "accessors [F#]"
ms.assetid: 2990db78-ff3a-44ad-92b4-94f974b141fb
caps.latest.revision: 29
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Properties (F#)
*Properties* are members that represent values associated with an object.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Remarks  
 Properties represent the "has a" relationship in object-oriented programming, representing data that is associated with object instances or, for static properties, with the type.  
  
 You can declare properties in two ways, depending on whether you want to explicitly specify the underlying value (also called the backing store) for the property, or if you want to allow the compiler to automatically generate the backing store for you. Generally, you should use the more explicit way if the property has a non-trivial implementation and the automatic way when the property is just a simple wrapper for a value or variable. To declare a property explicitly, use the <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> keyword. This declarative syntax is followed by the syntax that specifies the <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> methods, also named *accessors*. The various forms of the explicit syntax shown in the syntax section are used for read/write, read-only, and write-only properties. For read-only properties, you define only a <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> method; for write-only properties, define only a <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> method. Note that when a property has both <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> accessors, the alternative syntax enables you to specify attributes and accessibility modifiers that are different for each accessor, as is shown in the following code.  
  
 [!code[FsLangRef1#3201](../vs140/codesnippet/FSharp/properties--fsharp-_1.fs)]  
  
 For read/write properties, which have both a <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>11\</CodeContentPlaceHolder> method, the order of <CodeContentPlaceHolder>12\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>13\</CodeContentPlaceHolder> can be reversed. Alternatively, you can provide the syntax shown for <CodeContentPlaceHolder>14\</CodeContentPlaceHolder> only and the syntax shown for <CodeContentPlaceHolder>15\</CodeContentPlaceHolder> only instead of using the combined syntax. Doing this makes it easier to comment out the individual <CodeContentPlaceHolder>16\</CodeContentPlaceHolder> or <CodeContentPlaceHolder>17\</CodeContentPlaceHolder> method, if that is something you might need to do. This alternative to using the combined syntax is shown in the following code.  
  
 [!code[FsLangRef1#3203](../vs140/codesnippet/FSharp/properties--fsharp-_2.fs)]  
  
 Private values that hold the data for properties are called *backing stores*. To have the compiler create the backing store automatically, use the keywords <CodeContentPlaceHolder>18\</CodeContentPlaceHolder>, omit the self-identifier, then provide an expression to initialize the property. If the property is to be mutable, include <CodeContentPlaceHolder>19\</CodeContentPlaceHolder>. For example, the following class type includes two automatically implemented properties.  <CodeContentPlaceHolder>20\</CodeContentPlaceHolder> is read-only and is initialized to the argument provided to the primary constructor, and <CodeContentPlaceHolder>21\</CodeContentPlaceHolder> is a settable property initialized to an empty string:  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 Automatically implemented properties are part of the initialization of a type, so they must be included before any other member definitions, just like <CodeContentPlaceHolder>22\</CodeContentPlaceHolder> bindings and <CodeContentPlaceHolder>23\</CodeContentPlaceHolder> bindings in a type definition. Note that the expression that initializes an automatically implemented property is only evaluated upon initialization, and not every time the property is accessed. This behavior is in contrast to the behavior of an explicitly implemented property. What this effectively means is that the code to initialize these properties is added to the constructor of a class. Consider the following code that shows this difference:  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 **Output**  
  
 **class1.AutoProperty = 1853799794class1.AutoProperty = 1853799794class1.ExplicitProperty = 978922705class1.ExplicitProperty = 1131210765** The output of the preceding code shows that the value of AutoProperty is unchanged when called repeatedly, whereas the ExplicitProperty changes each time it is called. This demonstrates that the expression for an automatically implemented property is not evaluated each time, as is the getter method for the explicit property.  
  
> [!WARNING]
>  There are some libraries, such as the Entity Framework (System.Data.Entity) that perform custom operations in base class constructors that don't work well with the initialization of automatically implemented properties. In those cases, try using explicit properties.  
  
 Properties can be members of classes, structures, discriminated unions, records, interfaces, and type extensions and can also be defined in object expressions.  
  
 Attributes can be applied to properties. To apply an attribute to a property, write the attribute on a separate line before the property. For more information, see [Attributes (F#)](../vs140/attributes--fsharp-.md).  
  
 By default, properties are public. Accessibility modifiers can also be applied to properties. To apply an accessibility modifier, add it immediately before the name of the property if it is meant to apply to both the <CodeContentPlaceHolder>24\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>25\</CodeContentPlaceHolder> methods; add it before the <CodeContentPlaceHolder>26\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>27\</CodeContentPlaceHolder> keywords if different accessibility is required for each accessor. The <CodeContentPlaceHolder>28\</CodeContentPlaceHolder> can be one of the following: <CodeContentPlaceHolder>29\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>30\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>31\</CodeContentPlaceHolder>. For more information, see [Accessibility Control](../vs140/access-control--fsharp-.md).  
  
 Property implementations are executed each time a property is accessed.  
  
## Static and Instance Properties  
 Properties can be static or instance properties. Static properties can be invoked without an instance and are used for values associated with the type, not with individual objects. For static properties, omit the self-identifier. The self-identifier is required for instance properties.  
  
 The following static property definition is based on a scenario in which you have a static field <CodeContentPlaceHolder>32\</CodeContentPlaceHolder> that is the backing store for the property.  
  
 [!code[FsLangRef1#3204](../vs140/codesnippet/FSharp/properties--fsharp-_3.fs)]  
  
 Properties can also be array-like, in which case they are called *indexed properties*. For more information, see [Indexed Properties (F#)](../vs140/indexed-properties--fsharp-.md).  
  
## Type Annotation for Properties  
 In many cases, the compiler has enough information to infer the type of a property from the type of the backing store, but you can set the type explicitly by adding a type annotation.  
  
 [!code[FsLangRef1#3205](../vs140/codesnippet/FSharp/properties--fsharp-_4.fs)]  
  
## Using Property set Accessors  
 You can set properties that provide <CodeContentPlaceHolder>33\</CodeContentPlaceHolder> accessors by using the <CodeContentPlaceHolder>34\</CodeContentPlaceHolder> operator.  
  
 [!code[FsLangRef1#3206](../vs140/codesnippet/FSharp/properties--fsharp-_5.fs)]  
  
 The output is <CodeContentPlaceHolder>35\</CodeContentPlaceHolder>.  
  
## Abstract Properties  
 Properties can be abstract. As with methods, *abstract* just means that there is a virtual dispatch associated with the property. Abstract properties can be truly abstract, that is, without a definition in the same class. The class that contains such a property is therefore an abstract class. Alternatively, abstract can just mean that a property is virtual, and in that case, a definition must be present in the same class. Note that abstract properties must not be private, and if one accessor is abstract, the other must also be abstract. For more information about abstract classes, see [Abstract Classes and Members](../vs140/abstract-classes--fsharp-.md).  
  
 [!code[FsLangRef1#3207](../vs140/codesnippet/FSharp/properties--fsharp-_6.fs)]  
  
## See Also  
 [Members (F#)](../vs140/members--fsharp-.md)   
 [Methods (F#)](../vs140/methods--fsharp-.md)