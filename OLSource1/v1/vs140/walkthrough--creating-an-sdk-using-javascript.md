---
title: "Walkthrough: Creating an SDK using JavaScript"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "vs-ide-sdk"
ms.tgt_pltfrm: na
ms.topic: "article"
ms.assetid: a8c89d5d-5b78-4435-817f-c5f25ca6d715
caps.latest.revision: 19
ms.author: "gregvanl"
translation.priority.mt: 
  - "de-de"
  - "ja-jp"
---
# Walkthrough: Creating an SDK using JavaScript
This walkthrough teaches how to use JavaScript to create a simple math SDK as a Visual Studio Extension (VSIX).  The walkthrough is divided into these parts:  
  
-   [Creating the SimpleMathVSIX extension SDK project](../vs140/walkthrough--creating-an-sdk-using-javascript.md#createSimpleMathVSIX)  
  
-   [Creating a sample app that uses the SDK](../vs140/walkthrough--creating-an-sdk-using-javascript.md#createSampleApp)  
  
 For JavaScript, there is no class library project type. In this walkthrough, the sample arithmetic.js file is created directly in the VSIX project. In practice, we recommend that you first build and test the JavaScript and CSS files as a Windows Store app—for example, by using the **Blank App** template—before you put them in a VSIX project.  
  
## Prerequisites  
 To follow this walkthrough, you must install the Visual Studio SDK. For more information, see [Visual Studio Software Development Kit (SDK)](../vs140/visual-studio-sdk.md).  
  
##  \<a name="createSimpleMathVSIX">\</a> To create the SimpleMathVSIX extension SDK project  
  
1.  On the menu bar, choose **File**, **New**, **Project**.  
  
2.  In the list of template categories, under **Visual C#**, select **Extensibility**, and then select the **VSIX Project** template.  
  
3.  In the **Name** text box, specify <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> and choose the **OK** button.  
  
4.  If the **Visual Studio Package Wizard** appears, choose the **Next** button on the **Welcome** page, and then on **Page 1 of 7**, choose the **Finish** button.  
  
     Although the **Manifest Designer** opens, we'll keep this walkthrough simple by modifying the manifest file directly.  
  
5.  In **Solution Explorer**, open the shortcut menu for the source.extension.vsixmanifest file, and then choose **View Code**. Use this code to replace the existing content in the file.  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
6.  In **Solution Explorer**, open the shortcut menu for the SimpleMathVSIX project, and then choose **Add**, **New Item**.  
  
7.  In the **Data** category, select **XML file**, name the file <CodeContentPlaceHolder>7\</CodeContentPlaceHolder>, and choose the **Add** button.  
  
8.  In **Solution Explorer**, open the shortcut menu for the SDKManifest.xml file, and then choose **Open** to display the file in the **XML Editor**.  
  
9. Add the following code to the SDKManifest.xml file.  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
10. In **Solution Explorer**, on the shortcut menu for the SDKManifest.xml file, choose **Properties**.  
  
11. In the **Properties** window, set the **Include in VSIX** property to **True**.  
  
12. In **Solution Explorer**, on the shortcut menu for the SimpleMathVSIX project, choose **Add**, **New Folder**, and then name the folder <CodeContentPlaceHolder>8\</CodeContentPlaceHolder>.  
  
13. Add subfolders under Redist to create this folder structure:  
  
     \Redist\CommonConfiguration\Neutral\SimpleMath\js\  
  
14. On the shortcut menu for the \js\ folder, choose **Add**, **New Item**.  
  
15. Under **Visual C# items**, select the **Web** category, and then select the **JavaScript File** item. Name the file <CodeContentPlaceHolder>9\</CodeContentPlaceHolder>, and then choose the **Add** button.  
  
16. Insert the following code into arithmetic.js:  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
17. In **Solution Explorer**, on the shortcut menu for the arithmetic.js file, choose **Properties**. Make these property changes:  
  
    -   Set the **Include in VSIX** property to **True**.  
  
    -   Set the **Copy to Output Directory** property to **Copy Always**.  
  
18. In **Solution Explorer**, on the shortcut menu for the SimpleMathVSIX project, choose **Build**.  
  
19. After the build completes successfully, on the shortcut menu for the project, choose **Open Folder in File Explorer**. Navigate to \bin\debug\\, and run <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> to install it.  
  
20. Choose the **Install** button and let the installation complete.  
  
21. Restart Visual Studio.  
  
##  \<a name="createSampleApp">\</a> To create a sample app that uses the SDK  
  
1.  On the menu bar, choose **File**, **New**, **Project**.  
  
2.  In the list of template categories, under **JavaScript**, select **Windows Store**, and then select the **Blank App** template.  
  
3.  In the **Name** box, specify <CodeContentPlaceHolder>11\</CodeContentPlaceHolder>. Choose the **OK** button.  
  
4.  In **Solution Explorer**, open the shortcut menu for the ArithmeticUI project, and then choose **Add**, **Reference**.  
  
5.  Under **Windows**, choose **Extensions**, and notice that **Simple Math** is displayed.  
  
6.  Select the **Simple Math** check box and then choose the **OK** button.  
  
7.  In **Solution Explorer**, under **References**, notice that the **Simple Math** reference is displayed. Expand it and notice that there's a \js\ folder that includes arithmetic.js. You can open arithmetic.js to confirm that your source code was installed.  
  
8.  Use the following code to replace the contents of default.htm.  
  
<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
9. Use the next code to replace the contents of \js\default.js.  
  
<CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
10. Replace the contents of \css\default.css with this code:  
  
<CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
11. Choose the F5 key to build and run the app.  
  
12. In the app UI, enter any two numbers, select an operation, and then choose the **=** button. The correct result appears.  
  
## See Also  
 [How to: Create a Software Development Kit](../vs140/creating-a-software-development-kit.md)