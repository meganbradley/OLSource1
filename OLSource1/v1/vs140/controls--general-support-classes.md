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
author: ""
ms.author: ""
manager: ""
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Controls: General Support Classes
The following classes provide general support for ATL controls:  
  
-   [CComControl](../vs140/ccomcontrol-class.md) Consists of helper functions and data members that are essential to ATL controls.  
  
-   [IOleControlImpl](../vs140/iolecontrolimpl-class.md) Provides methods necessary for controls.  
  
-   [IOleObjectImpl](../vs140/ioleobjectimpl-class.md) Provides the principal methods through which a container communicates with a control. Manages the activation and deactivation of in-place controls.  
  
-   [IQuickActivateImpl](../vs140/iquickactivateimpl-class.md) Combines initialization into a single call to help containers avoid delays when loading controls.  
  
-   [IPointerInactiveImpl](../vs140/ipointerinactiveimpl-class.md) Provides minimal mouse interaction for an otherwise inactive control.  
  
## Sample Program  
 [ATLFire](../vs140/visual-c---samples.md)  
  
## Related Articles  
 [ATL Tutorial](../vs140/active-template-library--atl--tutorial.md)  
  
## See Also  
 [Class Overview](../vs140/atl-class-overview.md)