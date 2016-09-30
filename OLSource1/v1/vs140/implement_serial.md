---
title: "IMPLEMENT_SERIAL"
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
  - "IMPLEMENT_SERIAL"
  - "AFX/IMPLEMENT_SERIAL"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "run-time object model services macros"
  - "IMPLEMENT_SERIAL macro"
ms.assetid: 83dbcfe2-abe4-4fd7-aba1-9a4c1c23f078
caps.latest.revision: 14
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# IMPLEMENT_SERIAL
Generates the C++ code necessary for a dynamic `CObject`-derived class with run-time access to the class name and position within the hierarchy.  
  
## Syntax  
  
```  
  
IMPLEMENT_SERIAL(  
class_name  
,   
base_class_name  
,   
wSchema )  
```  
  
#### Parameters  
 *class_name*  
 The actual name of the class.  
  
 `base_class_name`  
 The name of the base class.  
  
 *wSchema*  
 A **UINT** "version number" that will be encoded in the archive to enable a deserializing program to identify and handle data created by earlier program versions. The class schema number must not be –1.  
  
## Remarks  
 Use the `IMPLEMENT_SERIAL` macro in a .cpp module; then link the resulting object code only once.  
  
 You can use the **AFX_API** macro to automatically export the `CArchive` extraction operator for classes that use the `DECLARE_SERIAL` and `IMPLEMENT_SERIAL` macros. Bracket the class declarations (located in the .h file) with the following code:  
  
 [!code[NVC_MFCCObjectSample#20](../vs140/codesnippet/CPP/implement_serial_1.h)]  
  
 For more information, see the [CObject Class Topics](../vs140/using-cobject.md).  
  
## Example  
 [!code[NVC_MFCCObjectSample#24](../vs140/codesnippet/CPP/implement_serial_2.cpp)]  
  
## Requirements  
 **Header:** afx.h  
  
## See Also  
 [Macros and Globals](../vs140/mfc-macros-and-globals.md)   
 [DECLARE_SERIAL](../vs140/declare_serial.md)   
 [RUNTIME_CLASS](../vs140/runtime_class.md)   
 [CObject::IsKindOf](../vs140/cobject--iskindof.md)