---
title: "CComControlBase::CComControlBase"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-cpp"
ms.tgt_pltfrm: na
ms.topic: "reference"
f1_keywords: 
  - "CComControlBase.CComControlBase"
  - "CComControlBase::CComControlBase"
  - "ATL::CComControlBase::CComControlBase"
  - "ATL.CComControlBase.CComControlBase"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "CComControlBase class, constructor"
  - "CComControlBase constructor"
ms.assetid: cdfacebc-8d90-4d0e-973c-b953640d149c
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CComControlBase::CComControlBase
The constructor.  
  
## Syntax  
  
```  
  
      CComControlBase(  
   HWND& h   
);  
```  
  
#### Parameters  
 `h`  
 The handle to the window associated with the control.  
  
## Remarks  
 Initializes the control size to 5080X5080 HIMETRIC units (2"X2") and initializes the `CComControlBase` data member values to **NULL** or **FALSE**.  
  
## Requirements  
 **Header:** atlctl.h  
  
## See Also  
 [CComControlBase Class](../vs140/ccomcontrolbase-class.md)   
 [CComControlBase::~CComControlBase](../vs140/ccomcontrolbase--~ccomcontrolbase.md)