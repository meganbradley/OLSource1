---
title: "SystemTimeToHttpDate"
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
  - "ATL.SystemTimeToHttpDate"
  - "ATL::SystemTimeToHttpDate"
  - "SystemTimeToHttpDate"
  - "ATL.SystemTimeToHttpDate<>"
  - "ATL::SystemTimeToHttpDate<>"
  - "ATLUTIL/SystemTimeToHttpDate"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "SystemTimeToHttpDate function"
ms.assetid: 3e240f32-1d64-422d-a281-31b2d1273962
caps.latest.revision: 16
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# SystemTimeToHttpDate
Call this function to convert a system time to a string in a format suitable for using in HTTP headers.  
  
## Syntax  
  
```  
  
      inline void SystemTimeToHttpDate(  
   const SYSTEMTIME& st,  
   CStringA & strTime   
);  
```  
  
#### Parameters  
 `st`  
 The system time to be obtained as an HTTP format string.  
  
 *strTime*  
 A reference to a string variable to receive the HTTP date time as defined in RFC 2616 ([http://www.ietf.org/rfc/rfc2616.txt](http://www.ietf.org/rfc/rfc2616.txt)) and RFC 1123 ([http://www.ietf.org/rfc/rfc1123.txt](http://www.ietf.org/rfc/rfc1123.txt)).  
  
## Requirements  
 **Header:** atlutil.h  
  
## See Also  
 [ATL Concepts](../vs140/active-template-library--atl--concepts.md)   
 [ATL Reference](../vs140/atl-com-desktop-components.md)   
 [ATL Functions Alphabetical Reference](../vs140/atl-functions-alphabetical-reference.md)