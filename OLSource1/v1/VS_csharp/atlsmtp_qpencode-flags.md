---
title: "ATLSMTP_QPENCODE Flags"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-cpp"
ms.tgt_pltfrm: na
ms.topic: "reference"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "ATLSMTP_QPENCODE flags"
ms.assetid: 6b15a3ab-8e57-49e4-8104-09b26ebb96c4
caps.latest.revision: 18
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# ATLSMTP_QPENCODE Flags
These flags describe how quoted-printable encoding is to be performed by [QPEncode](../VS_csharp/qpencode.md).  
  
## Syntax  
  
```  
  
      #define ATLSMTP_QPENCODE_DOT   
#define ATLSMTP_QPENCODE_TRAILING_SOFT  
```  
  
## Remarks  
  
|Flag|Description|  
|----------|-----------------|  
|ATLSMTP_QPENCODE_DOT|If a period appears at the start of a line, it is added to the output as well as encoded.|  
|ATLSMTP_QPENCODE_TRAILING_SOFT|Appends =\r\n to the encoded string.|  
  
 The quoted-printable encoding scheme is described in RFC 2045 ([http://www.ietf.org/rfc/rfc2045.txt](http://www.ietf.org/rfc/rfc2045.txt)).  
  
## Requirements  
 **Header:** atlenc.h  
  
## See Also  
 [ATL Concepts](../VS_csharp/active-template-library--atl--concepts.md)   
 [ATL Reference](../VS_csharp/atl-com-desktop-components.md)   
 [ATL Macros Alphabetical Reference](../VS_csharp/atl-macros-alphabetical-reference.md)   
 [QPEncode](../VS_csharp/qpencode.md)