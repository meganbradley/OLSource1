---
title: "CMDIChildWndEx::UnregisterTaskbarTab"
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
  - "UnregisterTaskbarTab"
  - "afxmdichildwndex/CMDIChildWndEx::UnregisterTaskbarTab"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "UnregisterTaskbarTab"
ms.assetid: 2803f657-abb9-4adb-80bc-474455eb8003
caps.latest.revision: 13
author: ""
ms.author: ""
manager: ""
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CMDIChildWndEx::UnregisterTaskbarTab
Removes the MDI child from Windows 7 taskbar tabs.  
  
## Syntax  
  
```  
void UnregisterTaskbarTab(  
   BOOL bCheckRegisteredMDIChildCount = TRUE  
);  
```  
  
#### Parameters  
 `bCheckRegisteredMDIChildCount`  
 Specifies whether this function needs to check the number of MDI children registered with MDI tabs. If this number is 0, then this function removes the clipping rectangle from the application's taskbar thumbnail.  
  
## Remarks  
  
## Requirements  
 **Header:** afxmdichildwndex.h  
  
## See Also  
 [CMDIChildWndEx Class](../vs140/cmdichildwndex-class.md)