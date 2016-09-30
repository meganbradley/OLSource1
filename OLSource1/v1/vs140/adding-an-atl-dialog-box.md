---
title: "Adding an ATL Dialog Box"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-cpp"
ms.tgt_pltfrm: na
ms.topic: "reference"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "ATL projects, adding dialog resources"
  - "MFC dialog boxes, ATL dialogs"
  - "dialog boxes, ATL"
ms.assetid: 152a378f-7b24-4f66-aeba-c740973f03a6
caps.latest.revision: 12
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Adding an ATL Dialog Box
To add an ATL dialog to your project, your project must be either an ATL project or an MFC project that includes ATL support. You can use the [ATL Project Wizard](../vs140/atl-project-wizard.md) to create an ATL application, or [add an ATL object to your MFC application](../vs140/adding-atl-support-to-your-mfc-project.md) to implement ATL support for an MFC application.  
  
 By default, the ATL Dialog Wizard implements a dialog box derived from [CAxDialogImpl](../vs140/caxdialogimpl-class.md). This class includes support for hosting ActiveX and Windows controls. If you do not want the overhead of ActiveX control support, once the wizard has generated your code, replace all instances of <CodeContentPlaceHolder>0\</CodeContentPlaceHolder> with either [CSimpleDialog](../vs140/csimpledialog-class.md) or [CDialogImpl](../vs140/cdialogimpl-class.md) as your base class.  
  
> [!NOTE]
>  <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> creates only modal dialog boxes that support only Windows common controls. <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> creates either modal or modeless dialog boxes.  
  
### To add an ATL dialog resource to your project  
  
1.  Create an ATL project using the [ATL Project Wizard](../vs140/atl-project-wizard.md).  
  
2.  From [Class View](assetId:///8d7430a9-3e33-454c-a9e1-a85e3d2db925), right-click the project name and click **Add** from the shortcut menu. Click **Add Class**.  
  
3.  In the Templates pane of the [Add Class](../vs140/add-class-dialog-box.md) dialog box, click **ATL Dialog**. Click **Open** to display the [ATL Dialog Wizard](../vs140/atl-dialog-wizard.md).  
  
 For more information, see [Implementing a Dialog Box](../vs140/implementing-a-dialog-box.md).  
  
## See Also  
 [Adding a Class](../vs140/adding-a-class--visual-c---.md)   
 [Window Classes](../vs140/atl-window-classes.md)   
 [Message Maps](../vs140/message-maps--atl-.md)