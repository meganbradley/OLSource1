---
title: "How to: Create XML Snippets"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "vs-ide-general"
ms.tgt_pltfrm: na
ms.topic: "article"
ms.assetid: d8556dd7-1382-4af7-ba80-3e873c9416be
caps.latest.revision: 6
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# How to: Create XML Snippets
The XML Editor can be used to create new XML snippets. The editor includes an XML snippet, named "Snippet", that is a boilerplate snippet for creating new XML snippets.  
  
## To create a new XML snippet  
 To create a new XML code snippet create a new XML file and use the **Insert Snippet** feature.  
  
1.  On the **File** menu, click **New** and then click **File**.  
  
2.  Click **XML File** and then click **Open**.  
  
3.  Right-click in the editor pane and select **Insert Snippet**.  
  
4.  Select **Snippet** from the list and press ENTER.  
  
5.  Make any changes to the new snippet.  
  
6.  From the **File** menu select **Save XMLFile.xml**.  
  
     The **Save File As** dialog box is displayed.  
  
7.  Enter the name for the new snippet and select **Snippet Files** from the **Save as type** drop-down window.  
  
8.  Use the **Save in** drop-down list to change the file location to the My Documents\Visual Studio 2005\Code Snippets\XML\My XML Snippets folder and then press **Save**.  
  
## Snippet Description  
 This section describes some of the key elements in the boilerplate snippet. For more information about schema elements used by the XML snippets, see [Code Snippets Schema Reference](../vs140/code-snippets-schema-reference.md).  
  
### SnippetType Element  
 The editor supports two snippet types:  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
 The <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> type determines whether the snippet appears when you invoke the **Insert Snippet** command. The <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> type determines whether the snippet appears when you invoke the **Surrounds With** command.  
  
### Code Element  
 The <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> element defines the XML text that will be inserted when the snippet is invoked.  
  
> [!NOTE]
>  The XML snippet text must be enclosed in a <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> section.  
  
 The following is the <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> element that is created by the boilerplate snippet.  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 The <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> element includes three variables.  
  
-   $name$ is user-defined variable. It creates a <CodeContentPlaceHolder>11\</CodeContentPlaceHolder> element, which has an editable value that defaults to "name". User-defined variables are defined using the <CodeContentPlaceHolder>12\</CodeContentPlaceHolder> element.  
  
-   $selected$ is a predefined variable. It represents the text that was selected in the XML Editor before invoking the snippet. The placement of this variable determines where the selected text appears in the code snippet that surrounds that selection.  
  
-   $end$ is a predefined variable. When the user presses ENTER to finish editing the code snippet fields, this variable determines where the caret (^) is moved to.  
  
 The above <CodeContentPlaceHolder>13\</CodeContentPlaceHolder> element inserts the following XML text:  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 The value of the name element is marked as an editable region.  
  
### Literal Element  
 The <CodeContentPlaceHolder>14\</CodeContentPlaceHolder> element is used to identify replacement text that can be customized after it is inserted into the file. For example, literal strings, numeric values, and some variable names can be declared as literals. You can define any number of literals in your XML snippet and you can refer to them multiple times from within the snippet. The following is an example of a <CodeContentPlaceHolder>15\</CodeContentPlaceHolder> element that defines a $name$ variable whose default value is "name."  
  
<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 Literals can also refer to functions. The XML Editor includes a function named **LookupPrefix**. The **LookupPrefix** function looks up the given namespace URI from the location in the XML document that this snippet is invoked from and returns the namespace prefix that is defined for that namespace, if any, and it includes the colon (:) in that name. The following is an example of a <CodeContentPlaceHolder>16\</CodeContentPlaceHolder> element that uses the **LookupPrefix** function.  
  
<CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
 The $prefix$ variable can then be used elsewhere in your XML snippet.  
  
## See Also  
 [XML Snippets](../vs140/xml-snippets.md)   
 [How To: Use XML Snippets](../vs140/how-to--use-xml-snippets.md)   
 [How To: Generate an XML Snippet From an XML Schema](../vs140/how-to--generate-an-xml-snippet-from-an-xml-schema.md)