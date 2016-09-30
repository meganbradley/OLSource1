---
title: "Creating a Settings Category"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "vs-ide-sdk"
ms.tgt_pltfrm: na
ms.topic: "article"
helpviewer_keywords: 
  - "profile settings, creating categories"
ms.assetid: 97c88693-05ff-499e-8c43-352ee073dcb7
caps.latest.revision: 43
ms.author: "gregvanl"
translation.priority.mt: 
  - "de-de"
  - "ja-jp"
---
# Creating a Settings Category
In this walkthrough you create a Visual Studio settings category and use it to save values to and restore values from a settings file. A settings category is a group of related properties that appear as a "custom settings point"; that is, as a check box in the **Import and Exports Settings** Wizard. (You can find it on the **Tools** menu.) Settings are saved or restored as a category, and individual settings are not displayed in the wizard. For more information, see [Customizing Development Settings in Visual Studio](assetId:///22c4debb-4e31-47a8-8f19-16f328d7dcd3).  
  
 You create a settings category by deriving it from the \<xref:Microsoft.VisualStudio.Shell.DialogPage*> class.  
  
 To start this walkthrough, you must first complete the first section of [Walkthrough: Creating a Tools/Options Page](../vs140/creating-an-options-page.md). The resulting Options property grid lets you examine and change the properties in the category. After you save the property category in a settings file, you examine the file to see how the property values are stored.  
  
## Prerequisites  
 Starting in Visual Studio 2015, you do not install the Visual Studio SDK from the download center. It is included as an optional feature in Visual Studio setup. You can also install the VS SDK later on. For more information, see [Installing the Visual Studio SDK](../vs140/installing-the-visual-studio-sdk.md).  
  
## Creating a Settings Category  
 In this section, you use a custom settings point to save and restore the values of the settings category.  
  
#### To create a settings category  
  
1.  Complete the [Walkthrough: Creating a Tools/Options Page](../vs140/creating-an-options-page.md).  
  
2.  Open the VSPackage.resx file and add these three string resources:  
  
    |Name|Value|  
    |----------|-----------|  
    |106|My Category|  
    |107|My Settings|  
    |108|OptionInteger and OptionFloat|  
  
     This creates resources that name the category "My Category", the object "My Settings", and the category description "OptionInteger and OptionFloat".  
  
    > [!NOTE]
    >  Of these three, only the category name does not appear in the Import and Export Settings wizard.  
  
3.  In MyToolsOptionsPackage.cs, add a <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> property named <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> to the <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> class, as shown in the following example.  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
    > [!NOTE]
    >  The <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> category named "My Category" now consists of the two properties, <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>8\</CodeContentPlaceHolder>.  
  
4.  Add a \<xref:Microsoft.VisualStudio.Shell.ProvideProfileAttribute*> to the <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> class and give it the CategoryName "My Category", give it the ObjectName "My Settings", and set isToolsOptionPage to true. Set the categoryResourceID, objectNameResourceID, and DescriptionResourceID to the corresponding string resource IDs created earlier.  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
5.  Build the project and start debugging. In the experimental instance you should see that **My Grid Page** now has both integer and float values.  
  
## Examining the Settings File  
 In this section, you export property category values to a settings file. You examine the file and then import the values back into the property category.  
  
1.  Start the project in debug mode by pressing F5. This starts the experimental instance.  
  
2.  Open the **Tools / Options** dialog.  
  
3.  In the tree view in the left pane, expand **My Category** and then click **My Grid Page**.  
  
4.  Change the value of **OptionFloat** to 3.1416 and **OptionInteger** to 12. Click **OK**.  
  
5.  On the **Tools** menu, click **Import and Export Settings**.  
  
     The **Import and Export Settings** wizard appears.  
  
6.  Make sure **Export selected environment settings** is selected, and then click **Next**.  
  
     The **Choose Settings to Export** page appears.  
  
7.  Click **My Settings**.  
  
     The **Description** changes to **OptionInteger and OptionFloat**.  
  
8.  Make sure that **My Settings** is the only category that is selected, and then click **Next**.  
  
     The **Name Your Settings File** page appears.  
  
9. Name the new settings file <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> and save it in an appropriate directory. Click **Finish**.  
  
     The **Export Complete** page reports that your settings were successfully exported.  
  
10. On the **File** menu, point to **Open**, and then click **File**. Locate <CodeContentPlaceHolder>11\</CodeContentPlaceHolder> and open it.  
  
     You can find the property category you exported in the following section of the file (your GUIDs will differ).  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
     Notice that the full category name is formed by the addition of an underscore to the category name followed by the object name. OptionFloat and OptionInteger appear in the category, together with their exported values.  
  
11. Close the settings file without changing it.  
  
12. On the **Tools** menu, click **Options**, expand **My Category**, click **My Grid Page** and then change the value of **OptionFloat** to 1.0 and **OptionInteger** to 1. Click **OK**.  
  
13. On the **Tools** menu, click **Import and Export Settings**, select **Import selected environment settings**, and then click **Next**.  
  
     The **Save Current Settings** page appears.  
  
14. Select **No, just import new settings** and then click **Next**.  
  
     The **Choose a Collection of Settings to Import** page appears.  
  
15. Select the <CodeContentPlaceHolder>12\</CodeContentPlaceHolder> file in the **My Settings** node of the tree view. If the file does not appear in the tree view, click **Browse** and find it. Click **Next**.  
  
     The **Choose Settings to Import** dialog box appears.  
  
16. Make sure that **My Settings** is selected, and then click **Finish**. When the **Import Complete** page appears, click **Close**.  
  
17. On the **Tools** menu, click **Options**, expand **My Category**, click **My Grid Page** and verify that the property category values have been restored.