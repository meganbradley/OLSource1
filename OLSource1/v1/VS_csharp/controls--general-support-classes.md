---
title: "Controls: General Support Classes"
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
  - "vc.atl.controls"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "controls [ATL]"
  - "general support classes"
ms.assetid: cf73f1d2-7542-48e3-b8c8-9d3abf29f85b
caps.latest.revision: 14
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Controls: General Support Classes
The following classes provide general support for ATL controls:  
  
-   [CComControl](../VS_csharp/ccomcontrol-class.md) Consists of helper functions and data members that are essential to ATL controls.  
  
-   [IOleControlImpl](../VS_csharp/iolecontrolimpl-class.md) Provides methods necessary for controls.  
  
-   [IOleObjectImpl](../VS_csharp/ioleobjectimpl-class.md) Provides the principal methods through which a container communicates with a control. Manages the activation and deactivation of in-place controls.  
  
-   [IQuickActivateImpl](../VS_csharp/iquickactivateimpl-class.md) Combines initialization into a single call to help containers avoid delays when loading controls.  
  
-   [IPointerInactiveImpl](../VS_csharp/ipointerinactiveimpl-class.md) Provides minimal mouse interaction for an otherwise inactive control.  
  
## Sample Program  
 [ATLFire](../VS_csharp/visual-c---samples.md)  
  
## Related Articles  
 [ATL Tutorial](../VS_csharp/active-template-library--atl--tutorial.md)  
  
## See Also  
 [Class Overview](../VS_csharp/atl-class-overview.md)