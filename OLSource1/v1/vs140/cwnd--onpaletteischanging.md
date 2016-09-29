---
title: "CWnd::OnPaletteIsChanging"
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
  - "CWnd.OnPaletteIsChanging"
  - "WM_PALETTEISCHANGING"
  - "OnPaletteIsChanging"
  - "CWnd::OnPaletteIsChanging"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "WM_PALETTEISCHANGING"
  - "OnPaletteIsChanging method"
ms.assetid: 4beef7f5-a575-4c79-83cd-66c6f816e00f
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CWnd::OnPaletteIsChanging
The framework calls this member function to inform applications that an application is going to realize its logical palette.  
  
## Syntax  
  
```  
  
      afx_msg void OnPaletteIsChanging(  
   CWnd* pRealizeWnd   
);  
```  
  
#### Parameters  
 *pRealizeWnd*  
 Specifies the window that is about to realize its logical palette.  
  
## Remarks  
 This member function is called by the framework to allow your application to handle a Windows message. The parameters passed to your function reflect the parameters received by the framework when the message was received. If you call the base-class implementation of this function, that implementation will use the parameters originally passed with the message and not the parameters you supply to the function.  
  
## Requirements  
 **Header:** afxwin.h  
  
## See Also  
 [CWnd Class](../vs140/cwnd-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CWnd::OnPaletteChanged](../vs140/cwnd--onpalettechanged.md)   
 [CWnd::OnQueryNewPalette](../vs140/cwnd--onquerynewpalette.md)   
 [WM_PALETTEISCHANGING](http://msdn.microsoft.com/library/windows/desktop/dd145215)