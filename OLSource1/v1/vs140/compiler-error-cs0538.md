---
title: "Compiler Error CS0538"
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
  - "CS0538"
dev_langs: 
  - "CSharp"
helpviewer_keywords: 
  - "CS0538"
ms.assetid: 46ac205e-16b0-4637-bd0f-9a755ac19f18
caps.latest.revision: 11
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Compiler Error CS0538
'name' in explicit interface declaration is not an interface  
  
 An attempt was made to explicitly declare an [interface](../vs140/interface--csharp-reference-.md), but an interface was not specified.  
  
 The following sample generates CS0538:  
  
```  
// CS0538.cs  
interface MyIFace  
{  
   void F();  
}  
  
public class MyClass  
{  
   public void G()  
   {  
   }  
}  
  
class C: MyIFace  
{  
   void MyIFace.F()  
   {  
   }  
  
   void MyClass.G()   // CS0538, MyClass not an interface  
   {  
   }  
}  
```