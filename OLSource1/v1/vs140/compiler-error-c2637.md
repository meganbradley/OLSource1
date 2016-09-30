---
title: "Compiler Error C2637"
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
  - "C2637"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "C2637"
ms.assetid: 58d94447-eb96-4d8f-a690-dd78d322462e
caps.latest.revision: 12
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Compiler Error C2637
'identifier' : cannot modify pointers to data members  
  
 A pointer to a data member cannot have a calling convention. To resolve, either remove the calling convention or declare a pointer to member function.  
  
 The following sample generates C2637:  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>