---
title: "Compiler Error CS0504"
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
  - "CS0504"
dev_langs: 
  - "CSharp"
helpviewer_keywords: 
  - "CS0504"
ms.assetid: f2486ffd-aa85-4b40-a89c-a32530b85d1f
caps.latest.revision: 7
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
# Compiler Error CS0504
The constant 'variable' cannot be marked static  
  
 If a variable is [const](../VS_csharp/const--csharp-reference-.md), it is also [static](../VS_csharp/static--csharp-reference-.md). If you want a **const** and **static** variable, just declare that variable as **const**; if all you want is a **static** variable, just mark it **static**.  
  
 The following sample generates CS0504:  
  
```  
// CS0504.cs  
namespace x  
{  
   abstract public class clx  
   {  
      static const int i = 0;   // CS0504, cannot be both static and const  
      abstract public void f();  
   }  
}  
```