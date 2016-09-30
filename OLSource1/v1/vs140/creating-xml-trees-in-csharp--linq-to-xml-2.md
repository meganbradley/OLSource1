---
title: "Creating XML Trees in C# (LINQ to XML)2"
ms.custom: na
ms.date: "09/22/2016"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-csharp"
ms.tgt_pltfrm: na
ms.topic: "article"
H1: "Creating XML Trees in C# (LINQ to XML)"
dev_langs: 
  - "CSharp"
ms.assetid: cc74234a-0bac-4327-9c8c-5a2ead15b595
caps.latest.revision: 7
---
# Creating XML Trees in C# (LINQ to XML)2
This section provides information about creating XML trees in C#.  
  
 For information about using the results of LINQ queries as the content for an \<xref:System.Xml.Linq.XElement*>, see [Functional Construction (LINQ to XML) (C#)](../vs140/functional-construction--linq-to-xml---csharp-.md).  
  
## Constructing Elements  
 The signatures of the \<xref:System.Xml.Linq.XElement*> and \<xref:System.Xml.Linq.XAttribute*> constructors let you pass the contents of the element or attribute as arguments to the constructor. Because one of the constructors takes a variable number of arguments, you can pass any number of child elements. Of course, each of those child elements can contain their own child elements. For any element, you can add any number of attributes.  
  
 When adding \<xref:System.Xml.Linq.XNode*> (including \<xref:System.Xml.Linq.XElement*>) or \<xref:System.Xml.Linq.XAttribute*> objects, if the new content has no parent, the objects are simply attached to the XML tree. If the new content already is parented, and is part of another XML tree, the new content is cloned, and the newly cloned content is attached to the XML tree. The last example in this topic demonstrates this.  
  
 To create a <CodeContentPlaceHolder>15\</CodeContentPlaceHolder>\<xref:System.Xml.Linq.XElement*>, you could use the following code:  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
 If indented properly, the code to construct \<xref:System.Xml.Linq.XElement*> objects closely resembles the structure of the underlying XML.  
  
## XElement Constructors  
 The \<xref:System.Xml.Linq.XElement*> class uses the following constructors for functional construction. Note that there are some other constructors for \<xref:System.Xml.Linq.XElement*>, but because they are not used for functional construction they are not listed here.  
  
|Constructor|Description|  
|-----------------|-----------------|  
|<CodeContentPlaceHolder>16\</CodeContentPlaceHolder>|Creates an \<xref:System.Xml.Linq.XElement*>. The <CodeContentPlaceHolder>17\</CodeContentPlaceHolder> parameter specifies the name of the element; <CodeContentPlaceHolder>18\</CodeContentPlaceHolder> specifies the content of the element.|  
|<CodeContentPlaceHolder>19\</CodeContentPlaceHolder>|Creates an \<xref:System.Xml.Linq.XElement*> with its \<xref:System.Xml.Linq.XName*> initialized to the specified name.|  
|<CodeContentPlaceHolder>20\</CodeContentPlaceHolder>|Creates an \<xref:System.Xml.Linq.XElement*> with its \<xref:System.Xml.Linq.XName*> initialized to the specified name. The attributes and/or child elements are created from the contents of the parameter list.|  
  
 The <CodeContentPlaceHolder>21\</CodeContentPlaceHolder> parameter is extremely flexible. It supports any type of object that is a valid child of an \<xref:System.Xml.Linq.XElement*>. The following rules apply to different types of objects passed in this parameter:  
  
-   A string is added as text content.  
  
-   An \<xref:System.Xml.Linq.XElement*> is added as a child element.  
  
-   An \<xref:System.Xml.Linq.XAttribute*> is added as an attribute.  
  
-   An \<xref:System.Xml.Linq.XProcessingInstruction*>, \<xref:System.Xml.Linq.XComment*>, or \<xref:System.Xml.Linq.XText*> is added as child content.  
  
-   An \<xref:System.Collections.IEnumerable*> is enumerated, and these rules are applied recursively to the results.  
  
-   For any other type, its <CodeContentPlaceHolder>22\</CodeContentPlaceHolder> method is called and the result is added as text content.  
  
### Creating an XElement with Content  
 You can create an \<xref:System.Xml.Linq.XElement*> that contains simple content with a single method call. To do this, specify the content as the second parameter, as follows:  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 This example produces the following output:  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 You can pass any type of object as the content. For example, the following code creates an element that contains a floating point number as content:  
  
<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 This example produces the following output:  
  
<CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
 The floating point number is boxed and passed in to the constructor. The boxed number is converted to a string and used as the content of the element.  
  
### Creating an XElement with a Child Element  
 If you pass an instance of the \<xref:System.Xml.Linq.XElement*> class for the content argument, the constructor creates an element with a child element:  
  
<CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
 This example produces the following output:  
  
<CodeContentPlaceHolder>6\</CodeContentPlaceHolder>  
### Creating an XElement with Multiple Child Elements  
 You can pass in a number of \<xref:System.Xml.Linq.XElement*> objects for the content. Each of the \<xref:System.Xml.Linq.XElement*> objects is included as a child element.  
  
<CodeContentPlaceHolder>7\</CodeContentPlaceHolder>  
 This example produces the following output:  
  
<CodeContentPlaceHolder>8\</CodeContentPlaceHolder>  
 By extending the above example, you can create an entire XML tree, as follows:  
  
<CodeContentPlaceHolder>9\</CodeContentPlaceHolder>  
 This example produces the following output:  
  
<CodeContentPlaceHolder>10\</CodeContentPlaceHolder>  
### Creating an Empty Element  
 To create an empty \<xref:System.Xml.Linq.XElement*>, you do not pass any content to the constructor. The following example creates an empty element:  
  
<CodeContentPlaceHolder>11\</CodeContentPlaceHolder>  
 This example produces the following output:  
  
<CodeContentPlaceHolder>12\</CodeContentPlaceHolder>  
### Attaching vs. Cloning  
 As mentioned previously, when adding \<xref:System.Xml.Linq.XNode*> (including \<xref:System.Xml.Linq.XElement*>) or \<xref:System.Xml.Linq.XAttribute*> objects, if the new content has no parent, the objects are simply attached to the XML tree. If the new content already is parented and is part of another XML tree, the new content is cloned, and the newly cloned content is attached to the XML tree.  
  
<CodeContentPlaceHolder>13\</CodeContentPlaceHolder>  
 This example produces the following output:  
  
<CodeContentPlaceHolder>14\</CodeContentPlaceHolder>  
## See Also  
 [Creating XML Trees (C#)](../vs140/creating-xml-trees--csharp-.md)