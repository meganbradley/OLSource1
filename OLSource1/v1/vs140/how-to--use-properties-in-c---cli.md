---
title: "How to: Use Properties in C++-CLI"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-cpp"
ms.tgt_pltfrm: na
ms.topic: "article"
H1: "How to: Use Properties in C++/CLI"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "simple properties"
  - "properties [C++], simple"
ms.assetid: f5d82547-e214-4f05-9e1b-ddb6d0dc5e4c
caps.latest.revision: 12
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# How to: Use Properties in C++-CLI
This article shows how to use properties in C++/CLI.  
  
## Basic properties  
 For basic properties—those that merely assign and retrieve a private data member—you don't have to explicitly define the get and set accessor functions because the compiler automatically provides them when given just the data type of the property. This code demonstrates a basic property:  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
 **Output**  
  
 **c->Size = 111**   
## Static properties  
 This code sample shows how to declare and use a static property.  A static property can only access static members of its class.  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 **Output**  
  
 **96**  
**47**   
## Indexed properties  
 An indexed property typically exposes a data structure that's accessed by using a subscript operator.  
  
 If you use a default indexed property, you can access the data structure just by referring to the class name, but if you use a user-defined indexed property, you must to specify the property name to access the data structure.  
  
 For information about how to access a default indexer by using the <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> pointer, see [Semantics of the this Pointer in Value and Reference Types](../vs140/semantics-of-the-this-pointer-in-value-and-reference-types.md).  
  
 For information about how to consume an indexer that's written in C#, see [How to: Consume a C# Indexer](../vs140/how-to--consume-a-csharp-indexer--c---cli-.md).  
  
 This code sample shows how to use default and user-defined indexed properties:  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 **Output**  
  
 **[ 0 1 2 3 4 ]**  
**[ 0 2 4 6 8 ]** The next sample shows how to call the default indexer by using the <CodeContentPlaceHolder>11\</CodeContentPlaceHolder> pointer.  
  
<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 This sample shows how to use \<xref:System.Reflection.DefaultMemberAttribute*> to specify the default indexer:  
  
<CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
 The next sample consumes the metadata that's created in the previous example.  
  
<CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
 **Output**  
  
 **9**   
## Virtual properties  
 This code sample shows how to declare and use virtual properties:  
  
<CodeContentPlaceHolder>6\</CodeContentPlaceHolder>  
 **Output**  
  
 **93**  
**43**   
## Abstract and sealed properties  
 Although the [abstract (C++)](../vs140/abstract---c---component-extensions-.md) and [sealed](../vs140/sealed---c---component-extensions-.md) keywords are specified as valid in the ECMA C++/CLI specification, for the Visual C++ compiler, you cannot specify them on trivial properties, nor on the property declaration of a non-trivial property.  
  
 To declare a sealed or abstract property, you must define a non-trivial property and then specify the <CodeContentPlaceHolder>12\</CodeContentPlaceHolder> or <CodeContentPlaceHolder>13\</CodeContentPlaceHolder> keyword on the get and set accessor functions.  
  
<CodeContentPlaceHolder>7\</CodeContentPlaceHolder>  
 **Output**  
  
 **86**  
**87**   
## Multidimensional properties  
 You can use multidimensional properties to define property accessor methods that take a non-standard number of parameters.  
  
<CodeContentPlaceHolder>8\</CodeContentPlaceHolder>  
 **Output**  
  
 **1.1**   
## Overloading property accessors  
 The following example shows how to overload indexed properties.  
  
<CodeContentPlaceHolder>9\</CodeContentPlaceHolder>  
 **Output**  
  
 **3.4**  
**6.8**   
## See Also  
 [property](../vs140/property---c---component-extensions-.md)