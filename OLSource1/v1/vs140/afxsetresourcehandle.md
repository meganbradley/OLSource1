---
title: "AfxSetResourceHandle"
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
  - "AfxSetResourceHandle"
  - "AFXWIN/AfxSetResourceHandle"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "AfxSetResourceHandle function"
ms.assetid: 4fa9b820-c64c-4db3-8dc0-de6dfeb8e65b
caps.latest.revision: 13
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# AfxSetResourceHandle
Use this function to set the `HINSTANCE` handle that determines where the default resources of the application are loaded.  
  
## Syntax  
  
```  
  
      void AFXAPI AfxSetResourceHandle(  
   HINSTANCE hInstResource   
);   
```  
  
#### Parameters  
 `hInstResource`  
 The instance or module handle to an .EXE or DLL file from which the application's resources are loaded.  
  
## Example  
 [!code[NVC_MFCWindowing#135](../vs140/codesnippet/CPP/afxsetresourcehandle_1.cpp)]  
  
## Requirements  
 **Header:** afxwin.h  
  
## See Also  
 [Macros and Globals](../vs140/mfc-macros-and-globals.md)   
 [AfxGetInstanceHandle](../vs140/afxgetinstancehandle.md)   
 [AfxGetResourceHandle](../vs140/afxgetresourcehandle.md)