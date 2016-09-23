---
title: "ActiveX Control Containers: Inserting a Control into a Control Container Application"
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
  - ActiveX control containers [C++], inserting controls
  - ActiveX controls [C++], adding to projects
ms.assetid: bbb617ff-872f-43d8-b4d6-c49adb16b148
caps.latest.revision: 11
translation.priority.ht: 
  - de-de
  - ja-jp
---
# ActiveX Control Containers: Inserting a Control into a Control Container Application
Before you can access an ActiveX control from an ActiveX control container application, you must add the ActiveX control to the container application using the [Insert ActiveX Control](../vs140/insert-activex-control-dialog-box.md) dialog box.  
  
 To add an ActiveX control to the ActiveX control container project, see [Viewing and Adding ActiveX Controls to a Dialog Box](../vs140/viewing-and-adding-activex-controls-to-a-dialog-box.md).  
  
 Once you add the control, you need to add a member variable (of the ActiveX control type) to the dialog box class. For more information on this procedure, see [Adding a Member Variable](../vs140/adding-a-member-variable---visual-c---.md).  
  
 Once you have added the member variable a class, referred to as a wrapper class, is automatically generated and added to your project. This class is used as an interface between the control container and the embedded control.  
  
## See Also  
 [ActiveX Control Containers](../vs140/activex-control-containers.md)