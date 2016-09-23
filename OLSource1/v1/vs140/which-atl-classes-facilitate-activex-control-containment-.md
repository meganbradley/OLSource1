---
title: "Which ATL Classes Facilitate ActiveX Control Containment?"
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
  - hosting controls using ATL
  - ActiveX control containers [C++], ATL control hosting
ms.assetid: 803a4605-7f4c-4139-8638-49d8783d31b0
caps.latest.revision: 13
translation.priority.ht: 
  - de-de
  - ja-jp
---
# Which ATL Classes Facilitate ActiveX Control Containment?
ATL's control-hosting code doesn't require you to use any ATL classes; you can simply create an **"AtlAxWin80"** window and use the control-hosting API if necessary (for more information, see [What Is the ATL Control-Hosting API?](../vs140/what-is-the-atl-control-hosting-api-.md)). However, the following classes make the containment features easier to use.  
  
|Class|Description|  
|-----------|-----------------|  
|[CAxWindow](../vs140/caxwindow-class.md)|Wraps an **"AtlAxWin80"** window, providing methods for creating the window, creating a control and/or attaching a control to the window, and retrieving interface pointers on the host object.|  
|[CAxWindow2T](../vs140/caxwindow2t-class.md)|Wraps an **"AtlAxWinLic80"** window, providing methods for creating the window, creating a control and/or attaching a licensed control to the window, and retrieving interface pointers on the host object.|  
|[CComCompositeControl](../vs140/ccomcompositecontrol-class.md)|Acts as a base class for ActiveX control classes based on a dialog resource. Such controls can contain other ActiveX controls.|  
|[CAxDialogImpl](../vs140/caxdialogimpl-class.md)|Acts as a base class for dialog classes based on a dialog resource. Such dialogs can contain ActiveX controls.|  
|[CWindow](../vs140/cwindow-class.md)|Provides a method, [GetDlgControl](../vs140/cwindow--getdlgcontrol.md), that will return an interface pointer on a control, given the ID of its host window. In addition, the Windows API wrappers exposed by `CWindow` generally make window management easier.|  
  
## See Also  
 [Control Containment FAQ](../vs140/atl-control-containment-faq.md)