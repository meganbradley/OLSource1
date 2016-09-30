---
title: "Delegate Statement"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-visual-basic"
ms.tgt_pltfrm: na
ms.topic: "article"
f1_keywords: 
  - "vb.Delegate"
dev_langs: 
  - "VB"
helpviewer_keywords: 
  - "delegate keyword"
  - "Delegate statement"
ms.assetid: f799c518-0817-40cc-ad0b-4da846fdba57
caps.latest.revision: 31
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Delegate Statement
Used to declare a delegate. A delegate is a reference type that refers to a <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> method of a type or to an instance method of an object. Any procedure with matching parameter and return types can be used to create an instance of this delegate class. The procedure can then later be invoked by means of the delegate instance.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Parts  
  
|||  
|-|-|  
|Term|Definition|  
|<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>|Optional. List of attributes that apply to this delegate. Multiple attributes are separated by commas. You must enclose the [Attribute List](../vs140/attribute-list--visual-basic-.md) in angle brackets ("<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>" and "<CodeContentPlaceHolder>4\</CodeContentPlaceHolder>").|  
|<CodeContentPlaceHolder>5\</CodeContentPlaceHolder>|Optional. Specifies what code can access the delegate. Can be one of the following:\<br />\<br /> -   [Public](../vs140/public--visual-basic-.md). Any code that can access the element that declares the delegate can access it.\<br />-   [Protected](../vs140/protected--visual-basic-.md). Only code within the delegate's class or a derived class can access it.\<br />-   [Friend](../vs140/friend--visual-basic-.md). Only code within the same assembly can access the delegate.\<br />-   [Private](../vs140/private--visual-basic-.md). Only code within the element that declares the delegate can access it.\<br />\<br /> You can specify <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> to enable access from code within the delegate's class, a derived class, or the same assembly.|  
|<CodeContentPlaceHolder>7\</CodeContentPlaceHolder>|Optional. Indicates that this delegate redeclares and hides an identically named programming element, or set of overloaded elements, in a base class. You can shadow any kind of declared element with any other kind.\<br />\<br /> A shadowed element is unavailable from within the derived class that shadows it, except from where the shadowing element is inaccessible. For example, if a <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> element shadows a base class element, code that does not have permission to access the <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> element accesses the base class element instead.|  
|<CodeContentPlaceHolder>10\</CodeContentPlaceHolder>|Optional, but either <CodeContentPlaceHolder>11\</CodeContentPlaceHolder> or <CodeContentPlaceHolder>12\</CodeContentPlaceHolder> must appear. Declares this procedure as a delegate <CodeContentPlaceHolder>13\</CodeContentPlaceHolder> procedure that does not return a value.|  
|<CodeContentPlaceHolder>14\</CodeContentPlaceHolder>|Optional, but either <CodeContentPlaceHolder>15\</CodeContentPlaceHolder> or <CodeContentPlaceHolder>16\</CodeContentPlaceHolder> must appear. Declares this procedure as a delegate <CodeContentPlaceHolder>17\</CodeContentPlaceHolder> procedure that returns a value.|  
|<CodeContentPlaceHolder>18\</CodeContentPlaceHolder>|Required. Name of the delegate type; follows standard variable naming conventions.|  
|<CodeContentPlaceHolder>19\</CodeContentPlaceHolder>|Optional. List of type parameters for this delegate. Multiple type parameters are separated by commas. Optionally, each type parameter can be declared variant by using <CodeContentPlaceHolder>20\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>21\</CodeContentPlaceHolder> generic modifiers. You must enclose the [Type List](../vs140/type-list--visual-basic-.md) in parentheses and introduce it with the <CodeContentPlaceHolder>22\</CodeContentPlaceHolder> keyword.|  
|<CodeContentPlaceHolder>23\</CodeContentPlaceHolder>|Optional. List of parameters that are passed to the procedure when it is called. You must enclose the [Parameter List](../vs140/parameter-list--visual-basic-.md) in parentheses.|  
|<CodeContentPlaceHolder>24\</CodeContentPlaceHolder>|Required if you specify a <CodeContentPlaceHolder>25\</CodeContentPlaceHolder> procedure. Data type of the return value.|  
  
## Remarks  
 The <CodeContentPlaceHolder>26\</CodeContentPlaceHolder> statement defines the parameter and return types of a delegate class. Any procedure with matching parameters and return types can be used to create an instance of this delegate class. The procedure can then later be invoked by means of the delegate instance, by calling the delegate's <CodeContentPlaceHolder>27\</CodeContentPlaceHolder> method.  
  
 Delegates can be declared at the namespace, module, class, or structure level, but not within a procedure.  
  
 Each delegate class defines a constructor that is passed the specification of an object method. An argument to a delegate constructor must be a reference to a method, or a lambda expression.  
  
 To specify a reference to a method, use the following syntax:  
  
 <CodeContentPlaceHolder>28\</CodeContentPlaceHolder> [<CodeContentPlaceHolder>29\</CodeContentPlaceHolder>.]<CodeContentPlaceHolder>30\</CodeContentPlaceHolder>  
  
 The compile-time type of the <CodeContentPlaceHolder>31\</CodeContentPlaceHolder> must be the name of a class or an interface that contains a method of the specified name whose signature matches the signature of the delegate class. The <CodeContentPlaceHolder>32\</CodeContentPlaceHolder> can be either a shared method or an instance method. The <CodeContentPlaceHolder>33\</CodeContentPlaceHolder> is not optional, even if you create a delegate for the default method of the class.  
  
 To specify a lambda expression, use the following syntax:  
  
 <CodeContentPlaceHolder>34\</CodeContentPlaceHolder> ([<CodeContentPlaceHolder>35\</CodeContentPlaceHolder> As <CodeContentPlaceHolder>36\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>37\</CodeContentPlaceHolder> As <CodeContentPlaceHolder>38\</CodeContentPlaceHolder>, ...]) <CodeContentPlaceHolder>39\</CodeContentPlaceHolder>  
  
 The signature of the function must match that of the delegate type. For more information about lambda expressions, see [Lambda Expressions](../vs140/lambda-expressions--visual-basic-.md).  
  
 For more information about delegates, see [Delegates (Visual Basic)](../vs140/delegates--visual-basic-.md).  
  
## Example  
 The following example uses the <CodeContentPlaceHolder>40\</CodeContentPlaceHolder> statement to declare a delegate for operating on two numbers and returning a number. The <CodeContentPlaceHolder>41\</CodeContentPlaceHolder> method takes an instance of a delegate of this type and uses it to operate on pairs of numbers.  
  
 [!code[VbVbalrDelegates#14](../vs140/codesnippet/VisualBasic/delegate-statement_1.vb)]  
  
## See Also  
 [AddressOf Operator](../vs140/addressof-operator--visual-basic-.md)   
 [Of](../vs140/of-clause--visual-basic-.md)   
 [Delegates (Visual Basic)](../vs140/delegates--visual-basic-.md)   
 [How to: Use a Generic Class](../vs140/how-to--use-a-generic-class--visual-basic-.md)   
 [Generic Types in Visual Basic](../vs140/generic-types-in-visual-basic--visual-basic-.md)   
 [Covariance and Contravariance (C# and Visual Basic)](../vs140/covariance-and-contravariance--csharp-and-visual-basic-.md)   
 [in (Generic Modifier) (Visual Basic)](../vs140/in--generic-modifier---visual-basic-.md)   
 [Out (Generic Modifier) (Visual Basic)](../vs140/out--generic-modifier---visual-basic-.md)