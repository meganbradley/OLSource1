---
title: "Deployment Concepts"
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
  - "Windows Installer [C++]"
  - "dependencies [C++], application deployment and"
  - "application deployment [C++], about application deployment"
  - "deploying applications [C++], about deploying applications"
  - "libraries [C++], application deployment issues"
ms.assetid: ebd7f246-ab54-40e8-87fa-dac02c0047b3
caps.latest.revision: 15
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Deployment Concepts
This section discusses the main considerations for deploying C++ applications.  
  
## Windows Installer Deployment in C++  
 Visual C++ projects typically use the traditional Windows Installer setup for deployment. To prepare a Windows Installer deployment, you package your application in a setup.exe file and distribute that file, together with an installer package (.msi). Users then run setup.exe to install your application.  
  
 You package your application by adding a Setup project to your solution; when built, it creates the setup and installer package files that you distribute to users. For more information, see [Choosing a Deployment Method](../VS_csharp/choosing-a-deployment-method.md).  
  
## Library Dependencies  
 When a C/C++ application is built using functionality provided by the Visual C++ libraries, it becomes dependent on the presence of those libraries at runtime. In order for the application to run, it must link, either statically or dynamically, to the necessary Visual C++ libraries. If an application dynamically links to a Visual C++ library, then when it runs that library must be present so it can be loaded. On the other hand, if the application statically links to a Visual C++ library, then it does not need the corresponding DLLs to be present on the user's computer. Static linking, however, has some negative effects, such as the increasing the size of the application files, and making maintenance potentially more difficult. For more information, see [Advantages of Using DLLs](../VS_csharp/advantages-of-using-dlls.md).  
  
## Packaging and Redistributing  
 Visual C++ libraries are packaged as DLLs, and all necessary libraries for C/C++ applications are installed by Visual Studio on the developer's computer. However, when deploying your application to your users, it is not feasible in most cases to require them to install Visual Studio in order to run your application. It is important to be able to redistribute just the parts of Visual C++ that are required by your application to run correctly.  
  
 For more information about packaging and redistributing, see the following topics:  
  
-   [Determining Which DLLs to Redistribute](../VS_csharp/determining-which-dlls-to-redistribute.md).  
  
-   [Choosing a Deployment Method](../VS_csharp/choosing-a-deployment-method.md).  
  
 For deployment examples and suggestions about troubleshooting, see:  
  
-   [Deployment Examples](../VS_csharp/deployment-examples.md).  
  
-   [Troubleshooting C/C++ Isolated Applications and Side-by-side Assemblies](../VS_csharp/troubleshooting-c-c---isolated-applications-and-side-by-side-assemblies.md).  
  
## See Also  
 [Deployment (C++)](../VS_csharp/deploying-native-desktop-applications--visual-c---.md)   
 [Understanding Dependencies of a Visual C++ Application](../VS_csharp/understanding-the-dependencies-of-a-visual-c---application.md)   
 [Windows Installer Deployment](assetId:///121be21b-b916-43e2-8f10-8b080516d2a0)