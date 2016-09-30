---
title: "Walkthrough: Creating a Margin Glyph"
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
  - "editors [Visual Studio SDK], new - margin glyph"
ms.assetid: 814185db-24f9-417f-b3b1-7c5aabb42b45
caps.latest.revision: 33
ms.author: "gregvanl"
translation.priority.mt: 
  - "de-de"
  - "ja-jp"
---
# Walkthrough: Creating a Margin Glyph
You can customize the appearance of editor margins by using custom editor extensions. This walkthrough puts a custom glyph on the indicator margin whenever the word "todo" appears in a code comment.  
  
## Prerequisites  
 Starting in Visual Studio 2015, you do not install the Visual Studio SDK from the download center. It is included as an optional feature in Visual Studio setup. You can also install the VS SDK later on. For more information, see [Installing the Visual Studio SDK](../vs140/installing-the-visual-studio-sdk.md).  
  
## Creating a MEF Project  
  
1.  Create a C# VSIX project. (In the **New Project** dialog, select **Visual C# / Extensibility**, then **VSIX Project**.) Name the solution <CodeContentPlaceHolder>0\</CodeContentPlaceHolder>.  
  
2.  Add an Editor Classifier project item. For more information, see [Creating an Extension with an Editor Item Template](../vs140/creating-an-extension-with-an-editor-item-template.md).  
  
3.  Delete the existing class files.  
  
## Defining the Glyph  
 Define a glyph by implementing the \<xref:Microsoft.VisualStudio.Text.Editor.IGlyphFactory*> interface.  
  
#### To define the glyph  
  
1.  Add a class file and name it <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>.  
  
