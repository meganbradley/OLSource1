---
title: "ActiveX Control Containers: Connecting an ActiveX Control to a Member Variable"
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
  - ActiveX control containers [C++], accessing ActiveX controls
  - ActiveX controls [C++], member variables of project
  - connecting ActiveX controls to container member variables
  - ActiveX controls [C++], accessing
  - member variables [C++], ActiveX controls in project
  - ActiveX control containers [C++], ActiveX controls as member variables
ms.assetid: 7898a336-440d-4a60-be43-cb062b807aee
caps.latest.revision: 11
translation.priority.ht: 
  - de-de
  - ja-jp
---
# ActiveX Control Containers: Connecting an ActiveX Control to a Member Variable
The easiest way to access an ActiveX control from within its control container application is to associate the ActiveX control with a member variable of the dialog class that will contain the control.  
  
> [!NOTE]
>  This is not the only way to access an embedded control from within a container class, but for the purposes of this article it is sufficient.  
  
### Adding a member variable to the dialog class  
  
1.  From Class View, right-click the main dialog class to open the shortcut menu. For example, `CContainerDlg`.  
  
2.  From the shortcut menu, click **Add** and then **Add Variable**.  
  
3.  In the Add Member Variable Wizard, click **Control variable**.  
  
4.  In the **Control ID** list box, select the control ID of the embedded ActiveX control. For example, `IDC_CIRCCTRL1`.  
  
5.  In the **Variable Name** box, enter a name.  
  
     For example, `m_circctl`.  
  
6.  Click **Finish** to accept your choices and exit the Add Member Variable Wizard.  
  
## See Also  
 [ActiveX Control Containers](../vs140/activex-control-containers.md)