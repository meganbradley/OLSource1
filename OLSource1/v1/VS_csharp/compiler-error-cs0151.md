---
title: "Compiler Error CS0151"
ms.custom: na
ms.date: "10/03/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-csharp"
ms.tgt_pltfrm: na
ms.topic: "error-reference"
f1_keywords: 
  - "CS0151"
dev_langs: 
  - "CSharp"
helpviewer_keywords: 
  - "CS0151"
ms.assetid: 1adda08b-6be5-46c8-96f9-5ac7c7bfe48c
caps.latest.revision: 14
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
# Compiler Error CS0151
A value of an integral type expected  
  
 A variable was used in a situation where an integral data type was required. For more information, see [Types](../VS_csharp/types--csharp-programming-guide-.md).  
  
## Example  
 This error can occur when there is no conversion or if the available implicit conversions result in an ambiguous situation. The following sample generates CS0151.  
  
```  
// CS0151.cs  
public class MyClass  
{  
   public static implicit operator int (MyClass aa)  
   {  
      return 0;  
   }  
  
   public static implicit operator long (MyClass aa)  
   {  
      return 0;  
   }  
  
   public static void Main()  
   {  
      MyClass a = new MyClass();  
  
      // Compiler cannot choose between int and long  
      switch (a)   // CS0151  
      // try the following line instead  
      // switch ((int)a)  
      {  
         case 1:  
            break;  
      }  
   }  
}  
```  
  
## Example  
 In Visual Studio 2008 and later, a [void](../VS_csharp/void--csharp-reference-.md) method invocation generates CS0151. You can fix the error by calling a method that returns an integral type such as [int](../VS_csharp/int--csharp-reference-.md) or [long](../VS_csharp/long--csharp-reference-.md).  
  
```  
class C  
{  
    static void Main()  
    {  
  
        switch (M()) // CS0151  
        {  
            default:  
                break;  
        }  
    }  
  
    static void M()  
    {  
    }  
}  
```