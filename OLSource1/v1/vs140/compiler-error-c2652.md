---
title: "Compiler Error C2652"
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
  - "C2652"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "C2652"
ms.assetid: 6e3d1a90-a989-4088-8afd-dc82f6a2d66f
caps.latest.revision: 12
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Compiler Error C2652
'identifier' : illegal copy constructor: first parameter must not be an 'identifier'  
  
 The first parameter in the copy constructor has the same type as the class, structure, or union for which it is defined. The first parameter can be a reference to the type but not the type itself.  
  
 The following sample generates C2651:  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>