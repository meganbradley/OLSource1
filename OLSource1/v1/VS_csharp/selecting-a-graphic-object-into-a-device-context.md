---
title: "Selecting a Graphic Object into a Device Context"
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
  - "graphic objects, selecting into device context"
  - "SelectObject method"
  - "GDI objects [C++], device contexts"
  - "lifetime, graphic objects"
  - "device contexts, selecting graphic objects into"
  - "device contexts, graphic objects"
ms.assetid: cf54a330-63ef-421f-83eb-90ec7bd82eef
caps.latest.revision: 12
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Selecting a Graphic Object into a Device Context
This topic applies to using graphic objects in a window's device context. After you [create a drawing object](../VS_csharp/one-stage-and-two-stage-construction-of-objects.md), you must select it into the device context in place of the default object stored there:  
  
 [!code[NVC_MFCDocViewSDI#7](../VS_csharp/codesnippet/CPP/selecting-a-graphic-object-into-a-device-context_1.cpp)]  
  
## Lifetime of Graphic Objects  
 The graphic object returned by [SelectObject](../Topic/CDC::SelectObject.md) is "temporary." That is, it will be deleted by the [OnIdle](../Topic/CWinApp::OnIdle.md) member function of class `CWinApp` the next time the program gets idle time. As long as you use the object returned by `SelectObject` in a single function without returning control to the main message loop, you will have no problem.  
  
### What do you want to know more about?  
  
-   [Graphic objects](../VS_csharp/graphic-objects.md)  
  
-   [One-stage and two-stage construction of graphic objects](../VS_csharp/one-stage-and-two-stage-construction-of-objects.md)  
  
-   [Device contexts](../VS_csharp/device-contexts.md)  
  
-   [Drawing in a View](../VS_csharp/drawing-in-a-view.md)  
  
## See Also  
 [Graphic Objects](../VS_csharp/graphic-objects.md)