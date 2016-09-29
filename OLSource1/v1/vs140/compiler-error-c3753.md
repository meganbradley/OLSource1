---
title: "Compiler Error C3753"
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
  - "C3753"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "C3753"
ms.assetid: a5b99e28-796c-4107-a673-97c2ae3bb2b9
caps.latest.revision: 7
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Compiler Error C3753
a generic property is not allowed  
  
 Generic parameter lists can only appear on managed classes, structs, or functions.  
  
 For more information, see [Generics (C++)](../vs140/generics---c---component-extensions-.md) and [property](../vs140/property---c---component-extensions-.md).  
  
## Example  
 The following sample generates C3753.  
  
```  
// C3753.cpp  
// compile with: /clr /c  
ref struct A {  
   generic <typename T>  
   property int i;   // C3753 error  
};  
```