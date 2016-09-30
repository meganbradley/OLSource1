---
title: "CWnd::ReleaseDC"
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
  - "CWnd.ReleaseDC"
  - "CWnd::ReleaseDC"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "DC functions"
  - "ReleaseDC method"
  - "device contexts, releasing"
ms.assetid: d5e52d65-c5a8-42bd-81d0-82443a5f8fe5
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CWnd::ReleaseDC
Releases a device context, freeing it for use by other applications.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 Identifies the device context to be released.  
  
## Return Value  
 Nonzero if successful; otherwise 0.  
  
## Remarks  
 The effect of the <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> member function depends on the device-context type.  
  
 The application must call the <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> member function for each call to the [GetWindowDC](../vs140/cwnd--getwindowdc.md) member function and for each call to the [GetDC](../vs140/cwnd--getdc.md) member function.  
  
## Requirements  
 **Header:** afxwin.h  
  
## See Also  
 [CWnd Class](../vs140/cwnd-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CWnd::GetDC](../vs140/cwnd--getdc.md)   
 [CWnd::GetWindowDC](../vs140/cwnd--getwindowdc.md)   
 [ReleaseDC](http://msdn.microsoft.com/library/windows/desktop/dd162920)