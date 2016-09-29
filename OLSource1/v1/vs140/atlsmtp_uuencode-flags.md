---
title: "ATLSMTP_UUENCODE Flags"
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
  - "ATLSMTP_UUENCODE flags"
ms.assetid: ecb79b81-b764-4a48-a05c-a9dee6e7bbce
caps.latest.revision: 15
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# ATLSMTP_UUENCODE Flags
These flags describe how uuencoding is to be performed by [UUEncode](../vs140/uuencode.md).  
  
## Syntax  
  
```  
  
      #define ATLSMTP_UUENCODE_HEADER   
#define ATLSMTP_UUENCODE_END   
#define ATLSMTP_UUENCODE_DOT  
```  
  
## Remarks  
  
|Flag|Description|  
|----------|-----------------|  
|ATLSMTP_UUENCODE_HEADER|The header will be encoded.|  
|ATLSMTP_UUENCODE_END|The end will be encoded.|  
|ATLSMTP_UUENCODE_DOT|Data stuffing will be performed.|  
  
## Requirements  
 **Header:** atlenc.h  
  
## See Also  
 [ATL Concepts](../vs140/active-template-library--atl--concepts.md)   
 [ATL Reference](../vs140/atl-com-desktop-components.md)   
 [ATL Macros Alphabetical Reference](../vs140/atl-macros-alphabetical-reference.md)   
 [UUEncode](../vs140/uuencode.md)