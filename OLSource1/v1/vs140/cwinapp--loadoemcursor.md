---
title: "CWinApp::LoadOEMCursor"
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
  - "CWinApp.LoadOEMCursor"
  - "LoadOEMCursor"
  - "CWinApp::LoadOEMCursor"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "OEM cursors"
  - "CWinApp class, operations"
  - "OEM cursors, loading"
  - "LoadOEMCursor method"
ms.assetid: ea360729-97aa-456e-a4d1-92397a370952
caps.latest.revision: 15
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CWinApp::LoadOEMCursor
Loads the Windows predefined cursor resource specified by `nIDCursor`.  
  
## Syntax  
  
```  
  
      HCURSOR LoadOEMCursor(  
   UINT nIDCursor   
) const;  
```  
  
#### Parameters  
 `nIDCursor`  
 An **OCR_** manifest constant identifier that specifies a predefined Windows cursor. You must have **#define OEMRESOURCE** before **#include <afxwin.h>** to gain access to the **OCR_** constants in WINDOWS.H.  
  
## Return Value  
 A handle to a cursor if successful; otherwise **NULL**.  
  
## Remarks  
 Use the `LoadOEMCursor` or [LoadStandardCursor](../vs140/cwinapp--loadstandardcursor.md) member function to access the predefined Windows cursors.  
  
## Example  
 [!code[NVC_MFCWindowing#45](../vs140/codesnippet/CPP/cwinapp--loadoemcursor_1.h)]  
  
 [!code[NVC_MFCWindowing#46](../vs140/codesnippet/CPP/cwinapp--loadoemcursor_2.cpp)]  
  
## Requirements  
 **Header:** afxwin.h  
  
## See Also  
 [CWinApp Class](../vs140/cwinapp-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CWinApp::LoadCursor](../vs140/cwinapp--loadcursor.md)   
 [CWinApp::LoadStandardCursor](../vs140/cwinapp--loadstandardcursor.md)   
 [LoadCursor](http://msdn.microsoft.com/library/windows/desktop/ms648391)