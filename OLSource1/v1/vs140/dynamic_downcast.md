---
title: "DYNAMIC_DOWNCAST"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-cpp"
ms.tgt_pltfrm: na
ms.topic: "article"
f1_keywords: 
  - "DYNAMIC_DOWNCAST"
  - "AFX/DYNAMIC_DOWNCAST"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "casting, pointers to class objects"
  - "DYNAMIC_DOWNCAST macro"
  - "pointers, to class objects"
ms.assetid: 1d77f9a6-e187-46d5-954c-2a6af8bf6b03
caps.latest.revision: 12
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# DYNAMIC_DOWNCAST
Provides a handy way to cast a pointer to a pointer to a class object while checking to see if the cast is legal.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 The name of a class.  
  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 A pointer to be cast to a pointer to an object of type <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>.  
  
## Remarks  
 The macro will cast the <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> parameter to a pointer to an object of the <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> parameter's type.  
  
 If the object referenced by the pointer is a "kind of" the identified class, the macro returns the appropriate pointer. If it is not a legal cast, the macro returns **NULL**.  
  
## Requirements  
 **Header:** afx.h  
  
## See Also  
 [Macros and Globals](../vs140/mfc-macros-and-globals.md)   
 [STATIC_DOWNCAST](../vs140/static_downcast.md)   
 [dynamic_cast Operator](../vs140/dynamic_cast-operator.md)