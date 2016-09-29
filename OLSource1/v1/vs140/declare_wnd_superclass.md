---
title: "DECLARE_WND_SUPERCLASS"
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
  - "DECLARE_WND_SUPERCLASS"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "DECLARE_WND_SUPERCLASS macro"
ms.assetid: 650337b6-4973-41e5-8c36-55f90327bdcd
caps.latest.revision: 15
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# DECLARE_WND_SUPERCLASS
Allows you to specify the parameters of a class. Place this macro in an ATL ActiveX control's control class.  
  
## Syntax  
  
```  
  
      DECLARE_WND_SUPERCLASS(   
   WndClassName,   
   OrigWndClassName    
)  
```  
  
#### Parameters  
 `WndClassName`  
 [in] The name of the window class that will superclass `OrigWndClassName`. If **NULL**, ATL will generate a window class name.  
  
 `OrigWndClassName`  
 [in] The name of an existing window class.  
  
## Remarks  
 This macro allows you to specify the name of a window class that will superclass an existing window class. [CWndClassInfo](../vs140/cwndclassinfo-class.md) manages the information of the superclass.  
  
 `DECLARE_WND_SUPERCLASS` implements the following static function:  
  
 [!code[NVC_ATL_Windowing#127](../vs140/codesnippet/CPP/declare_wnd_superclass_1.cpp)]  
  
 By default, [CWindowImpl](../vs140/cwindowimpl-class.md) uses the [DECLARE_WND_CLASS](../vs140/declare_wnd_class.md) macro to create a window based on a new window class. By specifying the `DECLARE_WND_SUPERCLASS` macro in a `CWindowImpl`-derived class, the window class will be based on an existing class but will use your window procedure. This technique is called superclassing.  
  
 Besides using the `DECLARE_WND_CLASS` and `DECLARE_WND_SUPERCLASS` macros, you can override the [GetWndClassInfo](../vs140/cwindowimpl--getwndclassinfo.md) function with your own implementation.  
  
 For more information about using windows in ATL, see the article [ATL Window Classes](../vs140/atl-window-classes.md).  
  
## Requirements  
 **Header:** atlwin.h  
  
## See Also  
 [Window Class Macros](../vs140/window-class-macros.md)   
 [Macros](../vs140/atl-macros.md)