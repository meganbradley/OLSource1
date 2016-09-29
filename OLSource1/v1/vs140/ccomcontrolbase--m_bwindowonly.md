---
title: "CComControlBase::m_bWindowOnly"
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
  - "ATL::CComControlBase::m_bWindowOnly"
  - "CComControlBase.m_bWindowOnly"
  - "CComControlBase::m_bWindowOnly"
  - "m_bWindowOnly"
  - "ATL.CComControlBase.m_bWindowOnly"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "m_bWindowOnly"
ms.assetid: 2c578e39-b36b-49b7-9269-fc81ab131b08
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CComControlBase::m_bWindowOnly
Flag indicating the control should be windowed, even if the container supports windowless controls.  
  
## Syntax  
  
```  
  
unsigned m_bWindowOnly:1;  
```  
  
## Remarks  
  
> [!NOTE]
>  To use this data member within your control class, you must declare it as a data member in your control class. Your control class will not inherit this data member from the base class because it is declared within a union in the base class.  
  
## Requirements  
 **Header:** atlctl.h  
  
## See Also  
 [CComControlBase Class](../vs140/ccomcontrolbase-class.md)   
 [CComControlBase::m_bWndLess](../vs140/ccomcontrolbase--m_bwndless.md)