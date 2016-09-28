---
title: "CComControlBase::FireViewChange"
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
  - "FireViewChange"
  - "ATL.CComControlBase.FireViewChange"
  - "CComControlBase.FireViewChange"
  - "CComControlBase::FireViewChange"
  - "ATL::CComControlBase::FireViewChange"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "FireViewChange method"
ms.assetid: a384d6b0-4df2-4766-9950-c8e13e33446b
caps.latest.revision: 15
author: ""
ms.author: ""
manager: ""
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CComControlBase::FireViewChange
Call this method to tell the container to redraw the control, or notify the registered advise sinks that the control's view has changed.  
  
## Syntax  
  
```  
  
HRESULT FireViewChange( );  
  
```  
  
## Return Value  
 One of the standard HRESULT values.  
  
## Remarks  
 If the control is active (the control class data member [CComControlBase::m_bInPlaceActive](../vs140/ccomcontrolbase--m_binplaceactive.md) is **TRUE**), notifies the container that you want to redraw the entire control. If the control is inactive, notifies the control's registered advise sinks (through the control class data member [CComControlBase::m_spAdviseSink](../vs140/ccomcontrolbase--m_spadvisesink.md)) that the control's view has changed.  
  
## Example  
 [!code[NVC_ATL_COM#21](../vs140/codesnippet/CPP/ccomcontrolbase--fireviewchange_1.cpp)]  
  
## Requirements  
 **Header:** atlctl.h  
  
## See Also  
 [CComControlBase Class](../vs140/ccomcontrolbase-class.md)