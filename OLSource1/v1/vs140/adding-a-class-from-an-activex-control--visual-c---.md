---
title: "Adding a Class from an ActiveX Control (Visual C++)"
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
  - ActiveX controls [C++], adding classes
  - classes [C++], creating
ms.assetid: 729fcb37-54b8-44d5-9b4e-50bb16e0eea4
caps.latest.revision: 12
translation.priority.ht: 
  - de-de
  - ja-jp
---
# Adding a Class from an ActiveX Control (Visual C++)
Use this wizard to create an MFC class from an interface in an available ActiveX control. You can add an MFC class to an [MFC application](../vs140/creating-an-mfc-application.md), an [MFC DLL](../vs140/creating-an-mfc-dll-project.md), or an [MFC ActiveX control](../vs140/creating-an-mfc-activex-control.md).  
  
> [!NOTE]
>  You do not need to create your MFC project with Automation enabled to add a class from an ActiveX control.  
  
 An ActiveX control is a reusable software component based on the Component Object Model (COM) that supports a wide variety of OLE functionality and can be customized to fit many software needs. ActiveX controls are designed for use both in ordinary ActiveX control containers and on the Internet in World Wide Web pages.  
  
### To add an MFC class from an ActiveX control  
  
1.  In either **Solution Explorer** or [Class View](assetId:///8d7430a9-3e33-454c-a9e1-a85e3d2db925), right-click the name of the project to which you want to add the ActiveX control class.  
  
2.  From the shortcut menu, click **Add**, and then click **Add Class**.  
  
3.  In the [Add Class](../vs140/add-class-dialog-box.md) dialog box, in the Templates pane, click **MFC Class from ActiveX Control**, and then click **Open** to display the [Add Class from ActiveX Control Wizard](../vs140/add-class-from-activex-control-wizard.md).  
  
 In the wizard, you can add more than one interface in an ActiveX control. Likewise, you can create classes from more than one ActiveX control in a single wizard session.  
  
 You can add classes from ActiveX controls registered in your system, or you can add classes from ActiveX controls located in type library files (.tlb, .olb, .dll, .ocx, or .exe) without first registering them in your system. See [Registering OLE Controls](../vs140/registering-ole-controls.md) for more information on registering ActiveX controls.  
  
 The wizard creates an MFC class, derived from [CWnd](../vs140/cwnd-class.md) or from [COleDispatchDriver](../vs140/coledispatchdriver-class.md), for each interface you add from the selected ActiveX control.  
  
## See Also  
 [MFC ActiveX Controls](../vs140/mfc-activex-controls.md)   
 [Introduction to COM and ATL](../vs140/introduction-to-com-and-atl.md)