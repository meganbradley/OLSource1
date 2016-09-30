---
title: "Create XML Documentation Comments for JavaScript IntelliSense"
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
  - "code comments, JavaScript IntelliSense"
  - "XML documentation comments, JavaScript IntelliSense"
  - "documentation comments [JavaScript]"
  - "IntelliSense [JavaScript], XML documentation comments"
ms.assetid: a27f5b50-9807-436f-a0cf-6f3137ecbaf0
caps.latest.revision: 19
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Create XML Documentation Comments for JavaScript IntelliSense
*XML documentation comments* are JavaScript comments that you add to a script to provide information about code elements such as functions, fields, and variables. In Visual Studio, these text descriptions are displayed with IntelliSense when you reference the script function.  
  
 This topic provides a basic tutorial on using XML documentation comments. For information about using other elements, such as [\<var>](../vs140/-var---javascript-.md) and [\<value>](../vs140/-value---javascript-.md), and for additional code examples, see [XML Documentation Comments](../vs140/xml-documentation-comments--javascript-.md). For information about providing IntelliSense information for an asynchronous callback such as a <CodeContentPlaceHolder>11\</CodeContentPlaceHolder>, see [\<returns>](../vs140/-returns---javascript-.md).  
  
> [!NOTE]
>  XML documentation comments are available only from referenced files, assemblies, and services.  
  
### To create XML documentation comments for a JavaScript function  
  
-   In the function, add [\<summary>](../vs140/-summary---javascript-.md), [\<param>](../vs140/-param---javascript-.md), and [\<returns>](../vs140/-returns---javascript-.md) elements, and precede each element with three slash marks (///).  
  
    > [!NOTE]
    >  Each element must be on a single line.  
  
     The following example shows a JavaScript function.  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
-   To view the XML documentation comments, type the name and the opening parenthesis of a function that is marked with XML documentation comments, as in the following example:  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
     When you type the opening parenthesis of the function that contains the XML documentation comments, the Code Editor uses IntelliSense to display the information that is defined in XML documentation comments.  
  
### To create XML Documentation comments for a JavaScript field  
  
-   In a constructor function or object definition, add a [\<field>](../vs140/-field---javascript-.md) element preceded by three slash marks (///).  
  
     The following example shows the use of the <CodeContentPlaceHolder>12\</CodeContentPlaceHolder> element in a constructor function. For additional examples, see [\<field>](../vs140/-field---javascript-.md).  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
-   To view the XML documentation comments, create an object by using the function constructor that is marked with XML documentation comments, as in the following example.  
  
<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
-   On the next line, type the name of the object and a period to show IntelliSense information for the field.  
  
<CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
### To create XML documentation comments for an overloaded function  
  
1.  In the function, add a [\<signature>](../vs140/-signature---javascript-.md) element for each overload. In these elements, add other elements, such as <CodeContentPlaceHolder>13\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>14\</CodeContentPlaceHolder>, and <CodeContentPlaceHolder>15\</CodeContentPlaceHolder>, preceding each element with three slash marks (///).  
  
     The following example shows an overloaded JavaScript function. In this example, the overloads differ by parameter type.  
  
<CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
2.  To view the XML documentation comments, type the name and the opening parenthesis of the function that is marked with XML documentation comments, as in the following example:  
  
<CodeContentPlaceHolder>6\</CodeContentPlaceHolder>  
### To create localized IntelliSense  
  
1.  Create an XML file that has documentation comments in the OpenAjax MessageBundle format.  
  
    > [!IMPORTANT]
    >  MessageBundle is the recommended format. This format is not supported in Microsoft Ajax or in .winmd files. For information about using the alternative <CodeContentPlaceHolder>16\</CodeContentPlaceHolder> format, see [\<loc>](../vs140/-loc---javascript-.md).  
  
     The following example shows content in a sidecar file that contains the localized IntelliSense information. This is an XML file that's located in a culture-specific folder, like JA. The folder must be in the same location as the .js file that contains the <CodeContentPlaceHolder>17\</CodeContentPlaceHolder> element. The file name of the XML file must match the <CodeContentPlaceHolder>18\</CodeContentPlaceHolder> parameter specified in the <CodeContentPlaceHolder>19\</CodeContentPlaceHolder> element.  
  
<CodeContentPlaceHolder>7\</CodeContentPlaceHolder>  
2.  In your .js file, add the following code. The <CodeContentPlaceHolder>20\</CodeContentPlaceHolder> element must be declared before any script, and follows the same usage rules as the <CodeContentPlaceHolder>21\</CodeContentPlaceHolder> element. For more information, see [JavaScript IntelliSense](../vs140/javascript-intellisense.md) and [\<loc>](../vs140/-loc---javascript-.md).  
  
<CodeContentPlaceHolder>8\</CodeContentPlaceHolder>  
3.  In your .js file, add the XML documentation elements and default descriptions. Set the <CodeContentPlaceHolder>22\</CodeContentPlaceHolder> attribute values to match the corresponding <CodeContentPlaceHolder>23\</CodeContentPlaceHolder> attribute values from the sidecar file. The default descriptions will be replaced by localized IntelliSense information, if it's available.  
  
<CodeContentPlaceHolder>9\</CodeContentPlaceHolder>  
4.  To view the XML documentation comments, type the name and the opening parenthesis of the function, as in the following example:  
  
<CodeContentPlaceHolder>10\</CodeContentPlaceHolder>  
## See Also  
 [JavaScript IntelliSense Overview](../vs140/javascript-intellisense.md)   
 [XML Documentation Comments](../vs140/xml-documentation-comments--javascript-.md)   
 [NIB: Walkthrough: JavaScript IntelliSense in ASP.NET](assetId:///4f6e0cc2-7f48-4dbf-abb0-7fb743a2d05b)