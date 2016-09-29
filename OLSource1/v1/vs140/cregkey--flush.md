---
title: "CRegKey::Flush"
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
  - "CRegKey.Flush"
  - "CRegKey::Flush"
  - "ATL::CRegKey::Flush"
  - "ATL.CRegKey.Flush"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "Flush method"
ms.assetid: 493f8241-4c44-4993-b16a-cf00f079b3ca
caps.latest.revision: 16
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CRegKey::Flush
Call this method to write all of the attributes of the open registry key into the registry.  
  
## Syntax  
  
```  
  
LONG Flush( ) throw( );  
  
```  
  
## Return Value  
 If the method succeeds, the return value is ERROR_SUCCESS. If the method fails, the return value is a nonzero error code defined in WINERROR.H.  
  
## Remarks  
 For more information, see [RegEnumFlush](http://msdn.microsoft.com/library/windows/desktop/ms724867) in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
## Requirements  
 **Header:** atlbase.h  
  
## See Also  
 [CRegKey Class](../vs140/cregkey-class.md)