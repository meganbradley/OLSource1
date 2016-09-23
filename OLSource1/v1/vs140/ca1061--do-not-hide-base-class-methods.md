---
title: "CA1061: Do not hide base class methods"
ms.custom: na
ms.date: 09/21/2016
ms.prod: visual-studio-dev14
ms.reviewer: na
ms.suite: na
ms.technology: 
  - vs-devops-test
ms.tgt_pltfrm: na
ms.topic: article
f1_keywords: 
  - CA1061
  - DoNotHideBaseClassMethods
helpviewer_keywords: 
  - DoNotHideBaseClassMethods
  - CA1061
ms.assetid: 0bda9dc8-87b4-4038-ab9d-563298387466
caps.latest.revision: 13
translation.priority.ht: 
  - de-de
  - ja-jp
---
# CA1061: Do not hide base class methods
|||  
|-|-|  
|TypeName|DoNotHideBaseClassMethods|  
|CheckId|CA1061|  
|Category|Microsoft.Design|  
|Breaking Change|Breaking|  
  
## Cause  
 A derived type declares a method with the same name and with the same number of parameters as one of its base methods; one or more of the parameters is a base type of the corresponding parameter in the base method; and any remaining parameters have types that are identical to the corresponding parameters in the base method.  
  
## Rule Description  
 A method in a base type is hidden by an identically named method in a derived type when the parameter signature of the derived method differs only by types that are more weakly derived than the corresponding types in the parameter signature of the base method.  
  
## How to Fix Violations  
 To fix a violation of this rule, remove or rename the method, or change the parameter signature so that the method does not hide the base method.  
  
## When to Suppress Warnings  
 Do not suppress a warning from this rule.  
  
## Example  
 The following example shows a method that violates the rule.  
  
 [!code[FxCop.Design.HideBaseMethod#1](../vs140/codesnippet/CSharp/ca1061--do-not-hide-base-class-methods_1.cs)]
