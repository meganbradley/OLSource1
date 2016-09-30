---
title: "MSBuild Target Framework and Target Platform"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "vs-ide-sdk"
ms.tgt_pltfrm: na
ms.topic: "article"
ms.assetid: df6517c5-edd6-4cc4-97ad-b3cdfc78e799
caps.latest.revision: 14
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# MSBuild Target Framework and Target Platform
A project can be built to run on a *target framework*, which is a particular version of the .NET Framework, and a *target platform*, which is a particular software architecture.  For example, you can target an application to run on the .NET Framework 2.0 on a 32-bit platform that is compatible with the 802x86 processor family (“x86”). The combination of target framework and target platform is known as the *target context*.  
  
## Target Framework and Profile  
 A target framework is the particular version of the [!INCLUDE[dnprdnshort](../vs140/includes/dnprdnshort_md.md)] that your project is built to run on. Specification of a target framework is required because it enables compiler features and assembly references that are exclusive to that version of the framework.  
  
 Currently, the following versions of the .NET Framework are available for use:  
  
-   The [!INCLUDE[dnprdnshort](../vs140/includes/dnprdnshort_md.md)] 2.0 (included in Visual Studio 2005)  
  
-   The [!INCLUDE[dnprdnshort](../vs140/includes/dnprdnshort_md.md)] 3.0 (included in [!INCLUDE[wiprlhext](../vs140/includes/wiprlhext_md.md)])  
  
-   The [!INCLUDE[dnprdnshort](../vs140/includes/dnprdnshort_md.md)] 3.5 (included in [!INCLUDE[vs_orcas_long](../vs140/includes/vs_orcas_long_md.md)])  
  
-   The [!INCLUDE[dnprdnshort](../vs140/includes/dnprdnshort_md.md)] 4 (included in Visual Studio 2010)  
  
-   The [!INCLUDE[dnprdnshort](../vs140/includes/dnprdnshort_md.md)] 4.5 (included in [!INCLUDE[vs_dev11_long](../vs140/includes/vs_dev11_long_md.md)])  
  
-   The [!INCLUDE[dnprdnshort](../vs140/includes/dnprdnshort_md.md)] 4.5.1 (included in [!INCLUDE[vs_dev12](../vs140/includes/vs_dev12_md.md)])  
  
-   The [!INCLUDE[dnprdnshort](../vs140/includes/dnprdnshort_md.md)] 4.5.2  
  
-   The [!INCLUDE[dnprdnshort](../vs140/includes/dnprdnshort_md.md)] 4.6 (included in [!INCLUDE[vs_dev14](../vs140/includes/vs_dev14_md.md)])  
  
 The versions of the .NET Framework differ from one another in the list of assemblies that each makes available to reference. For example, you cannot build Windows Presentation Foundation (WPF) applications unless your project targets the .NET Framework version 3.0 or above.  
  
 The target framework is specified in the <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> property in the project file. You can change the target framework for a project by using the project property pages in the Visual Studio integrated development environment (IDE). For more information, see [How To: Target a Specific .NET Framework](../vs140/how-to--target-a-version-of-the-.net-framework.md). The available values for <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> are <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>7\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>8\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>9\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>10\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>11\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>12\</CodeContentPlaceHolder>, and <CodeContentPlaceHolder>13\</CodeContentPlaceHolder>.  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
 A *target profile* is a subset of a target framework. For example, the .NET Framework 4 Client profile does not include references to the MSBuild assemblies.  
  
 The target profile is specified in the <CodeContentPlaceHolder>14\</CodeContentPlaceHolder> property in a project file. You can change the target profile by using the target-framework control in the project property pages in the IDE. For more information, see [How To: Target a Specific .NET Framework](../vs140/how-to--target-a-version-of-the-.net-framework.md).  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
## Target Platform  
 A *platform* is combination of hardware and software that defines a particular runtime environment. For example,  
  
-   <CodeContentPlaceHolder>15\</CodeContentPlaceHolder> designates a 32-bit Windows operating system that is running on an Intel 80x86 processor or its equivalent.  
  
-   <CodeContentPlaceHolder>16\</CodeContentPlaceHolder> designates the Microsoft Xbox 360 platform.  
  
 A *target platform* is the particular platform that your project is built to run on. The target platform is specified in the <CodeContentPlaceHolder>17\</CodeContentPlaceHolder> build property in a project file. You can change the target platform by using the project property pages or the **Configuration Manager** in the IDE.  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 A *target configuration* is a subset of a target platform. For example, the <CodeContentPlaceHolder>18\</CodeContentPlaceHolder> configuration does not include most code optimizations. The target configuration is specified in the <CodeContentPlaceHolder>19\</CodeContentPlaceHolder> build property in a project file. You can change the target configuration by using the project property pages or the **Configuration Manager**.  
  
<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
## See Also  
 [Multitargeting](../vs140/msbuild-multitargeting-overview.md)