---
title: "ExitInstance Member Function"
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
  - "CWinApp::ExitInstance"
  - "CWinApp.ExitInstance"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "programs [C++], terminating"
  - "CWinApp class, ExitInstance"
  - "ExitInstance method"
ms.assetid: 5bb597bd-8dab-4d49-8bcf-9c45aa8be4a2
caps.latest.revision: 11
author: ""
ms.author: ""
manager: ""
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# ExitInstance Member Function
The [ExitInstance](../vs140/cwinapp--exitinstance.md) member function of class [CWinApp](../vs140/cwinapp-class.md) is called each time a copy of your application terminates, usually as a result of the user quitting the application.  
  
 Override `ExitInstance` if you need special cleanup processing, such as freeing graphics device interface (GDI) resources or deallocating memory used during program execution. Cleanup of standard items such as documents and views, however, is provided by the framework, with other overridable functions for doing special cleanup specific to those objects.  
  
## See Also  
 [CWinApp: The Application Class](../vs140/cwinapp--the-application-class.md)