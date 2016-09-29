---
title: "CComControlBase::m_rcPos"
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
  - "CComControlBase.m_rcPos"
  - "m_rcPos"
  - "ATL::CComControlBase::m_rcPos"
  - "ATL.CComControlBase.m_rcPos"
  - "CComControlBase::m_rcPos"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "m_rcPos"
ms.assetid: 4d536492-f486-491c-8de0-3374f4ecd948
caps.latest.revision: 14
author: ""
ms.author: ""
manager: ""
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CComControlBase::m_rcPos
The position in pixels of the control, expressed in the coordinates of the container.  
  
## Syntax  
  
```  
  
RECT m_rcPos;  
```  
  
## Remarks  
  
> [!NOTE]
>  To use this data member within your control class, you must declare it as a data member in your control class. Your control class will not inherit this data member from the base class because it is declared within a union in the base class.  
  
## Requirements  
 **Header:** atlctl.h  
  
## See Also  
 [CComControlBase Class](../vs140/ccomcontrolbase-class.md)   
 [CComControlBase::m_sizeExtent](../vs140/ccomcontrolbase--m_sizeextent.md)   
 [CComControlBase::m_sizeNatural](../vs140/ccomcontrolbase--m_sizenatural.md)   
 [RECT](http://msdn.microsoft.com/library/windows/desktop/dd162897)