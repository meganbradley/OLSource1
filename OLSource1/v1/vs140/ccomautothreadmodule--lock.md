---
title: "CComAutoThreadModule::Lock"
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
  - "CComAutoThreadModule::Lock"
  - "CComAutoThreadModule.Lock"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "Lock method"
ms.assetid: 7dd467c6-314f-43de-95f4-f2f99aeea4bf
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CComAutoThreadModule::Lock
As of ATL 7.0, <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> is obsolete: see [ATL Module Classes](../vs140/atl-module-classes.md) for more details.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Return Value  
 A value that may be useful for diagnostics or testing.  
  
## Remarks  
 Performs an atomic increment on the lock count for the module and for the current thread. <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> uses the module lock count to determine whether any clients are accessing the module. The lock count on the current thread is used for statistical purposes.  
  
## Requirements  
 **Header:** atlbase.h  
  
## See Also  
 [CComAutoThreadModule Class](../vs140/ccomautothreadmodule-class.md)   
 [CComAutoThreadModule::Unlock](../vs140/ccomautothreadmodule--unlock.md)