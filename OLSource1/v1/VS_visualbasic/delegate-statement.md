---
title: "Delegate Statement"
ms.custom: na
ms.date: "10/03/2016"
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
caps.latest.revision: 27
ms.author: "shoag"
manager: "wpickett"
translation.priority.ht: 
  - "cs-cz"
  - "de-de"
  - "es-es"
  - "fr-fr"
  - "it-it"
  - "ja-jp"
  - "ko-kr"
  - "pl-pl"
  - "pt-br"
  - "ru-ru"
  - "tr-tr"
  - "zh-cn"
  - "zh-tw"
---
# Delegate Statement
Used to declare a delegate. A delegate is a reference type that refers to a `Shared` method of a type or to an instance method of an object. Any procedure with matching parameter and return types can be used to create an instance of this delegate class. The procedure can then later be invoked by means of the delegate instance.  
  
## Syntax  
  
```  
[ <attrlist> ] [ accessmodifier ] _  
[ Shadows ] Delegate [ Sub | Function ] name [( Of typeparamlist )] [([ parameterlist ])] [ As type ]  
```  
  
## Parts  
  
|||  
|-|-|  
|Term|Definition|  
|`attrlist`|Optional. List of attributes that apply to this delegate. Multiple attributes are separated by commas. You must enclose the [Attribute List](../VS_visualbasic/attribute-list--visual-basic-.md) in angle brackets ("`<`" and "`>`").|  
|`accessmodifier`|Optional. Specifies what code can access the delegate. Can be one of the following:<br /><br /> -   [Public](../VS_visualbasic/public--visual-basic-.md). Any code that can access the element that declares the delegate can access it.<br />-   [Protected](../VS_visualbasic/protected--visual-basic-.md). Only code within the delegate's class or a derived class can access it.<br />-   [Friend](../VS_visualbasic/friend--visual-basic-.md). Only code within the same assembly can access the delegate.<br />-   [Private](../VS_visualbasic/private--visual-basic-.md). Only code within the element that declares the delegate can access it.<br /><br /> You can specify `Protected Friend` to enable access from code within the delegate's class, a derived class, or the same assembly.|  
|`Shadows`|Optional. Indicates that this delegate redeclares and hides an identically named programming element, or set of overloaded elements, in a base class. You can shadow any kind of declared element with any other kind.<br /><br /> A shadowed element is unavailable from within the derived class that shadows it, except from where the shadowing element is inaccessible. For example, if a `Private` element shadows a base class element, code that does not have permission to access the `Private` element accesses the base class element instead.|  
|`Sub`|Optional, but either `Sub` or `Function` must appear. Declares this procedure as a delegate `Sub` procedure that does not return a value.|  
|`Function`|Optional, but either `Sub` or `Function` must appear. Declares this procedure as a delegate `Function` procedure that returns a value.|  
|`name`|Required. Name of the delegate type; follows standard variable naming conventions.|  
|`typeparamlist`|Optional. List of type parameters for this delegate. Multiple type parameters are separated by commas. Optionally, each type parameter can be declared variant by using `In` and `Out` generic modifiers. You must enclose the [Type List](../VS_visualbasic/type-list--visual-basic-.md) in parentheses and introduce it with the `Of` keyword.|  
|`parameterlist`|Optional. List of parameters that are passed to the procedure when it is called. You must enclose the [Parameter List](../VS_visualbasic/parameter-list--visual-basic-.md) in parentheses.|  
|`type`|Required if you specify a `Function` procedure. Data type of the return value.|  
  
## Remarks  
 The `Delegate` statement defines the parameter and return types of a delegate class. Any procedure with matching parameters and return types can be used to create an instance of this delegate class. The procedure can then later be invoked by means of the delegate instance, by calling the delegate's `Invoke` method.  
  
 Delegates can be declared at the namespace, module, class, or structure level, but not within a procedure.  
  
 Each delegate class defines a constructor that is passed the specification of an object method. An argument to a delegate constructor must be a reference to a method, or a lambda expression.  
  
 To specify a reference to a method, use the following syntax:  
  
 `AddressOf` [`expression`.]`methodname`  
  
 The compile-time type of the `expression` must be the name of a class or an interface that contains a method of the specified name whose signature matches the signature of the delegate class. The `methodname` can be either a shared method or an instance method. The `methodname` is not optional, even if you create a delegate for the default method of the class.  
  
 To specify a lambda expression, use the following syntax:  
  
 `Function` ([`parm` As `type`, `parm2` As `type2`, ...]) `expression`  
  
 The signature of the function must match that of the delegate type. For more information about lambda expressions, see [Lambda Expressions](../VS_visualbasic/lambda-expressions--visual-basic-.md).  
  
 For more information about delegates, see [Delegates](../VS_visualbasic/delegates--visual-basic-.md).  
  
## Example  
 The following example uses the `Delegate` statement to declare a delegate for operating on two numbers and returning a number. The `DelegateTest` method takes an instance of a delegate of this type and uses it to operate on pairs of numbers.  
  
 [!code[VbVbalrDelegates#14](../VS_visualbasic/codesnippet/VisualBasic/delegate-statement_1.vb)]  
  
## See Also  
 [AddressOf Operator](../VS_visualbasic/addressof-operator--visual-basic-.md)   
 [Of](../VS_visualbasic/of-clause--visual-basic-.md)   
 [Delegates](../VS_visualbasic/delegates--visual-basic-.md)   
 [How to: Use a Generic Class](../VS_visualbasic/how-to--use-a-generic-class--visual-basic-.md)   
 [Generic Types in Visual Basic](../VS_visualbasic/generic-types-in-visual-basic--visual-basic-.md)   
 [Covariance and Contravariance](../Topic/Covariance%20and%20Contravariance%20\(C%23%20and%20Visual%20Basic\).md)   
 [In](../VS_visualbasic/in--generic-modifier---visual-basic-.md)   
 [Out](../VS_visualbasic/out--generic-modifier---visual-basic-.md)