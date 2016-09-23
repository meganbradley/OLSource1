---
title: "AtlAxWinTerm"
ms.custom: na
ms.date: 09/22/2016
ms.prod: visual-studio-dev14
ms.reviewer: na
ms.suite: na
ms.technology: 
  - devlang-cpp
ms.tgt_pltfrm: na
ms.topic: reference
f1_keywords: 
  - atlaxwinterm
  - ATL::AtlAxWinTerm
  - ATL.AtlAxWinTerm
dev_langs: 
  - C++
helpviewer_keywords: 
  - AtlAxWinTerm function
ms.assetid: 3aba9ffb-4f66-43b0-85eb-db219a8d4bd7
caps.latest.revision: 18
translation.priority.ht: 
  - de-de
  - ja-jp
---
# AtlAxWinTerm
This function uninitializes ATL's control hosting code by unregistering the **"AtlAxWin80"** and **"AtlAxWinLic80"** window classes.  
  
> [!IMPORTANT]
>  This function cannot be used in applications that execute in the [!INCLUDE[wrt](../vs140/includes/wrt_md.md)].  
  
## Syntax  
  
```  
  
inline BOOL AtlAxWinTerm( );  
  
```  
  
## Return Value  
 Always returns **TRUE**.  
  
## Remarks  
 This function simply calls [UnregisterClass](http://msdn.microsoft.com/library/windows/desktop/ms644899) as described in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
 Call this function to clean up after all existing host windows have been destroyed if you called [AtlAxWinInit](../vs140/atlaxwininit.md) and you no longer need to create host windows. If you don't call this function, the window class will be unregistered automatically when the process terminates.  
  
## Requirements  
 **Header:** atlhost.h  
  
## See Also  
 [Composite Control Global Functions](../vs140/composite-control-global-functions.md)   
 [Composite Control Fundamentals](../vs140/atl-composite-control-fundamentals.md)   
 [AtlAxWinInit](../vs140/atlaxwininit.md)