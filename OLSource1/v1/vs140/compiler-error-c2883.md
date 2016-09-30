---
title: "Compiler Error C2883"
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
  - "C2883"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "C2883"
ms.assetid: 5c6d689d-ed42-41ad-b5c0-e9c2e0b8c356
caps.latest.revision: 11
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Compiler Error C2883
'name' : function declaration conflicts with 'identifier' introduced by using-declaration  
  
 You tried to define a function more than once. The first definition was made from a namespace with a <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> declaration. The second was a local definition.  
  
 The following sample generates C2883:  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>