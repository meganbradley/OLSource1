---
title: "Compiler Warning (level 1) C4215"
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
  - "C4215"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "C4215"
ms.assetid: f2aab64d-1bab-4f75-95ee-89e1263047b1
caps.latest.revision: 11
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Compiler Warning (level 1) C4215
nonstandard extension used : long float  
  
 The default Microsoft extensions (/Ze) treat **long float** as **double**. ANSI compatibility ([/Za](../vs140/-za---ze--disable-language-extensions-.md)) does not. Use **double** to maintain compatibility.  
  
 The following sample generates C4215:  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>