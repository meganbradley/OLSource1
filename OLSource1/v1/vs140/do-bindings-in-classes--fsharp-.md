---
title: "do Bindings in Classes (F#)"
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
  - "do bindings [F#], classes"
ms.assetid: de12e2fb-d8c6-4e8d-a35c-efe20532a421
caps.latest.revision: 21
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# do Bindings in Classes (F#)
A <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> binding in a class definition performs actions when the object is constructed or, for a static <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> binding, when the type is first used.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Remarks  
 A <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> binding appears together with or after <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> bindings but before member definitions in a class definition. Although the <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> keyword is optional for <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> bindings at the module level, it is not optional for <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> bindings in a class definition.  
  
 For the construction of every object of any given type, non-static <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> bindings and non-static <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> bindings are executed in the order in which they appear in the class definition. Multiple <CodeContentPlaceHolder>11\</CodeContentPlaceHolder> bindings can occur in one type. The non-static <CodeContentPlaceHolder>12\</CodeContentPlaceHolder> bindings and the non-static <CodeContentPlaceHolder>13\</CodeContentPlaceHolder> bindings become the body of the primary constructor. The code in the non-static <CodeContentPlaceHolder>14\</CodeContentPlaceHolder> bindings section can reference the primary constructor parameters and any values or functions that are defined in the <CodeContentPlaceHolder>15\</CodeContentPlaceHolder> bindings section.  
  
 Non-static <CodeContentPlaceHolder>16\</CodeContentPlaceHolder> bindings can access members of the class as long as the class has a self identifier that is defined by an <CodeContentPlaceHolder>17\</CodeContentPlaceHolder> keyword in the class heading, and as long as all uses of those members are qualified with the self identifier for the class.  
  
 Because <CodeContentPlaceHolder>18\</CodeContentPlaceHolder> bindings initialize the private fields of a class, which is often necessary to guarantee that members behave as expected, <CodeContentPlaceHolder>19\</CodeContentPlaceHolder> bindings are usually put after <CodeContentPlaceHolder>20\</CodeContentPlaceHolder> bindings so that code in the <CodeContentPlaceHolder>21\</CodeContentPlaceHolder> binding can execute with a fully initialized object. If your code attempts to use a member before the initialization is complete, an InvalidOperationException is raised.  
  
 Static <CodeContentPlaceHolder>22\</CodeContentPlaceHolder> bindings can reference static members or fields of the enclosing class but not instance members or fields. Static <CodeContentPlaceHolder>23\</CodeContentPlaceHolder> bindings become part of the static initializer for the class, which is guaranteed to execute before the class is first used.  
  
 Attributes are ignored for <CodeContentPlaceHolder>24\</CodeContentPlaceHolder> bindings in types. If an attribute is required for code that executes in a <CodeContentPlaceHolder>25\</CodeContentPlaceHolder> binding, it must be applied to the primary constructor.  
  
 In the following code, a class has a static <CodeContentPlaceHolder>26\</CodeContentPlaceHolder> binding and a non-static <CodeContentPlaceHolder>27\</CodeContentPlaceHolder> binding. The object has a constructor that has two parameters, <CodeContentPlaceHolder>28\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>29\</CodeContentPlaceHolder>, and two private fields are defined in the <CodeContentPlaceHolder>30\</CodeContentPlaceHolder> bindings for the class. Two properties are also defined. All of these are in scope in the non-static <CodeContentPlaceHolder>31\</CodeContentPlaceHolder> bindings section, as is illustrated by the line that prints all those values.  
  
 [!code[FsLangRef1#3101](../vs140/codesnippet/FSharp/do-bindings-in-classes--fsharp-_1.fs)]  
  
 The output is as follows.  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
## See Also  
 [Members (F#)](../vs140/members--fsharp-.md)   
 [Classes (F#)](../vs140/classes--fsharp-.md)   
 [Constructors (F#)](../vs140/constructors--fsharp-.md)   
 [Let Bindings in Classes (F#)](../vs140/let-bindings-in-classes--fsharp-.md)   
 [do Bindings (F#)](../vs140/do-bindings--fsharp-.md)