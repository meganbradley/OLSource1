---
title: "COleDispatchDriver::m_bAutoRelease"
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
  - "m_bAutoRelease"
  - "COleDispatchDriver::m_bAutoRelease"
  - "COleDispatchDriver.m_bAutoRelease"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "m_bAutoRelease"
ms.assetid: 0a07fc46-a136-40a7-b8b1-8849cf0792d6
caps.latest.revision: 16
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# COleDispatchDriver::m_bAutoRelease
If **TRUE**, the COM object accessed by [m_lpDispatch](../vs140/coledispatchdriver--m_lpdispatch.md) will be automatically released when [ReleaseDispatch](../vs140/coledispatchdriver--releasedispatch.md) is called or when this `COleDispatchDriver` object is destroyed.  
  
## Syntax  
  
```  
  
BOOL m_bAutoRelease;  
  
```  
  
## Remarks  
 By default, `m_bAutoRelease` is set to **TRUE** in the constructor.  
  
 For more information on releasing COM objects, see [Implementing Reference Counting](http://msdn.microsoft.com/library/windows/desktop/ms693431) and [IUnknown::Release](http://msdn.microsoft.com/library/windows/desktop/ms682317) in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
## Example  
 [!code[NVC_MFCOleContainer#9](../vs140/codesnippet/CPP/coledispatchdriver--m_bautorelease_1.cpp)]  
  
## Requirements  
 **Header:** afxdisp.h  
  
## See Also  
 [COleDispatchDriver Class](../vs140/coledispatchdriver-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [COleDispatchDriver::AttachDispatch](../vs140/coledispatchdriver--attachdispatch.md)   
 [COleDispatchDriver::ReleaseDispatch](../vs140/coledispatchdriver--releasedispatch.md)   
 [COleDispatchDriver::m_lpDispatch](../vs140/coledispatchdriver--m_lpdispatch.md)