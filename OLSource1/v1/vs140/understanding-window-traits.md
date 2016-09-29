---
title: "Understanding Window Traits"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-cpp"
ms.tgt_pltfrm: na
ms.topic: "article"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "window traits"
ms.assetid: c90cf850-9e91-49da-9cf3-ad4efb30347d
caps.latest.revision: 13
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Understanding Window Traits
Window traits classes provide a simple method for standardizing the styles used for the creation of an ATL window object. Window traits are accepted as template parameters by [CWindowImpl](../vs140/cwindowimpl-class.md) and other ATL window classes as a way of providing default window styles at the class level.  
  
 If the creator of a window instance doesn't provide styles explicitly in the call to [Create](../vs140/cwindowimpl--create.md), you can use a traits class to ensure that the window is still created with the correct styles. You can even ensure that certain styles are set for all instances of that window class while permitting other styles to be set on a per-instance basis.  
  
## ATL Window Traits Templates  
 ATL provides two window traits templates that allow you to set default styles at compile time using their template parameters.  
  
|Class|Description|  
|-----------|-----------------|  
|[CWinTraits](../vs140/cwintraits-class.md)|Use this template when you want to provide default window styles that will be used only when no other styles are specified in the call to **Create**. The styles provided at run time take precedence over the styles set at compile time.|  
|[CWinTraitsOR](../vs140/cwintraitsor-class.md)|Use this class when you want to specify styles that must always be set for the window class. The styles provided at run time are combined with the styles set at compile time using the bitwise OR operator.|  
  
 In addition to these templates, ATL provides a number of predefined specializations of the `CWinTraits` template for commonly used combinations of window styles. See the [CWinTraits](../vs140/cwintraits-class.md) reference documentation for full details.  
  
## Custom Window Traits  
 In the unlikely situation that specializing one of the templates provided by ATL isn't sufficient and you need to create your own traits class, you just need to create a class that implements two static functions: `GetWndStyle` and **GetWndStyleEx**:  
  
 [!code[NVC_ATL_Windowing#68](../vs140/codesnippet/CPP/understanding-window-traits_1.h)]  
  
 Each of these functions will be passed some style value at run time which it can use to produce a new style value. If your window traits class is being used as the template argument to an ATL window class, the style values passed to these static functions will be whatever was passed as the style arguments to [Create](../vs140/cwindowimpl--create.md).  
  
## See Also  
 [Window Classes](../vs140/atl-window-classes.md)