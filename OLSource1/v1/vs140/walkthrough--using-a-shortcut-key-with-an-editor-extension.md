---
title: "Walkthrough: Using a Shortcut Key with an Editor Extension"
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
  - "editors [Visual Studio SDK], new - link keystrokes to commands"
ms.assetid: cf6cc6c6-5a65-4f90-8f14-663decf74672
caps.latest.revision: 36
ms.author: "gregvanl"
translation.priority.mt: 
  - "de-de"
  - "ja-jp"
---
# Walkthrough: Using a Shortcut Key with an Editor Extension
You can respond to shortcut keys in your editor extension. The following walkthrough shows how to add a view adornment to a text view by using a shortcut key. This walkthrough is based on the viewport adornment editor template, and it allows you to add the adornment by using the + character.  
  
## Prerequisites  
 Starting in Visual Studio 2015, you do not install the Visual Studio SDK from the download center. It is included as an optional feature in Visual Studio setup. You can also install the VS SDK later on. For more information, see [Installing the Visual Studio SDK](../vs140/installing-the-visual-studio-sdk.md).  
  
## Creating a Managed Extensibility Framework (MEF) Project  
  
1.  Create a C# VSIX project. (In the **New Project** dialog, select **Visual C# / Extensibility**, then **VSIX Project**.) Name the solution <CodeContentPlaceHolder>13\</CodeContentPlaceHolder>.  
  
2.  Add an Editor Text Adornment item template to the project and name it <CodeContentPlaceHolder>14\</CodeContentPlaceHolder>. For more information, see [Creating an Extension with an Editor Item Template](../vs140/creating-an-extension-with-an-editor-item-template.md).  
  
3.  Add the following references and set **CopyLocal** to <CodeContentPlaceHolder>15\</CodeContentPlaceHolder>:  
  
     Microsoft.VisualStudio.Editor  
  
     Microsoft.VisualStudio.OLE.Interop  
  
     Microsoft.VisualStudio.Shell.14.0  
  
     Microsoft.VisualStudio.TextManager.Interop  
  
 In the KeyBindingTest class file, change the class name to PurpleCornerBox. Use the light bulb that appears in the left margin to make the other appropriate changes. Inside the constructor, change the name of the adornment layer from **KeyBindingTest** to **PurpleCornerBox**:  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Defining the Command Filter  
 The command filter is an implementation of \<xref:Microsoft.VisualStudio.OLE.Interop.IOleCommandTarget*>, which handles the command by instantiating the adornment.  
  
1.  Add a class file and name it <CodeContentPlaceHolder>16\</CodeContentPlaceHolder>.  
  
2.  Add the following using statements.  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
3.  The class named KeyBindingCommandFilter should inherit from \<xref:Microsoft.VisualStudio.OLE.Interop.IOleCommandTarget*>.  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
4.  Add private fields for the text view, the next command in the command chain, and a flag to represent whether the command filter has already been added.  
  
<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
5.  Add a constructor that sets the text view.  
  
<CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
6.  Implement the <CodeContentPlaceHolder>17\</CodeContentPlaceHolder> method as follows.  
  
<CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
7.  Implement the <CodeContentPlaceHolder>18\</CodeContentPlaceHolder> method so that it adds a purple box to the view if a + character is typed.  
  
<CodeContentPlaceHolder>6\</CodeContentPlaceHolder>  
## Adding the Command Filter  
 The adornment provider must add a command filter to the text view. In this example, the provider implements \<xref:Microsoft.VisualStudio.Editor.IVsTextViewCreationListener*> to listen to text view creation events. This adornment provider also exports the adornment layer, which defines the Z-order of the adornment.  
  
1.  In the KeyBindingTestTextViewCreationListener file, add the following using statements:  
  
<CodeContentPlaceHolder>7\</CodeContentPlaceHolder>  
2.  In the adornment layer definition, change the name of the AdornmentLayer from **KeyBindingTest** to **PurpleCornerBox**.  
  
<CodeContentPlaceHolder>8\</CodeContentPlaceHolder>  
3.  To get the text view adapter, you must import the \<xref:Microsoft.VisualStudio.Editor.IVsEditorAdaptersFactoryService*>.  
  
<CodeContentPlaceHolder>9\</CodeContentPlaceHolder>  
4.  Change the \<xref:Microsoft.VisualStudio.Text.Editor.IWpfTextViewCreationListener.TextViewCreated*> method so that it adds the <CodeContentPlaceHolder>19\</CodeContentPlaceHolder>.  
  
<CodeContentPlaceHolder>10\</CodeContentPlaceHolder>  
5.  The <CodeContentPlaceHolder>20\</CodeContentPlaceHolder> handler gets the text view adapter and adds the command filter.  
  
<CodeContentPlaceHolder>11\</CodeContentPlaceHolder>  
## Making the Adornment Appear on Every Line  
 The original adornment appeared on every character ‘a’ in a text file. Now that we have changed the code to add the adornment in response to the ‘+’ character, it adds the adornment only on the line where the ‘+’ is typed. We can change the adornment code so that the adornment once more appears on every ‘a’.  
  
 In the KeyBindingTest.cs file, change the CreateVisuals() method to iterate through all the lines in the view to decorate the ‘a’ character.  
  
<CodeContentPlaceHolder>12\</CodeContentPlaceHolder>  
## Building and Testing the Code  
  
1.  Build the KeyBindingTest solution and run it in the experimental instance.  
  
2.  Create or open a text file. Type some words containing the character ‘a’, and then type + anywhere in the text view.  
  
     A purple square should appear on every ‘a’ character in the file.