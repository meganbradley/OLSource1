---
title: "Compiler Error C3386"
ms.custom: na
ms.date: 09/22/2016
ms.prod: visual-studio-dev14
ms.reviewer: na
ms.suite: na
ms.technology: 
  - devlang-cpp
ms.tgt_pltfrm: na
ms.topic: error-reference
f1_keywords: 
  - C3386
dev_langs: 
  - C++
helpviewer_keywords: 
  - C3386
ms.assetid: 93fa8c33-0f10-402b-8eec-b0a217a1f8dc
caps.latest.revision: 15
translation.priority.ht: 
  - de-de
  - ja-jp
---
# Compiler Error C3386
'type' : __declspec(dllexport)/\__declspec(dllimport) cannot be applied to a managed or WinRTtype  
  
 The `dllimport` and [dllexport](../vs140/dllexport--dllimport.md) `__declspec` modifiers are not valid on a managed or Windows Runtime type.  
  
 The following sample generates C3386 and shows how to fix it:  
  
```  
// C3386.cpp  
// compile with: /clr /c  
ref class __declspec(dllimport) X1 {   // C3386  
// try the following line instead  
// ref class X1 {  
};  
```