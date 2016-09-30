---
title: "Object Variable Assignment (Visual Basic)"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-visual-basic"
ms.tgt_pltfrm: na
ms.topic: "article"
dev_langs: 
  - "VB"
helpviewer_keywords: 
  - "Nothing keyword, object variable assignment"
  - "object variables, initializing"
  - "variables [Visual Basic], initializing"
  - "objects [Visual Basic], current instance"
  - "object variables, assigning"
  - "variables [Visual Basic], object variables"
  - "current instance, defined"
  - "variables [Visual Basic], assigning"
  - "assignment statements, object variable assignment"
  - "Me keyword, as object variable"
ms.assetid: 3706811d-fd40-44fe-8727-d692e8e55d6d
caps.latest.revision: 23
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Object Variable Assignment (Visual Basic)
You use a normal assignment statement to assign an object to an object variable. You can assign an object expression or the [Nothing](../vs140/nothing--visual-basic-.md) keyword, as the following example illustrates.  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
 <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> means there is no object currently assigned to the variable.  
  
## Initialization  
 When your code begins running, your object variables are initialized to <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>. Those whose declarations include initialization are reinitialized to the values you specify when the declaration statements are executed.  
  
 You can include initialization in your declaration by using the [New](../vs140/new-operator--visual-basic-.md) keyword. The following declaration statements declare object variables <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> and assign specific objects to them. Each uses one of the overloaded constructors of the appropriate class to initialize the object.  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
## Disassociation  
 Setting an object variable to <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> discontinues the association of the variable with any specific object. This prevents you from accidentally changing the object by changing the variable. It also allows you to test whether the object variable points to a valid object, as the following example shows.  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 If the object your variable refers to is in another application, this test cannot determine whether that application has terminated or just invalidated the object.  
  
 An object variable with a value of <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> is also called a *null reference*.  
  
## Current Instance  
 The *current instance* of an object is the one in which the code is currently executing. Since all code executes inside a procedure, the current instance is the one in which the procedure was invoked.  
  
 The <CodeContentPlaceHolder>11\</CodeContentPlaceHolder> keyword acts as an object variable referring to the current instance. If a procedure is not [Shared (Visual Basic)](../vs140/shared--visual-basic-.md), it can use the <CodeContentPlaceHolder>12\</CodeContentPlaceHolder> keyword to obtain a pointer to the current instance. Shared procedures cannot be associated with a specific instance of a class.  
  
 Using <CodeContentPlaceHolder>13\</CodeContentPlaceHolder> is particularly useful for passing the current instance to a procedure in another module. For example, suppose you have a number of XML documents and wish to add some standard text to all of them. The following example defines a procedure to do this.  
  
<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 Every XML document object could then call the procedure and pass its current instance as an argument. The following example demonstrates this.  
  
<CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
## See Also  
 [Object Variables](../vs140/object-variables-in-visual-basic.md)   
 [Object Variable Declaration](../vs140/object-variable-declaration--visual-basic-.md)   
 [Object Variable Values](../vs140/object-variable-values--visual-basic-.md)   
 [How to: Declare an Object Variable and Assign an Object to It in Visual Basic](../vs140/how-to--declare-an-object-variable-and-assign-an-object-to-it-in-visual-basic.md)   
 [How to: Make an Object Variable Not Refer to Any Instance](../vs140/how-to--make-an-object-variable-not-refer-to-any-instance--visual-basic-.md)   
 [Me, My, MyBase, and MyClass in Visual Basic](../vs140/me--my--mybase--and-myclass-in-visual-basic.md)