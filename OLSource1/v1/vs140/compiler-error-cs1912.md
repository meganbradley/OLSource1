---
title: "Compiler Error CS1912"
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
  - CS1912
dev_langs: 
  - CSharp
helpviewer_keywords: 
  - CS1912
ms.assetid: 6205420e-01b9-4470-89f9-5924f1e49108
caps.latest.revision: 12
translation.priority.ht: 
  - de-de
  - ja-jp
---
# Compiler Error CS1912
Duplicate initialization of member 'name'.  
  
 An object initializer can initialize each member only one time.  
  
### To correct this error  
  
1.  Remove the second initialization of the member in the object initializer.  
  
## Example  
 The following code generates CS1912 because `memberA` is initialized two times:  
  
```  
// cs1912.cs  
using System.Linq;  
  
public class TestClass  
{  
    public int memberA { get; set; }  
    public int memberB { get; set; }  
}  
  
public class Test  
{  
    static void Main()  
    {  
        TestClass tc = new TestClass() { memberA = 5, memberA = 6, memberB = 2}; // CS1912  
    }  
}  
```  
  
## See Also  
 [Object and Collection Initializers (C# Programming Guide)](../vs140/object-and-collection-initializers--csharp-programming-guide-.md)