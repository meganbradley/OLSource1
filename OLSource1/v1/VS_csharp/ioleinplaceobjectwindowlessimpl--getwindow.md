---
title: "IOleInPlaceObjectWindowlessImpl::GetWindow"
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
  - "IOleInPlaceObjectWindowlessImpl.GetWindow"
  - "IOleInPlaceObjectWindowlessImpl::GetWindow"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "GetWindow method"
ms.assetid: a46c5606-707e-4af1-88af-a69c467f38fa
caps.latest.revision: 15
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# IOleInPlaceObjectWindowlessImpl::GetWindow
The container calls this function to get the window handle of the control.  
  
## Syntax  
  
```  
  
      HRESULT GetWindow(  
   HWND* phwnd   
);  
```  
  
## Remarks  
 Some containers will not work with a control that has been windowless, even if it is currently windowed. In ATL's implementation, if the control class's data member `m_bWasOnceWindowless` is **TRUE**, the function returns **E_FAIL**. Otherwise, if *phwnd* is not **NULL**, `GetWindow` sets **phwnd* to the control class's data member `m_hWnd` and returns `S_OK`.  
  
 See [IOleWindow::GetWindow](http://msdn.microsoft.com/library/windows/desktop/ms687282) in the [!INCLUDE[winSDK](../VS_csharp/includes/winsdk_md.md)].  
  
## Requirements  
 **Header:** atlctl.h  
  
## See Also  
 [IOleInPlaceObjectWindowlessImpl Class](../VS_csharp/ioleinplaceobjectwindowlessimpl-class.md)   
 [CComControlBase::m_bWasOnceWindowless](../Topic/CComControlBase::m_bWasOnceWindowless.md)