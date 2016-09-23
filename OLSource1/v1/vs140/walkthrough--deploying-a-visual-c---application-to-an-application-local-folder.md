---
title: "Walkthrough: Deploying a Visual C++ Application to an Application-local Folder"
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
  - deploying Visual C++ applications
ms.assetid: 47a81c47-9dbe-47c6-96cc-fbb2fda5e6ad
caps.latest.revision: 11
translation.priority.ht: 
  - de-de
  - ja-jp
---
# Walkthrough: Deploying a Visual C++ Application to an Application-local Folder
Describes how to deploy a Visual C++ application by copying files to its folder.  
  
## Prerequisites  
  
-   A computer that has Visual Studio installed.  
  
-   Another computer that does not have the Visual C++ libraries.  
  
### To deploy an application to an application-local folder  
  
1.  Create and build an MFC application by following the steps in [Walkthrough: Deploying a Visual C++ Application by using a Setup Project](../vs140/walkthrough--deploying-a-visual-c---application-by-using-a-setup-project.md).  
  
2.  Copy the appropriate MFC and C Run-Time (CRT) library files—for example, for an x86 platform and Unicode support, copy mfc100u.dll and msvcr100.dll from \Program Files\Microsoft Visual Studio 10.0\VC\redist\x86\—and then paste them in the \Release\ folder of your MFC project. For more information about other files that you might have to copy, see [Determining Which DLLs to Redistribute](../vs140/determining-which-dlls-to-redistribute.md).  
  
3.  Run the MFC application on a second computer that does not have the Visual C++ libraries.  
  
    1.  Copy the contents of the \Release\ folder and paste them in the application folder on the second computer.  
  
    2.  Run the application on the second computer.  
  
     The application runs successfully because the Visual C++ libraries are available in the application-local folder.  
  
## See Also  
 [Deployment Examples](../vs140/deployment-examples.md)