---
title: "UI Support Classes"
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
  - "vc.atl.ui"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "user interfaces, support classes"
  - "user interfaces, ATL classes"
ms.assetid: 313dfc95-308a-4118-b919-5a3c3673b865
caps.latest.revision: 12
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# UI Support Classes
The following classes provide general UI support:  
  
-   [IDocHostUIHandlerDispatch](../VS_csharp/idochostuihandlerdispatch-interface.md) An interface to the Microsoft HTML parsing and rendering engine.  
  
-   [IOleObjectImpl](../VS_csharp/ioleobjectimpl-class.md) Provides the principal methods through which a container communicates with a control. Manages the activation and deactivation of in-place controls.  
  
-   [IOleInPlaceObjectWindowlessImpl](../VS_csharp/ioleinplaceobjectwindowlessimpl-class.md) Manages the reactivation of in-place controls. Enables a windowless control to receive messages, as well as to participate in drag-and-drop operations.  
  
-   [IOleInPlaceActiveObjectImpl](../VS_csharp/ioleinplaceactiveobjectimpl-class.md) Assists communication between an in-place control and its container.  
  
-   [IViewObjectExImpl](../VS_csharp/iviewobjecteximpl-class.md) Enables a control to display itself directly and to notify the container of changes in its display. Provides support for flicker-free drawing, non-rectangular and transparent controls, and hit testing.  
  
## Related Articles  
 [ATL Tutorial](../VS_csharp/active-template-library--atl--tutorial.md)  
  
## See Also  
 [Class Overview](../VS_csharp/atl-class-overview.md)