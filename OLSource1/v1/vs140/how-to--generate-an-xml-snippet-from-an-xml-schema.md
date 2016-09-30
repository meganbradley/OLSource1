---
title: "How to: Generate an XML Snippet From an XML Schema"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "vs-ide-general"
ms.tgt_pltfrm: na
ms.topic: "article"
ms.assetid: 2c128d2a-aaa6-4814-aa95-e07056afe338
caps.latest.revision: 6
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# How to: Generate an XML Snippet From an XML Schema
The XML Editor has the ability to generate XML snippets from an XML Schema definition language (XSD) schema. For example, as you are authoring an XML file, while positioned next to the element name, you can press TAB to populate the element with XML data generated from the schema information for that element.  
  
 This feature is only available on elements. The following rules also apply:  
  
-   The element must have an associated schema type; that is, the element must be valid according to some associated schema. The schema type cannot be abstract and the type must contain the required attributes and/or required child elements.  
  
-   The current element in the editor must be empty with no attributes. For example,  the following are all valid  
  
    -   <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
  
    -   <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
  
    -   <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
  
-   The cursor must be located immediately to the right of the element name.  
  
 The generated snippet contains all required attributes and elements. If <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> is greater than one, the required minimum number of instances of that element is included in the snippet, up to a maximum of 100 instances. Any fixed values found in the schema result in fixed values in the snippet. <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> elements are ignored and result in no additional snippet constructs.  
  
 Default values are generated and noted as editable values. If the schema specifies a default value, this default value is used. However, if the schema default value is an empty string, the editor generates the default values in the following manner:  
  
-   If the schema type contains any enumeration facets, either directly or indirectly by means of any of members of a union type, the first enumerated value found in the Schema Object Model is used as the default.  
  
-   If the schema type is an atomic type, the editor gets the atomic type and inserts the atomic type name. For a derived simple type it uses the base simple type. For a list type the atomic type is the <CodeContentPlaceHolder>8\</CodeContentPlaceHolder>. For a union, the atomic type is the atomic type of the first <CodeContentPlaceHolder>9\</CodeContentPlaceHolder>.  
  
## Example  
 The steps in this section show you how use the schema-generated XML snippet feature of the XML Editor.  
  
> [!NOTE]
>  Before starting these procedures, save the schema file to your local computer.  
  
#### To create a new XML file and associate it with an XML Schema  
  
1.  On the **File** menu, point to **New**, and click **File**.  
  
2.  Select **XML File** in the **Templates** pane and click **Open**.  
  
     A new file is opened in the editor. The file contains a default XML declaration, <CodeContentPlaceHolder>10\</CodeContentPlaceHolder>.  
  
3.  In the document properties window, click the browse button (**…**) on the **Schemas** field.  
  
     The **XSD Schemas** dialog box is displayed.  
  
4.  Click **Add**.  
  
     The **Open XSD Schema** dialog box is displayed.  
  
5.  Select the schema file and click **Open**.  
  
6.  Click **OK**.  
  
     The XML Schema is now associated with the XML document.  
  
#### To generate an XML snippet  
  
1.  Type <CodeContentPlaceHolder>11\</CodeContentPlaceHolder> in the editor pane.  
  
2.  The members list displays the possible items:  
  
     **!--** to add a comment.  
  
     **!DOCTYPE** to add a document type.  
  
     **?** to add a processing instruction.  
  
     **Contact** to add the root element.  
  
3.  Select **Contact** from the member list and press ENTER.  
  
     The editor adds the start tag <CodeContentPlaceHolder>12\</CodeContentPlaceHolder> and positions the cursor after the element name.  
  
4.  Press TAB to generate XML data for the <CodeContentPlaceHolder>13\</CodeContentPlaceHolder> element based on its schema information.  
  
### Input  
 The following schema file is used by the walkthrough.  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
### Output  
 Following is the XML data that is generated based on the schema information associated with the <CodeContentPlaceHolder>14\</CodeContentPlaceHolder> element. Items marked as <CodeContentPlaceHolder>15\</CodeContentPlaceHolder> designate editable fields in the XML snippet.  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
## See Also  
 [XML Snippets](../vs140/xml-snippets.md)   
 [How To: Use XML Snippets](../vs140/how-to--use-xml-snippets.md)