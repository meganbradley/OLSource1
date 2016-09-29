---
title: "Type Casting of MFC Class Objects"
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
  - "vc.mfc.macros.classes"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "macros, type casting"
  - "pointers, type casting"
  - "type casts"
  - "casting types"
  - "macros, casting pointers"
ms.assetid: e138465e-c35f-4e84-b788-bd200ccf2f0e
caps.latest.revision: 12
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Type Casting of MFC Class Objects
Type casting macros provide a way to cast a given pointer to a pointer that points to an object of specific class, with or without checking that the cast is legal.  
  
 The following table lists the MFC type casting macros.  
  
### Macros That Cast Pointers to MFC Class Objects  
  
|||  
|-|-|  
|[DYNAMIC_DOWNCAST](../VS_csharp/dynamic_downcast.md)|Casts a pointer to a pointer to a class object while checking to see if the cast is legal.|  
|[STATIC_DOWNCAST](../VS_csharp/static_downcast.md)|Casts a pointer to an object from one class to a pointer of a related type. In a debug build, causes an **ASSERT** if the object is not a "kind of" the target type.|  
  
## See Also  
 [Macros and Globals](../VS_csharp/mfc-macros-and-globals.md)