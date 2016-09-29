---
title: "AtlGetDefaultUrlPort"
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
  - "ATL::AtlGetDefaultUrlPort"
  - "ATLUTIL/AtlGetDefaultUrlPort"
  - "AtlGetDefaultUrlPort"
  - "ATL.AtlGetDefaultUrlPort"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "AtlGetDefaultUrlPort function"
ms.assetid: d894e370-0236-4f19-b4a1-eba50c07550b
caps.latest.revision: 15
author: ""
ms.author: ""
manager: ""
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# AtlGetDefaultUrlPort
Call this function to get the default port number associated with a particular Internet protocol or scheme.  
  
## Syntax  
  
```  
  
      inline ATL_URL_PORT AtlGetDefaultUrlPort(  
   ATL_URL_SCHEME m_nScheme   
) throw( );  
```  
  
#### Parameters  
 *m_nScheme*  
 The [ATL_URL_SCHEME](../vs140/atl_url_scheme.md) value identifying the scheme for which you want to obtain the port number.  
  
## Return Value  
 The [ATL_URL_PORT](../vs140/atl_url_port.md) associated with the specified scheme or ATL_URL_INVALID_PORT_NUMBER if the scheme is not recognized.  
  
## Requirements  
 **Header:** atlutil.h  
  
## See Also  
 [ATL Concepts](../vs140/active-template-library--atl--concepts.md)   
 [ATL Reference](../vs140/atl-com-desktop-components.md)   
 [ATL Functions Alphabetical Reference](../vs140/atl-functions-alphabetical-reference.md)