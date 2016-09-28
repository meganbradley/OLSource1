---
title: "CWinApp and the MFC Application Wizard"
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
  - "CWinApp"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "application wizards [C++], and CWinApp"
  - "CWinApp class, and MFC Application Wizard"
  - "MFC [C++], wizards"
ms.assetid: f8ac0491-3302-4e46-981d-0790624eb8a2
caps.latest.revision: 11
author: ""
ms.author: ""
manager: ""
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CWinApp and the MFC Application Wizard
When it creates a skeleton application, the MFC Application Wizard declares an application class derived from [CWinApp](../vs140/cwinapp-class.md). The MFC Application Wizard also generates an implementation file that contains the following items:  
  
-   A message map for the application class.  
  
-   An empty class constructor.  
  
-   A variable that declares the one and only object of the class.  
  
-   A standard implementation of your `InitInstance` member function.  
  
 The application class is placed in the project header and main source files. The names of the class and files created are based on the project name you supply in the MFC Application Wizard. The easiest way to view the code for these classes is through [Class View](assetId:///8d7430a9-3e33-454c-a9e1-a85e3d2db925).  
  
 The standard implementations and message map supplied are adequate for many purposes, but you can modify them as needed. The most interesting of these implementations is the `InitInstance` member function. Typically, you will add code to the skeletal implementation of `InitInstance`.  
  
## See Also  
 [CWinApp: The Application Class](../vs140/cwinapp--the-application-class.md)   
 [Overridable CWinApp Member Functions](../vs140/overridable-cwinapp-member-functions.md)   
 [Special CWinApp Services](../vs140/special-cwinapp-services.md)