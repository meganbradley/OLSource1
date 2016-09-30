---
title: "Indexed Properties (F#)"
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
  - "properties, F#"
  - "properties [F#]"
  - "indexed properties [F#]"
  - "properties, indexed [F#]"
ms.assetid: 5ffd355b-5a21-4064-8b2a-387f54c57ed1
caps.latest.revision: 22
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Indexed Properties (F#)
*Indexed properties* are properties that provide array-like access to ordered data.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Remarks  
 The three forms of the previous syntax show how to define indexed properties that have both a <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> and a <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> method, have a <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> method only, or have a <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> method only. You can also combine both the syntax shown for get only and the syntax shown for set only, and produce a property that has both get and set. This latter form allows you to put different accessibility modifiers and attributes on the get and set methods.  
  
 When the <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> is <CodeContentPlaceHolder>7\</CodeContentPlaceHolder>, the compiler treats the property as a default indexed property. A *default indexed property* is a property that you can access by using array-like syntax on the object instance. For example, if <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> is an object of the type that defines this property, the syntax <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> is used to access the property.  
  
 The syntax for accessing a nondefault indexed property is to provide the name of the property and the index in parentheses. For example, if the property is <CodeContentPlaceHolder>10\</CodeContentPlaceHolder>, you write <CodeContentPlaceHolder>11\</CodeContentPlaceHolder> to access it.  
  
 Regardless of which form you use, you should always use the curried form for the <CodeContentPlaceHolder>12\</CodeContentPlaceHolder> method on an indexed property. For information about curried functions, see [Functions (F#)](../vs140/functions--fsharp-.md).  
  
## Example  
 The following code example illustrates the definition and use of default and non-default indexed properties that have <CodeContentPlaceHolder>13\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>14\</CodeContentPlaceHolder> methods.  
  
 [!code[FsLangRef1#3301](../vs140/codesnippet/FSharp/indexed-properties--fsharp-_1.fs)]  
  
## Output  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
## Indexed Properties with Multiple Index Variables  
 Indexed properties can have more than one index variable. In that case, the variables are separated by commas when the property is used. The set method in such a property must have two curried arguments, the first of which is a tuple containing the keys, and the second of which is the value being set.  
  
 The following code demonstrates the use of an indexed property with multiple index variables.  
  
 [!code[FsLangRef1#3302](../vs140/codesnippet/FSharp/indexed-properties--fsharp-_2.fs)]  
  
## See Also  
 [Members (F#)](../vs140/members--fsharp-.md)