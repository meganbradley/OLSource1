---
title: "Compiler Warning (level 4) C4100"
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
  - "C4100"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "C4100"
ms.assetid: 478ed97d-e502-49e4-9afb-ac2a6c61194b
caps.latest.revision: 11
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Compiler Warning (level 4) C4100
'identifier' : unreferenced formal parameter  
  
 The formal parameter is not referenced in the body of the function. The unreferenced parameter is ignored.  
  
 C4100 can also be issued when code calls a destructor on a otherwise unreferenced parameter of primitive type.  This is a limitation of the Visual C++ compiler.  
  
 The following sample generates C4100:  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>