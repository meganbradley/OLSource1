---
title: "Compiler Error CS1001"
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
  - "CS1001"
dev_langs: 
  - "CSharp"
helpviewer_keywords: 
  - "CS1001"
ms.assetid: 327ad669-9c20-4fe8-a771-234878dbb90e
caps.latest.revision: 11
author: ""
ms.author: ""
manager: ""
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Compiler Error CS1001
Identifier expected  
  
 You did not supply an identifier. An identifier is the name of a class, struct, namespace, method, variable and so on that you provide.  
  
 The following example declares a simple class but does not give the class a name:  
  
```  
//cs1001.cs  
public class              //CS1001  
    {  
        public int Num {get; set;}  
        void MethodA(){}  
    }  
```  
  
 The following sample generates CS1001 because, when declaring an enum, you must specify members:  
  
```  
// CS1001.cs  
public class clx  
{  
   enum Colors : int  
   {  
      'a', 'b' // CS1001, 'a' is not a valid int identifier  
       // The following line shows examples of valid identifiers:  
       // Blue, Red, Orange  
   };  
  
   public static void Main()  
   {  
   }  
}  
  
```  
  
 Parameter names are required even if the compiler doesn't use them, for example, in an interface definition. These parameters are required so that programmers who are consuming the interface know something about the what the parameters mean.  
  
```  
// CS1001-2.cs  
// compile with: /target:library  
interface IMyTest  
{  
   void TestFunc1(int, int);  // CS1001  
   // Use the following line instead:  
   // void TestFunc1(int a, int b);  
}  
  
class CMyTest : IMyTest  
{  
   void IMyTest.TestFunc1(int a, int b)  
   {  
   }  
}  
```  
  
## See Also  
 [Statements, Expressions, and Operators (C# Programming Guide)](../vs140/statements--expressions--and-operators--csharp-programming-guide-.md)   
 [Types (C# Programming Guide)](../vs140/types--csharp-programming-guide-.md)