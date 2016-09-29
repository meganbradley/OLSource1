---
title: "CComControlBase::m_bDrawGetDataInHimetric"
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
  - "CComControlBase::m_bDrawGetDataInHimetric"
  - "m_bDrawGetDataInHimetric"
  - "ATL::CComControlBase::m_bDrawGetDataInHimetric"
  - "CComControlBase.m_bDrawGetDataInHimetric"
  - "ATL.CComControlBase.m_bDrawGetDataInHimetric"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "m_bDrawGetDataInHimetric"
ms.assetid: d4c94d3d-92ab-49bc-8adc-eab89f300fa7
caps.latest.revision: 14
author: ""
ms.author: ""
manager: ""
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CComControlBase::m_bDrawGetDataInHimetric
Flag indicating that `IDataObjectImpl::GetData` should use HIMETRIC units and not pixels when drawing.  
  
## Syntax  
  
```  
  
unsigned m_bDrawGetDataInHimetric:1;  
```  
  
## Remarks  
 Each logical HIMETRIC unit is 0.01 millimeter.  
  
> [!NOTE]
>  To use this data member within your control class, you must declare it as a data member in your control class. Your control class will not inherit this data member from the base class because it is declared within a union in the base class.  
  
## Requirements  
 **Header:** atlctl.h  
  
## See Also  
 [CComControlBase Class](../vs140/ccomcontrolbase-class.md)   
 [IDataObjectImpl::GetData](../vs140/idataobjectimpl--getdata.md)