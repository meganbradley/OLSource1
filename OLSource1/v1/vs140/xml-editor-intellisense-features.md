---
title: "XML Editor IntelliSense Features"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "vs-ide-general"
ms.tgt_pltfrm: na
ms.topic: "article"
ms.assetid: 2b26f214-cc3a-46bf-b260-14eb8e599182
caps.latest.revision: 6
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# XML Editor IntelliSense Features
The XML Editor provides full IntelliSense features comparable to other language editors provided in Visual Studio. This section explains how you can use the IntelliSense with XML Schema definition language (XSD) and XSLT documents.  
  
## IntelliSense in an XSD Document  
 After a schema is associated with your document, you get a drop-down list of expected elements any time you type <CodeContentPlaceHolder>0\</CodeContentPlaceHolder> or click the **Display an Object Member List** button on the XML editor toolbar. For information about how to associate schemas with your XML documents, see [XML Document Validation](../vs140/xml-document-validation.md).  
  
 When you type SPACE from inside a start tag, you also get a drop-down list showing all attributes that can be added to the current element.  
  
 When you type <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> for an attribute value, or the opening quote for the value, you also get list of possible values for that attribute. Values are only provided if the schema provides enumerated values via <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> facets, or if the attribute is a <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> type. An IntelliSense list of known language codes is also provided for <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> or any <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> that derives from <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>. An IntelliSense list of known <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> values is provided for namespace declarations.  
  
 An IntelliSense list of possible values is also provided when you type <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> to close a start tag if the element is a <CodeContentPlaceHolder>9\</CodeContentPlaceHolder>. The behavior for elements is similar to the behavior for attributes described in the previous paragraph.  
  
 ToolTips also appear on these IntelliSense lists based on <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>11\</CodeContentPlaceHolder> information found in the associated schema.  
  
## IntelliSense in an XSLT Document  
 After you add a named template or an attribute to your XSLT document, you can use IntelliSense to insert the following:  
  
-   Attribute set names.  
  
-   Template modes.  
  
-   Template names.  
  
-   Parameter names for a given mode.  
  
-   Parameter names for a given named template.  
  
 For more information, see [Walkthrough: Using XSLT IntelliSence](../vs140/walkthrough--using-xslt-intellisense.md) topic.  
  
## Auto-Completion  
 The XML editor also makes editing XML easier by filling in required XML syntax for you. For example, if you type the following start tag:  
  
 <CodeContentPlaceHolder>12\</CodeContentPlaceHolder>  
  
 The XML editor fills in the end tag and positions the cursor after the start tag. The following is an example of this (the "&#124;" notes the cursor position):  
  
 <CodeContentPlaceHolder>13\</CodeContentPlaceHolder>&#124;<CodeContentPlaceHolder>14\</CodeContentPlaceHolder>  
  
 Because attribute values must always have quotes, the XML editor fills in the quotes for you. For example, if you type the following:  
  
 <CodeContentPlaceHolder>15\</CodeContentPlaceHolder>  
  
 The XML editor adds the quotes and positions the cursor between the quotes:  
  
 <CodeContentPlaceHolder>16\</CodeContentPlaceHolder>&#124;<CodeContentPlaceHolder>17\</CodeContentPlaceHolder>  
  
 Similarly, the XML editor also inserts the following XML syntax automatically for you:  
  
-   End a processing instruction:  <CodeContentPlaceHolder>18\</CodeContentPlaceHolder>  
  
-   End a CDATA block: <CodeContentPlaceHolder>19\</CodeContentPlaceHolder>  
  
-   End a comment: <CodeContentPlaceHolder>20\</CodeContentPlaceHolder>  
  
-   End a DTD declaration: <CodeContentPlaceHolder>21\</CodeContentPlaceHolder>  
  
 The XML Editor also has the ability to insert a namespace declaration if you select a namespace qualified element or attribute from an IntelliSense list and the namespace for that element or attribute is not yet in scope.  
  
 For example, if you select the <CodeContentPlaceHolder>22\</CodeContentPlaceHolder> element from the IntelliSense list where the prefix is bound to the <CodeContentPlaceHolder>23\</CodeContentPlaceHolder> namespace that has not been declared in the document, the XML editor inserts the required namespace declaration for you. The following is the resulting XML text:  
  
 <CodeContentPlaceHolder>24\</CodeContentPlaceHolder>  
  
## Brace Matching  
 The XML editor provides brace highlighting to give you immediate feedback on elements you have just closed. You can also use the keyboard shortcut (CTRL+]) to jump from one brace to the matching brace.  
  
 The XML editor does this for the following items:  
  
-   Matching start and end tags.  
  
-   Any pair of "\<" or ">" angle brackets.  
  
-   Start and end of comments.  
  
-   Start and end of processing instructions.  
  
-   Start and end of CDATA blocks.  
  
-   Start and end of DTD declarations.  
  
-   Opening and closing quotes on attributes.  
  
## Modifying the IntelliSense Options  
 The IntelliSense and auto-completion features are enabled by default. However, you can change this by modifying your Tools-Options settings.  
  
 The **Auto Insert** section of the **Miscellaneous** page controls the following behavior:  
  
|Name|Description|  
|----------|-----------------|  
|Close tags|Inserts close tags for new elements.|  
|Attribute quotes|Inserts attribute value quotes when you enter a new attribute name.|  
|Other markup|Completes comments, CDATA, DOCTYPE, processing instructions, and other markup declarations.|  
  
#### To change the auto-completion behavior  
  
1.  Select **Options** from the **Tools** menu.  
  
2.  Expand **Text Editor**, expand **XML**, and select **Miscellaneous**.  
  
3.  Make any changes to the **Auto insert** section and click **OK**.  
  
## See Also  
 [XML Editor](../vs140/xml-editor.md)   
 [Using IntelliSense](../vs140/using-intellisense.md)   
 [Walkthrough: Using XSLT IntelliSense](../vs140/walkthrough--using-xslt-intellisense.md)