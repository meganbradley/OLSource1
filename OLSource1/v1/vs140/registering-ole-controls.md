---
title: "Registering OLE Controls"
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
  - "vc.mfc.macros.ole"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "registering OLE controls"
  - "OLE controls, registering"
ms.assetid: 73c45b7f-7dbc-43f5-bd17-dd77c6acec72
caps.latest.revision: 12
author: ""
ms.author: ""
manager: ""
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Registering OLE Controls
OLE controls, like other OLE server objects, can be accessed by other OLE-aware applications. This is achieved by registering the control's type library and class.  
  
 The following functions allow you to add and remove the control's class, property pages, and type library in the Windows registration database:  
  
### Registering OLE Controls  
  
|||  
|-|-|  
|[AfxOleRegisterControlClass](../vs140/afxoleregistercontrolclass.md)|Adds the control's class to the registration database.|  
|[AfxOleRegisterPropertyPageClass](../vs140/afxoleregisterpropertypageclass.md)|Adds a control property page to the registration database.|  
|[AfxOleRegisterTypeLib](../vs140/afxoleregistertypelib.md)|Adds the control's type library to the registration database.|  
|[AfxOleUnregisterClass](../vs140/afxoleunregisterclass.md)|Removes a control class or a property page class from the registration database.|  
|[AfxOleUnregisterTypeLib](../vs140/afxoleunregistertypelib.md)|Removes the control's type library from the registration database.|  
  
 `AfxOleRegisterTypeLib` is typically called in a control DLL's implementation of `DllRegisterServer`. Similarly, `AfxOleUnregisterTypeLib` is called by `DllUnregisterServer`. `AfxOleRegisterControlClass`, `AfxOleRegisterPropertyPageClass`, and `AfxOleUnregisterClass` are typically called by the `UpdateRegistry` member function of a control's class factory or property page.  
  
## See Also  
 [Macros and Globals](../vs140/mfc-macros-and-globals.md)