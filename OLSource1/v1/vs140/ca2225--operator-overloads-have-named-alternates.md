---
title: "CA2225: Operator overloads have named alternates"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "vs-devops-test"
ms.tgt_pltfrm: na
ms.topic: "article"
f1_keywords: 
  - "OperatorOverloadsHaveNamedAlternates"
  - "CA2225"
helpviewer_keywords: 
  - "OperatorOverloadsHaveNamedAlternates"
  - "CA2225"
ms.assetid: af8f7ab1-63ad-4861-afb9-b7a7a2be15e1
caps.latest.revision: 24
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CA2225: Operator overloads have named alternates
|||  
|-|-|  
|TypeName|OperatorOverloadsHaveNamedAlternates|  
|CheckId|CA2225|  
|Category|Microsoft.Usage|  
|Breaking Change|Non Breaking|  
  
## Cause  
 An operator overload was detected, and the expected named alternative method was not found.  
  
## Rule Description  
 Operator overloading allows the use of symbols to represent computations for a type. For example, a type that overloads the plus symbol (+) for addition would typically have an alternative member named 'Add'. The named alternative member provides access to the same functionality as the operator, and is provided for developers who program in languages that do not support overloaded operators.  
  
 This rule examines the operators listed in the following table.  
  
|C#|Visual Basic|C++|Alternate name|  
|---------|------------------|-----------|--------------------|  
|+ (binary)|+|+ (binary)|Add|  
|+=|+=|+=|Add|  
|&|And|&|BitwiseAnd|  
|&=|And=|&=|BitwiseAnd|  
|&#124;|Or|&#124;|BitwiseOr|  
|&#124;=|Or=|&#124;=|BitwiseOr|  
|--|N/A|--|Decrement|  
|/|/|/|Divide|  
|/=|/=|/=|Divide|  
|==|=|==|Equals|  
|^|Xor|^|Xor|  
|^=|Xor=|^=|Xor|  
|>|>|>|Compare|  
|>=|>=|>=|Compare|  
|++|N/A|++|Increment|  
|<>|!=|Equals|  
|<<|<<|<<|LeftShift|  
|<<=|<<=|<<=|LeftShift|  
|<|<|<|Compare|  
|<=|<=|<=|Compare|  
|&&|N/A|&&|LogicalAnd|  
|&#124;&#124;|N/A|&#124;&#124;|LogicalOr|  
|!|N/A|!|LogicalNot|  
|%|Mod|%|Mod or Remainder|  
|%=|N/A|%=|Mod|  
|* (binary)|*|*|Multiply|  
|*=|N/A|*=|Multiply|  
|~|Not|~|OnesComplement|  
|>>|>>|>>|RightShift|  
=|N/A|>>=|RightShift|  
|- (binary)|- (binary)|- (binary)|Subtract|  
|-=|N/A|-=|Subtract|  
|true|IsTrue|N/A|IsTrue (Property)|  
|- (unary)|N/A|-|Negate|  
|+ (unary)|N/A|+|Plus|  
|false|IsFalse|False|IsTrue (Property)|  
  
 N/A == Cannot be overloaded in the selected language.  
  
 The rule also checks implicit and explicit cast operators in a type (`SomeType`) by checking for methods named `ToSomeType` and `FromSomeType`.  
  
 In C#, when a binary operator is overloaded, the corresponding assignment operator, if any, is also implicitly overloaded.  
  
## How to Fix Violations  
 To fix a violation of this rule, implement the alternative method for the operator; name it using the recommended alternative name.  
  
## When to Suppress Warnings  
 Do not suppress a warning from this rule if you are implementing a shared library. Applications can ignore a warning from this rule.  
  
## Example  
 The following example defines a structure that violates this rule. To correct the example, add a public `Add(int x, int y)` method to the structure.  
  
 [!code[FxCop.Usage.OperatorOverloadsHaveNamedAlternates#1](../vs140/codesnippet/CSharp/ca2225--operator-overloads-have-named-alternates_1.cs)]  
  
## Related Rules  
 [Do not override operator equals on reference types](../vs140/ca1046--do-not-overload-operator-equals-on-reference-types.md)  
  
 [Operators should have symmetrical overloads](../vs140/ca2226--operators-should-have-symmetrical-overloads.md)  
  
 [Override equals on overriding operator equals](../vs140/ca2224--override-equals-on-overloading-operator-equals.md)  
  
 [Override GetHashCode on overriding Equals](../vs140/ca2218--override-gethashcode-on-overriding-equals.md)  
  
 [Override operator equals on overriding value type equals](../vs140/ca2231--overload-operator-equals-on-overriding-valuetype.equals.md)