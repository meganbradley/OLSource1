---
title: "ASSERT_KINDOF"
ms.custom: na
ms.date: 09/22/2016
ms.prod: visual-studio-dev14
ms.reviewer: na
ms.suite: na
ms.technology: 
  - devlang-cpp
ms.tgt_pltfrm: na
ms.topic: article
f1_keywords: 
  - AFX/ASSERT_KINDOF
  - ASSERT_KINDOF
dev_langs: 
  - C++
helpviewer_keywords: 
  - ASSERT_KINDOF macro
ms.assetid: 94b62f7c-ba07-46b7-b90b-734f31ef134f
caps.latest.revision: 13
translation.priority.ht: 
  - de-de
  - ja-jp
---
# ASSERT_KINDOF
This macro asserts that the object pointed to is an object of the specified class, or is an object of a class derived from the specified class.  
  
## Syntax  
  
```  
  
ASSERT_KINDOF(  
classname  
,   
pobject )  
```  
  
#### Parameters  
 *classname*  
 The name of a `CObject`-derived class.  
  
 *pobject*  
 A pointer to a class object.  
  
## Remarks  
 The *pobject* parameter should be a pointer to an object and can be **const**. The object pointed to and the class must support `CObject` run-time class information. As an example, to ensure that `pDocument` is a pointer to an object of the `CMyDoc` class, or any of its derivatives, you could code:  
  
 [!code[NVC_MFCDocView#194](../vs140/codesnippet/CPP/assert_kindof_1.cpp)]
  
  
 Using the `ASSERT_KINDOF` macro is exactly the same as coding:  
  
 [!code[NVC_MFCDocView#195](../vs140/codesnippet/CPP/assert_kindof_2.cpp)]
  
  
 This function works only for classes declared with the [DECLARE_DYNAMIC](../vs140/declare_dynamic.md) or [DECLARE_SERIAL](../vs140/declare_serial.md) macro.  
  
> [!NOTE]
>  This function is available only in the Debug version of MFC.  
  
## Requirements  
 **Header:** afx.h  
  
## See Also  
 [Macros and Globals](../vs140/mfc-macros-and-globals.md)   
 [ASSERT](../vs140/assert--mfc-.md)