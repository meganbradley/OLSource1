---
title: "CComControlBase::m_bUsingWindowRgn"
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
  - "CComControlBase::m_bUsingWindowRgn"
  - "CComControlBase.m_bUsingWindowRgn"
  - "m_bUsingWindowRgn"
  - "ATL.CComControlBase.m_bUsingWindowRgn"
  - "ATL::CComControlBase::m_bUsingWindowRgn"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "m_bUsingWindowRgn"
ms.assetid: 6151ef56-917b-4afc-911a-a73c3b2bf806
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CComControlBase::m_bUsingWindowRgn
Flag indicating the control is using the container-supplied window region.  
  
## Syntax  
  
```  
  
unsigned m_bUsingWindowRgn:1;  
```  
  
## Remarks  
  
> [!NOTE]
>  To use this data member within your control class, you must declare it as a data member in your control class. Your control class will not inherit this data member from the base class because it is declared within a union in the base class.  
  
## Requirements  
 **Header:** atlctl.h  
  
## See Also  
 [CComControlBase Class](../vs140/ccomcontrolbase-class.md)