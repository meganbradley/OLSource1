---
title: "CWnd::GetControlUnknown"
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
  - GetControlUnknown
  - CWnd::GetControlUnknown
  - CWnd.GetControlUnknown
dev_langs: 
  - C++
helpviewer_keywords: 
  - GetControlUnknown method
ms.assetid: 0adf8cf1-11c3-4a79-9b0c-0194a01d9164
caps.latest.revision: 15
robots: noindex,nofollow
translation.priority.ht: 
  - de-de
  - ja-jp
---
# CWnd::GetControlUnknown
Call this member function to retrieve a pointer to an unknown OLE control.  
  
## Syntax  
  
```  
  
LPUNKNOWN GetControlUnknown( );  
  
```  
  
## Return Value  
 A pointer to the [IUnknown](http://msdn.microsoft.com/library/windows/desktop/ms680509) interface of the OLE control represented by this `CWnd` object. If this object does not represent an OLE control, the return value is **NULL**.  
  
## Remarks  
 You should not release this **IUnknown** pointer. Typically, you would use to obtain a specific interface of the control.  
  
 The interface pointer returned by **GetControlUnknown** is not reference-counted. Do not call [IUnknown::Release](http://msdn.microsoft.com/library/windows/desktop/ms682317) on the pointer unless you have previously called [IUnknown::AddRef](http://msdn.microsoft.com/library/windows/desktop/ms691379) on it.  
  
## Example  
 [!code[NVC_MFCWindowing#96](../vs140/codesnippet/CPP/cwnd--getcontrolunknown_1.cpp)]
  
  
## Requirements  
 **Header:** afxwin.h  
  
## See Also  
 [CWnd Class](../vs140/cwnd-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [IUnknown::Release](http://msdn.microsoft.com/library/windows/desktop/ms682317)   
 [IUnknown::QueryInterface](http://msdn.microsoft.com/library/windows/desktop/ms682521)