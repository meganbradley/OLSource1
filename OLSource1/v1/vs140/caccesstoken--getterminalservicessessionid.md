---
title: "CAccessToken::GetTerminalServicesSessionId"
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
  - "CAccessToken::GetTerminalServicesSessionId"
  - "ATL::CAccessToken::GetTerminalServicesSessionId"
  - "CAccessToken.GetTerminalServicesSessionId"
  - "ATL.CAccessToken.GetTerminalServicesSessionId"
  - "GetTerminalServicesSessionId"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "GetTerminalServicesSessionId method"
ms.assetid: 90a5833c-e9f9-4691-9c41-dc322e63ffb3
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CAccessToken::GetTerminalServicesSessionId
Call this method to get the Terminal Services Session ID associated with the `CAccessToken` object.  
  
## Syntax  
  
```  
  
      bool GetTerminalServicesSessionId(  
   DWORD* pdwSessionId  
) const throw(...);  
```  
  
#### Parameters  
 *pdwSessionId*  
 The Terminal Services Session ID.  
  
## Return Value  
 Returns true on success, false on failure.  
  
## Requirements  
 **Header:** atlsecurity.h  
  
## See Also  
 [CAccessToken Class](../vs140/caccesstoken-class.md)