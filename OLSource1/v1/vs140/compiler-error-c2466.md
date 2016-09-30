---
title: "Compiler Error C2466"
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
  - "C2466"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "C2466"
ms.assetid: 75b251d1-7d0b-4a86-afca-26adedf74486
caps.latest.revision: 13
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Compiler Error C2466
cannot allocate an array of constant size 0  
  
 An array is allocated or declared with size zero. The constant expression for the array size must be an integer greater than zero. An array declaration with a zero subscript is legal only for a class, structure, or union member and only with Microsoft extensions ([/Ze](../vs140/-za---ze--disable-language-extensions-.md)).  
  
 The following sample generates C2466:  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>