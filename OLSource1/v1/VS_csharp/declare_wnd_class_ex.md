---
title: "DECLARE_WND_CLASS_EX"
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
  - "DECLARE_WND_CLASS_EX"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "DECLARE_WND_CLASS_EX macro"
ms.assetid: 0672c144-f2aa-4f6a-ae16-566e3a1f5411
caps.latest.revision: 15
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# DECLARE_WND_CLASS_EX
Allows you to specify the name of an existing window class on which a new window class will be based. Place this macro in an ATL ActiveX control's control class.  
  
## Syntax  
  
```  
  
      DECLARE_WND_CLASS_EX(   
   WndClassName,   
   style,   
   bkgnd    
)  
```  
  
#### Parameters  
 `WndClassName`  
 [in] The name of the new window class. If **NULL**, ATL will generate a window class name.  
  
 `style`  
 [in] The style of the window.  
  
 *bkgnd*  
 [in] The background color of the window.  
  
## Remarks  
 This macro allows you to specify the class parameters of a new window class, whose information will be managed by [CWndClassInfo](../VS_csharp/cwndclassinfo-class.md). `DECLARE_WND_CLASS_EX` defines the new window class by implementing the following static function:  
  
 [!code[NVC_ATL_Windowing#127](../VS_csharp/codesnippet/CPP/declare_wnd_class_ex_1.cpp)]  
  
 If you want to use the default styles and background color, use the [DECLARE_WND_CLASS](../VS_csharp/declare_wnd_class.md) macro. For more information about using windows in ATL, see the article [ATL Window Classes](../VS_csharp/atl-window-classes.md).  
  
## Requirements  
 **Header:** atlwin.h  
  
## See Also  
 [Window Class Macros](../VS_csharp/window-class-macros.md)   
 [Macros](../VS_csharp/atl-macros.md)   
 [DECLARE_WND_SUPERCLASS](../VS_csharp/declare_wnd_superclass.md)