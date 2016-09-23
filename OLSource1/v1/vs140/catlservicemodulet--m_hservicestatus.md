---
title: "CAtlServiceModuleT::m_hServiceStatus"
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
  - CAtlServiceModuleT.m_hServiceStatus
  - CAtlServiceModuleT::m_hServiceStatus
  - ATL::CAtlServiceModuleT::m_hServiceStatus
  - ATL.CAtlServiceModuleT.m_hServiceStatus
  - m_hServiceStatus
dev_langs: 
  - C++
helpviewer_keywords: 
  - m_hServiceStatus
ms.assetid: bd28c4d4-4051-489a-a61b-601671d8f559
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - de-de
  - ja-jp
---
# CAtlServiceModuleT::m_hServiceStatus
Member variable storing a handle to the status information structure for the current service.  
  
## Syntax  
  
```  
  
SERVICE_STATUS_HANDLE m_hServiceStatus;  
  
```  
  
## Remarks  
 The [SERVICE_STATUS](http://msdn.microsoft.com/library/windows/desktop/ms685996) structure contains information about a service.  
  
## Requirements  
 **Header:** atlbase.h  
  
## See Also  
 [CAtlServiceModuleT Class](../vs140/catlservicemodulet-class.md)