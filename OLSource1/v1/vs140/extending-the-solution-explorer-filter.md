---
title: "Extending the Solution Explorer Filter"
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
  - "Solution Explorer, extending"
  - "extensibility [Visual Studio], projects and solutions"
ms.assetid: df976c76-27ec-4f00-ab6d-a26a745dc6c7
caps.latest.revision: 29
ms.author: "gregvanl"
translation.priority.mt: 
  - "de-de"
  - "ja-jp"
---
# Extending the Solution Explorer Filter
You can extend **Solution Explorer** filter functionality to show or hide different files. For example, you can create a filter that shows only C# class factory files in the **Solution Explorer**, as this walkthrough demonstrates.  
  
## Prerequisites  
 Starting in Visual Studio 2015, you do not install the Visual Studio SDK from the download center. It is included as an optional feature in Visual Studio setup. You can also install the VS SDK later on. For more information, see [Installing the Visual Studio SDK](../vs140/installing-the-visual-studio-sdk.md).  
  
### Create a Visual Studio Package Project  
  
1.  Create a VSIX project named <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>. Add a custom command item template named **FileFilter**. For more information, see [Creating an Extension with a Menu Command](../vs140/creating-an-extension-with-a-menu-command.md).  
  
2.  Add a reference to <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>7\</CodeContentPlaceHolder>.  
  
3.  Make the menu command appear on the **Solution Explorer** toolbar. Open the FileFilterPackage.vsct file.  
  
4.  Change the <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> block to the following:  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
### Update the Manifest File  
  
1.  In the source.extension.vsixmanifest file, add an asset that is a MEF component.  
  
2.  On the **Assets** tab, choose the **New** button.  
  
3.  In the **Type** field, choose **Microsoft.VisualStudio.MefComponent**.  
  
4.  In the **Source** field, choose **A project in current solution**.  
  
5.  In the **Project** field, choose **FileFilter**, and then choose the **OK** button.  
  
### Add the Filter Code  
  
1.  Add some GUIDs to the FileFilterPackageGuids.cs file:  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
2.  Add a class file to the FileFilter project named FileNameFilter.cs.  
  
3.  Replace the empty namespace and the empty class with the code below.  
  
     The <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> method takes the collection that contains the root of the solution (<CodeContentPlaceHolder>10\</CodeContentPlaceHolder>) and returns the collection of items to be included in the filter.  
  
     The <CodeContentPlaceHolder>11\</CodeContentPlaceHolder> method filters the items in the **Solution Explorer** hierarchy based on the condition that you specify.  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
4.  In FileFilter.cs, remove the command placement and handling code from the FileFilter constructor. The result should look like this:  
  
<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
     Remove the ShowMessageBox() method as well.  
  
5.  In FileFilterPackage,cs, replace the code in the Initialize() method with the following:  
  
<CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
### Test Your Code  
  
1.  Build and run the project. A second instance of Visual Studio appears. This is called the experimental instance.  
  
2.  In the experimental instance of Visual Studio, open a C# project.  
  
3.  Look for the button you added on the Solution Explorer toolbar. It should be the fourth button from the left.  
  
4.  When you click the button, all the files should be filtered out, and you should see “All items have been filtered from view.” in the Solution Explorer.