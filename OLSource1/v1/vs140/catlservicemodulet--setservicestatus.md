---
title: "CAtlServiceModuleT::SetServiceStatus"
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
  - "SetServiceStatus"
  - "CAtlServiceModuleT.SetServiceStatus"
  - "ATL.CAtlServiceModuleT.SetServiceStatus"
  - "CAtlServiceModuleT::SetServiceStatus"
  - "ATL::CAtlServiceModuleT::SetServiceStatus"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "SetServiceStatus method"
ms.assetid: e6e24da7-7044-4622-8336-9070712ef8ba
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CAtlServiceModuleT::SetServiceStatus
This method updates the service status.  
  
## Syntax  
  
```  
  
      void SetServiceStatus(  
   DWORD dwState   
) throw( );  
```  
  
#### Parameters  
 `dwState`  
 The new status. See [SetServiceStatus](http://msdn.microsoft.com/library/windows/desktop/ms686241) for possible values.  
  
## Remarks  
 Updates the Service Control Manager's status information for the service. It is called by [CAtlServiceModuleT::Run](../vs140/catlservicemodulet--run.md), [CAtlServiceModuleT::ServiceMain](../vs140/catlservicemodulet--servicemain.md) and other handler methods. The status is also stored in the member variable [CAtlServiceModuleT::m_status](../vs140/catlservicemodulet--m_status.md).  
  
## Requirements  
 **Header:** atlbase.h  
  
## See Also  
 [CAtlServiceModuleT Class](../vs140/catlservicemodulet-class.md)