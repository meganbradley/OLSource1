---
title: "AfxOleUnregisterClass"
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
  - AfxOleUnregisterClass
  - AFXCTL/AfxOleUnregisterClass
dev_langs: 
  - C++
helpviewer_keywords: 
  - AfxOleUnregisterClass function
ms.assetid: c5235da2-9df8-449b-b307-2969890f2e68
caps.latest.revision: 12
translation.priority.ht: 
  - de-de
  - ja-jp
---
# AfxOleUnregisterClass
Removes the control or property page class entry from the Windows registration database.  
  
## Syntax  
  
```  
  
      BOOL AFXAPI AfxOleUnregisterClass(  
   REFCLSID clsID,  
   LPCSTR pszProgID   
);  
```  
  
#### Parameters  
 *clsID*  
 The unique class ID of the control or property page.  
  
 `pszProgID`  
 The unique program ID of the control or property page.  
  
## Return Value  
 Nonzero if the control or property page class was successfully unregistered; otherwise 0.  
  
## Requirements  
 **Header:** afxctl.h  
  
## See Also  
 [Macros and Globals](../vs140/mfc-macros-and-globals.md)   
 [AfxOleRegisterPropertyPageClass](../vs140/afxoleregisterpropertypageclass.md)   
 [AfxOleRegisterControlClass](../vs140/afxoleregistercontrolclass.md)   
 [AfxOleRegisterTypeLib](../vs140/afxoleregistertypelib.md)