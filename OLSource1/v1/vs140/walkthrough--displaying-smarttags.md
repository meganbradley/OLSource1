---
title: "Walkthrough: Displaying SmartTags"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-csharp"
ms.tgt_pltfrm: na
ms.topic: "article"
helpviewer_keywords: 
  - "editors [Visual Studio SDK], new - smart tags"
ms.assetid: 10bb4f69-b259-41f0-b91a-69b04385d9a5
caps.latest.revision: 35
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Walkthrough: Displaying SmartTags
Smart tags are deprecated in favor of light bulbs. See [Walkthrough: Displaying Light Bulb Suggestions](../vs140/walkthrough--displaying-light-bulb-suggestions.md).  
  
 Smart tags are tags on text that expand to display a set of actions. For example, in a Visual Basic or Visual C# project, a red line appears under a word when you rename an identifier such as a variable name. When you move the pointer over the underline, a button is displayed near the pointer. If you click the button, a suggested action is displayed, for example, **Rename IsRead to IsReady**. If you click the action, all references to **IsRead** in the project are renamed **IsReady**.  
  
 Although smart tags are part of the IntelliSense implementation in the editor, you can implement smart tags by subclassing \<xref:Microsoft.VisualStudio.Language.Intellisense.SmartTag*>, and then implementing the <xref:Microsoft.VisualStudio.Text.Tagging.ITagger<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>SmartTagTest<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>Microsoft.VisualStudio.MefComponent<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>A project in current solution<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>false<CodeContentPlaceHolder>4\</CodeContentPlaceHolder>TestSmartTag<CodeContentPlaceHolder>5\</CodeContentPlaceHolder>TestSmartTag<CodeContentPlaceHolder>6\</CodeContentPlaceHolder>TestSmartTagger<CodeContentPlaceHolder>7\</CodeContentPlaceHolder>1*> of type <CodeContentPlaceHolder>8\</CodeContentPlaceHolder>, and implements \<xref:System.IDisposable*>.  
  
     [!code[VSSDKSmartTagTest#4](../vs140/codesnippet/CSharp/walkthrough--displaying-smarttags_4.cs)]
[!code[VSSDKSmartTagTest#4](../vs140/codesnippet/VisualBasic/walkthrough--displaying-smarttags_4.vb)]  
  
6.  Add the following private fields to the tagger class.  
  
     [!code[VSSDKSmartTagTest#5](../vs140/codesnippet/CSharp/walkthrough--displaying-smarttags_5.cs)]
[!code[VSSDKSmartTagTest#5](../vs140/codesnippet/VisualBasic/walkthrough--displaying-smarttags_5.vb)]  
  
7.  Add a constructor that sets the private fields, and subscribes to the \<xref:Microsoft.VisualStudio.Text.Editor.ITextView.LayoutChanged*> event.  
  
     [!code[VSSDKSmartTagTest#6](../vs140/codesnippet/CSharp/walkthrough--displaying-smarttags_6.cs)]
[!code[VSSDKSmartTagTest#6](../vs140/codesnippet/VisualBasic/walkthrough--displaying-smarttags_6.vb)]  
  
8.  Implement <xref:Microsoft.VisualStudio.Text.Tagging.ITagger<CodeContentPlaceHolder>9\</CodeContentPlaceHolder>GetSmartTagActions<CodeContentPlaceHolder>10\</CodeContentPlaceHolder>GetSmartTagActions<CodeContentPlaceHolder>11\</CodeContentPlaceHolder>SmartTagsChanged<CodeContentPlaceHolder>12\</CodeContentPlaceHolder>OnLayoutChanged<CodeContentPlaceHolder>13\</CodeContentPlaceHolder>TagsChanged<CodeContentPlaceHolder>14\</CodeContentPlaceHolder>1.GetTags*> to be called.  
  
     [!code[VSSDKSmartTagTest#10](../vs140/codesnippet/CSharp/walkthrough--displaying-smarttags_10.cs)]
[!code[VSSDKSmartTagTest#10](../vs140/codesnippet/VisualBasic/walkthrough--displaying-smarttags_10.vb)]  
  
12. Implement the \<xref:System.IDisposable.Dispose*> method so that it unsubscribes from the \<xref:Microsoft.VisualStudio.Text.Editor.ITextView.LayoutChanged*> event.  
  
     [!code[VSSDKSmartTagTest#11](../vs140/codesnippet/CSharp/walkthrough--displaying-smarttags_11.cs)]
[!code[VSSDKSmartTagTest#11](../vs140/codesnippet/VisualBasic/walkthrough--displaying-smarttags_11.vb)]  
  
## Implementing the Smart Tag Tagger Provider  
  
#### To implement the smart tag tagger provider  
  
1.  Add a class named <CodeContentPlaceHolder>15\</CodeContentPlaceHolder> that inherits from \<xref:Microsoft.VisualStudio.Text.Tagging.IViewTaggerProvider*>. Export it with a \<xref:Microsoft.VisualStudio.Utilities.ContentTypeAttribute*> of "text", a \<xref:Microsoft.VisualStudio.Utilities.OrderAttribute*> of Before="default", and a \<xref:Microsoft.VisualStudio.Text.Tagging.TagTypeAttribute*> of \<xref:Microsoft.VisualStudio.Language.Intellisense.SmartTag*>.  
  
     [!code[VSSDKSmartTagTest#12](../vs140/codesnippet/CSharp/walkthrough--displaying-smarttags_12.cs)]
[!code[VSSDKSmartTagTest#12](../vs140/codesnippet/VisualBasic/walkthrough--displaying-smarttags_12.vb)]  
  
2.  Import the \<xref:Microsoft.VisualStudio.Text.Operations.ITextStructureNavigatorSelectorService*> as a property.  
  
     [!code[VSSDKSmartTagTest#13](../vs140/codesnippet/CSharp/walkthrough--displaying-smarttags_13.cs)]
[!code[VSSDKSmartTagTest#13](../vs140/codesnippet/VisualBasic/walkthrough--displaying-smarttags_13.vb)]  
  
3.  Implement the \<xref:Microsoft.VisualStudio.Text.Tagging.IViewTaggerProvider.CreateTagger*> method.  
  
     [!code[VSSDKSmartTagTest#14](../vs140/codesnippet/CSharp/walkthrough--displaying-smarttags_14.cs)]
[!code[VSSDKSmartTagTest#14](../vs140/codesnippet/VisualBasic/walkthrough--displaying-smarttags_14.vb)]  
  
## Implementing Smart Tag Actions  
  
#### To implement smart tag actions  
  
1.  Create two classes, the first named <CodeContentPlaceHolder>16\</CodeContentPlaceHolder> and the second named <CodeContentPlaceHolder>17\</CodeContentPlaceHolder>. Both classes implement \<xref:Microsoft.VisualStudio.Language.Intellisense.ISmartTagAction*>.  
  
     [!code[VSSDKSmartTagTest#15](../vs140/codesnippet/CSharp/walkthrough--displaying-smarttags_15.cs)]
[!code[VSSDKSmartTagTest#15](../vs140/codesnippet/VisualBasic/walkthrough--displaying-smarttags_15.vb)]  
  
     [!code[VSSDKSmartTagTest#16](../vs140/codesnippet/CSharp/walkthrough--displaying-smarttags_16.cs)]
[!code[VSSDKSmartTagTest#16](../vs140/codesnippet/VisualBasic/walkthrough--displaying-smarttags_16.vb)]  
  
 Both classes are alike except that one calls \<xref:System.String.ToUpper*> and the other calls \<xref:System.String.ToLower*>. The following steps cover only the uppercase action class, but you must implement both classes. Use the steps for implementing the uppercase action as a pattern for implementing the lowercase action.  
  
1.  Declare a set of private fields.  
  
     [!code[VSSDKSmartTagTest#17](../vs140/codesnippet/CSharp/walkthrough--displaying-smarttags_17.cs)]
[!code[VSSDKSmartTagTest#17](../vs140/codesnippet/VisualBasic/walkthrough--displaying-smarttags_17.vb)]  
  
2.  Add a constructor that sets the fields.  
  
     [!code[VSSDKSmartTagTest#18](../vs140/codesnippet/CSharp/walkthrough--displaying-smarttags_18.cs)]
[!code[VSSDKSmartTagTest#18](../vs140/codesnippet/VisualBasic/walkthrough--displaying-smarttags_18.vb)]  
  
3.  Implement the properties as follows.  
  
     [!code[VSSDKSmartTagTest#19](../vs140/codesnippet/CSharp/walkthrough--displaying-smarttags_19.cs)]
[!code[VSSDKSmartTagTest#19](../vs140/codesnippet/VisualBasic/walkthrough--displaying-smarttags_19.vb)]  
  
4.  Implement the \<xref:Microsoft.VisualStudio.Language.Intellisense.ISmartTagAction.Invoke*> method by replacing the text in the span with its uppercase equivalent.  
  
     [!code[VSSDKSmartTagTest#20](../vs140/codesnippet/CSharp/walkthrough--displaying-smarttags_20.cs)]
[!code[VSSDKSmartTagTest#20](../vs140/codesnippet/VisualBasic/walkthrough--displaying-smarttags_20.vb)]  
  
## Building and Testing the Code  
 To test this code, build the SmartTagTest solution and run it in the experimental instance.  
  
#### To build and test the SmartTagTest solution  
  
1.  Build the solution.  
  
2.  When you run this project in the debugger, a second instance of Visual Studio is instantiated.  
  
3.  Create a text file and type some text.  
  
     A blue line should be displayed under the first letter of the first word of the text.  
  
4.  Move the pointer over the blue line.  
  
     A button should be displayed near the pointer.  
  
5.  When you click the button, two suggested actions should be displayed: **Convert to upper case** and **Convert to lower case**. If you click the first action, all the text in the current word should be converted to upper case. If you click the second action, all the text should be converted to lower case.  
  
## See Also  
 [How to: Link a Content Type to a File Extension](../vs140/walkthrough--linking-a-content-type-to-a-file-name-extension.md)