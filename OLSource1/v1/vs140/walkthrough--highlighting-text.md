---
title: "Walkthrough: Highlighting Text"
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
  - "editors [Visual Studio SDK], new - highlight text"
ms.assetid: 64b772ad-4392-42e9-a237-5137f0384bf0
caps.latest.revision: 46
ms.author: "gregvanl"
translation.priority.mt: 
  - "de-de"
  - "ja-jp"
---
# Walkthrough: Highlighting Text
You can add different visual effects to the editor by creating Managed Extensibility Framework (MEF) component parts. This walkthrough shows how to highlight every occurrence of the current word in a text file. If a word occurs more than one time in a text file, and you position the caret in one occurrence, every occurrence is highlighted.  
  
## Prerequisites  
 Starting in Visual Studio 2015, you do not install the Visual Studio SDK from the download center. It is included as an optional feature in Visual Studio setup. You can also install the VS SDK later on. For more information, see [Installing the Visual Studio SDK](../vs140/installing-the-visual-studio-sdk.md).  
  
## Creating a MEF Project  
  
1.  Create a C# VSIX project. (In the **New Project** dialog, select **Visual C# / Extensibility**, then **VSIX Project**.) Name the solution <CodeContentPlaceHolder>15\</CodeContentPlaceHolder>.  
  
2.  Add an Editor Classifier item template to the project. For more information, see [Creating an Extension with an Editor Item Template](../vs140/creating-an-extension-with-an-editor-item-template.md).  
  
3.  Delete the existing class files.  
  
## Defining a TextMarkerTag  
 The first step in highlighting text is to subclass \<xref:Microsoft.VisualStudio.Text.Tagging.TextMarkerTag*> and define its appearance.  
  
#### To define a TextMarkerTag and a MarkerFormatDefinition  
  
1.  Add a class file and name it **HighlightWordTag**.  
  
2.  Add the following references:  
  
    1.  Microsoft.VisualStudio.CoreUtility  
  
    2.  Microsoft.VisualStudio.Text.Data  
  
    3.  Microsoft.VisualStudio.Text.Logic  
  
    4.  Microsoft.VisualStudio.Text.UI  
  
    5.  Microsoft.VisualStudio.Text.UI.Wpf  
  
    6.  System.ComponentModel.Composition  
  
    7.  Presentation.Core  
  
    8.  Presentation.Framework  
  
3.  Import the following namespaces.  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
4.  Create a class that inherits from \<xref:Microsoft.VisualStudio.Text.Tagging.TextMarkerTag*> and name it <CodeContentPlaceHolder>16\</CodeContentPlaceHolder>.  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
5.  Create a second class that inherits from \<xref:Microsoft.VisualStudio.Text.Classification.MarkerFormatDefinition*>, and name it HighlightWordFormatDefinition. In order to use this format definition for your tag, you must export it with the following attributes:  
  
    -   \<xref:Microsoft.VisualStudio.Utilities.NameAttribute*>: tags use this to reference this format  
  
    -   \<xref:Microsoft.VisualStudio.Text.Classification.UserVisibleAttribute*>: this causes the format to appear in the UI  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
6.  In the constructor for HighlightWordFormatDefinition, define its display name and appearance. The Background property defines the fill color, while the Foreground property defines the border color.  
  
<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
7.  In the constructor for HighlightWordTag, pass in the name of the format definition you just created.  
  
<CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
## Implementing an ITagger  
 The next step is to implement the <xref:Microsoft.VisualStudio.Text.Tagging.ITagger<CodeContentPlaceHolder>17\</CodeContentPlaceHolder>1*> of type <CodeContentPlaceHolder>18\</CodeContentPlaceHolder>, and name it <CodeContentPlaceHolder>19\</CodeContentPlaceHolder>.  
  
<CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
2.  Add the following private fields and properties to the class:  
  
    -   An \<xref:Microsoft.VisualStudio.Text.Editor.ITextView*>, which corresponds to the current text view.  
  
    -   An \<xref:Microsoft.VisualStudio.Text.ITextBuffer*>, which corresponds to the text buffer that underlies the text view.  
  
    -   An \<xref:Microsoft.VisualStudio.Text.Operations.ITextSearchService*>, which is used to find text.  
  
    -   An \<xref:Microsoft.VisualStudio.Text.Operations.ITextStructureNavigator*>, which has methods for navigating within text spans.  
  
    -   A \<xref:Microsoft.VisualStudio.Text.NormalizedSnapshotSpanCollection*>, which contains the set of words to highlight.  
  
    -   A \<xref:Microsoft.VisualStudio.Text.SnapshotSpan*>, which corresponds to the current word.  
  
    -   A \<xref:Microsoft.VisualStudio.Text.SnapshotPoint*>, which corresponds to the current position of the caret.  
  
    -   A lock object.  
  
