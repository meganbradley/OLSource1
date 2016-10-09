---
title: "Compiler Error CS0178"
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
  - "CS0178"
dev_langs: 
  - "CSharp"
helpviewer_keywords: 
  - "CS0178"
ms.assetid: 73e48648-6c0c-4987-92ca-fb2015a38910
caps.latest.revision: 10
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
# Compiler Error CS0178
Invalid rank specifier: expected ',' or ']'  
  
 An array initialization was ill-formed. For example, when specifying the array dimensions, you can specify the following:  
  
-   A number in brackets  
  
-   Empty brackets  
  
-   A comma enclosed in brackets  
  
 For more information, see [Arrays](../VS_csharp/arrays--csharp-programming-guide-.md) and the C# specification ([C# Language Specification](../VS_csharp/csharp-language-specification.md)) section on array initializers.  
  
## Example  
 The following sample generates CS0178.  
  
```  
// CS0178.cs  
class MyClass  
{  
   public static void Main()  
   {  
      int a = new int[5][,][][5;   // CS0178  
      int[,] b = new int[3,2];   // OK  
  
      int[][] c = new int[10][];  
      c[0] = new int[5][5];   // CS0178  
      c[0] = new int[2];   // OK  
      c[1] = new int[2]{1,2};   // OK  
   }  
}  
```