---
title: "ClickOnce Deployment for Visual C++ Applications"
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
  - "deploying applications [C++], ClickOnce"
  - "application deployment [C++], ClickOnce"
  - "ClickOnce deployment [C++], C++ applications"
ms.assetid: 9988c546-0936-452c-932f-9c76daa42157
caps.latest.revision: 21
author: ""
ms.author: ""
manager: ""
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# ClickOnce Deployment for Visual C++ Applications
[!INCLUDE[vsprvs](../vs140/includes/vsprvs_md.md)] provides two different technologies for deploying Windows applications: ClickOnce deployment or [Windows Installer](http://msdn.microsoft.com/library/cc185688) deployment.  
  
## ClickOnce Deployment in C++  
 The [!INCLUDE[vcprvc](../vs140/includes/vcprvc_md.md)] development environment does not directly support deployment of [!INCLUDE[vcprvc](../vs140/includes/vcprvc_md.md)] projects with [!INCLUDE[ndptecclick](../vs140/includes/ndptecclick_md.md)], but tools are available to use it.  
  
> [!NOTE]
>  [!INCLUDE[vsprvs](../vs140/includes/vsprvs_md.md)] does support [!INCLUDE[ndptecclick](../vs140/includes/ndptecclick_md.md)] in the [!INCLUDE[csprcs](../vs140/includes/csprcs_md.md)] and [!INCLUDE[vbprvb](../vs140/includes/vbprvb_md.md)] development environments. If your [!INCLUDE[vcprvc](../vs140/includes/vcprvc_md.md)] project is a dependency of a [!INCLUDE[csprcs](../vs140/includes/csprcs_md.md)] project, you can publish the application (including its dependencies) using [!INCLUDE[ndptecclick](../vs140/includes/ndptecclick_md.md)] deployment from the [!INCLUDE[csprcs](../vs140/includes/csprcs_md.md)] development environment.  
  
 To deploy a [!INCLUDE[vcprvc](../vs140/includes/vcprvc_md.md)] application using [!INCLUDE[ndptecclick](../vs140/includes/ndptecclick_md.md)], you first have to build a [ClickOnce Application Manifest](../vs140/clickonce-application-manifest.md) and a [ClickOnce Deployment Manifest](../vs140/clickonce-deployment-manifest.md) using the [Manifest Generation and Editing Tool (Mage.exe)](assetId:///77dfe576-2962-407e-af13-82255df725a1) or its graphical user interface version (for information, see [Manifest Generation and Editing Tool, Graphical Client (MageUI.exe)](assetId:///f9e130a6-8117-49c4-839c-c988f641dc14)).  
  
 You first use Mage.exe to build the application manifest; the resulting file will have the extension .manifest. You then use Mage.exe to build the deployment manifest; the resulting file will have the extension .application. You then sign the manifests.  
  
 The application manifest must specify the target processor (**x86**, **x64**, or **ARM**). See [Deploying 64-bit Applications](../vs140/deploying-prerequisites-for-64-bit-applications.md) for information on these options.  
  
 Also, the name of the application and deployment manifests must be different from the name of the C++ application. This avoids conflict between the application manifest created by Mage.exe and the external manifest that is part of the C++ application.  
  
 Your deployment will need to install any [!INCLUDE[vcprvc](../vs140/includes/vcprvc_md.md)] libraries on which your application depends. To determine the dependencies for a particular application, you can use depends.exe or the DUMPBIN utility with the /DEPENDENTS option. For more information on dependencies, see [Understanding Dependencies of a Visual C++ Application](../vs140/understanding-the-dependencies-of-a-visual-c---application.md). You might need to run VCRedist.exe; this utility installs [!INCLUDE[vcprvc](../vs140/includes/vcprvc_md.md)] libraries on the target computer.  
  
 You may also need to build a bootstrapper (prerequisites installer) for your application to deploy prerequisite components; for information on the bootstrapper, see [Adding Custom Prerequisites](../vs140/creating-bootstrapper-packages.md).  
  
 For a more detailed description of the technology, see [ClickOnce Deployment](../vs140/clickonce-security-and-deployment.md). For a detailed example of [!INCLUDE[ndptecclick](../vs140/includes/ndptecclick_md.md)] deployment, see [Walkthrough: Deploying a ClickOnce Application Manually](../vs140/walkthrough--manually-deploying-a-clickonce-application.md).  
  
## See Also  
 [Manifest Generation and Editing Tool (Mage.exe)](assetId:///77dfe576-2962-407e-af13-82255df725a1)   
 [Manifest Generation and Editing Tool, Graphical Client (MageUI.exe)](assetId:///f9e130a6-8117-49c4-839c-c988f641dc14)   
 [Certificate Creation Tool (Makecert.exe)](assetId:///b0343f8e-9c41-4852-a85c-f8a0c408cf0d)   
 [Deployment (C++)](../vs140/deploying-native-desktop-applications--visual-c---.md)   
 [Deploying Applications and Components](../vs140/deploying-applications--services--and-components.md)   
 [Windows Installer Deployment](assetId:///121be21b-b916-43e2-8f10-8b080516d2a0)   
 [ClickOnce Deployment](../vs140/clickonce-security-and-deployment.md)   
 [Adding Custom Prerequisites](../vs140/creating-bootstrapper-packages.md)   
 [.NET Programming in C++](../vs140/.net-programming-with-c---cli--visual-c---.md)   
 [Native/.NET Interop in C++](../vs140/native-and-.net-interoperability.md)