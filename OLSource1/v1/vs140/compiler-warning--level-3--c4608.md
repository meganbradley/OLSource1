---
title: "Compiler Warning (level 3) C4608"
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
  - "C4608"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "C4608"
ms.assetid: 8b8f5f28-8ce9-457e-9d3d-a8c0efce9b6a
caps.latest.revision: 11
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Compiler Warning (level 3) C4608
'union_member' has already been initialized by another union member in the initializer list, 'union_member'  
  
 Two members of the same union were initialized in an initialization list. You can only access one member of the union.  
  
 The following sample generates C4608:  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>