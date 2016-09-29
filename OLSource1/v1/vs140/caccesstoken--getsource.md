---
title: "CAccessToken::GetSource"
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
  - "CAccessToken::GetSource"
  - "CAccessToken.GetSource"
  - "ATL.CAccessToken.GetSource"
  - "ATL::CAccessToken::GetSource"
  - "GetSource"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "GetSource method"
ms.assetid: 85ff88bc-a253-4b8b-a6a6-55d8cbb4bd2d
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CAccessToken::GetSource
Call this method to get the source of the `CAccessToken` object.  
  
## Syntax  
  
```  
  
      bool GetSource(  
   TOKEN_SOURCE* pSource  
) const throw(...);  
```  
  
#### Parameters  
 *pSource*  
 Pointer to a [TOKEN_SOURCE](http://msdn.microsoft.com/library/windows/desktop/aa379631) structure.  
  
## Return Value  
 Returns true on success, false on failure.  
  
## Requirements  
 **Header:** atlsecurity.h  
  
## See Also  
 [CAccessToken Class](../vs140/caccesstoken-class.md)