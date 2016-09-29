---
title: "CComControlBase::m_spAdviseSink"
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
  - "CComControlBase.m_spAdviseSink"
  - "ATL::CComControlBase::m_spAdviseSink"
  - "m_spAdviseSink"
  - "ATL.CComControlBase.m_spAdviseSink"
  - "CComControlBase::m_spAdviseSink"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "m_spAdviseSink"
ms.assetid: 9b685414-7827-4650-a883-1701a89ef63a
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CComControlBase::m_spAdviseSink
A direct pointer to the advisory connection on the container (the container's [IAdviseSink](http://msdn.microsoft.com/library/windows/desktop/ms692513)).  
  
## Syntax  
  
```  
  
CComPtr<IAdviseSink> m_spAdviseSink;  
```  
  
## Remarks  
  
> [!NOTE]
>  To use this data member within your control class, you must declare it as a data member in your control class. Your control class will not inherit this data member from the base class because it is declared within a union in the base class.  
  
## Requirements  
 **Header:** atlctl.h  
  
## See Also  
 [CComControlBase Class](../vs140/ccomcontrolbase-class.md)