---
title: "Constructors (F#)"
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
  - "constructors [F#], additional"
  - "self identifiers [F#]"
  - "new keyword [F#]"
  - "constructors [F#], primary"
  - "then keyword [F#]"
  - "constructors [F#]"
ms.assetid: 2cd0ed07-d214-4125-8317-4f288af99f05
caps.latest.revision: 27
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Constructors (F#)
This topic describes how to define and use constructors to create and initialize class and structure objects.  
  
## Construction of Class Objects  
 Objects of class types have constructors. There are two kinds of constructors. One is the primary constructor, whose parameters appear in parentheses just after the type name. You specify other, optional additional constructors by using the <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> keyword. Any such additional constructors must call the primary constructor.  
  
 The primary constructor contains <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> bindings that appear at the start of the class definition. A <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> binding declares private fields and methods of the class; a <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> binding executes code. For more information about <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> bindings in class constructors, see [Let Bindings in Classes](../vs140/let-bindings-in-classes--fsharp-.md). For more information about <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> bindings in constructors, see [Do Bindings in Classes](../vs140/do-bindings-in-classes--fsharp-.md).  
  
 Regardless of whether the constructor you want to call is a primary constructor or an additional constructor, you can create objects by using a <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> expression, with or without the optional <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> keyword. You initialize your objects together with constructor arguments, either by listing the arguments in order and separated by commas and enclosed in parentheses, or by using named arguments and values in parentheses. You can also set properties on an object during the construction of the object by using the property names and assigning values just as you use named constructor arguments.  
  
 The following code illustrates a class that has a constructor and various ways of creating objects.  
  
 [!code[FsLangRef2#3501](../vs140/codesnippet/FSharp/constructors--fsharp-_1.fs)]  
  
 The output is as follows.  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Construction of Structures  
 Structures follow all the rules of classes. Therefore, you can have a primary constructor, and you can provide additional constructors by using <CodeContentPlaceHolder>11\</CodeContentPlaceHolder>. However, there is one important difference between structures and classes: structures can have a default constructor (that is, one with no arguments) even if no primary constructor is defined. The default constructor initializes all the fields to the default value for that type, usually zero or its equivalent. Any constructors that you define for structures must have at least one argument so that they do not conflict with the default constructor.  
  
 Also, structures often have fields that are created by using the <CodeContentPlaceHolder>12\</CodeContentPlaceHolder> keyword; classes can also have these fields. Structures and classes that have fields defined by using the <CodeContentPlaceHolder>13\</CodeContentPlaceHolder> keyword can also be initialized in additional constructors by using record expressions, as shown in the following code.  
  
 [!code[FsLangRef2#3502](../vs140/codesnippet/FSharp/constructors--fsharp-_2.fs)]  
  
 For more information, see [Fields: the val Keyword](../vs140/explicit-fields--the-val-keyword--fsharp-.md).  
  
## Executing Side Effects in Constructors  
 A primary constructor in a class can execute code in a <CodeContentPlaceHolder>14\</CodeContentPlaceHolder> binding. However, what if you have to execute code in an additional constructor, without a <CodeContentPlaceHolder>15\</CodeContentPlaceHolder> binding? To do this, you use the <CodeContentPlaceHolder>16\</CodeContentPlaceHolder> keyword.  
  
 [!code[FsLangRef2#3503](../vs140/codesnippet/FSharp/constructors--fsharp-_3.fs)]  
  
 The side effects of the primary constructor still execute. Therefore, the output is as follows.  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
## Self Identifiers in Constructors  
 In other members, you provide a name for the current object in the definition of each member. You can also put the self identifier on the first line of the class definition by using the <CodeContentPlaceHolder>17\</CodeContentPlaceHolder> keyword immediately following the constructor parameters. The following example illustrates this syntax.  
  
 [!code[FsLangRef2#3504](../vs140/codesnippet/FSharp/constructors--fsharp-_4.fs)]  
  
 In additional constructors, you can also define a self identifier by putting the <CodeContentPlaceHolder>18\</CodeContentPlaceHolder> clause right after the constructor parameters. The following example illustrates this syntax.  
  
 [!code[FsLangRef2#3505](../vs140/codesnippet/FSharp/constructors--fsharp-_5.fs)]  
  
 Problems can occur when you try to use an object before it is fully defined. Therefore, uses of the self identifier can cause the compiler to emit a warning and insert additional checks to ensure the members of an object are not accessed before the object is initialized. You should only use the self identifier in the <CodeContentPlaceHolder>19\</CodeContentPlaceHolder> bindings of the primary constructor, or after the <CodeContentPlaceHolder>20\</CodeContentPlaceHolder> keyword in additional constructors.  
  
 The name of the self identifier does not have to be <CodeContentPlaceHolder>21\</CodeContentPlaceHolder>. It can be any valid identifier.  
  
## Assigning Values to Properties at Initialization  
 You can assign values to the properties of a class object in the initialization code by appending a list of assignments of the form <CodeContentPlaceHolder>22\</CodeContentPlaceHolder> to the argument list for a constructor. This is shown in the following code example.  
  
 [!code[FsLangRef2#3506](../vs140/codesnippet/FSharp/constructors--fsharp-_6.fs)]  
  
 The following version of the previous code illustrates the combination of ordinary arguments, optional arguments, and property settings in one constructor call.  
  
 [!code[FsLangRef2#3507](../vs140/codesnippet/FSharp/constructors--fsharp-_7.fs)]  
  
## Static Constructors or Type Constructors  
 In addition to specifying code for creating objects, static <CodeContentPlaceHolder>23\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>24\</CodeContentPlaceHolder> bindings can be authored in class types that execute before the type is first used to perform initialization at the type level. For more information, see [Let Bindings in Classes](../vs140/let-bindings-in-classes--fsharp-.md) and [Do Bindings in Classes](../vs140/do-bindings-in-classes--fsharp-.md).  
  
## See Also  
 [Members](../vs140/members--fsharp-.md)