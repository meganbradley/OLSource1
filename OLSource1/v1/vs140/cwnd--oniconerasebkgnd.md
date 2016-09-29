---
title: "CWnd::OnIconEraseBkgnd"
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
  - "WM_ICONERASEBKGND"
  - "OnIconEraseBkgnd"
  - "CWnd::OnIconEraseBkgnd"
  - "CWnd.OnIconEraseBkgnd"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "WM_ICONERASEBKGND"
  - "OnIconEraseBkgnd method"
ms.assetid: af8933ce-18d4-4ee9-a48c-f60fc84f7d7f
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CWnd::OnIconEraseBkgnd
The framework calls this member function for a minimized (iconic) `CWnd` object when the background of the icon must be filled before painting the icon.  
  
## Syntax  
  
```  
  
      afx_msg void OnIconEraseBkgnd(  
   CDC* pDC   
);  
```  
  
#### Parameters  
 `pDC`  
 Specifies the device-context object of the icon. May be temporary and should not be stored for later use.  
  
## Remarks  
 `CWnd` receives this call only if a class icon is defined for the window default implementation; otherwise [OnEraseBkgnd](../vs140/cwnd--onerasebkgnd.md) is called.  
  
 The [DefWindowProc](../vs140/cwnd--defwindowproc.md) member function fills the icon background with the background brush of the parent window.  
  
> [!NOTE]
>  This member function is called by the framework to allow your application to handle a Windows message. The parameters passed to your function reflect the parameters received by the framework when the message was received. If you call the base-class implementation of this function, that implementation will use the parameters originally passed with the message and not the parameters you supply to the function.  
  
## Requirements  
 **Header:** afxwin.h  
  
## See Also  
 [CWnd Class](../vs140/cwnd-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CWnd::OnEraseBkgnd](../vs140/cwnd--onerasebkgnd.md)   
 [WM_ICONERASEBKGND](https://msdn.microsoft.com/en-us/library/ms648056.aspx)