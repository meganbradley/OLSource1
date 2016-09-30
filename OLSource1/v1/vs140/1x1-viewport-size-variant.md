---
title: "1x1 Viewport Size Variant"
ms.custom: na
ms.date: "09/21/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "vs-ide-debug"
ms.tgt_pltfrm: na
ms.topic: "article"
ms.assetid: 3dbc3247-00f5-4644-8ff9-72e9febcf09a
caps.latest.revision: 10
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# 1x1 Viewport Size Variant
Reduces the viewport dimensions on all render targets to 1x1 pixels.  
  
## Interpretation  
 A smaller viewport reduces the number of pixels that must be shaded, but doesn't reduce the number of vertices that must be processed. Setting the viewport dimensions to 1x1 pixels effectively eliminates pixel-shading from your app.  
  
 If this variant shows a large performance gain, it might indicate that your app consumes too much fillrate. This can indicate that the resolution you have chosen is too high for the target platform or that your app spends significant time shading pixels that are later overwritten (overdraw). This result suggests that decreasing the size of your framebuffer or reducing the amount of overdraw will improve your app's performance.  
  
## Remarks  
 The viewport dimensions are reset to 1x1 pixels after every call to <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> or <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>.  
  
## Example  
 This variant can be reproduced by using code like this:  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>