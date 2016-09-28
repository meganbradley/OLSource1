---
title: "Compiler Error CS0552"
ms.custom: na
ms.date: "09/21/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-csharp"
ms.tgt_pltfrm: na
ms.topic: "error-reference"
f1_keywords: 
  - "CS0552"
dev_langs: 
  - "CSharp"
helpviewer_keywords: 
  - "CS0552"
ms.assetid: ce5cfb26-8406-4ca0-adb7-55d1d03d8145
caps.latest.revision: 10
author: ""
ms.author: ""
manager: ""
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Compiler Error CS0552
'conversion routine' : user defined conversion to/from interface  
  
 You cannot create a user-defined conversion to or from an interface. If you need the conversion routine, resolve this error by making the interface a class or derive a class from the interface.  
  
 The following sample generates CS0552:  
  
```  
// CS0552.cs  
public interface ii  
{  
}  
  
public class a  
{  
   // delete the routine to resolve CS0552  
   public static implicit operator ii(a aa) // CS0552  
   {  
      return new ii();  
   }  
  
   public static void Main()  
   {  
   }  
}  
```