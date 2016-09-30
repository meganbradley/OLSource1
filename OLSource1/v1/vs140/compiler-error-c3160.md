---
title: "Compiler Error C3160"
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
  - "C3160"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "C3160"
ms.assetid: a250c433-8adf-43b9-8dee-c3794e09b0a5
caps.latest.revision: 13
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Compiler Error C3160
'pointer' : a data member of a managed or WinRT class cannot have this type  
  
 Interior garbage collection pointers may point to the interior of a managed or WinRT class. Because they are slower than whole-object pointers and require special handling by the garbage collector, you cannot declare interior managed pointers as members of a class.  
  
 The following sample generates C3160:  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
 **Managed Extensions for C++**  
  
 The following sample generates C3160:  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>