---
title: "DECLARE_WND_CLASS"
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
  - "DECLARE_WND_CLASS"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "DECLARE_WND_CLASS macro"
ms.assetid: 55247a72-fb9e-4bde-87f3-747c08076971
caps.latest.revision: 15
author: ""
ms.author: ""
manager: ""
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# DECLARE_WND_CLASS
Allows you to specify the name of a new window class. Place this macro in an ATL ActiveX control's control class.  
  
## Syntax  
  
```  
  
      DECLARE_WND_CLASS(   
   WndClassName    
)  
```  
  
#### Parameters  
 `WndClassName`  
 [in] The name of the new window class. If **NULL**, ATL will generate a window class name.  
  
## Remarks  
 This macro allows you to specify the name of a new window class whose information will be managed by [CWndClassInfo](../vs140/cwndclassinfo-class.md). `DECLARE_WND_CLASS` defines the new window class by implementing the following static function:  
  
 [!code[NVC_ATL_Windowing#127](../vs140/codesnippet/CPP/declare_wnd_class_1.cpp)]  
  
 `DECLARE_WND_CLASS` specifies the following styles for the new window:  
  
-   CS_HREDRAW  
  
-   CS_VREDRAW  
  
-   CS_DBLCLKS  
  
 `DECLARE_WND_CLASS` also specifies the default window's background color. Use the [DECLARE_WND_CLASS_EX](../vs140/declare_wnd_class_ex.md) macro to provide your own styles and background color.  
  
 [CWindowImpl](../vs140/cwindowimpl-class.md) uses the `DECLARE_WND_CLASS` macro to create a window based on a new window class. To override this behavior, use the [DECLARE_WND_SUPERCLASS](../vs140/declare_wnd_superclass.md) macro, or provide your own implementation of the [GetWndClassInfo](../vs140/cwindowimpl--getwndclassinfo.md) function.  
  
 For more information about using windows in ATL, see the article [ATL Window Classes](../vs140/atl-window-classes.md).  
  
## Requirements  
 **Header:** atlwin.h  
  
## See Also  
 [Window Class Macros](../vs140/window-class-macros.md)   
 [Macros](../vs140/atl-macros.md)