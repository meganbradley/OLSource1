---
title: "Sharing Constants"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-cpp"
ms.tgt_pltfrm: na
ms.topic: "article"
f1_keywords: 
  - "_SH_DENYNO"
  - "_SH_DENYRD"
  - "_SH_DENYRW"
  - "_SH_DENYWR"
  - "_SH_COMPAT"
dev_langs: 
  - "C++"
  - "C"
helpviewer_keywords: 
  - "_SH_DENYRW constant"
  - "SH_DENYRD constant"
  - "_SH_COMPAT constant"
  - "_SH_DENYRD constant"
  - "SH_DENYRW constant"
  - "sharing constants"
  - "SH_DENYNO constant"
  - "_SH_DENYWR constant"
  - "SH_DENYWR constant"
  - "_SH_DENYNO constant"
  - "SH_COMPAT constant"
ms.assetid: 95fadc3a-55dc-473d-98b5-e8211900465d
caps.latest.revision: 12
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Sharing Constants
Constants for file-sharing modes.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Remarks  
 The *shflag* argument determines the sharing mode, which consists of one or more manifest constants. These can be combined with the *oflag* arguments (see [File Constants](../vs140/file-constants.md)).  
  
 The following table lists the constants and their meanings:  
  
|Constant|Meaning|  
|--------------|-------------|  
|<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>|Denies read and write access to file|  
|<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>|Denies write access to file|  
|<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>|Denies read access to file|  
|<CodeContentPlaceHolder>4\</CodeContentPlaceHolder>|Permits read and write access|  
|<CodeContentPlaceHolder>5\</CodeContentPlaceHolder>|Sets secure mode (shared read, exclusive write access).|  
  
## See Also  
 [_sopen, _wsopen](../vs140/_sopen--_wsopen.md)   
 [_fsopen, _wfsopen](../vs140/_fsopen--_wfsopen.md)   
 [Global Constants](../vs140/global-constants.md)