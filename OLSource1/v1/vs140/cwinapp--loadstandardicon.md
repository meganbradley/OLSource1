---
title: "CWinApp::LoadStandardIcon"
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
  - "LoadStandardIcon"
  - "CWinApp::LoadStandardIcon"
  - "CWinApp.LoadStandardIcon"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "CWinApp class, operations"
  - "standard icons"
  - "LoadStandardIcon method"
  - "standard icons, loading"
ms.assetid: f9cc187f-5a50-482c-9e04-a4e61ae1cefb
caps.latest.revision: 15
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CWinApp::LoadStandardIcon
Loads the Windows predefined icon resource that `lpszIconName` specifies.  
  
## Syntax  
  
```  
  
      HICON LoadStandardIcon(  
   LPCTSTR lpszIconName   
) const;  
```  
  
#### Parameters  
 `lpszIconName`  
 A manifest constant identifier that specifies a predefined Windows icon. These identifiers are defined in WINDOWS.H. For a list of the possible predefined values and their descriptions, see the *lpIconName* parameter in [LoadIcon](http://msdn.microsoft.com/library/windows/desktop/ms648072) in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
## Return Value  
 A handle to an icon if successful; otherwise **NULL**.  
  
## Remarks  
 Use the `LoadStandardIcon` or [LoadOEMIcon](../vs140/cwinapp--loadoemicon.md) member function to access the predefined Windows icons.  
  
## Requirements  
 **Header:** afxwin.h  
  
## See Also  
 [CWinApp Class](../vs140/cwinapp-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CWinApp::LoadOEMIcon](../vs140/cwinapp--loadoemicon.md)   
 [CWinApp::LoadIcon](../vs140/cwinapp--loadicon.md)   
 [LoadIcon](http://msdn.microsoft.com/library/windows/desktop/ms648072)