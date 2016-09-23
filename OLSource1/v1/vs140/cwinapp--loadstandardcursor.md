---
title: "CWinApp::LoadStandardCursor"
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
  - CWinApp::LoadStandardCursor
  - LoadStandardCursor
  - CWinApp.LoadStandardCursor
dev_langs: 
  - C++
helpviewer_keywords: 
  - CWinApp class, operations
  - standard cursors, loading
  - LoadStandardCursor method
ms.assetid: ddcd46bb-459d-41b2-a080-b550de736299
caps.latest.revision: 15
robots: noindex,nofollow
translation.priority.ht: 
  - de-de
  - ja-jp
---
# CWinApp::LoadStandardCursor
Loads the Windows predefined cursor resource that `lpszCursorName` specifies.  
  
## Syntax  
  
```  
  
      HCURSOR LoadStandardCursor(  
   LPCTSTR lpszCursorName   
) const;  
```  
  
#### Parameters  
 `lpszCursorName`  
 An **IDC_** manifest constant identifier that specifies a predefined Windows cursor. These identifiers are defined in WINDOWS.H. The following list shows the possible predefined values and meanings for `lpszCursorName`:  
  
-   **IDC_ARROW** Standard arrow cursor  
  
-   **IDC_IBEAM** Standard text-insertion cursor  
  
-   **IDC_WAIT** Hourglass cursor used when Windows performs a time-consuming task  
  
-   **IDC_CROSS** Cross-hair cursor for selection  
  
-   **IDC_UPARROW** Arrow that points straight up  
  
-   **IDC_SIZE** Obsolete and unsupported; use **IDC_SIZEALL**  
  
-   **IDC_SIZEALL** A four-pointed arrow. The cursor to use to resize a window.  
  
-   **IDC_ICON** Obsolete and unsupported. Use **IDC_ARROW**.  
  
-   **IDC_SIZENWSE** Two-headed arrow with ends at upper left and lower right  
  
-   **IDC_SIZENESW** Two-headed arrow with ends at upper right and lower left  
  
-   **IDC_SIZEWE** Horizontal two-headed arrow  
  
-   **IDC_SIZENS** Vertical two-headed arrow  
  
## Return Value  
 A handle to a cursor if successful; otherwise **NULL**.  
  
## Remarks  
 Use the `LoadStandardCursor` or [LoadOEMCursor](../vs140/cwinapp--loadoemcursor.md) member function to access the predefined Windows cursors.  
  
## Example  
 [!code[NVC_MFCWindowing#47](../vs140/codesnippet/CPP/cwinapp--loadstandardcursor_1.cpp)]
  
  
## Requirements  
 **Header:** afxwin.h  
  
## See Also  
 [CWinApp Class](../vs140/cwinapp-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CWinApp::LoadOEMCursor](../vs140/cwinapp--loadoemcursor.md)   
 [CWinApp::LoadCursor](../vs140/cwinapp--loadcursor.md)   
 [LoadCursor](http://msdn.microsoft.com/library/windows/desktop/ms648391)