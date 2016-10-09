---
title: "How to: Create a SharePoint Command"
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
  - "SharePoint commands [SharePoint development in Visual Studio], creating"
ms.assetid: e1fda8f0-eae1-4278-91c1-19a5e1fc327f
caps.latest.revision: 22
ms.author: "kempb"
manager: "douge"
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
# How to: Create a SharePoint Command
  If you want to use the server object model in a SharePoint tools extension, you must create a custom *SharePoint command* to call the API. You define the SharePoint command in an assembly that can call into the server object model directly.  
  
 For more information about the purpose of SharePoint commands, see [Calling into the SharePoint Object Models](../VS_officedev/calling-into-the-sharepoint-object-models.md).  
  
### To create a SharePoint command  
  
1.  Create a class library project that has the following configuration:  
  
    -   Targets the .NET Framework 3.5. For more information about selecting the target framework, see [How to: Target a Version of the .NET Framework](../Topic/How%20to:%20Target%20a%20Version%20of%20the%20.NET%20Framework.md).  
  
    -   Targets the AnyCPU or x64 platform. By default, the target platform for class library projects is AnyCPU. For more information about selecting the target platform, see [NIB: How to: Optimize an Application for a Specific CPU Type](assetId:///294a75d2-4279-4b72-8298-2bea05be907a).  
  
    > [!NOTE]  
    >  You cannot implement a SharePoint command in the same project that defines a SharePoint tools extension, because SharePoint commands target the .NET Framework 3.5 and SharePoint tools extensions target the [!INCLUDE[net_v40_short](../VS_officedev/includes/net_v40_short_md.md)]. You must define any SharePoint commands that are used by your extension in a separate project. For more information, see [Deploying Extensions for the SharePoint Tools in Visual Studio](../VS_officedev/deploying-extensions-for-the-sharepoint-tools-in-visual-studio.md).  
  
2.  Add references to the following assemblies:  
  
    -   Microsoft.VisualStudio.SharePoint.Commands  
  
    -   Microsoft.SharePoint  
  
3.  In a class in the project, create a method that defines your SharePoint command. The method must conform to the following guidelines:  
  
    -   It can have one or two parameters.  
  
         The first parameter must be a \<xref:Microsoft.VisualStudio.SharePoint.Commands.ISharePointCommandContext> object. This object provides the Microsoft.SharePoint.SPSite or Microsoft.SharePoint.SPWeb in which the command is executed. It also provides an \<xref:Microsoft.VisualStudio.SharePoint.Commands.ISharePointCommandLogger> object that can be used to write messages to the **Output** window or **Error List** window in Visual Studio.  
  
         The second parameter can be a type of your choice, but this parameter is optional. You can add this parameter to your SharePoint command if you need to pass data from your SharePoint tools extension to the command.  
  
    -   It can have a return value, but this is optional.  
  
    -   The second parameter and return value must be a type that can be serialized by the Windows Communication Foundation (WCF). For more information, see [Types Supported by the Data Contract Serializer](../Topic/Types%20Supported%20by%20the%20Data%20Contract%20Serializer.md) and [Using the XmlSerializer Class](../Topic/Using%20the%20XmlSerializer%20Class.md).  
  
    -   The method can have any visibility (**public**, **internal**, or **private**), and it can be static or non-static.  
  
4.  Apply the \<xref:Microsoft.VisualStudio.SharePoint.Commands.SharePointCommandAttribute> to the method. This attribute specifies a unique identifier for the command; this identifier does not have to match the method name.  
  
     You must specify the same unique identifier when you call the command from your SharePoint tools extension. For more information, see [How to: Execute a SharePoint Command](../VS_officedev/how-to--execute-a-sharepoint-command.md).  
  
## Example  
 The following code example demonstrates a SharePoint command that has the identifier `Contoso.Commands.UpgradeSolution`. This command uses APIs in the server object model to upgrade to a deployed solution.  
  
 [!code[SPExtensibility.ProjectExtension.UpgradeDeploymentStep#5](../VS_officedev/codesnippet/CSharp/how-to--create-a-sharepoint-command_1.cs)]
[!code[SPExtensibility.ProjectExtension.UpgradeDeploymentStep#5](../VS_officedev/codesnippet/VisualBasic/how-to--create-a-sharepoint-command_1.vb)]  
  
 In addition to the implicit first \<xref:Microsoft.VisualStudio.SharePoint.Commands.ISharePointCommandContext> parameter, this command also has a custom string parameter that contains the full path of the .wsp file that is being upgraded to the SharePoint site. To see this code in the context of a larger example, see [Walkthrough: Creating a Custom Deployment Step for SharePoint Projects](../VS_officedev/walkthrough--creating-a-custom-deployment-step-for-sharepoint-projects.md).  
  
## Compiling the Code  
 This example requires references to the following assemblies:  
  
-   Microsoft.VisualStudio.SharePoint.Commands  
  
-   Microsoft.SharePoint  
  
## Deploying the Command  
 To deploy the command, include the command assembly in the same [!INCLUDE[vsprvs](../VS_officedev/includes/vsprvs_md.md)] extension (VSIX) package with the extension assembly that uses the command. You must also add an entry for the command assembly in the extension.vsixmanifest file. For more information, see [Deploying Extensions for the SharePoint Tools in Visual Studio](../VS_officedev/deploying-extensions-for-the-sharepoint-tools-in-visual-studio.md).  
  
## See Also  
 [Calling into the SharePoint Object Models](../VS_officedev/calling-into-the-sharepoint-object-models.md)   
 [How to: Execute a SharePoint Command](../VS_officedev/how-to--execute-a-sharepoint-command.md)   
 [Walkthrough: Extending Server Explorer to Display Web Parts](../VS_officedev/walkthrough--extending-server-explorer-to-display-web-parts.md)  
  
  