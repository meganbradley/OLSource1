---
title: "How to: Install the Visual Studio Tools for Office Runtime Redistributable"
ms.custom: na
ms.date: "10/01/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.tgt_pltfrm: na
ms.topic: "article"
dev_langs: 
  - "VB"
  - "CSharp"
helpviewer_keywords: 
  - "Office runtime [Office development in Visual Studio]"
  - "installing Office development tools in Visual Studio"
ms.assetid: ac7a9ad3-e810-4d7f-a0e2-9992c9036b8d
caps.latest.revision: 94
ms.author: "normesta"
manager: "ghogen"
translation.priority.ht: 
  - "cs-cz"
  - "de-de"
  - "es-es"
  - "fr-fr"
  - "it-it"
  - "ja-jp"
  - "ko-kr"
  - "pl-pl"
  - "pt-br"
  - "ru-ru"
  - "tr-tr"
  - "zh-cn"
  - "zh-tw"
---
# How to: Install the Visual Studio Tools for Office Runtime Redistributable
  The Visual Studio 2010 Tools for Office Runtime must be installed on each computer that runs solutions that are created by using the Microsoft Office developer tools in [!INCLUDE[vsprvs](../VS_officedev/includes/vsprvs_md.md)]. The runtime is installed automatically when you install [!INCLUDE[vsprvs](../VS_officedev/includes/vsprvs_md.md)], and Microsoft Office. For more information, see [Visual Studio Tools for Office Runtime Installation Scenarios](../VS_officedev/visual-studio-tools-for-office-runtime-installation-scenarios.md).  
  
 You might need to follow the manual installation instructions below in the following situations:  
  
-   You need to install the [!INCLUDE[vsto_runtime](../VS_officedev/includes/vsto_runtime_md.md)] on a server. For example, you want to use the \<xref:Microsoft.VisualStudio.Tools.Applications.ServerDocument> class to manage document-level solutions on a server.  
  
-   You need to install the runtime on a computer that already has all the other prerequisites for Office solutions installed.  
  
    > [!NOTE]  
    >  You must be an administrator on the development computer to install the .NET Framework and the [!INCLUDE[vsto_runtime](../VS_officedev/includes/vsto_runtime_md.md)].  
  
### To install the Visual Studio Tools for Office runtime  
  
1.  Install the [!INCLUDE[net_v40_short](../VS_officedev/includes/net_v40_short_md.md)] or later.  
  
    -   To download the [!INCLUDE[net_v40_short](../VS_officedev/includes/net_v40_short_md.md)], see [Microsoft .NET Framework 4 (Web Installer)](http://go.microsoft.com/fwlink/?LinkId=178957).  
  
    -   To download the [!INCLUDE[net_client_v40_long](../VS_officedev/includes/net_client_v40_long_md.md)], see [Microsoft .NET Framework 4 Client Profile (Web Installer)](http://go.microsoft.com/fwlink/?LinkId=178958).  
  
    -   To download the [!INCLUDE[net_v45](../VS_officedev/includes/net_v45_md.md)], see [Microsoft .NET Framework 4.5](http://www.microsoft.com/download/details.aspx?id=30653).  
  
2.  Run vstor_redist.exe to install the [!INCLUDE[vsto_runtime](../VS_officedev/includes/vsto_runtime_md.md)].  
  
     You can download these setup files from [Visual Studio 2010 Tools for Office Runtime](http://go.microsoft.com/fwlink/?LinkId=140384). The prerequisites for the [!INCLUDE[vsto_runtime](../VS_officedev/includes/vsto_runtime_md.md)] match the prerequisites for the .NET Framework.  
  
     The [!INCLUDE[vsto_runtime](../VS_officedev/includes/vsto_runtime_md.md)]includes language packs. If your installation of Windows is set to a language other than English, you can display runtime messages in the same language that you use for Windows. Similarly, if end users install the [!INCLUDE[vsto_runtime](../VS_officedev/includes/vsto_runtime_md.md)] and then run your solutions on installations of Windows that are set to a language other than English, runtime messages will appear in the same language as Windows. In some cases, you might need additional language packs. For example, you might need additional language packs if your copy of Windows uses more than one language setting, or you switch to another language after you’ve already installed the [!INCLUDE[vsto_runtime](../VS_officedev/includes/vsto_runtime_md.md)]. You can find language packs at [Microsoft Visual Studio 2010 Tools for the Microsoft Office System (Version 4.0 Runtime) Language Pack](http://go.microsoft.com/fwlink/?LinkId=140386).  
  
## See Also  
 [Getting Started &#40;Office Development in Visual Studio&#41;](../VS_officedev/getting-started--office-development-in-visual-studio-.md)   
 [Configuring a Computer to Develop Office Solutions](../VS_officedev/configuring-a-computer-to-develop-office-solutions.md)   
 [How to: Configure a Computer to Develop Office Solutions](../VS_officedev/how-to--configure-a-computer-to-develop-office-solutions.md)   
 [How to: Install Office Primary Interop Assemblies](../VS_officedev/how-to--install-office-primary-interop-assemblies.md)   
 [Managing Documents on a Server by Using the ServerDocument Class](../VS_officedev/managing-documents-on-a-server-by-using-the-serverdocument-class.md)   
 [Deploying an Office Solution](../VS_officedev/deploying-an-office-solution.md)  
  
  