---
title: "Compiler Warning (level 1) C4946"
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
  - "C4946"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "C4946"
ms.assetid: b85cbef0-e053-4de6-9b14-7b0f82d40495
caps.latest.revision: 15
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Compiler Warning (level 1) C4946
reinterpret_cast used between related classes: 'class1' and 'class2'  
  
 Do not use [reinterpret_cast](../vs140/reinterpret_cast-operator.md) to cast between related types. Use [static_cast](../vs140/static_cast-operator.md) instead, or for polymorphic types, use [dynamic_cast](../vs140/dynamic_cast-operator.md).  
  
 By default, this warning is off. For more information, see [Compiler Warnings That Are Off by Default](../vs140/compiler-warnings-that-are-off-by-default.md).  
  
 The following code example generates C4946:  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>