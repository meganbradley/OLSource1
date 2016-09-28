---
title: "Compiler Error CS0314"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-csharp"
ms.tgt_pltfrm: na
ms.topic: "article"
f1_keywords: 
  - "CS0314"
dev_langs: 
  - "CSharp"
helpviewer_keywords: 
  - "CS0314"
ms.assetid: 12f68f51-0568-4e80-b0fd-15899807477d
caps.latest.revision: 11
author: ""
ms.author: ""
manager: ""
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Compiler Error CS0314
The type 'type1' cannot be used as type parameter 'name' in the generic type or method 'name'. There is no boxing conversion or type parameter conversion from 'type1' to 'type2'.  
  
 When a generic type uses a type parameter that is constrained, the new class must also satisfy those same constraints.  
  
### To correct this error  
  
1.  In the example that follows, add `where T : ClassConstraint` to class `B`.  
  
## Example  
 The following code generates CS0314:  
  
```  
// cs0314.cs  
// Compile with: /target:library  
public class ClassConstraint { }  
  
public class A<T> where T : ClassConstraint  
{ }  
  
public class B<T> : A<T> //CS0314  
{ }  
  
// Try using this instead.  
public class C<T> : A<T> where T : ClassConstraint  
{ }  
```  
  
## See Also  
 [Constraints on Type Parameters (C# Programming Guide)](../vs140/constraints-on-type-parameters--csharp-programming-guide-.md)