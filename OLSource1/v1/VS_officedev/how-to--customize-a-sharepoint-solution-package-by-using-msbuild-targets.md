---
title: "How to: Customize a SharePoint Solution Package by Using MSBuild Targets"
ms.custom: na
ms.date: "08/09/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.tgt_pltfrm: na
ms.topic: "article"
dev_langs: 
  - "VB"
  - "CSharp"
  - "VB"
  - "CSharp"
helpviewer_keywords: 
  - "SharePoint development in Visual Studio, packages"
ms.assetid: 7fa6a276-04c8-463e-be95-57c2c6240d76
caps.latest.revision: 15
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
# How to: Customize a SharePoint Solution Package by Using MSBuild Targets
  By using MSBuild targets at a command prompt, you can customize how Visual Studio creates SharePoint package files (.wsp). For example, you can customize the MSBuild properties to change the packaging intermediate directory and the MSBuild item groups that specify the enumerated files.  
  
## Customizing and Running MSBuild Targets  
 If you customize the BeforeLayout and AfterLayout targets, you can perform tasks before package layout, such as adding, removing, or modifying files that will be packaged.  
  
#### To customize the BeforeLayout target  
  
1.  Open an editor, such as Notepad, and then add the following code.  
  
    ```  
    <Project xmlns="http://schemas.microsoft.com/developer/msbuild/2003">  
      <Target Name="BeforeLayout">  
        <Message Importance="high" Text="In the BeforeLayout Target"></Message>  
      </Target>  
    </Project>  
    ```  
  
     This example displays a message before the packaging of this target.  
  
2.  Name the file **CustomLayout.SharePoint.targets**, and then save it in the folder for the SharePoint project.  
  
3.  Open the project, open its shortcut menu, and then choose **Unload Project**.  
  
4.  In **Solution Explorer**, open the shortcut menu for the project, and then choose **Edit***ProjectName***.vbproj** or **Edit***ProjectName***.csproj**.  
  
5.  After the `Import` line near the end of the project file, add the following line.  
  
    ```  
    <Import Project="CustomLayout.SharePoint.targets" />  
    ```  
  
6.  Save and close the project file.  
  
7.  In **Solution Explorer**, open the shortcut menu for the project, and then choose **Reload Project**.  
  
 When you publish the project, the message will appear in the output before packaging begins.  
  
#### To customize the AfterLayout target  
  
1.  On the menu bar, choose **File**, **Open**, **File**.  
  
2.  In the **Open File** dialog box, navigate to the project folder, choose the CustomLayout.target file, and then choose the **Open** button.  
  
3.  Just before the `</Project>` tag, add the following code:  
  
    ```  
    <Target Name="AfterLayout">  
      <Message Importance="high" Text="In the AfterLayout Target"></Message>  
    </Target>  
    ```  
  
     This example displays a message after this target is packaged.  
  
4.  Save and close the targets file.  
  
5.  Restart Visual Studio, and then open the project.  
  
 When you publish the project, the BeforeLayout message appears before packaging starts, and the AfterLayout message appears after packaging finishes.  
  
## See Also  
 [Packaging and Deploying SharePoint Solutions](../VS_officedev/packaging-and-deploying-sharepoint-solutions.md)  
  
  