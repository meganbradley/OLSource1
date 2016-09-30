---
title: "&lt;signature&gt; (JavaScript)"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "vs-ide-general"
ms.tgt_pltfrm: na
ms.topic: "article"
helpviewer_keywords: 
  - "<signature> JavaScript XML tag"
  - "signature JavaScript XML tag"
ms.assetid: 319138e7-cfbe-4b37-9643-2ddb7f9c63d4
caps.latest.revision: 16
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# &lt;signature&gt; (JavaScript)
Groups a set of related elements for a function or method to provide documentation for overloaded functions.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 Optional. If the <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> attribute for the [\<loc>](../vs140/-loc---javascript-.md) element is <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>, this attribute specifies the member ID used to locate the XML code that's associated with the signature. Unlike the <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> attribute, this attribute specifies that all elements in the member that has this ID should be loaded. Any associated description information present in the XML code will also be merged with the elements specified in the signature. This enables you to specify additional elements, such as <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>, in the sidecar file without specifying them in the source file. <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> is an optional attribute.  
  
 <CodeContentPlaceHolder>8\</CodeContentPlaceHolder>  
 Optional. Specifies the name of the file in which to find the <CodeContentPlaceHolder>9\</CodeContentPlaceHolder>. This attribute is ignored if no <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> is present. This is an optional attribute. The default value is the name of the current file but with a file extension of .xml instead of .js. By default, managed resource lookup rules for localization are used to locate the file.  
  
 <CodeContentPlaceHolder>11\</CodeContentPlaceHolder>  
 Optional. The keyword for F1 help.  
  
 <CodeContentPlaceHolder>12\</CodeContentPlaceHolder>  
 Optional. The identifier for localization information about the field. The identifier is either a member ID or it corresponds to the <CodeContentPlaceHolder>13\</CodeContentPlaceHolder> attribute value in a message bundle defined by OpenAjax metadata. The identifier type depends on the format specified in the [\<loc>](../vs140/-loc---javascript-.md) tag.  
  
## Remarks  
 Use one <CodeContentPlaceHolder>14\</CodeContentPlaceHolder> element for each overloaded function description in the .js file, or use one <CodeContentPlaceHolder>15\</CodeContentPlaceHolder> element for each external member ID specified.  
  
 The <CodeContentPlaceHolder>16\</CodeContentPlaceHolder> element must be placed in the function body before any statements. When using [\<summary>](../vs140/-summary---javascript-.md), [\<param>](../vs140/-param---javascript-.md), or [\<returns>](../vs140/-returns---javascript-.md) elements with the <CodeContentPlaceHolder>17\</CodeContentPlaceHolder> element, place the other elements inside the <CodeContentPlaceHolder>18\</CodeContentPlaceHolder> block.  
  
## Example  
 The following code example shows how to use the <CodeContentPlaceHolder>19\</CodeContentPlaceHolder> element.  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
## See Also  
 [XML Documentation Comments](../vs140/xml-documentation-comments--javascript-.md)