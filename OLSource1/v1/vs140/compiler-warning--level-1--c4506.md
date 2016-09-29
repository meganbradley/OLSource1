---
title: "Compiler Warning (level 1) C4506"
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
  - "C4506"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "C4506"
ms.assetid: aa682869-65d1-4dad-ba32-198f10b44f91
caps.latest.revision: 10
author: ""
ms.author: ""
manager: ""
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Compiler Warning (level 1) C4506
no definition for inline function 'function'  
  
 The given function was declared and marked for inlining but was not defined.  
  
 The compiler did not inline the function.  
  
 Make sure that external functions to be inlined are declared with the `extern` keyword.