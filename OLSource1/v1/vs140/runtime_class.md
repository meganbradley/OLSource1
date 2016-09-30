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
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 *class_name*  
 The actual name of the class (not enclosed in quotation marks).  
  
## Remarks  
 <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> returns a pointer to a [CRuntimeClass](../vs140/cruntimeclass-structure.md) structure for the class specified by *class_name*. Only <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>-derived classes declared with <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>, or <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> will return pointers to a <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> structure.  
  
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