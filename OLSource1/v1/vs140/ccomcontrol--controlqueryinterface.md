---
title: "CComControl::ControlQueryInterface"
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
  - "CComControl::ControlQueryInterface"
  - "ATL.CComControl.ControlQueryInterface"
  - "ATL::CComControl::ControlQueryInterface"
  - "CComControl.ControlQueryInterface"
  - "ControlQueryInterface"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "ControlQueryInterface method"
ms.assetid: a479f29f-ae1f-4e65-aeb8-28cab7c6531c
caps.latest.revision: 15
author: ""
ms.author: ""
manager: ""
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CComControl::ControlQueryInterface
Retrieves a pointer to the requested interface.  
  
## Syntax  
  
```  
  
      virtual HRESULT ControlQueryInterface(  
   const IID& iid,  
   void** ppv   
);  
```  
  
#### Parameters  
 `iid`  
 [in] The GUID of the interface being requested.  
  
 `ppv`  
 [out] A pointer to the interface pointer identified by `iid`, or **NULL** if the interface is not found.  
  
## Remarks  
 Only handles interfaces in the COM map table.  
  
## Example  
 [!code[NVC_ATL_COM#15](../vs140/codesnippet/CPP/ccomcontrol--controlqueryinterface_1.cpp)]  
  
## Requirements  
 **Header:** atlctl.h  
  
## See Also  
 [CComControl Class](../vs140/ccomcontrol-class.md)   
 [CComObjectRootEx::InternalQueryInterface](../vs140/ccomobjectrootex--internalqueryinterface.md)