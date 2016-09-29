---
title: "CComControlBase::SendOnDataChange"
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
  - "SendOnDataChange"
  - "ATL::CComControlBase::SendOnDataChange"
  - "ATL.CComControlBase.SendOnDataChange"
  - "CComControlBase.SendOnDataChange"
  - "CComControlBase::SendOnDataChange"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "SendOnDataChange method"
ms.assetid: c9196eec-632f-49ef-9fc6-a7202a57387f
caps.latest.revision: 14
author: ""
ms.author: ""
manager: ""
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CComControlBase::SendOnDataChange
Notifies all advisory sinks registered with the advise holder that the control data has changed.  
  
## Syntax  
  
```  
  
      HRESULT SendOnDataChange(  
   DWORD advf = 0  
);  
```  
  
#### Parameters  
 *advf*  
 Advise flags that specify how the call to [IAdviseSink::OnDataChange](http://msdn.microsoft.com/library/windows/desktop/ms687283) is made. Values are from the [ADVF](http://msdn.microsoft.com/library/windows/desktop/ms693742) enumeration.  
  
## Return Value  
 Returns S_OK on success, or an error HRESULT on failure.  
  
## Requirements  
 **Header:** atlctl.h  
  
## See Also  
 [CComControlBase Class](../vs140/ccomcontrolbase-class.md)   
 [CComControlBase::m_spDataAdviseHolder](../vs140/ccomcontrolbase--m_spdataadviseholder.md)