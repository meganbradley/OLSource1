---
title: "Compiler Error C2847"
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
  - "C2847"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "C2847"
ms.assetid: 9ad9a0e0-8b16-49d9-a5be-f8eda2372aa9
caps.latest.revision: 16
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Compiler Error C2847
cannot apply sizeof to managed or WinRT type 'class'  
  
 The [sizeof](../vs140/sizeof-operator.md) operator gets the value of an object at compile time. The size of a managed or WinRT class, interface, or value type is dynamic and so cannot be known at compile time.  
  
 For example, the following sample generates C2847:  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
 The following sample generates C2847:  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>