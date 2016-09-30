---
title: "Methods (F#)"
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
  - "default keyword [F#]"
  - "methods [F#]"
  - "override keyword [F#]"
ms.assetid: 35b81cfa-821d-4b85-b7d6-ee3b61f88e70
caps.latest.revision: 33
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Methods (F#)
A *method* is a function that is associated with a type. In object-oriented programming, methods are used to expose and implement the functionality and behavior of objects and types.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Remarks  
 In the previous syntax, you can see the various forms of method declarations and definitions. In longer method bodies, a line break follows the equal sign (=), and the whole method body is indented.  
  
 Attributes can be applied to any method declaration. They precede the syntax for a method definition and are usually listed on a separate line. For more information, see [Attributes](../vs140/attributes--fsharp-.md).  
  
 Methods can be marked <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>. For information about <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>, see [Inline Functions](../vs140/inline-functions--fsharp-.md).  
  
 Non-inline methods can be used recursively within the type; there is no need to explicitly use the <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> keyword.  
  
## Instance Methods  
 Instance methods are declared with the <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> keyword and a <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>, followed by a period (.) and the method name and parameters. As is the case for <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> bindings, the <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> can be a pattern. Typically, you enclose method parameters in parentheses in a tuple form, which is the way methods appear in F# when they are created in other .NET Framework languages. However, the curried form (parameters separated by spaces) is also common, and other patterns are supported also.  
  
 The following example illustrates the definition and use of a non-abstract instance method.  
  
 [!code[FsLangRef1#3401](../vs140/codesnippet/FSharp/methods--fsharp-_1.fs)]  
  
 Within instance methods, do not use the self identifier to access fields defined by using let bindings. Use the self identifier when accessing other members and properties.  
  
## Static Methods  
 The keyword <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> is used to specify that a method can be called without an instance and is not associated with an object instance. Otherwise, methods are instance methods.  
  
 The example in the next section shows fields declared with the <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> keyword, property members declared with the <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> keyword, and a static method declared with the <CodeContentPlaceHolder>11\</CodeContentPlaceHolder> keyword.  
  
 The following example illustrates the definition and use of static methods. Assume that these method definitions are in the <CodeContentPlaceHolder>12\</CodeContentPlaceHolder> class in the previous section.  
  
 [!code[FsLangRef1#3402](../vs140/codesnippet/FSharp/methods--fsharp-_2.fs)]  
  
## Abstract and Virtual Methods  
 The keyword <CodeContentPlaceHolder>13\</CodeContentPlaceHolder> indicates that a method has a virtual dispatch slot and might not have a definition in the class. A *virtual dispatch slot* is an entry in an internally maintained table of functions that is used at run time to look up virtual function calls in an object-oriented type. The virtual dispatch mechanism is the mechanism that implements *polymorphism*, an important feature of object-oriented programming. A class that has at least one abstract method without a definition is an *abstract class*, which means that no instances can be created of that class. For more information about abstract classes, see [Abstract Classes](../vs140/abstract-classes--fsharp-.md).  
  
 Abstract method declarations do not include a method body. Instead, the name of the method is followed by a colon (:) and a type signature for the method. The type signature of a method is the same as that shown by IntelliSense when you pause the mouse pointer over a method name in the Visual Studio Code Editor, except without parameter names. Type signatures are also displayed by the interpreter, fsi.exe, when you are working interactively. The type signature of a method is formed by listing out the types of the parameters, followed by the return type, with appropriate separator symbols. Curried parameters are separated by -> and tuple parameters are separated by *. The return value is always separated from the arguments by a -> symbol. Parentheses can be used to group complex parameters, such as when a function type is a parameter, or to indicate when a tuple is treated as a single parameter rather than as two parameters.  
  
 You can also give abstract methods default definitions by adding the definition to the class and using the <CodeContentPlaceHolder>14\</CodeContentPlaceHolder> keyword, as shown in the syntax block in this topic. An abstract method that has a definition in the same class is equivalent to a virtual method in other .NET Framework languages. Whether or not a definition exists, the <CodeContentPlaceHolder>15\</CodeContentPlaceHolder> keyword creates a new dispatch slot in the virtual function table for the class.  
  
 Regardless of whether a base class implements its abstract methods, derived classes can provide implementations of abstract methods. To implement an abstract method in a derived class, define a method that has the same name and signature in the derived class, except use the <CodeContentPlaceHolder>16\</CodeContentPlaceHolder> or <CodeContentPlaceHolder>17\</CodeContentPlaceHolder> keyword, and provide the method body. The keywords <CodeContentPlaceHolder>18\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>19\</CodeContentPlaceHolder> mean exactly the same thing. Use <CodeContentPlaceHolder>20\</CodeContentPlaceHolder> if the new method overrides a base class implementation; use <CodeContentPlaceHolder>21\</CodeContentPlaceHolder> when you create an implementation in the same class as the original abstract declaration. Do not use the <CodeContentPlaceHolder>22\</CodeContentPlaceHolder> keyword on the method that implements the method that was declared abstract in the base class.  
  
 The following example illustrates an abstract method <CodeContentPlaceHolder>23\</CodeContentPlaceHolder> that has a default implementation, the equivalent of a .NET Framework virtual method.  
  
 [!code[FsLangRef1#3403](../vs140/codesnippet/FSharp/methods--fsharp-_3.fs)]  
  
 The following example illustrates a derived class that overrides a base class method. In this case, the override changes the behavior so that the method does nothing.  
  
 [!code[FsLangRef1#3404](../vs140/codesnippet/FSharp/methods--fsharp-_4.fs)]  
  
## Overloaded Methods  
 Overloaded methods are methods that have identical names in a given type but that have different arguments. In F#, optional arguments are usually used instead of overloaded methods. However, overloaded methods are permitted in the language, provided that the arguments are in tuple form, not curried form.  
  
## Example: Properties and Methods  
 The following example contains a type that has examples of fields, private functions, properties, and a static method.  
  
 [!code[FsLangRef1#3406](../vs140/codesnippet/FSharp/methods--fsharp-_5.fs)]  
  
## See Also  
 [Members (F#)](../vs140/members--fsharp-.md)