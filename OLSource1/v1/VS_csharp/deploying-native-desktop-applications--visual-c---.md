---
title: "Deploying Native Desktop Applications (Visual C++)"
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
  - "deploying applications [C++]"
  - "application deployment [C++]"
  - "Visual C++, application deployment"
  - "application deployment [C++], about application deployment"
  - "deploying applications [C++], about deploying applications"
  - "distributing applications [C++]"
ms.assetid: 37f1691e-d67c-41e4-926e-528a237a9bac
caps.latest.revision: 32
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Deploying Native Desktop Applications (Visual C++)
Deployment is the process by which you distribute a finished application or component to be installed on other computers. Deployment planning starts when an application is created on a developer's computer. Deployment ends when the application is installed and ready to run on a user's computer.  
  
 Visual Studio provides different technologies for deploying Windows applications. These include [!INCLUDE[ndptecclick](../VS_csharp/includes/ndptecclick_md.md)] deployment and Windows Installer deployment.  
  
-   [!INCLUDE[ndptecclick](../VS_csharp/includes/ndptecclick_md.md)] can be used to deploy C++ applications that target the common language runtime (CLR)—mixed, pure, and verifiable assemblies. Although you can use Windows Installer to deploy a managed application, we recommend that you use [!INCLUDE[ndptecclick](../VS_csharp/includes/ndptecclick_md.md)] because it takes advantage of .NET Framework security features such as manifest signing. [!INCLUDE[ndptecclick](../VS_csharp/includes/ndptecclick_md.md)] does not support deployment of native C++ applications. For more information, see [ClickOnce Deployment for Visual C++ Applications](../VS_csharp/clickonce-deployment-for-visual-c---applications.md).  
  
-   Windows Installer technology can be used to deploy either native C++ applications or C++ applications that target the CLR.  
  
 The articles in this section of the documentation discuss how to ensure that a native Visual C++ application runs on any computer that provides a supported target platform, which files you must include in an installation package, and the recommended ways to redistribute the components that your application depends on.  
  
## In This Section  
 [Deployment in Visual C++](../VS_csharp/deployment-in-visual-c--.md)  
  
 [Deployment Concepts](../VS_csharp/deployment-concepts.md)  
  
 [Understanding Dependencies of a Visual C++ Application](../VS_csharp/understanding-the-dependencies-of-a-visual-c---application.md)  
  
 [Determining Which DLLs to Redistribute](../VS_csharp/determining-which-dlls-to-redistribute.md)  
  
 [Choosing a Deployment Method](../VS_csharp/choosing-a-deployment-method.md)  
  
 [Redistributing Visual C++ Files](../VS_csharp/redistributing-visual-c---files.md)  
  
 [Deployment Examples](../VS_csharp/deployment-examples.md)  
  
 [Redistributing Web Applications](../VS_csharp/redistributing-web-client-applications.md)  
  
 [ClickOnce Deployment for Visual C++ Applications](../VS_csharp/clickonce-deployment-for-visual-c---applications.md)  
  
 [Running a C++ /clr Application on a Previous Runtime Version](../VS_csharp/running-a-c----clr-application-on-a-previous-runtime-version.md)  
  
## Related Sections  
 [Building C/C++ Isolated Applications and Side-by-side Assemblies](../VS_csharp/building-c-c---isolated-applications-and-side-by-side-assemblies.md)  
  
 [Deploying .NET Framework Applications](assetId:///238d8284-6042-4a38-a7f6-1ee8efd719da)  
  
 [Troubleshooting C/C++ Isolated Applications and Side-by-side Assemblies](../VS_csharp/troubleshooting-c-c---isolated-applications-and-side-by-side-assemblies.md)