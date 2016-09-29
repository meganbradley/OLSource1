---
title: "DECLARE_DYNCREATE"
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
  - "AFX/DECLARE_DYNCREATE"
  - "DECLARE_DYNCREATE"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "DECLARE_DYNCREATE macro"
  - "run-time object model services macros"
ms.assetid: f550e757-9dec-4875-b13f-841a982f5314
caps.latest.revision: 12
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# DECLARE_DYNCREATE
Enables objects of `CObject`-derived classes to be created dynamically at run time.  
  
## Syntax  
  
```  
  
DECLARE_DYNCREATE(  
class_name )  
```  
  
#### Parameters  
 *class_name*  
 The actual name of the class.  
  
## Remarks  
 The framework uses this ability to create new objects dynamically. For example, the new view created when you open a new document. Document, view, and frame classes should support dynamic creation because the framework needs to create them dynamically.  
  
 Add the `DECLARE_DYNCREATE` macro in the .h module for the class, then include that module in all .cpp modules that need access to objects of this class.  
  
 If `DECLARE_DYNCREATE` is included in the class declaration, then `IMPLEMENT_DYNCREATE` must be included in the class implementation.  
  
 For more information on the `DECLARE_DYNCREATE` macro, see [CObject Class Topics](../vs140/using-cobject.md).  
  
> [!NOTE]
>  The `DECLARE_DYNCREATE` macro includes all the functionality of `DECLARE_DYNAMIC`.  
  
## Example  
 See the example for [IMPLEMENT_DYNCREATE](../vs140/implement_dyncreate.md).  
  
## Requirements  
 **Header:** afx.h  
  
## See Also  
 [Macros and Globals](../vs140/mfc-macros-and-globals.md)   
 [DECLARE_DYNAMIC](../vs140/declare_dynamic.md)   
 [IMPLEMENT_DYNAMIC](../vs140/implement_dynamic.md)   
 [IMPLEMENT_DYNCREATE](../vs140/implement_dyncreate.md)   
 [RUNTIME_CLASS](../vs140/runtime_class.md)   
 [CObject::IsKindOf](../vs140/cobject--iskindof.md)