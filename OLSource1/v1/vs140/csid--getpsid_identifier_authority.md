---
title: "CSid::GetPSID_IDENTIFIER_AUTHORITY"
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
  - "CSid::GetPSID_IDENTIFIER_AUTHORITY"
  - "CSid.GetPSID_IDENTIFIER_AUTHORITY"
  - "ATL::CSid::GetPSID_IDENTIFIER_AUTHORITY"
  - "GetPSID_IDENTIFIER_AUTHORITY"
  - "ATL.CSid.GetPSID_IDENTIFIER_AUTHORITY"
  - "CSidGetPSID_IDENTIFIER_AUTHORITY"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "GetPSID_IDENTIFIER_AUTHORITY method"
ms.assetid: 3005a503-1afe-404d-abdb-d0ff5be9fc83
caps.latest.revision: 14
author: ""
ms.author: ""
manager: ""
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CSid::GetPSID_IDENTIFIER_AUTHORITY
Returns a pointer to the **SID_IDENTIFIER_AUTHORITY** structure.  
  
## Syntax  
  
```  
  
const SID_IDENTIFIER_AUTHORITY * GetPSID_IDENTIFIER_AUTHORITY( ) const throw();  
  
```  
  
## Return Value  
 If the method succeeds, it returns the address of the **SID_IDENTIFIER_AUTHORITY** structure. If it fails, the return value is undefined. Failure may occur if the `CSid` object is not valid, in which case the [CSid::IsValid](../vs140/csid--isvalid.md) method returns **false**. The function `GetLastError` can be called for extended error information.  
  
> [!NOTE]
>  Under debug builds the function will cause an ASSERT if the `CSid` object is not valid.  
  
## Requirements  
 **Header:** atlsecurity.h  
  
## See Also  
 [CSid Class](../vs140/csid-class.md)   
 [CSid::GetSubAuthority](../vs140/csid--getsubauthority.md)