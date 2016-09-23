---
title: "Compiler Warning (level 1) CS0658"
ms.custom: na
ms.date: 09/21/2016
ms.prod: visual-studio-dev14
ms.reviewer: na
ms.suite: na
ms.technology: 
  - devlang-csharp
ms.tgt_pltfrm: na
ms.topic: article
f1_keywords: 
  - CS0658
dev_langs: 
  - CSharp
helpviewer_keywords: 
  - CS0658
ms.assetid: 0309074c-741a-492c-9370-73b4bbfd3c1a
caps.latest.revision: 11
translation.priority.ht: 
  - de-de
  - ja-jp
---
# Compiler Warning (level 1) CS0658
'attribute modifier' is not a recognized attribute location. All attributes in this block will be ignored.  
  
 An invalid attribute modifier was specified. See [Attribute Targets](assetId:///59a261f0-1cfb-4aa5-b610-6b735389882c) for more information.  
  
 The following sample generates CS0658:  
  
```  
// CS0658.cs  
using System;  
public class TestAttribute : Attribute{}  
[badAttributeLocation: Test]   // CS0658, badAttributeLocation is invalid  
class ClassTest  
{  
   public static void Main()  
   {  
   }  
}  
```