---
title: "CComControlBase::m_bDrawFromNatural"
ms.custom: na
ms.date: 09/22/2016
ms.prod: visual-studio-dev14
ms.reviewer: na
ms.suite: na
ms.technology: 
  - devlang-cpp
ms.tgt_pltfrm: na
ms.topic: reference
f1_keywords: 
  - ATL.CComControlBase.m_bDrawFromNatural
  - CComControlBase::m_bDrawFromNatural
  - ATL::CComControlBase::m_bDrawFromNatural
  - CComControlBase.m_bDrawFromNatural
  - m_bDrawFromNatural
dev_langs: 
  - C++
helpviewer_keywords: 
  - m_bDrawFromNatural
ms.assetid: 82af4d97-e139-421e-9859-d914cb1e80d9
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - de-de
  - ja-jp
---
# CComControlBase::m_bDrawFromNatural
Flag indicating that `IDataObjectImpl::GetData` and `CComControlBase::GetZoomInfo` should set the control size from `m_sizeNatural` rather than from `m_sizeExtent`.  
  
## Syntax  
  
```  
  
unsigned m_bDrawFromNatural:1;  
```  
  
## Remarks  
  
> [!NOTE]
>  To use this data member within your control class, you must declare it as a data member in your control class. Your control class will not inherit this data member from the base class because it is declared within a union in the base class.  
  
## Requirements  
 **Header:** atlctl.h  
  
## See Also  
 [CComControlBase Class](../vs140/ccomcontrolbase-class.md)   
 [IDataObjectImpl::GetData](../vs140/idataobjectimpl--getdata.md)   
 [CComControlBase::m_sizeNatural](../vs140/ccomcontrolbase--m_sizenatural.md)   
 [CComControlBase::m_sizeExtent](../vs140/ccomcontrolbase--m_sizeextent.md)