---
title: "ActiveX Control Containers"
ms.custom: na
ms.date: 09/22/2016
ms.prod: visual-studio-dev14
ms.reviewer: na
ms.suite: na
ms.technology: 
  - devlang-cpp
ms.tgt_pltfrm: na
ms.topic: article
dev_langs: 
  - C++
helpviewer_keywords: 
  - ActiveX control containers [C++]
  - OLE controls [C++], containers
ms.assetid: 0eb1a713-e607-4c79-a0c7-67c5f1fd5fab
caps.latest.revision: 11
translation.priority.ht: 
  - de-de
  - ja-jp
---
# ActiveX Control Containers
An ActiveX control container is a container that fully supports ActiveX controls and can incorporate them into its own windows or dialogs. An ActiveX control is a reusable software element that you can use in many development projects. Controls allow your application's user to access databases, monitor data, and make various selections within your applications. For more information on ActiveX controls, see the article [MFC ActiveX Controls](../vs140/mfc-activex-controls.md).  
  
 Control containers typically take two forms in a project:  
  
-   Dialogs and dialog-like windows such as form views, where an ActiveX control is used somewhere in the dialog box.  
  
-   Windows in an application, where an ActiveX control is used in a toolbar, or other location in the user window.  
  
 The ActiveX control container interacts with the control via exposed [methods](../vs140/mfc-activex-controls--methods.md) and [properties](../vs140/mfc-activex-controls--properties.md). These methods and properties, which can be accessed and modified by the control container, are accessed through a wrapper class in the ActiveX control container project. The embedded ActiveX control can also interact with the container by firing (sending) [events](../vs140/mfc-activex-controls--events.md) to notify the container that an action has occurred. The control container can choose to act upon these notifications or not.  
  
 Additional articles discuss several topics, from creating an ActiveX control container project to basic implementation issues related to ActiveX control containers built with Visual C++:  
  
-   [Creating an MFC ActiveX Control Container](../vs140/creating-an-mfc-activex-control-container.md)  
  
-   [Containers for ActiveX Controls](../vs140/containers-for-activex-controls.md)  
  
-   [ActiveX Control Containers: Manually Enabling ActiveX Control Containment](../vs140/activex-control-containers--manually-enabling-activex-control-containment.md)  
  
-   [ActiveX Control Containers: Inserting a Control into a Control Container Application](../vs140/activex-control-containers--inserting-a-control-into-a-control-container-application.md)  
  
-   [ActiveX Control Containers: Connecting an ActiveX Control to a Member Variable](../vs140/activex-control-containers--connecting-an-activex-control-to-a-member-variable.md)  
  
-   [ActiveX Control Containers: Handling Events from an ActiveX control](../vs140/activex-control-containers--handling-events-from-an-activex-control.md)  
  
-   [ActiveX Control Containers: Viewing and Modifying Control Properties](../vs140/activex-control-containers--viewing-and-modifying-control-properties.md)  
  
-   [ActiveX Control Containers: Programming ActiveX Controls in an ActiveX Control Container](../vs140/activex-control-containers--programming-activex-controls-in-an-activex-control-container.md)  
  
-   [ActiveX Control Containers: Using Controls in a Non-Dialog Container](../vs140/activex-control-containers--using-controls-in-a-non-dialog-container.md)  
  
 For more information about using ActiveX controls in a dialog box, see the [Dialog Editor](../vs140/dialog-editor.md) topics.  
  
 For a list of articles that explain the details of developing ActiveX controls using Visual C++ and the MFC ActiveX control classes, see [MFC ActiveX controls](../vs140/mfc-activex-controls.md). The articles are grouped by functional categories.  
  
## See Also  
 [MFC ActiveX Controls](../vs140/mfc-activex-controls.md)