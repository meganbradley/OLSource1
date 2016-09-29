---
title: "CComControlBase::m_spDataAdviseHolder"
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
  - "CComControlBase::m_spDataAdviseHolder"
  - "CComControlBase.m_spDataAdviseHolder"
  - "ATL.CComControlBase.m_spDataAdviseHolder"
  - "ATL::CComControlBase::m_spDataAdviseHolder"
  - "m_spDataAdviseHolder"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "m_spDataAdviseHolder"
ms.assetid: 2b549ee0-f12c-4c0e-999c-fba96b200b5b
caps.latest.revision: 14
author: ""
ms.author: ""
manager: ""
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CComControlBase::m_spDataAdviseHolder
Provides a standard means to hold advisory connections between data objects and advise sinks.  
  
## Syntax  
  
```  
  
CComPtr<IDataAdviseHolder> m_spDataAdviseHolder;  
```  
  
## Remarks  
  
> [!NOTE]
>  To use this data member within your control class, you must declare it as a data member in your control class. Your control class will not inherit this data member from the base class because it is declared within a union in the base class.  
  
 A data object is a control that can transfer data and that implements [IDataObject](http://msdn.microsoft.com/library/windows/desktop/ms688421), whose methods specify the format and transfer medium of the data.  
  
 The interface `m_spDataAdviseHolder` implements the [IDataObject::DAdvise](http://msdn.microsoft.com/library/windows/desktop/ms692579) and [IDataObject::DUnadvise](http://msdn.microsoft.com/library/windows/desktop/ms692448) methods to establish and delete advisory connections to the container. The control's container must implement an advise sink by supporting the [IAdviseSink](http://msdn.microsoft.com/library/windows/desktop/ms692513) interface.  
  
## Requirements  
 **Header:** atlctl.h  
  
## See Also  
 [CComControlBase Class](../vs140/ccomcontrolbase-class.md)   
 [CComPtr Class](../vs140/ccomptr-class.md)