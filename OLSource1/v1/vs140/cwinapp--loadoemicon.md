---
title: "CWinApp::LoadOEMIcon"
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
  - CWinApp.LoadOEMIcon
  - LoadOEMIcon
  - CWinApp::LoadOEMIcon
dev_langs: 
  - C++
helpviewer_keywords: 
  - CWinApp class, operations
  - OEM icons, loading
  - LoadOEMIcon method
  - OEM icons
ms.assetid: 194d7379-e000-40e2-bab0-e1b63881b1ef
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - de-de
  - ja-jp
---
# CWinApp::LoadOEMIcon
Loads the Windows predefined icon resource specified by `nIDIcon`.  
  
## Syntax  
  
```  
  
      HICON LoadOEMIcon(  
   UINT nIDIcon   
) const;  
```  
  
#### Parameters  
 `nIDIcon`  
 An **OIC_** manifest constant identifier that specifies a predefined Windows icon. You must have **#define OEMRESOURCE** before **#include <afxwin.h>** to access the **OIC_** constants in WINDOWS.H.  
  
## Return Value  
 A handle to an icon if successful; otherwise **NULL**.  
  
## Remarks  
 Use the `LoadOEMIcon` or [LoadStandardIcon](../vs140/cwinapp--loadstandardicon.md) member function to access the predefined Windows icons.  
  
## Requirements  
 **Header:** afxwin.h  
  
## See Also  
 [CWinApp Class](../vs140/cwinapp-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CWinApp::LoadStandardIcon](../vs140/cwinapp--loadstandardicon.md)   
 [CWinApp::LoadIcon](../vs140/cwinapp--loadicon.md)   
 [LoadIcon](http://msdn.microsoft.com/library/windows/desktop/ms648072)