2.  Add the following using declarations.  
  
     [!code[VSSDKTodoGlyphTest#1](../vs140/codesnippet/CSharp/walkthrough--creating-a-margin-glyph_1.cs)]
[!code[VSSDKTodoGlyphTest#1](../vs140/codesnippet/VisualBasic/walkthrough--creating-a-margin-glyph_1.vb)]  
  
3.  Add a class named <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> that implements \<xref:Microsoft.VisualStudio.Text.Editor.IGlyphFactory*>.  
  
     [!code[VSSDKTodoGlyphTest#2](../vs140/codesnippet/CSharp/walkthrough--creating-a-margin-glyph_2.cs)]
[!code[VSSDKTodoGlyphTest#2](../vs140/codesnippet/VisualBasic/walkthrough--creating-a-margin-glyph_2.vb)]  
  
4.  Add a private field that defines the dimensions of the glyph.  
  
     [!code[VSSDKTodoGlyphTest#3](../vs140/codesnippet/CSharp/walkthrough--creating-a-margin-glyph_3.cs)]
[!code[VSSDKTodoGlyphTest#3](../vs140/codesnippet/VisualBasic/walkthrough--creating-a-margin-glyph_3.vb)]  
  
5.  Implement <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> by defining the glyph user interface (UI) element. <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> is defined later in this walkthrough.  
  
     [!code[VSSDKTodoGlyphTest#4](../vs140/codesnippet/CSharp/walkthrough--creating-a-margin-glyph_4.cs)]
[!code[VSSDKTodoGlyphTest#4](../vs140/codesnippet/VisualBasic/walkthrough--creating-a-margin-glyph_4.vb)]  
  
6.  Add a class named <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> that implements \<xref:Microsoft.VisualStudio.Text.Editor.IGlyphFactoryProvider*>. Export this class with a \<xref:Microsoft.VisualStudio.Utilities.NameAttribute*> of "TodoGlyph", an \<xref:Microsoft.VisualStudio.Utilities.OrderAttribute*> of After VsTextMarker, a \<xref:Microsoft.VisualStudio.Utilities.ContentTypeAttribute*> of "code", and a \<xref:Microsoft.VisualStudio.Text.Tagging.TagTypeAttribute*> of TodoTag.  
  
     [!code[VSSDKTodoGlyphTest#5](../vs140/codesnippet/CSharp/walkthrough--creating-a-margin-glyph_5.cs)]
[!code[VSSDKTodoGlyphTest#5](../vs140/codesnippet/VisualBasic/walkthrough--creating-a-margin-glyph_5.vb)]  
  
7.  Implement the \<xref:Microsoft.VisualStudio.Text.Editor.IGlyphFactoryProvider.GetGlyphFactory*> method by instantiating the <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>.  
  
     [!code[VSSDKTodoGlyphTest#6](../vs140/codesnippet/CSharp/walkthrough--creating-a-margin-glyph_6.cs)]
[!code[VSSDKTodoGlyphTest#6](../vs140/codesnippet/VisualBasic/walkthrough--creating-a-margin-glyph_6.vb)]  
  
## Defining a Todo Tag and Tagger  
 Define the relationship between the UI element that you defined in the previous steps and the indicator margin by creating a tag type and tagger, and exporting it by using a tagger provider.  
  
#### To define a todo tag and tagger  
  
1.  Add a new class file to the project and name it <CodeContentPlaceHolder>7\</CodeContentPlaceHolder>.  
  
2.  Add the following imports.  
  
     [!code[VSSDKTodoGlyphTest#7](../vs140/codesnippet/CSharp/walkthrough--creating-a-margin-glyph_7.cs)]
[!code[VSSDKTodoGlyphTest#7](../vs140/codesnippet/VisualBasic/walkthrough--creating-a-margin-glyph_7.vb)]  
  
3.  Add a class named <CodeContentPlaceHolder>8\</CodeContentPlaceHolder>.  
  
     [!code[VSSDKTodoGlyphTest#8](../vs140/codesnippet/CSharp/walkthrough--creating-a-margin-glyph_8.cs)]
[!code[VSSDKTodoGlyphTest#8](../vs140/codesnippet/VisualBasic/walkthrough--creating-a-margin-glyph_8.vb)]  
  
4.  Modify the class named <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> that implements <xref:Microsoft.VisualStudio.Text.Tagging.ITagger<CodeContentPlaceHolder>10\</CodeContentPlaceHolder>TodoTag<CodeContentPlaceHolder>11\</CodeContentPlaceHolder>TodoTagger<CodeContentPlaceHolder>12\</CodeContentPlaceHolder>1.GetTags*> method by finding all the classification spans whose names include the word "comment" and whose text includes the search text. Whenever the search text is found, yield back a new <xref:Microsoft.VisualStudio.Text.Tagging.TagSpan<CodeContentPlaceHolder>13\</CodeContentPlaceHolder>TodoTag<CodeContentPlaceHolder>14\</CodeContentPlaceHolder>TagsChanged<CodeContentPlaceHolder>15\</CodeContentPlaceHolder>TodoTaggerProvider<CodeContentPlaceHolder>16\</CodeContentPlaceHolder>TodoTagger`.  
  
     [!code[VSSDKTodoGlyphTest#16](../vs140/codesnippet/CSharp/walkthrough--creating-a-margin-glyph_16.cs)]
[!code[VSSDKTodoGlyphTest#16](../vs140/codesnippet/VisualBasic/walkthrough--creating-a-margin-glyph_16.vb)]  
  
## Building and Testing the Code  
 To test this code, build the TodoGlyphTest solution and run it in the experimental instance.  
  
#### To build and test the TodoGlyphTest solution  
  
1.  Build the solution.  
  
2.  Run the project by pressing F5. A second instance of Visual Studio is instantiated.  
  
3.  Make sure that the indicator margin is showing. (On the **Tools** menu, click **Options**. On the **Text Editor** page, make sure that **Indicator margin** is selected.)  
  
4.  Open a code file that has comments. Add the word "todo" to one of the comment sections.  
  
5.  A light blue circle that has a dark blue outline should appear in the indicator margin to the left of the code window.