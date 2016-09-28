---
title: "Adding an MFC Class"
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
  - "vc.codewiz.classes.adding.mfc"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "classes [C++], adding MFC"
  - "MFC, adding classes"
ms.assetid: 9a96b67f-40bf-43d4-8872-2f8dfc5404f1
caps.latest.revision: 15
author: ""
ms.author: ""
manager: ""
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Adding an MFC Class
To add classes derived from Microsoft Foundation Class (MFC) library classes to your project, use the **Add Class** command available from [Class View](assetId:///8d7430a9-3e33-454c-a9e1-a85e3d2db925). Specify the name of the new class, select the base class, and select the ID of the dialog box with which it is associated (if any). The code wizard creates a header file and an implementation file and adds them to your project.  
  
> [!NOTE]
>  You can add MFC classes to an ATL COM application if you initially [created the application with MFC support](../vs140/mfc-support-in-atl-projects.md). You can also add MFC classes to Win32 projects that have MFC support.  
  
### To add an MFC class to your project  
  
1.  From Class View, right-click the project name. Click **Add** and then click **Add Class** to open the [Add Class](../vs140/add-class-dialog-box.md) dialog box.  
  
2.  In the Templates pane, select **MFC Class** and press the **Add** button.  
  
3.  Define the settings for the new class in the [MFC Class Wizard](../vs140/mfc-add-class-wizard.md) dialog box.  
  
4.  Click **Finish** to close the wizard and view the new class in Class View. You can also view the files created by the wizard in **Solution Explorer**.  
  
## See Also  
 [Adding Functionality with Code Wizards](../vs140/adding-functionality-with-code-wizards--c---.md)   
 [Adding a Class](../vs140/adding-a-class--visual-c---.md)   
 [Class Overview](../vs140/class-library-overview.md)