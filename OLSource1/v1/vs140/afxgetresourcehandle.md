---
title: "AfxGetResourceHandle"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-cpp"
ms.tgt_pltfrm: na
ms.topic: "article"
f1_keywords: 
  - "AfxGetResourceHandle"
  - "AFXWIN/AfxGetResourceHandle"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "AfxGetResourceHandle function"
ms.assetid: d0eff6c4-f566-471a-96b7-a5a70a751a92
caps.latest.revision: 13
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# AfxGetResourceHandle
Use the `HINSTANCE` handle returned by this function to access the application's resources directly, for example, in calls to the Windows function **FindResource**.  
  
## Syntax  
  
```  
  
extern HINSTANCE AfxGetResourceHandle( );  
```  
  
## Return Value  
 An `HINSTANCE` handle where the default resources of the application are loaded.  
  
## Example  
 [!code[NVC_MFCWindowing#130](../vs140/codesnippet/CPP/afxgetresourcehandle_1.cpp)]  
  
## Requirements  
 **Header:** afxwin.h  
  
## See Also  
 [Macros and Globals](../vs140/mfc-macros-and-globals.md)   
 [AfxGetInstanceHandle](../vs140/afxgetinstancehandle.md)   
 [AfxSetResourceHandle](../vs140/afxsetresourcehandle.md)   
 [AfxFindResourceHandle](../vs140/afxfindresourcehandle.md)