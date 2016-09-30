---
title: "let Bindings in Classes (F#)"
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
  - "let bindings [F#], classes"
ms.assetid: a492df11-7701-4c02-ba30-45edbea9ab5c
caps.latest.revision: 27
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# let Bindings in Classes (F#)
You can define private fields and private functions for F# classes by using <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> bindings in the class definition.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Remarks  
 The previous syntax appears after the class heading and inheritance declarations but before any member definitions. The syntax is like that of <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> bindings outside of classes, but the names defined in a class have a scope that is limited to the class. A <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> binding creates a private field or function; to expose data or functions publicly, declare a property or a member method.  
  
 A <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> binding that is not static is called an instance <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> binding. Instance <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> bindings execute when objects are created. Static <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> bindings are part of the static initializer for the class, which is guaranteed to execute before the type is first used.  
  
 The code within instance <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> bindings can use the primary constructor's parameters.  
  
 Attributes and accessibility modifiers are not permitted on <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> bindings in classes.  
  
 The following code examples illustrate several types of <CodeContentPlaceHolder>11\</CodeContentPlaceHolder> bindings in classes.  
  
 [!code[FsLangRef1#3001](../vs140/codesnippet/FSharp/let-bindings-in-classes--fsharp-_1.fs)]  
  
 The output is as follows.  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
## Alternative Ways to Create Fields  
 You can also use the <CodeContentPlaceHolder>12\</CodeContentPlaceHolder> keyword to create a private field. When using the <CodeContentPlaceHolder>13\</CodeContentPlaceHolder> keyword, the field is not given a value when the object is created, but instead is initialized with a default value. For more information, see [Fields: the val keyword](../vs140/explicit-fields--the-val-keyword--fsharp-.md).  
  
 You can also define private fields in a class by using a member definition and adding the keyword <CodeContentPlaceHolder>14\</CodeContentPlaceHolder> to the definition. This can be useful if you expect to change the accessibility of a member without rewriting your code. For more information, see [Access Control](../vs140/access-control--fsharp-.md).  
  
## See Also  
 [Members (F#)](../vs140/members--fsharp-.md)   
 [do Bindings in Classes](../vs140/do-bindings-in-classes--fsharp-.md)   
 [let Bindings](../vs140/let-bindings--fsharp-.md)