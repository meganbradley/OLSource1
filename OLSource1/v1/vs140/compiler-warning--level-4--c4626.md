---
title: "Compiler Warning (level 4) C4626"
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
  - "C4626"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "C4626"
ms.assetid: 7f822ff4-a4a3-4f17-b45b-e8b7b4659a14
caps.latest.revision: 12
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Compiler Warning (level 4) C4626
'derived class' : assignment operator was implicitly defined as deleted because a base class assignment operator is inaccessible or deleted  
  
 An assignment operator was deleted or not accessible in a base class and was therefore not generated for a derived class. Any attempt to assign objects of this type will cause a compiler error.  
  
 This warning is off by default. See [Compiler Warnings That Are Off by Default](../vs140/compiler-warnings-that-are-off-by-default.md) for more information.  
  
 The following sample generates C4626 and shows how to fix it:  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>