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
author: ""
ms.author: ""
manager: ""
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Selecting a Graphic Object into a Device Context
This topic applies to using graphic objects in a window's device context. After you [create a drawing object](../vs140/one-stage-and-two-stage-construction-of-objects.md), you must select it into the device context in place of the default object stored there:  
  
 [!code[NVC_MFCDocViewSDI#7](../vs140/codesnippet/CPP/selecting-a-graphic-object-into-a-device-context_1.cpp)]  
  
## Lifetime of Graphic Objects  
 The graphic object returned by [SelectObject](../vs140/cdc--selectobject.md) is "temporary." That is, it will be deleted by the [OnIdle](../vs140/cwinapp--onidle.md) member function of class `CWinApp` the next time the program gets idle time. As long as you use the object returned by `SelectObject` in a single function without returning control to the main message loop, you will have no problem.  
  
### What do you want to know more about?  
  
-   [Graphic objects](../vs140/graphic-objects.md)  
  
-   [One-stage and two-stage construction of graphic objects](../vs140/one-stage-and-two-stage-construction-of-objects.md)  
  
-   [Device contexts](../vs140/device-contexts.md)  
  
-   [Drawing in a View](../vs140/drawing-in-a-view.md)  
  
## See Also  
 [Graphic Objects](../vs140/graphic-objects.md)