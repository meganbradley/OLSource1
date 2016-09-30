---
title: "CComControlBase::ControlQueryInterface"
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
  - "ControlQueryInterface"
  - "CComControlBase::ControlQueryInterface"
  - "CComControlBase.ControlQueryInterface"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "ControlQueryInterface method"
ms.assetid: ba37fcde-2c48-43f3-8cf1-89493db5af2b
caps.latest.revision: 15
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CComControlBase::ControlQueryInterface
Retrieves a pointer to the requested interface.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 The GUID of the interface being requested.  
  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 A pointer to the interface pointer identified by <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>, or **NULL** if the interface is not found.  
  
## Remarks  
 Only handles interfaces in the COM map table.  
  
## Example  
 [!code[NVC_ATL_COM#15](../vs140/codesnippet/CPP/ccomcontrolbase--controlqueryinterface_1.cpp)]  
  
## Requirements  
 **Header:** atlctl.h  
  
## See Also  
 [CComControlBase Class](../vs140/ccomcontrolbase-class.md)   
 [CComObjectRootEx::InternalQueryInterface](../vs140/ccomobjectrootex--internalqueryinterface.md)