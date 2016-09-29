---
title: "CUrl::SetPortNumber"
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
  - "ATL.CUrl.SetPortNumber"
  - "CUrl::SetPortNumber"
  - "SetPortNumber"
  - "ATL::CUrl::SetPortNumber"
  - "CUrl.SetPortNumber"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "SetPortNumber method"
ms.assetid: 312b708c-687f-4525-bc31-40aaf827e64e
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CUrl::SetPortNumber
Call this method to set the port number.  
  
## Syntax  
  
```  
  
      inline BOOL SetPortNumber(  
   ATL_URL_PORT nPrt   
) throw( );  
```  
  
#### Parameters  
 *nPrt*  
 The port number.  
  
## Return Value  
 Returns TRUE on success, FALSE on failure.  
  
## Requirements  
 **Header:** atlutil.h  
  
## See Also  
 [CUrl Class](../vs140/curl-class.md)   
 [CUrl::GetPortNumber](../vs140/curl--getportnumber.md)   
 [ATL_URL_PORT](../vs140/atl_url_port.md)