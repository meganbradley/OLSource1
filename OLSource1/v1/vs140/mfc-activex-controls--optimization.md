---
title: "MFC ActiveX Controls: Optimization"
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
  - "MFC ActiveX controls, windowless"
  - "flicker-free ActiveX controls"
  - "MFC ActiveX controls, mouse interaction"
  - "device contexts, unclipped for MFC ActiveX controls"
  - "MFC ActiveX controls, optimizing"
  - "performance, ActiveX controls"
  - "optimization, ActiveX controls"
  - "MFC ActiveX controls, flicker-free"
  - "windowless MFC ActiveX controls"
  - "MFC ActiveX controls, active/inactive state"
  - "optimizing performance, ActiveX controls"
ms.assetid: 8b11f26a-190d-469b-b594-5336094a0109
caps.latest.revision: 10
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# MFC ActiveX Controls: Optimization
This article explains techniques you can use to optimize your ActiveX controls for better performance.  
  
 The topics [Turning Off the Activate When Visible Option](../vs140/turning-off-the-activate-when-visible-option.md) and [Providing Mouse Interaction While Inactive](../vs140/providing-mouse-interaction-while-inactive.md) discuss controls that don't create a window until activated. The topic [Providing Windowless Activation](../vs140/providing-windowless-activation.md) discusses controls that never create a window, even when they are activated.  
  
 Windows have two major drawbacks for OLE objects: they prevent objects from being transparent or nonrectangular when active, and they add a large overhead to the instantiation and display of controls. Typically, creating a window takes 60 percent of a control's creation time. With a single shared window (usually the container's) and some dispatching code, a control receives the same window services, generally without a loss of performance. Having a window is mostly unnecessary overhead for the object.  
  
 Some optimizations do not necessarily improve performance when your control is used in certain containers. For example, containers released prior to 1996 did not support windowless activation, so implementing this feature will not provide a benefit in older containers. However, nearly every container supports persistence, so optimizing your control's persistence code will likely improve its performance in any container. If your control is specifically intended to be used with one particular type of container, you may want to research which of these optimizations is supported by that container. In general, however, you should try to implement as many of these techniques as are applicable to your particular control to ensure your control performs as well as it possibly can in a wide array of containers.  
  
 You can implement many of these optimizations through the [MFC ActiveX Control Wizard](../vs140/mfc-activex-control-wizard.md), on the [Control Settings](../vs140/control-settings--mfc-activex-control-wizard.md) page.  
  
### MFC ActiveX Control Wizard OLE Optimization Options  
  
|Control setting in the MFC ActiveX Control Wizard|Action|More information|  
|-------------------------------------------------------|------------|----------------------|  
|**Activate when visible** check box|Clear|[Turning Off the Activate When Visible Option](../vs140/turning-off-the-activate-when-visible-option.md)|  
|**Windowless activation** check box|Select|[Providing Windowless Activation](../vs140/providing-windowless-activation.md)|  
|**Unclipped device context** check box|Select|[Using an Unclipped Device Context](../vs140/using-an-unclipped-device-context.md)|  
|**Flicker-free activation** check box|Select|[Providing Flicker-Free Activation](../vs140/providing-flicker-free-activation.md)|  
|**Mouse pointer notifications when inactive** check box|Select|[Providing Mouse Interaction While Inactive](../vs140/providing-mouse-interaction-while-inactive.md)|  
|**Optimized drawing code** check box|Select|[Optimizing Control Drawing](../vs140/optimizing-control-drawing.md)|  
  
 For detailed information about the member functions that implement these optimizations, see [COleControl](../vs140/colecontrol-class.md). The member functions are listed by use, such as [Windowless Operations](assetId:///e9e28f79-9a70-4ae4-a5aa-b3e92f1904df) and [Inactive Pointer Handling Functions](assetId:///e9e28f79-9a70-4ae4-a5aa-b3e92f1904df).  
  
 For more information, see:  
  
-   [Optimizing Persistence and Initialization](../vs140/optimizing-persistence-and-initialization.md)  
  
-   [Providing Windowless Activation](../vs140/providing-windowless-activation.md)  
  
-   [Turning Off the Activate When Visible Option](../vs140/turning-off-the-activate-when-visible-option.md)  
  
-   [Providing Mouse Interaction While Inactive](../vs140/providing-mouse-interaction-while-inactive.md)  
  
-   [Providing Flicker-Free Activation](../vs140/providing-flicker-free-activation.md)  
  
-   [Using an Unclipped Device Context](../vs140/using-an-unclipped-device-context.md)  
  
-   [Optimizing Control Drawing](../vs140/optimizing-control-drawing.md)  
  
## See Also  
 [MFC ActiveX Controls](../vs140/mfc-activex-controls.md)