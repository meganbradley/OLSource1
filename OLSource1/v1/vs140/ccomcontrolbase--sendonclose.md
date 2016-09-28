---
title: "CComControlBase::SendOnClose"
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
  - "CComControlBase.SendOnClose"
  - "SendOnClose"
  - "ATL.CComControlBase.SendOnClose"
  - "ATL::CComControlBase::SendOnClose"
  - "CComControlBase::SendOnClose"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "SendOnClose method"
ms.assetid: 5ed2fd7f-4051-47c0-8410-fc032f2c7a51
caps.latest.revision: 14
author: ""
ms.author: ""
manager: ""
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CComControlBase::SendOnClose
Notifies all advisory sinks registered with the advise holder that the control has been closed.  
  
## Syntax  
  
```  
  
HRESULT SendOnClose( );  
  
```  
  
## Return Value  
 Returns S_OK on success, or an error HRESULT on failure.  
  
## Remarks  
 Sends a notification that the control has closed its advisory sinks.  
  
## Requirements  
 **Header:** atlctl.h  
  
## See Also  
 [CComControlBase Class](../vs140/ccomcontrolbase-class.md)