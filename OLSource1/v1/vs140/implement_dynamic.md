---
title: "IMPLEMENT_DYNAMIC"
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
  - "AFX/IMPLEMENT_DYNAMIC"
  - "IMPLEMENT_DYNAMIC"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "run-time object model services macros"
  - "IMPLEMENT_DYNAMIC macro"
ms.assetid: 8c2eef04-6e71-4512-be7f-9043bd0ed826
caps.latest.revision: 13
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# IMPLEMENT_DYNAMIC
Generates the C++ code necessary for a dynamic `CObject`-derived class with run-time access to the class name and position within the hierarchy.  
  
## Syntax  
  
```  
  
IMPLEMENT_DYNAMIC(  
class_name  
,   
base_class_name )  
```  
  
#### Parameters  
 *class_name*  
 The actual name of the class.  
  
 `base_class_name`  
 The name of the base class.  
  
## Remarks  
 Use the `IMPLEMENT_DYNAMIC` macro in a .cpp module, and then link the resulting object code only once.  
  
 For more information, see [CObject Class Topics](../vs140/using-cobject.md).  
  
## Example  
 [!code[NVC_MFCCObjectSample#2](../vs140/codesnippet/CPP/implement_dynamic_1.h)]  
  
 [!code[NVC_MFCCObjectSample#3](../vs140/codesnippet/CPP/implement_dynamic_2.cpp)]  
  
## Requirements  
 **Header:** afx.h  
  
## See Also  
 [Macros and Globals](../vs140/mfc-macros-and-globals.md)   
 [DECLARE_DYNAMIC](../vs140/declare_dynamic.md)   
 [RUNTIME_CLASS](../vs140/runtime_class.md)   
 [CObject::IsKindOf](../vs140/cobject--iskindof.md)