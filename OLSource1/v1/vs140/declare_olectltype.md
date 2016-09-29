---
title: "DECLARE_OLECTLTYPE"
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
  - "GetMiscStatus"
  - "AFX/DECLARE_OLECTLTYPE"
  - "DECLARE_OLECTLTYPE"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "GetMiscStatus, declaration of"
  - "GetUserTypeNameID member function"
  - "DECLARE_OLECTLTYPE macro"
ms.assetid: 9e78bd1d-9700-4f06-869f-3c40889bca7e
caps.latest.revision: 12
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# DECLARE_OLECTLTYPE
Declares the **GetUserTypeNameID** and `GetMiscStatus` member functions of your control class.  
  
## Syntax  
  
```  
  
DECLARE_OLECTLTYPE(  
class_name )  
```  
  
#### Parameters  
 *class_name*  
 The name of the control class.  
  
## Remarks  
 **GetUserTypeNameID** and `GetMiscStatus` are pure virtual functions, declared in `COleControl`. Because these functions are pure virtual, they must be overridden in your control class. In addition to **DECLARE_OLECTLTYPE**, you must add the `IMPLEMENT_OLECTLTYPE` macro to your control class declaration.  
  
## Requirements  
 **Header:** afxctl.h  
  
## See Also  
 [Macros and Globals](../vs140/mfc-macros-and-globals.md)   
 [IMPLEMENT_OLECTLTYPE](../vs140/implement_olectltype.md)