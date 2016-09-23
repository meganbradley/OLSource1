---
title: "Compiler Error CS1112"
ms.custom: na
ms.date: 09/22/2016
ms.prod: visual-studio-dev14
ms.reviewer: na
ms.suite: na
ms.technology: 
  - devlang-csharp
ms.tgt_pltfrm: na
ms.topic: error-reference
f1_keywords: 
  - CS1112
dev_langs: 
  - CSharp
helpviewer_keywords: 
  - CS1112
ms.assetid: 72c5f497-8572-41c7-8243-0d5670daca3f
caps.latest.revision: 11
translation.priority.ht: 
  - de-de
  - ja-jp
---
# Compiler Error CS1112
Do not use 'System.Runtime.CompilerServices.ExtensionAttribute'. Use the 'this' keyword instead.  
  
 This error is generated when the <xref:System.Runtime.CompilerServices.ExtensionAttribute?qualifyHint=False> is used on a non-static class that contains extension methods. If this attribute is used on a static class, another error, such as CS0708: "Cannot declare instance members in a static class," might occur.  
  
 In C#, extension methods must be defined in a static class and the first parameter of the method is modified with the `this` keyword. Do not use the attribute at all in the source code. For more information, see [Extension Methods (C# Programming Guide)](../vs140/extension-methods--csharp-programming-guide-.md).  
  
### To correct this error  
  
1.  Remove the attribute and apply the `this` modifier to the first parameter of the method.  
  
## Example  
 The following example generates CS1112:  
  
```  
// cs1112.cs  
[System.Runtime.CompilerServices.ExtensionAttribute] // CS1112  
public class Extensions  
{  
    public bool A(bool b) { return b; }  
}  
  
class A { }   
```