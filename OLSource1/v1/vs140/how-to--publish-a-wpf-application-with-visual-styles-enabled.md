---
title: "How to: Publish a WPF Application with Visual Styles Enabled"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "vs-ide-deployment"
ms.tgt_pltfrm: na
ms.topic: "article"
ms.assetid: 73b22b02-fc75-42aa-82d3-51fdcaf8e5c8
caps.latest.revision: 7
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# How to: Publish a WPF Application with Visual Styles Enabled
Visual styles enable the appearance of common controls to change based on the theme chosen by the user. By default, visual styles are not enabled for Windows Presentation Foundation (WPF) applications, so you must enable them manually. However, enabling visual styles for a WPF application and then publishing the solution causes an error. This topic describes how to resolve this error and the process for publishing a WPF application with visual styles enabled. For more information about visual styles, see [Visual Styles Overview](assetId:///5b5d7bb6-684f-478d-bf5f-b8d18bbcff2e). For more information about the error message, see [Troubleshooting Specific Errors in ClickOnce Deployments](../vs140/troubleshooting-specific-errors-in-clickonce-deployments.md).  
  
 To resolve the error and to publish the solution, you must perform the following tasks:  
  
-   [Publish the solution without visual styles enabled](#BKMK_publishsolwovs).  
  
-   [Create a manifest file](#BKMK_CreateManifest).  
  
-   [Embed the manifest file into the executable file of the published solution](#BKMK_embedmanifest).  
  
-   [Sign the application and deployment manifests](#BKMK_signappdeplyman).  
  
 Then, you can move the published files to the location from which you want end users to install the application.  
  
##  \<a name="BKMK_publishsolwovs">\</a> Publish the solution without visual styles enabled  
  
1.  Ensure that your project does not have visual styles enabled. First, check your project’s manifest file for the following XML. Then, if the XML is present, enclose the XML with a comment tag.  
  
     By default, visual styles are not enabled.  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
     The following procedures show how to open the manifest file associated with your project.  
  
    ###### To open the manifest file in a Visual Basic project  
  
    1.  On the menu bar, choose **Project**, *ProjectName***Properties**, where *ProjectName* is the name of your WPF project.  
  
         The property pages for your WPF project appear.  
  
    2.  On the **Application** tab, choose **View Windows Settings**.  
  
         The app.manifest file opens in the **Code Editor**.  
  
    ###### To open the manifest file in a C# project  
  
    1.  On the menu bar, choose **Project**, *ProjectName***Properties**, where *ProjectName* is the name of your WPF project.  
  
         The property pages for your WPF project appear.  
  
    2.  On the **Application** tab, make a note of the name that appears in the manifest field. This is the name of the manifest that is associated with your project.  
  
        > [!NOTE]
        >  If **Embed manifest with default settings** or **Create application without manifest** appear in the manifest field, visual styles are not enabled. If the name of a manifest file appears in the manifest field, proceed to the next step in this procedure.  
  
    3.  In **Solution Explorer**, choose **Show All Files** ().  
  
         This button shows all project items, including those that have been excluded and those that are normally hidden. The manifest file appears as a project item.  
  
2.  Build and publish your solution. For more information about how to publish the solution, see [How to: Publish a ClickOnce Application using the Publish Wizard](../vs140/how-to--publish-a-clickonce-application-using-the-publish-wizard.md).  
  
##  \<a name="BKMK_CreateManifest">\</a> Create a manifest file  
  
1.  Paste the following XML into a Notepad file.  
  
     This XML describes the assembly that contains controls that support visual styles.  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
2.  In Notepad, click **File**, and then click **Save As**.  
  
3.  In the **Save As** dialog box, in the **Save as type** drop-down list, select **All Files**.  
  
4.  In the **File name** box, name the file and append **.manifest** to the end of the file name. For example: **themes.manifest**.  
  
5.  Choose the **Browse Folders** button, select any folder, and then click **Save**.  
  
    > [!NOTE]
    >  The remaining procedures assume that the name of this file is **themes.manifest** and that the file is saved to the C:\temp directory on your computer.  
  
##  \<a name="BKMK_embedmanifest">\</a> Embed the manifest file into the executable file of the published solution  
  
1.  Open the **Visual Studio Command Prompt**.  
  
     For more information about how to open the **Visual Studio Command Prompt**, see [Visual Studio and Windows SDK Command Prompts](assetId:///94fcf524-9045-4993-bfb2-e2d8bad44219).  
  
    > [!NOTE]
    >  The remaining steps make the following assumptions about your solution:  
    >   
    >  -   The name of the solution is **MyWPFProject**.  
    > -   The solution is located in the following directory: <CodeContentPlaceHolder>8\</CodeContentPlaceHolder>.  
    >   
    >      The solution is published to the following directory: <CodeContentPlaceHolder>9\</CodeContentPlaceHolder>.  
    > -   The most recent version of the published application files is located in the following directory: <CodeContentPlaceHolder>10\</CodeContentPlaceHolder>  
    >   
    >  You do not have to use the name or the directory locations described above. The name and locations described above are used only to illustrate the steps required to publish your solution.  
  
2.  At the command prompt, change the path to the directory that contains the most recent version of the published application files. The following example demonstrates this step.  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
3.  At the command prompt, run the following command to embed the manifest file into the executable file of the application.  
  
<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
##  \<a name="BKMK_signappdeplyman">\</a> Sign the application and deployment manifests  
  
1.  At the command prompt, run the following command to remove the <CodeContentPlaceHolder>11\</CodeContentPlaceHolder> extension from the executable file in the current directory.  
  
<CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
    > [!NOTE]
    >  This example assumes that only one file has the <CodeContentPlaceHolder>12\</CodeContentPlaceHolder> file extension. Make sure that you rename all files in this directory that have the <CodeContentPlaceHolder>13\</CodeContentPlaceHolder> file extension.  
  
2.  At the command prompt, run the following command to sign the application manifest.  
  
<CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
    > [!NOTE]
    >  This example assumes that you sign the manifest by using the <CodeContentPlaceHolder>14\</CodeContentPlaceHolder> file of the project. If you are not signing the manifest, you can omit the <CodeContentPlaceHolder>15\</CodeContentPlaceHolder> parameter that is used in this example. If you are signing the manifest with a certificate that requires a password, specify the <CodeContentPlaceHolder>16\</CodeContentPlaceHolder> option (<CodeContentPlaceHolder>17\</CodeContentPlaceHolder>).  
  
3.  At the command prompt, run the following command to add the <CodeContentPlaceHolder>18\</CodeContentPlaceHolder> extension to the name of the file that you renamed in a previous step of this procedure.  
  
<CodeContentPlaceHolder>6\</CodeContentPlaceHolder>  
    > [!NOTE]
    >  This example assumes that only one file had a <CodeContentPlaceHolder>19\</CodeContentPlaceHolder> file extension. Make sure that you rename all files in this directory that previously had the <CodeContentPlaceHolder>20\</CodeContentPlaceHolder> file name extension.  
  
4.  At the command prompt, run the following command to sign the deployment manifest.  
  
<CodeContentPlaceHolder>7\</CodeContentPlaceHolder>  
    > [!NOTE]
    >  This example assumes that you sign the manifest by using the <CodeContentPlaceHolder>21\</CodeContentPlaceHolder> file of the project. If you are not signing the manifest, you can omit the <CodeContentPlaceHolder>22\</CodeContentPlaceHolder> parameter that is used in this example. If you are signing the manifest with a certificate that requires a password, specify the <CodeContentPlaceHolder>23\</CodeContentPlaceHolder> option, as in this example:<CodeContentPlaceHolder>24\</CodeContentPlaceHolder>.  
  
 After you have performed these steps, you can move the published files to the location from which you want end users to install the application. If you intend to update the solution often, you can move these commands into a script and run the script each time that you publish a new version.  
  
## See Also  
 [Troubleshooting Specific Errors in ClickOnce Deployments](../vs140/troubleshooting-specific-errors-in-clickonce-deployments.md)   
 [Visual Styles Overview](assetId:///5b5d7bb6-684f-478d-bf5f-b8d18bbcff2e)   
 [Enabling Visual Styles](VS|Controls|~\controls\userex\cookbook.htm)   
 [Visual Studio and Windows SDK Command Prompts](assetId:///94fcf524-9045-4993-bfb2-e2d8bad44219)