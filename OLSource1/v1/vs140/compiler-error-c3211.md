---
title: "Compiler Error C3211"
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
  - C3211
dev_langs: 
  - C++
helpviewer_keywords: 
  - C3211
ms.assetid: 85e33fed-3b59-4315-97e6-20d31c6a985a
caps.latest.revision: 10
translation.priority.ht: 
  - de-de
  - ja-jp
---
# Compiler Error C3211
'explicit specialization' : explicit specialization is using partial specialization syntax, use template <> instead  
  
 An explicit specialization was ill formed.  
  
 The following sample generates C3211:  
  
```  
// C3211.cpp  
// compile with: /LD  
template<class T>  
struct s;  
  
template<class T>  
// use the following line instead  
// template<>  
struct s<int>{};   // C3211  
```