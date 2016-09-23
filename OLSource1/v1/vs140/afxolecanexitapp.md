---
title: "AfxOleCanExitApp"
ms.custom: na
ms.date: 09/22/2016
ms.prod: visual-studio-dev14
ms.reviewer: na
ms.suite: na
ms.technology: 
  - devlang-cpp
ms.tgt_pltfrm: na
ms.topic: article
f1_keywords: 
  - AFXWIN/AfxOleCanExitApp
  - AfxOleCanExitApp
dev_langs: 
  - C++
helpviewer_keywords: 
  - AfxOleCanExitApp function
  - application control
ms.assetid: 07dcda32-5444-432f-97f2-e54024425063
caps.latest.revision: 13
translation.priority.ht: 
  - de-de
  - ja-jp
---
# AfxOleCanExitApp
Indicates whether the application can terminate.  
  
## Syntax  
  
```  
  
BOOL AFXAPI AfxOleCanExitApp( );  
```  
  
## Return Value  
 Nonzero if the application can exit; otherwise 0.  
  
## Remarks  
 An application should not terminate if there are outstanding references to its objects. The global functions `AfxOleLockApp` and `AfxOleUnlockApp` increment and decrement, respectively, a counter of references to the application's objects. The application should not terminate when this counter is nonzero. If the counter is nonzero, the application's main window is hidden (not destroyed) when the user chooses Close from the system menu or Exit from the File menu. The framework calls this function in **CFrameWnd::OnClose**.  
  
## Example  
 [!code[NVC_MFCAutomation#2](../vs140/codesnippet/CPP/afxolecanexitapp_1.cpp)]
  
  
## Requirements  
 **Header:** <afxdisp.h>  
  
## See Also  
 [Macros and Globals](../vs140/mfc-macros-and-globals.md)   
 [AfxOleLockApp](../vs140/afxolelockapp.md)   
 [AfxOleUnlockApp](../vs140/afxoleunlockapp.md)