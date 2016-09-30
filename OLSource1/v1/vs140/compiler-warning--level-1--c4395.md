---
title: "Compiler Warning (level 1) C4395"
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
  - "C4395"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "C4395"
ms.assetid: 8051469a-3a39-4677-80f7-1300fbffe8ea
caps.latest.revision: 10
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Compiler Warning (level 1) C4395
'function' : member function will be invoked on a copy of the initonly data member 'member'  
  
 A member function was called on an [initonly](../vs140/initonly--c---cli-.md) data member.  C4395 warns that the **initonly** data member cannot be modified by the function.  
  
 The following sample generates C4395:  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>