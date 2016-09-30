---
title: "&lt;loc&gt; (JavaScript)"
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
  - "<loc> JavaScript XML tag"
  - "loc JavaScript XML tag"
ms.assetid: 0d3349b6-4bdd-418f-bc11-73665305baae
caps.latest.revision: 21
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# &lt;loc&gt; (JavaScript)
Specifies the location and type of the sidecar file that provides localized IntelliSense information.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
 Optional. The root name of the sidecar file that contains localization information for the neutral culture. When Visual Studio searches for localization information, it attempts to find a culture-specific version of this file. For example, if <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> is jquery.xml, Visual Studio searches for the correct culture-specific folder (like JA) in the same location as the .js file that contains the <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> element. If it locates the culture-specific folder, it checks whether a jquery.xml file exists in it. If it cannot locate the correct file, it instead uses managed resource location rules. The default value for <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> is the name of the current file, but with an .xml extension instead of .js.  
  
 <CodeContentPlaceHolder>9\</CodeContentPlaceHolder>  
 Optional. The type of sidecar file used for localization. Use <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> to specify the use of message bundles defined by Open Ajax metadata. <CodeContentPlaceHolder>11\</CodeContentPlaceHolder> is the recommended format. However, this format is not supported in Microsoft Ajax or in .winmd files. Use <CodeContentPlaceHolder>12\</CodeContentPlaceHolder> to specify the standard .NET Framework localization format that is used by Microsoft Ajax and Windows Runtime. This attribute is optional. <CodeContentPlaceHolder>13\</CodeContentPlaceHolder> is the default format.  
  
## Remarks  
 The <CodeContentPlaceHolder>14\</CodeContentPlaceHolder> element must appear at the top of the file in the same section as the <CodeContentPlaceHolder>15\</CodeContentPlaceHolder> element. Usage rules for the <CodeContentPlaceHolder>16\</CodeContentPlaceHolder> element are the same as the <CodeContentPlaceHolder>17\</CodeContentPlaceHolder> element. For more information, see the “References Directives” section in [JavaScript IntelliSense](../vs140/javascript-intellisense.md).  
  
 Visual Studio processes a single <CodeContentPlaceHolder>18\</CodeContentPlaceHolder> element for each .js file. If multiple <CodeContentPlaceHolder>19\</CodeContentPlaceHolder> elements are present, only a single <CodeContentPlaceHolder>20\</CodeContentPlaceHolder> element is used. Behavior for determining which <CodeContentPlaceHolder>21\</CodeContentPlaceHolder> element to use is not defined.  
  
 When using message bundle format, use the <CodeContentPlaceHolder>22\</CodeContentPlaceHolder> attribute in XML documentation comments to specify the <CodeContentPlaceHolder>23\</CodeContentPlaceHolder> attribute value.  
  
## Example  
 The following example shows how to use the <CodeContentPlaceHolder>24\</CodeContentPlaceHolder> element with messagebundle format. Add the following XML to a file named messageFilename.xml and place the file in the correct culture-specific folder, as specified in the description of the <CodeContentPlaceHolder>25\</CodeContentPlaceHolder> parameter.  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 For the messagebundle example, add the following code to a JavaScript file in your project. The <CodeContentPlaceHolder>26\</CodeContentPlaceHolder> element must appear as the first line in the JavaScript file. The descriptions in this code will be replaced by localized descriptions, if available.  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 The following example uses VSDoc format. Add the following XML to a file named scriptFilename.xml and place the file in the correct culture-specific folder.  
  
<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 For the VSDoc example, add the following code to a JavaScript file in your project. The descriptions in this code will be replaced by localized descriptions, if available.  
  
<CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
## See Also  
 [XML Documentation Comments](../vs140/xml-documentation-comments--javascript-.md)