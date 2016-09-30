---
title: "accelerator::has_display Data Member"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-cpp"
ms.tgt_pltfrm: na
ms.topic: "article"
f1_keywords: 
  - "amprt/Concurrency::accelerator::has_display"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "has_display data member"
ms.assetid: ba5481af-72c5-4d81-aeef-f2090d8baa28
caps.latest.revision: 15
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# accelerator::has_display Data Member
Gets a Boolean value that indicates whether the [accelerator](../vs140/accelerator-class.md) can output to a display.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Remarks  
 The value of the <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> property indicates whether the accelerator can output to a display, but it does not necessarily indicate that a display is physically attached to the accelerator.  
  
 For hardware accelerators, <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> is <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> only when a display device is attached to the accelerator. For the REF and WARP accelerators, <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> is always <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> because they are always capable of outputting to a display. For the CPU accelerator—which cannot output to a display—<CodeContentPlaceHolder>6\</CodeContentPlaceHolder> is always <CodeContentPlaceHolder>7\</CodeContentPlaceHolder>. Refer to the following table for a summary of this information.  
  
|Feature|CPU|REF|WARP|C++ AMP-capable hardware, no display attached|C++ AMP-capable hardware, display attached|  
|-------------|---------|---------|----------|------------------------------------------------------|---------------------------------------------------|  
|has_display|false|true|true|false|true|  
  
 The <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> property can be used to determine whether the operating system or other system software components might use the accelerator for display purposes. If you are using C++ AMP only for computation, you might prefer an accelerator that can't output to a display so that you can avoid contending for accelerator resources. But if you are using C++ AMP to visualize data, you might prefer an accelerator that can output to a display so that you don't have to copy the result from the accelerator just to display it.  
  
## Requirements  
 **Header:** amprt.h  
  
 **Namespace:** Concurrency  
  
## See Also  
 [accelerator::get_has_display Method](../vs140/accelerator--get_has_display-method.md)   
 [accelerator Class](../vs140/accelerator-class.md)