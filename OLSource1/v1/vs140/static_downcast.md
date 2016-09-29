---
title: "STATIC_DOWNCAST"
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
  - "AFX/STATIC_DOWNCAST"
  - "STATIC_DOWNCAST"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "casting pointers to class objects"
  - "STATIC_DOWNCAST macro"
  - "pointers, to class objects"
ms.assetid: bcc4471e-2e40-4803-8083-b46e95c74be6
caps.latest.revision: 13
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# STATIC_DOWNCAST
Casts *pobject* to a pointer to a *class_name* object.  
  
## Syntax  
  
```  
  
STATIC_DOWNCAST(  
class_name  
, pobject )  
```  
  
#### Parameters  
 *class_name*  
 The name of the class being cast to.  
  
 *pobject*  
 The pointer to be cast to a pointer to a *class_name* object.  
  
## Remarks  
 *pobject* must either be **NULL**, or point to an object of a class which is derived directly, or indirectly, from *class_name*. In builds of your application with the **_DEBUG** preprocessor symbol defined, the macro will **ASSERT** if *pobject* is not **NULL**, or if it points to an object that is not a "kind of" the class specified in the *class_name* parameter (see [CObject::IsKindOf](../vs140/cobject--iskindof.md)). In non-**_DEBUG** builds, the macro performs the cast without any type checking.  
  
 The class specified in the *class_name* parameter must be derived from `CObject` and must use the `DECLARE_DYNAMIC` and `IMPLEMENT_DYNAMIC`, the `DECLARE_DYNCREATE` and `IMPLEMENT_DYNCREATE`, or the `DECLARE_SERIAL` and `IMPLEMENT_SERIAL` macros as explained in the article [CObject Class: Deriving a Class from CObject](../vs140/deriving-a-class-from-cobject.md).  
  
 For example, you might cast a pointer to `CMyDoc`, called `pMyDoc`, to a pointer to **CDocument** using this expression:  
  
 [!code[NVC_MFCDocView#197](../vs140/codesnippet/CPP/static_downcast_1.cpp)]  
  
 If `pMyDoc` does not point to an object derived directly or indirectly from **CDocument**, the macro will **ASSERT**.  
  
## Requirements  
 **Header:** afx.h  
  
## See Also  
 [Macros and Globals](../vs140/mfc-macros-and-globals.md)   
 [DYNAMIC_DOWNCAST](../vs140/dynamic_downcast.md)   
 [static_cast Operator](../vs140/static_cast-operator.md)