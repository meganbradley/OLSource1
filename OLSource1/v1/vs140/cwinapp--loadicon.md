---
title: "CWinApp::LoadIcon"
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
  - LoadIcon
  - CWinApp::LoadIcon
  - CWinApp.LoadIcon
dev_langs: 
  - C++
helpviewer_keywords: 
  - LoadIcon method
  - CWinApp class, operations
  - icons, loading
ms.assetid: 83b01cc2-8ea0-4d65-8095-a6f7fe0bf812
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - de-de
  - ja-jp
---
# CWinApp::LoadIcon
Loads the icon resource named by `lpszResourceName` or specified by `nIDResource` from the executable file.  
  
## Syntax  
  
```  
  
      HICON LoadIcon(  
   LPCTSTR lpszResourceName   
) const;  
HICON LoadIcon(  
   UINT nIDResource   
) const;  
```  
  
#### Parameters  
 `lpszResourceName`  
 Points to a null-terminated string that contains the name of the icon resource. You can also use a `CString` for this argument.  
  
 `nIDResource`  
 ID number of the icon resource.  
  
## Return Value  
 A handle to an icon if successful; otherwise **NULL**.  
  
## Remarks  
 `LoadIcon` loads the icon only if it has not been previously loaded; otherwise, it retrieves a handle of the existing resource.  
  
 You can use the [LoadStandardIcon](../vs140/cwinapp--loadstandardicon.md) or [LoadOEMIcon](../vs140/cwinapp--loadoemicon.md) member function to access the predefined Windows icons.  
  
> [!NOTE]
>  This member function calls the Win32 API function [LoadIcon](http://msdn.microsoft.com/library/windows/desktop/ms648072), which can only load an icon whose size conforms to the **SM_CXICON** and **SM_CYICON** system metric values.  
  
## Requirements  
 **Header:** afxwin.h  
  
## See Also  
 [CWinApp Class](../vs140/cwinapp-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CWinApp::LoadStandardIcon](../vs140/cwinapp--loadstandardicon.md)   
 [CWinApp::LoadOEMIcon](../vs140/cwinapp--loadoemicon.md)   
 [LoadIcon](http://msdn.microsoft.com/library/windows/desktop/ms648072)