<CodeContentPlaceHolder>6\</CodeContentPlaceHolder>  
3.  Add a constructor that initializes the properties listed earlier and adds \<xref:Microsoft.VisualStudio.Text.Editor.ITextView.LayoutChanged*> and \<xref:Microsoft.VisualStudio.Text.Editor.ITextCaret.PositionChanged*> event handlers.  
  
<CodeContentPlaceHolder>7\</CodeContentPlaceHolder>  
4.  The event handlers both call the <CodeContentPlaceHolder>20\</CodeContentPlaceHolder> method.  
  
<CodeContentPlaceHolder>8\</CodeContentPlaceHolder>  
5.  You must also add a <CodeContentPlaceHolder>21\</CodeContentPlaceHolder> event that will be called by the update method.  
  
     [!code[VSSDKHighlightWordTest#10](../vs140/codesnippet/CSharp/walkthrough--highlighting-text_1.cs)]
[!code[VSSDKHighlightWordTest#10](../vs140/codesnippet/VisualBasic/walkthrough--highlighting-text_1.vb)]  
  
6.  The <CodeContentPlaceHolder>22\</CodeContentPlaceHolder> method finds every word in the text buffer that is identical to the word where the cursor is positioned and constructs a list of \<xref:Microsoft.VisualStudio.Text.SnapshotSpan*> objects that correspond to the occurrences of the word. It then calls <CodeContentPlaceHolder>23\</CodeContentPlaceHolder>, which raises the <CodeContentPlaceHolder>24\</CodeContentPlaceHolder> event.  
  
<CodeContentPlaceHolder>9\</CodeContentPlaceHolder>  
7.  The <CodeContentPlaceHolder>25\</CodeContentPlaceHolder> performs a synchronous update on the <CodeContentPlaceHolder>26\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>27\</CodeContentPlaceHolder> properties, and raises the <CodeContentPlaceHolder>28\</CodeContentPlaceHolder> event.  
  
<CodeContentPlaceHolder>10\</CodeContentPlaceHolder>  
8.  You must implement the <xref:Microsoft.VisualStudio.Text.Tagging.ITagger<CodeContentPlaceHolder>29\</CodeContentPlaceHolder>1*> object that has a "blue" \<xref:Microsoft.VisualStudio.Text.Tagging.TextMarkerTag*>, which provides a blue background.  
  
<CodeContentPlaceHolder>11\</CodeContentPlaceHolder>  
## Creating a Tagger Provider  
 To create your tagger, you must implement a \<xref:Microsoft.VisualStudio.Text.Tagging.IViewTaggerProvider*>. This class is a MEF component part, so you must set the correct attributes so that this extension is recognized.  
  
> [!NOTE]
>  For more information about MEF, see [Managed Extensibility Framework Overview](assetId:///6c61b4ec-c6df-4651-80f1-4854f8b14dde).  
  
#### To create a tagger provider  
  
1.  Create a class named <CodeContentPlaceHolder>30\</CodeContentPlaceHolder> that implements \<xref:Microsoft.VisualStudio.Text.Tagging.IViewTaggerProvider*>, and export it with a \<xref:Microsoft.VisualStudio.Utilities.ContentTypeAttribute*> of "text" and a \<xref:Microsoft.VisualStudio.Text.Tagging.TagTypeAttribute*> of \<xref:Microsoft.VisualStudio.Text.Tagging.TextMarkerTag*>.  
  
<CodeContentPlaceHolder>12\</CodeContentPlaceHolder>  
2.  You must import two editor services, the \<xref:Microsoft.VisualStudio.Text.Operations.ITextSearchService*> and the \<xref:Microsoft.VisualStudio.Text.Operations.ITextStructureNavigatorSelectorService*>, to instantiate the tagger.  
  
<CodeContentPlaceHolder>13\</CodeContentPlaceHolder>  
3.  Implement the \<xref:Microsoft.VisualStudio.Text.Tagging.IViewTaggerProvider.CreateTagger*> method to return an instance of <CodeContentPlaceHolder>31\</CodeContentPlaceHolder>.  
  
<CodeContentPlaceHolder>14\</CodeContentPlaceHolder>  
## Building and Testing the Code  
 To test this code, build the HighlightWordTest solution and run it in the experimental instance.  
  
#### To build and test the HighlightWordTest solution  
  
1.  Build the solution.  
  
2.  When you run this project in the debugger, a second instance of Visual Studio is instantiated.  
  
3.  Create a text file and type some text in which the words are repeated, for example, "hello hello hello".  
  
4.  Position the cursor in one of the occurrences of "hello". Every occurrence should be highlighted in blue.  
  
## See Also  
 [How to: Link a Content Type to a File Extension](../vs140/walkthrough--linking-a-content-type-to-a-file-name-extension.md)