---
title: "DECLARE_SERIAL"
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
  - "DECLARE_SERIAL"
  - "AFX/DECLARE_SERIAL"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "DECLARE_SERIAL macro"
  - "run-time object model services macros"
ms.assetid: 1c1ec454-a666-4743-8ea5-5c059ef2868d
caps.latest.revision: 14
author: ""
ms.author: ""
manager: ""
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# DECLARE_SERIAL
Generates the C++ header code necessary for a `CObject`-derived class that can be serialized.  
  
## Syntax  
  
```  
  
DECLARE_SERIAL(  
class_name )  
```  
  
#### Parameters  
 *class_name*  
 The actual name of the class.  
  
## Remarks  
 Serialization is the process of writing or reading the contents of an object to and from a file.  
  
 Use the `DECLARE_SERIAL` macro in an .h module, and then include that module in all .cpp modules that need access to objects of this class.  
  
 If `DECLARE_SERIAL` is included in the class declaration, then `IMPLEMENT_SERIAL` must be included in the class implementation.  
  
 The `DECLARE_SERIAL` macro includes all the functionality of `DECLARE_DYNAMIC` and `DECLARE_DYNCREATE`.  
  
 You can use the **AFX_API** macro to automatically export the `CArchive` extraction operator for classes that use the `DECLARE_SERIAL` and `IMPLEMENT_SERIAL` macros. Bracket the class declarations (located in the .h file) with the following code:  
  
 [!code[NVC_MFCCObjectSample#20](../vs140/codesnippet/CPP/declare_serial_1.h)]  
  
 For more information on the `DECLARE_SERIAL` macro, see [CObject Class Topics](../vs140/using-cobject.md).  
  
## Example  
 [!code[NVC_MFCCObjectSample#21](../vs140/codesnippet/CPP/declare_serial_2.h)]  
  
## Requirements  
 **Header:** afx.h  
  
## See Also  
 [Macros and Globals](../vs140/mfc-macros-and-globals.md)   
 [DECLARE_DYNAMIC](../vs140/declare_dynamic.md)   
 [IMPLEMENT_SERIAL](../vs140/implement_serial.md)   
 [RUNTIME_CLASS](../vs140/runtime_class.md)   
 [CObject::IsKindOf](../vs140/cobject--iskindof.md)