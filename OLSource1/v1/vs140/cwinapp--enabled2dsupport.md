---
title: "CWinApp::EnableD2DSupport"
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
  - "EnableD2DSupport"
  - "afxwin/CWinApp::EnableD2DSupport"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "EnableD2DSupport method"
ms.assetid: 9c4941e3-afc7-4cb4-8520-0cd2ac91166b
caps.latest.revision: 12
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CWinApp::EnableD2DSupport
[!INCLUDE[dev10_sp1required](../vs140/includes/dev10_sp1required_md.md)]  
  
 Enables application D2D support. Call this method before the main window is initialized.  
  
## Syntax  
  
```  
BOOL EnableD2DSupport(  
   D2D1_FACTORY_TYPE d2dFactoryType = D2D1_FACTORY_TYPE_SINGLE_THREADED,  
   DWRITE_FACTORY_TYPE writeFactoryType = DWRITE_FACTORY_TYPE_SHARED  
);  
```  
  
#### Parameters  
 `d2dFactoryType`  
 The threading model of the D2D factory and the resources it creates.  
  
 `writeFactoryType`  
 A value that specifies whether the write factory object will be shared or isolated  
  
## Return Value  
 Returns TRUE if D2D support was enabled, FALSE - otherwise  
  
## Requirements  
 **Header:** afxwin.h  
  
## See Also  
 [CWinApp Class](../vs140/cwinapp-class.md)