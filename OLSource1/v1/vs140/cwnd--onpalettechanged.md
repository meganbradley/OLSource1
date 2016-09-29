---
title: "CWnd::OnPaletteChanged"
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
  - "WM_PALETTECHANGED"
  - "CWnd::OnPaletteChanged"
  - "CWnd.OnPaletteChanged"
  - "OnPaletteChanged"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "OnPaletteChanged method"
  - "WM_PALETTECHANGED"
ms.assetid: 1ebfc90b-65b9-42b2-b7fb-dd9a57667558
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CWnd::OnPaletteChanged
The framework calls this member function for all top-level windows after the window with input focus has realized its logical palette, thereby changing the system palette.  
  
## Syntax  
  
```  
  
      afx_msg void OnPaletteChanged(  
   CWnd* pFocusWnd   
);  
```  
  
#### Parameters  
 `pFocusWnd`  
 Specifies a pointer to the window that caused the system palette to change. The pointer may be temporary and should not be stored.  
  
## Remarks  
 This call allows a window without the input focus that uses a color palette to realize its logical palettes and update its client area.  
  
 The `OnPaletteChanged` member function is called for all top-level and overlapped windows, including the one that changed the system palette and caused the `WM_PALETTECHANGED` message to be sent. If any child window uses a color palette, this message must be passed on to it.  
  
 To avoid an infinite loop, the window shouldn't realize its palette unless it determines that `pFocusWnd` does not contain a pointer to itself.  
  
> [!NOTE]
>  This member function is called by the framework to allow your application to handle a Windows message. The parameters passed to your function reflect the parameters received by the framework when the message was received. If you call the base-class implementation of this function, that implementation will use the parameters originally passed with the message and not the parameters you supply to the function.  
  
## Requirements  
 **Header:** afxwin.h  
  
## See Also  
 [CWnd Class](../vs140/cwnd-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [RealizePalette](http://msdn.microsoft.com/library/windows/desktop/dd162896)   
 [WM_PALETTECHANGED](http://msdn.microsoft.com/library/windows/desktop/dd145214)   
 [CWnd::OnPaletteIsChanging](../vs140/cwnd--onpaletteischanging.md)   
 [CWnd::OnQueryNewPalette](../vs140/cwnd--onquerynewpalette.md)