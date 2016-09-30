---
title: "Compiler Error C3145"
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
  - "C3145"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "C3145"
ms.assetid: f165c874-0f51-45c7-85e8-ebe321cbc168
caps.latest.revision: 17
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Compiler Error C3145
'object' : global or static variable may not have managed or WinRT type 'type'  
  
 You can only define CLR or WinRT objects within function scope.  
  
 The following sample generates C3145 and shows how to fix it:  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
 The following sample generates C3145:  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 **Managed Extensions for C++**  
  
 The following sample generates C3145:  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>