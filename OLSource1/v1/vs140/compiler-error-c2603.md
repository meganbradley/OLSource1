---
title: "Compiler Error C2603"
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
  - "C2603"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "C2603"
ms.assetid: 9ca520d0-f082-4b65-933d-17c3bcf8b02c
caps.latest.revision: 10
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Compiler Error C2603
'function' : Too many block scope static objects with constructor/destructors in function  
  
 There is a limit of 31 on the number of static objects you can have in an externally visible inline function.  
  
 The following code generates C2603:  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>