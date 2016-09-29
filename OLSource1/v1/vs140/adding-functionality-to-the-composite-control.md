---
title: "Adding Functionality to the Composite Control"
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
  - "event handlers [C++], ActiveX controls"
  - "composite controls, handling events"
  - "ActiveX controls [C++], events"
ms.assetid: 98f85681-9564-480d-af38-03f9733fe58b
caps.latest.revision: 12
author: ""
ms.author: ""
manager: ""
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Adding Functionality to the Composite Control
Once you have inserted any necessary controls into the composite control, the next step involves adding new functionality. This new functionality usually falls into two categories:  
  
-   Supporting additional interfaces and customizing the behavior of your composite control with additional, specific features.  
  
-   Handling events from the contained ActiveX control (or controls).  
  
 For the purpose and scope of this article, the remainder of this section focuses solely on handling events from ActiveX controls.  
  
> [!NOTE]
>  If you need to handle messages from Windows controls, see [Implementing a Window](../vs140/implementing-a-window.md) for more information on message handling in ATL.  
  
 After inserting an ActiveX control in the dialog resource, right-click the control and click **Add Event Handler**. Select the event you want to handle and click **Add and Edit**. The event handler code will be added to the control's .h file.  
  
 Connection points for ActiveX controls on the composite control are automatically connected and disconnected via calls to [CComCompositeControl::AdviseSinkMap](../vs140/ccomcompositecontrol--advisesinkmap.md).  
  
## See Also  
 [Composite Control Fundamentals](../vs140/atl-composite-control-fundamentals.md)