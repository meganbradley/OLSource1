---
title: "CWinApp::LoadCursor"
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
  - "CWinApp::LoadCursor"
  - "CWinApp.LoadCursor"
  - "LoadCursor"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "CWinApp class, operations"
  - "LoadCursor method"
  - "cursors, loading"
ms.assetid: d4131bba-5703-4bcc-8d11-a45a458efbd4
caps.latest.revision: 16
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CWinApp::LoadCursor
Loads the cursor resource named by `lpszResourceName` or specified by `nIDResource` from the current executable file.  
  
## Syntax  
  
```  
  
      HCURSOR LoadCursor(  
   LPCTSTR lpszResourceName   
) const;  
HCURSOR LoadCursor(  
   UINT nIDResource   
) const;  
```  
  
#### Parameters  
 `lpszResourceName`  
 Points to a null-terminated string that contains the name of the cursor resource. You can use a `CString` for this argument.  
  
 `nIDResource`  
 ID of the cursor resource. For a list of resources, see [LoadCursor](http://msdn.microsoft.com/library/windows/desktop/ms648391) in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
## Return Value  
 A handle to a cursor if successful; otherwise **NULL**.  
  
## Remarks  
 `LoadCursor` loads the cursor into memory only if it has not been previously loaded; otherwise, it retrieves a handle of the existing resource.  
  
 Use the [LoadStandardCursor](../vs140/cwinapp--loadstandardcursor.md) or [LoadOEMCursor](../vs140/cwinapp--loadoemcursor.md) member function to access the predefined Windows cursors.  
  
## Example  
 [!code[NVC_MFCWindowing#44](../vs140/codesnippet/CPP/cwinapp--loadcursor_1.cpp)]  
  
## Requirements  
 **Header:** afxwin.h  
  
## See Also  
 [CWinApp Class](../vs140/cwinapp-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CWinApp::LoadStandardCursor](../vs140/cwinapp--loadstandardcursor.md)   
 [CWinApp::LoadOEMCursor](../vs140/cwinapp--loadoemcursor.md)   
 [LoadCursor](http://msdn.microsoft.com/library/windows/desktop/ms648391)