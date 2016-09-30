---
title: "CUrl::CrackUrl"
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
  - "CrackUrl"
  - "CUrl.CrackUrl"
  - "ATL.CUrl.CrackUrl"
  - "ATL::CUrl::CrackUrl"
  - "CUrl::CrackUrl"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "CrackUrl method"
ms.assetid: b79997e9-22af-4571-86d5-f0c71f3bca2c
caps.latest.revision: 16
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CUrl::CrackUrl
Call this method to decode and parse the URL.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 The URL.  
  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 Specify ATL_URL_DECODE or ATL_URL_ESCAPE to convert all escape characters in <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> to their real values after parsing. (Before Visual C++ 2005, ATL_URL_DECODE converted all escape characters before parsing.)  
  
## Return Value  
 Returns TRUE on success, FALSE on failure.  
  
## Requirements  
 **Header:** atlutil.h  
  
## See Also  
 [CUrl Class](../vs140/curl-class.md)