---
title: "RUNTIME_CLASS"
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
  - "AFX/RUNTIME_CLASS"
  - "RUNTIME_CLASS"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "run-time object model services macros"
  - "RUNTIME_CLASS structure"
ms.assetid: 98cbea2a-a210-44f3-8bc0-0bed990d7014
caps.latest.revision: 14
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# RUNTIME_CLASS
Gets the run-time class structure from the name of a C++ class.  
  
## Syntax  
  
```  
  
RUNTIME_CLASS(  
class_name )  
```  
  
#### Parameters  
 *class_name*  
 The actual name of the class (not enclosed in quotation marks).  
  
## Remarks  
 `RUNTIME_CLASS` returns a pointer to a [CRuntimeClass](../vs140/cruntimeclass-structure.md) structure for the class specified by *class_name*. Only `CObject`-derived classes declared with `DECLARE_DYNAMIC`, `DECLARE_DYNCREATE`, or `DECLARE_SERIAL` will return pointers to a `CRuntimeClass` structure.  
  
 For more information, see [CObject Class Topics](../vs140/using-cobject.md).  
  
## Example  
 [!code[NVC_MFCCObjectSample#25](../vs140/codesnippet/CPP/runtime_class_1.cpp)]  
  
## Requirements  
 **Header:** afx.h  
  
## See Also  
 [Macros and Globals](../vs140/mfc-macros-and-globals.md)   
 [DECLARE_DYNAMIC](../vs140/declare_dynamic.md)   
 [DECLARE_DYNCREATE](../vs140/declare_dyncreate.md)   
 [DECLARE_SERIAL](../vs140/declare_serial.md)   
 [CObject::GetRuntimeClass](../vs140/cobject--getruntimeclass.md)   
 [CRuntimeClass Structure](../vs140/cruntimeclass-structure.md)