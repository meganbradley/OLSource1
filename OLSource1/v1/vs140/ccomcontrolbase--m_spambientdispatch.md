---
title: "CComControlBase::m_spAmbientDispatch"
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
  - "CComControlBase::m_spAmbientDispatch"
  - "m_spAmbientDispatch"
  - "CComControlBase.m_spAmbientDispatch"
  - "ATL::CComControlBase::m_spAmbientDispatch"
  - "ATL.CComControlBase.m_spAmbientDispatch"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "m_spAmbientDispatch"
ms.assetid: 848d8288-6eb0-4f93-b825-fcb9609596ee
caps.latest.revision: 18
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CComControlBase::m_spAmbientDispatch
A `CComDispatchDriver` object that lets you retrieve and set an object's properties through an `IDispatch` pointer.  
  
## Syntax  
  
```  
  
CComDispatchDriver m_spAmbientDispatch;  
```  
  
## Remarks  
  
> [!NOTE]
>  To use this data member within your control class, you must declare it as a data member in your control class. Your control class will not inherit this data member from the base class because it is declared within a union in the base class.  
  
## Requirements  
 **Header:** atlctl.h  
  
## See Also  
 [CComControlBase Class](../vs140/ccomcontrolbase-class.md)   
 [CComDispatchDriver](../vs140/ccomdispatchdriver.md)