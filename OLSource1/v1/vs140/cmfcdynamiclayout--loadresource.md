---
title: "CMFCDynamicLayout::LoadResource"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-cpp"
ms.tgt_pltfrm: na
ms.topic: "reference"
dev_langs: 
  - "C++"
ms.assetid: b5b2c7ae-af4f-41d1-9fcd-fe8662cae1d9
caps.latest.revision: 8
author: ""
ms.author: ""
manager: ""
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CMFCDynamicLayout::LoadResource
Reads the dynamic layout from AFX_DIALOG_LAYOUT resource and then applies the layout to the host window.  
  
## Syntax  
  
```vb  
  
static BOOL LoadResource(    CWnd* pHostWnd,    LPVOID lpResource,    DWORD dwSize);  
```  
  
#### Parameters  
 `pHostWnd`  
 A pointer to the host window.  
  
 `lpResource`  
 A pointer to the buffer that contains the AFX_DIALOG_LAYOUT resource.  
  
 `dwSize`  
 The buffer size in bytes.  
  
## Return Value  
 TRUE if resource is loaded and applied to the host window; otherwise FALSE.  
  
## Remarks  
  
## Requirements  
 **Header:** afxlayout.h  
  
## See Also  
 [CMFCDynamicLayout Class](../vs140/cmfcdynamiclayout-class.md)