---
title: "CWnd::OnAskCbFormatName"
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
  - WM_ASKCBFORMATNAME
  - CWnd::OnAskCbFormatName
  - OnAskCbFormatName
  - CWnd.OnAskCbFormatName
dev_langs: 
  - C++
helpviewer_keywords: 
  - OnAskCbFormatName method
  - WM_ASKCBFORMATNAME
ms.assetid: 9185673a-3bb9-45c4-a6c9-9249ec5c230f
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - de-de
  - ja-jp
---
# CWnd::OnAskCbFormatName
The framework calls this member function when the Clipboard contains a data handle for the `CF_OWNERDISPLAY` format (that is, when the Clipboard owner will display the Clipboard contents).  
  
## Syntax  
  
```  
  
      afx_msg void OnAskCbFormatName(  
   UINT nMaxCount,  
   LPTSTR lpszString   
);  
```  
  
#### Parameters  
 `nMaxCount`  
 Specifies the maximum number of bytes to copy.  
  
 `lpszString`  
 Points to the buffer where the copy of the format name is to be stored.  
  
## Remarks  
 The Clipboard owner should provide a name for its format.  
  
 Override this member function and copy the name of the `CF_OWNERDISPLAY` format into the specified buffer, not exceeding the maximum number of bytes specified.  
  
> [!NOTE]
>  This member function is called by the framework to allow your application to handle a Windows message. The parameters passed to your function reflect the parameters received by the framework when the message was received. If you call the base-class implementation of this function, that implementation will use the parameters originally passed with the message and not the parameters you supply to the function.  
  
## Requirements  
 **Header:** afxwin.h  
  
## See Also  
 [CWnd Class](../vs140/cwnd-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [WM_ASKCBFORMATNAME](http://msdn.microsoft.com/library/windows/desktop/ms649018)