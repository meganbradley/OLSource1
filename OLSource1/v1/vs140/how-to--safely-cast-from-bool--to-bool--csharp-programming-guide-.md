---
title: "How to: Safely Cast from bool? to bool (C# Programming Guide)"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-csharp"
ms.tgt_pltfrm: na
ms.topic: "article"
dev_langs: 
  - "CSharp"
helpviewer_keywords: 
  - "casting [C#], nullable types"
  - "nullable types [C#], casting bool? to bool"
ms.assetid: e06e4274-a443-422d-8ef1-9dbf9df55237
caps.latest.revision: 13
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# How to: Safely Cast from bool? to bool (C# Programming Guide)
The `bool?` nullable type can contain three different values: `true`, `false`, and `null`. Therefore, the `bool?` type cannot be used in conditionals such as with `if`, `for`, or `while`. For example, the following code causes a compiler error.  
  
```  
bool? b = null;  
if (b) // Error CS0266.  
{  
}  
```  
  
 This is not allowed because it is unclear what `null` means in the context of a conditional. To use a `bool?` in a conditional statement, first check its <xref:System.Nullable`1.HasValue*> property to ensure that its value is not `null`, and then cast it to `bool`. For more information, see [bool](../vs140/bool--csharp-reference-.md). If you perform the cast on a `bool?` with a value of `null`, a <xref:System.InvalidOperationException*> will be thrown in the conditional test. The following example shows one way to safely cast from `bool?` to `bool`:  
  
## Example  
  
```c#  
bool? test = null;  
// Other code that may or may not  
// give a value to test.  
if(!test.HasValue) //check for a value  
{  
    // Assume that IsInitialized  
    // returns either true or false.  
    test = IsInitialized();  
}  
if((bool)test) //now this cast is safe  
{  
   // Do something.  
}  
```  
  
## See Also  
 [C# Programming Guide](../vs140/csharp-programming-guide.md)   
 [Literal Keywords](../vs140/literal-keywords--csharp-reference-.md)   
 [Nullable Types (C# Programming Guide)](../vs140/nullable-types--csharp-programming-guide-.md)   
 [?? Operator (C# Reference)](../vs140/---operator--csharp-reference-.md)