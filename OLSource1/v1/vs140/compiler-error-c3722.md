---
title: "Compiler Error C3722"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-cpp"
ms.tgt_pltfrm: na
ms.topic: "error-reference"
f1_keywords: 
  - "C3722"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "C3722"
ms.assetid: 3cb28363-5eff-4548-bd0d-d5c615846353
caps.latest.revision: 10
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Compiler Error C3722
a generic event is not allowed  
  
 The compiler only allows generic classes, structs, and functions.  For more information, see [generics](../vs140/generics---c---component-extensions-.md).  
  
 The following sample generates C3722:  
  
```  
// C3722.cpp  
// compile with: /clr  
generic <typename T>  
public delegate void MyEventHandler(System::Object^ sender, System::EventArgs^ e, T optional);  
  
generic <class T>  
public ref struct MyButton {  
   generic<typename U>  
   event MyEventHandler<U>^ Click;   // C3722  
};  
```