---
title: "Compiler Error C3255"
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
  - "C3255"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "C3255"
ms.assetid: 877ffca2-fd92-44b6-9060-6091b928b1c1
caps.latest.revision: 16
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Compiler Error C3255
'value type' : cannot dynamically allocate this value type object on native heap  
  
 Instances of a value type (see [Classes and Structs (Managed)](../vs140/classes-and-structs---c---component-extensions-.md)) that contain managed members can be created on the stack but not on the heap.  
  
 The following sample generates C3255:  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
 **Managed Extensions for C++**  
  
 The following sample generates C3255:  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>