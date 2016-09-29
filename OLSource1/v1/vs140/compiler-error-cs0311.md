---
title: "Compiler Error CS0311"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-csharp"
ms.tgt_pltfrm: na
ms.topic: "error-reference"
f1_keywords: 
  - "CS0311"
dev_langs: 
  - "CSharp"
helpviewer_keywords: 
  - "CS0311"
ms.assetid: d095f0fa-efd7-491c-a80b-4c5704a90de7
caps.latest.revision: 11
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Compiler Error CS0311
The type 'type1' cannot be used as type parameter 'T' in the generic type or method '<name\>'. There is no implicit reference conversion from 'type1' to 'type2'.  
  
 When a constraint is applied to a generic type parameter, an implicit identity or reference conversion must exist from the concrete argument to the type of the constraint.  
  
### To correct this error  
  
1.  Change the argument you are using to create the class.  
  
2.  If you own the class, you can remove the constraint or else do something to enable an implicit reference or identity conversion. For example, you can make the second type inherit from the first.  
  
## Example  
  
```  
// cs0311.cs  
class B{}  
class C{}  
class Test<T> where T : C  
{ }  
  
class Program  
{  
    static void Main()  
    {  
        Test<B> test = new Test<B>(); //CS0311  
    }  
}  
```  
  
 If this error occurs when trying to use a value-type argument, notice that an implicit numeric conversion, for example from `short` to `int`, does not satisfy a generic type parameter.  
  
## See Also  
 [Constraints on Type Parameters (C# Programming Guide)](../vs140/constraints-on-type-parameters--csharp-programming-guide-.md)