---
title: "Member &#39;&lt;membername&gt;&#39; cannot be initialized in an object initializer expression because it is not a field or property"
ms.custom: na
ms.date: 09/22/2016
ms.prod: visual-studio-dev14
ms.reviewer: na
ms.suite: na
ms.technology: 
  - devlang-csharp
ms.tgt_pltfrm: na
ms.topic: article
f1_keywords: 
  - bc30990
  - vbc30990
helpviewer_keywords: 
  - BC30990
ms.assetid: 3be2c135-20f6-49b2-a324-d213cfdf9ee3
caps.latest.revision: 15
translation.priority.ht: 
  - de-de
  - ja-jp
---
# Member &#39;&lt;membername&gt;&#39; cannot be initialized in an object initializer expression because it is not a field or property
An object initializer list cannot include shared members, constants, or method calls. The members in the initializer list must be fields or properties, and property members cannot require arguments.  
  
 **Error ID:** BC30990  
  
### To correct this error  
  
-   Remove from the object initializer list all shared members, constants, method calls, or properties that have parameters.  
  
## See Also  
 [Object Initializers](../vs140/object-initializers--named-and-anonymous-types--visual-basic-.md)   
 [NOT IN BUILD: Shared Members in Visual Basic](assetId:///dbc3783f-83a2-4225-995d-c2d6d025663d)   
 [NOT IN BUILD: Properties and Property Procedures](assetId:///23e2a1ec-7e9d-4109-8940-c703d981077b)   
 [NOT IN BUILD: Default Properties](assetId:///a70f2a27-8176-4858-935e-f25afdd43ab5)   
 [NotInBuild:Object Members](assetId:///dfc2cc12-0e66-44fb-a78e-14f931db2309)   
 [Const Statement (Visual Basic)](../vs140/const-statement--visual-basic-.md)