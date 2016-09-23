---
title: "IOleInPlaceActiveObjectImpl::GetWindow"
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
  - IOleInPlaceActiveObjectImpl::GetWindow
  - IOleInPlaceActiveObjectImpl.GetWindow
dev_langs: 
  - C++
helpviewer_keywords: 
  - GetWindow method
ms.assetid: 84cb6b1e-d3cb-4854-9e1e-0a60d530fe12
caps.latest.revision: 15
translation.priority.ht: 
  - de-de
  - ja-jp
---
# IOleInPlaceActiveObjectImpl::GetWindow
The container calls this function to get the window handle of the control.  
  
## Syntax  
  
```  
  
      HRESULT GetWindow(  
   HWND* phwnd   
);  
```  
  
## Remarks  
 Some containers will not work with a control that has been windowless, even if it is currently windowed. In ATL's implementation, if the **CComControl::m_bWasOnceWindowless** data member is **TRUE**, the function returns **E_FAIL**. Otherwise, if \**phwnd* is not **NULL**, `GetWindow` assigns *phwnd* to the control class's data member `m_hWnd` and returns `S_OK`.  
  
 See [IOleWindow::GetWindow](http://msdn.microsoft.com/library/windows/desktop/ms687282) in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
## Requirements  
 **Header:** atlctl.h  
  
## See Also  
 [IOleInPlaceActiveObjectImpl Class](../vs140/ioleinplaceactiveobjectimpl-class.md)   
 [CComControlBase::m_bWasOnceWindowless](../vs140/ccomcontrolbase--m_bwasoncewindowless.md)