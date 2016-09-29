---
title: "CSid::GetPSID"
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
  - "CSid.GetPSID"
  - "CSid::GetPSID"
  - "ATL.CSid.GetPSID"
  - "ATL::CSid::GetPSID"
  - "GetPSID"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "GetPSID method"
ms.assetid: 6be64cb0-96c0-4172-a434-585a577262f9
caps.latest.revision: 14
author: ""
ms.author: ""
manager: ""
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CSid::GetPSID
Returns a pointer to a `SID` (security identifier) structure.  
  
## Syntax  
  
```  
  
const SID * GetPSID( ) const throw(...);  
  
```  
  
## Return Value  
 Returns the address of the `CSid` object's underlying `SID` structure.  
  
## Requirements  
 **Header:** atlsecurity.h  
  
## See Also  
 [CSid Class](../vs140/csid-class.md)   
 [CSid::GetPSID_IDENTIFIER_AUTHORITY](../vs140/csid--getpsid_identifier_authority.md)