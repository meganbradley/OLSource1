---
title: "Compiler Error CS0239"
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
  - CS0239
dev_langs: 
  - CSharp
helpviewer_keywords: 
  - CS0239
ms.assetid: 2e07bbc2-03a9-44b2-b321-477ca95fff8c
caps.latest.revision: 12
translation.priority.ht: 
  - de-de
  - ja-jp
---
# Compiler Error CS0239
'member' : cannot override inherited member 'inherited member' because it is sealed  
  
 A member cannot [override](../vs140/override--csharp-reference-.md) a [sealed](../vs140/sealed--csharp-reference-.md) inherited member. For more information, see [Checked and Unchecked (C# Programmer's Reference)](../vs140/checked-and-unchecked--csharp-reference-.md).  
  
 The following sample generates CS0239:  
  
```  
// CS0239.cs  
abstract class MyClass  
{  
   public abstract void f();  
}  
  
class MyClass2 : MyClass  
{  
   public static void Main()  
   {  
   }  
  
   public override sealed void f()  
   {  
   }  
}  
  
class MyClass3 : MyClass2  
{  
   public override void f()   // CS0239  
   // Try the following definition instead:  
   // public new void f()  
   {  
   }  
}  
```