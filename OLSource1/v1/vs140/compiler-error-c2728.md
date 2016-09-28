---
title: "Compiler Error C2728"
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
  - "C2728"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "C2728"
ms.assetid: 65635f91-1cd1-46e4-9ad7-14726d0546af
caps.latest.revision: 21
author: ""
ms.author: ""
manager: ""
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Compiler Error C2728
'type' : a native array cannot contain this type  
  
 Array creation syntax was used to create an array of managed or WinRT objects. You cannot create an array of managed or WinRT objects using native array syntax.  
  
 For more information, see [array](../vs140/arrays--c---component-extensions-.md).  
  
 The following sample generates C2728 and shows how to fix it:  
  
```  
// C2728.cpp  
// compile with: /clr  
  
int main() {  
   int^ arr[5];   // C2728  
  
   // try the following line instead  
   array<int>^arr2;  
}  
```  
  
 A [__nogc](../vs140/__nogc.md) array cannot be of a [__gc](../vs140/__gc.md) type.  
  
 The following sample generates C2728 and shows how to fix it:  
  
```  
// C2728_b.cpp  
// compile with: /clr:oldSyntax  
#using <mscorlib.dll>  
  
int main() {  
   int __gc* arr __nogc[5];   // C2728  
  
   // try the following line instead  
   int arr2 __gc[];  
}  
```