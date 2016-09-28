---
title: "CComControlBase::m_bRecomposeOnResize"
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
  - "m_bRecomposeOnResize"
  - "ATL.CComControlBase.m_bRecomposeOnResize"
  - "CComControlBase::m_bRecomposeOnResize"
  - "CComControlBase.m_bRecomposeOnResize"
  - "ATL::CComControlBase::m_bRecomposeOnResize"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "m_bRecomposeOnResize"
ms.assetid: 63f309ff-95d6-4255-8d40-914cae6495a4
caps.latest.revision: 14
author: ""
ms.author: ""
manager: ""
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CComControlBase::m_bRecomposeOnResize
Flag indicating the control wants to recompose its presentation when the container changes the control's display size.  
  
## Syntax  
  
```  
  
unsigned m_bRecomposeOnResize:1;  
```  
  
## Remarks  
  
> [!NOTE]
>  To use this data member within your control class, you must declare it as a data member in your control class. Your control class will not inherit this data member from the base class because it is declared within a union in the base class.  
  
 This flag is checked by [IOleObjectImpl::SetExtent](../vs140/ioleobjectimpl--setextent.md) and, if **TRUE**, `SetExtent` notifies the container of view changes. if this flag is set, the **OLEMISC_RECOMPOSEONRESIZE** bit in the [OLEMISC](http://msdn.microsoft.com/library/windows/desktop/ms678497) enumeration should also be set.  
  
## Requirements  
 **Header:** atlctl.h  
  
## See Also  
 [CComControlBase Class](../vs140/ccomcontrolbase-class.md)