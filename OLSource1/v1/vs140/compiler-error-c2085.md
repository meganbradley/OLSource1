---
title: "Compiler Error C2085"
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
  - "C2085"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "C2085"
ms.assetid: 0a86785c-8e6f-481b-8c7b-412220c1950d
caps.latest.revision: 11
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Compiler Error C2085
'identifier' : not in formal parameter list  
  
 The identifier was declared in a function definition but not in the formal parameter list. (ANSI C only)  
  
 The following sample generates C2085:  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
 Possible resolution:  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 With the semicolon missing, <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> looks like a function definition, not a prototype, so <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> is defined within <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>, generating Error C2085 for identifier <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>.