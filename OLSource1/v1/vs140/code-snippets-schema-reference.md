---
title: "Code Snippets Schema Reference"
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
  - "schema reference [Visual Studio]"
  - "snippets [Visual Studio], schema reference"
  - "code snippets [Visual Studio], schema reference"
  - "IntelliSense Code Snippets, XML Schema"
ms.assetid: 58a60621-725f-4763-93b7-62ea5424ef88
caps.latest.revision: 21
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Code Snippets Schema Reference
IntelliSense Code Snippets are pre-authored pieces of code that are ready to be inserted into your application with [!INCLUDE[vsprvs](../vs140/includes/vsprvs_md.md)]. You can increase productivity by providing code snippets that reduce the amount of time spent typing repetitive code or searching for samples. You can use the IntelliSense Code Snippet XML schema to create your own code snippets and add them to the code snippets that [!INCLUDE[vsprvs](../vs140/includes/vsprvs_md.md)] already includes.  
  
## IntelliSense Code Snippets Schema Elements  
  
||||  
|-|-|-|  
|[Assembly Element](../vs140/code-snippets-schema-reference.md#assembly)|[HelpUrl Element](../vs140/code-snippets-schema-reference.md#helpurl)|[References Element](../vs140/code-snippets-schema-reference.md#references)|  
|[Author Element](../vs140/code-snippets-schema-reference.md#author)|[ID Element](../vs140/code-snippets-schema-reference.md#id)|[Shortcut Element](../vs140/code-snippets-schema-reference.md#shortcut)|  
|[Code Element](../vs140/code-snippets-schema-reference.md#code)|[Import Element](../vs140/code-snippets-schema-reference.md#import)|[Snippet Element](../vs140/code-snippets-schema-reference.md#snippet)|  
|[CodeSnippet Element](../vs140/code-snippets-schema-reference.md#codesnippet)|[Imports Element](../vs140/code-snippets-schema-reference.md#imports)|[SnippetType Element](../vs140/code-snippets-schema-reference.md#snippettype)|  
|[CodeSnippets Element](../vs140/code-snippets-schema-reference.md#codesnippets)|[Keyword Element](../vs140/code-snippets-schema-reference.md#keyword)|[SnippetTypes Element](../vs140/code-snippets-schema-reference.md#snippettypes)|  
|[Declarations Element](../vs140/code-snippets-schema-reference.md#declarations)|[Keywords Element](../vs140/code-snippets-schema-reference.md#keywords)|[Title Element](../vs140/code-snippets-schema-reference.md#title)|  
|[Default Element](../vs140/code-snippets-schema-reference.md#default)|[Literal Element](../vs140/code-snippets-schema-reference.md#literal)|[ToolTip Element](../vs140/code-snippets-schema-reference.md#tooltip)|  
|[Description Element](../vs140/code-snippets-schema-reference.md#description)|[Namespace Element](../vs140/code-snippets-schema-reference.md#namespace)|[Type Element](../vs140/code-snippets-schema-reference.md#type)|  
|[Function Element](../vs140/code-snippets-schema-reference.md#function)|[Object Element](../vs140/code-snippets-schema-reference.md#object)|[Url Element](../vs140/code-snippets-schema-reference.md#url)|  
|[Header Element](../vs140/code-snippets-schema-reference.md#header)|[Reference Element](../vs140/code-snippets-schema-reference.md#reference)||  
  
##  \<a name="assembly">\</a> Assembly Element  
 Specifies the name of the assembly referenced by the code snippet.  
  
> [!NOTE]
>  The <CodeContentPlaceHolder>33\</CodeContentPlaceHolder> element is only supported by Visual Basic code snippets.  
  
 The text value of the **Assembly** element is either the friendly text name of the assembly, such as <CodeContentPlaceHolder>34\</CodeContentPlaceHolder>, or its strong name, such as <CodeContentPlaceHolder>35\</CodeContentPlaceHolder>.  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
|Parent Element|Description|  
|--------------------|-----------------|  
|[Reference Element](../vs140/code-snippets-schema-reference.md#reference)|Contains information about assembly references required by the code snippet.|  
  
 A text value is required. This text specifies the assembly that the code snippet references.  
  
##  \<a name="author">\</a> Author Element  
 Specifies the name of the snippet author. The **Code Snippets Manager** displays the name stored in the <CodeContentPlaceHolder>36\</CodeContentPlaceHolder> element of the code snippet.  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
|Parent Element|Description|  
|--------------------|-----------------|  
|[Header Element](../vs140/code-snippets-schema-reference.md#header)|Contains general information about the code snippet.|  
  
 A text value is required. This text specifies the author of the code snippet.  
  
##  \<a name="code">\</a> Code Element  
 Provides a container for short code blocks.  
  
 Two reserved words are available for use in the text of the <CodeContentPlaceHolder>37\</CodeContentPlaceHolder> element: <CodeContentPlaceHolder>38\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>39\</CodeContentPlaceHolder>. <CodeContentPlaceHolder>40\</CodeContentPlaceHolder> marks the location to place the cursor after the code snippet is inserted. <CodeContentPlaceHolder>41\</CodeContentPlaceHolder> represents text selected in the document that is to be inserted into the snippet when it is invoked. For example, given a snippet that includes:  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 If the word "Blue" is selected when the user invokes the template, the result is:  
  
<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 You may not use either <CodeContentPlaceHolder>42\</CodeContentPlaceHolder> or <CodeContentPlaceHolder>43\</CodeContentPlaceHolder> more than once in a code snippet. If you do, only the second instance is recognized. Given a snippet that includes:  
  
<CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
 If the word "Blue" is selected, the result is:  
  
<CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
 The initial space appears because there is a space between <CodeContentPlaceHolder>44\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>45\</CodeContentPlaceHolder>.  
  
 All other <CodeContentPlaceHolder>46\</CodeContentPlaceHolder> keywords are dynamically defined in the <CodeContentPlaceHolder>47\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>48\</CodeContentPlaceHolder> tags.  
  
<CodeContentPlaceHolder>6\</CodeContentPlaceHolder>  
|Attribute|Description|  
|---------------|-----------------|  
|<CodeContentPlaceHolder>49\</CodeContentPlaceHolder>|Optional attribute. Specifies the delimiter used to describe literals and objects in the code. By default, the delimiter is <CodeContentPlaceHolder>50\</CodeContentPlaceHolder>.|  
|<CodeContentPlaceHolder>51\</CodeContentPlaceHolder>|Optional attribute. Specifies the kind of code that the snippet contains and the location at which a code snippet must be inserted for the code snippet to compile. The values available are <CodeContentPlaceHolder>52\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>53\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>54\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>55\</CodeContentPlaceHolder>, and <CodeContentPlaceHolder>56\</CodeContentPlaceHolder>.|  
|<CodeContentPlaceHolder>57\</CodeContentPlaceHolder>|Required attribute. Specifies the language of the code snippet.|  
  
|Kind Attribute Value|Description|  
|--------------------------|-----------------|  
|<CodeContentPlaceHolder>58\</CodeContentPlaceHolder>|Specifies that the code snippet is a method body, and therefore, must be inserted inside a method declaration.|  
|<CodeContentPlaceHolder>59\</CodeContentPlaceHolder>|Specifies that the code snippet is a method, and therefore, must be inserted inside a class or module.|  
|<CodeContentPlaceHolder>60\</CodeContentPlaceHolder>|Specifies that the code snippet is a type, and therefore, must be inserted inside a class, module, or namespace.|  
|<CodeContentPlaceHolder>61\</CodeContentPlaceHolder>|Specifies that the snippet is a full code file. These code snippets can be inserted alone into a code file, or inside a namespace.|  
|<CodeContentPlaceHolder>62\</CodeContentPlaceHolder>|Specifies that the snippet can be inserted anywhere. This tag is used for code snippets that are context-independent, such as comments.|  
  
|Language Attribute Value|Description|  
|------------------------------|-----------------|  
|<CodeContentPlaceHolder>63\</CodeContentPlaceHolder>|Identifies a Visual Basic code snippet.|  
|<CodeContentPlaceHolder>64\</CodeContentPlaceHolder>|Identifies a C# code snippet.|  
|<CodeContentPlaceHolder>65\</CodeContentPlaceHolder>|Identifies a C++ code snippet.|  
|<CodeContentPlaceHolder>66\</CodeContentPlaceHolder>|Identifies an XML code snippet.|  
|<CodeContentPlaceHolder>67\</CodeContentPlaceHolder>|Identifies a JavaScript code snippet.|  
|<CodeContentPlaceHolder>68\</CodeContentPlaceHolder>|Identifies a SQL code snippet.|  
|<CodeContentPlaceHolder>69\</CodeContentPlaceHolder>|Identifies an HTML code snippet.|  
  
|Parent Element|Description|  
|--------------------|-----------------|  
|[Snippet Element](../vs140/code-snippets-schema-reference.md#snippet)|Contains the references, imports, declarations, and code for the code snippet.|  
  
 A text value is required. This text specifies the code, along with the literals and objects, that you can use when this code snippet is inserted into a project.  
  
##  \<a name="codesnippet">\</a> CodeSnippet Element  
 Allows you to specify a heading and multiple IntelliSense Code Snippets, which you can insert into Visual Studio code files.  
  
<CodeContentPlaceHolder>7\</CodeContentPlaceHolder>  
|Attribute|Description|  
|---------------|-----------------|  
|<CodeContentPlaceHolder>70\</CodeContentPlaceHolder>|Required attribute. Specifies the schema version of the code snippet. The Format attribute must be a string in the syntax of x.x.x, where each "x" represents a numerical value of the version number. Visual Studio will ignore code snippets with <CodeContentPlaceHolder>71\</CodeContentPlaceHolder> attributes that it does not understand.|  
  
|Child Element|Description|  
|-------------------|-----------------|  
|[Header Element](../vs140/code-snippets-schema-reference.md#header)|Required element. Contains general information about the code snippet. There must be exactly one <CodeContentPlaceHolder>72\</CodeContentPlaceHolder> element in a code snippet.|  
|[Snippet Element](../vs140/code-snippets-schema-reference.md#snippet)|Required element. Contains the code that will be inserted by Visual Studio. There must be exactly one <CodeContentPlaceHolder>73\</CodeContentPlaceHolder> element in a code snippet.|  
  
|Parent Element|Description|  
|--------------------|-----------------|  
|[CodeSnippets Element](../vs140/code-snippets-schema-reference.md#codesnippets)|Root element of the code snippet XML schema.|  
  
##  \<a name="codesnippets">\</a> CodeSnippets Element  
 Groups [CodeSnippet Element](../vs140/code-snippets-schema-reference.md#codesnippet)elements. The <CodeContentPlaceHolder>74\</CodeContentPlaceHolder> element is the root element of the code snippet XML schema.  
  
<CodeContentPlaceHolder>8\</CodeContentPlaceHolder>  
|Child Element|Description|  
|-------------------|-----------------|  
|[CodeSnippet Element](../vs140/code-snippets-schema-reference.md#codesnippet)|Optional element. Parent element for all code snippet data. There may be zero or more <CodeContentPlaceHolder>75\</CodeContentPlaceHolder> elements in a <CodeContentPlaceHolder>76\</CodeContentPlaceHolder> element.|  
  
##  \<a name="declarations">\</a> Declarations Element  
 Specifies the literals and objects that make up the parts of a code snippet that you can edit.  
  
<CodeContentPlaceHolder>9\</CodeContentPlaceHolder>  
|Child Element|Description|  
|-------------------|-----------------|  
|[Literal Element](../vs140/code-snippets-schema-reference.md#literal)|Optional element. Defines the literals of the code snippet that you can edit. There may be zero or more <CodeContentPlaceHolder>77\</CodeContentPlaceHolder> elements in a <CodeContentPlaceHolder>78\</CodeContentPlaceHolder> element.|  
|[Object Element](../vs140/code-snippets-schema-reference.md#object)|Optional element. Defines the objects of the code snippet that you can edit. There may be zero or more <CodeContentPlaceHolder>79\</CodeContentPlaceHolder> elements in a <CodeContentPlaceHolder>80\</CodeContentPlaceHolder> element.|  
  
|Parent Element|Description|  
|--------------------|-----------------|  
|[Snippet Element](../vs140/code-snippets-schema-reference.md#snippet)|Contains the references, imports, declarations, and code for the code snippet.|  
  
##  \<a name="default">\</a> Default Element  
 Specifies the default value of the literal or object for an IntelliSense Code Snippet.  
  
<CodeContentPlaceHolder>10\</CodeContentPlaceHolder>  
|Parent Element|Description|  
|--------------------|-----------------|  
|[Literal Element](../vs140/code-snippets-schema-reference.md#literal)|Defines the literal fields of the code snippet that you can edit.|  
|[Object Element](../vs140/code-snippets-schema-reference.md#object)|Defines the object fields of the code snippet that you can edit.|  
  
 A text value is required. This text specifies the default value of the literal or object that fills the fields of the code snippet that you can edit.  
  
##  \<a name="description">\</a> Description Element  
 Specifies descriptive information about the contents of an IntelliSense Code Snippet.  
  
<CodeContentPlaceHolder>11\</CodeContentPlaceHolder>  
|Parent Element|Description|  
|--------------------|-----------------|  
|[Header Element](../vs140/code-snippets-schema-reference.md#header)|Contains general information about the code snippet.|  
  
 A text value is required. This text describes the code snippet.  
  
##  \<a name="function">\</a> Function Element  
 Specifies a function to execute when the literal or object receives focus in Visual Studio.  
  
> [!NOTE]
>  The <CodeContentPlaceHolder>81\</CodeContentPlaceHolder> element is only supported in Visual C# code snippets.  
  
<CodeContentPlaceHolder>12\</CodeContentPlaceHolder>  
|Parent Element|Description|  
|--------------------|-----------------|  
|[Literal Element](../vs140/code-snippets-schema-reference.md#literal)|Defines the literal fields of the code snippet that you can edit.|  
|[Object Element](../vs140/code-snippets-schema-reference.md#object)|Defines the object fields of the code snippet that you can edit.|  
  
 A text value is required. This text specifies a function to execute when the literal or object field receives focus in Visual Studio.  
  
##  \<a name="header">\</a> Header Element  
 Specifies general information about the IntelliSense Code Snippet.  
  
<CodeContentPlaceHolder>13\</CodeContentPlaceHolder>  
|Child Element|Description|  
|-------------------|-----------------|  
|[Author Element](../vs140/code-snippets-schema-reference.md#author)|Optional element. The name of the person or company that authored the code snippet. There may be zero or one <CodeContentPlaceHolder>82\</CodeContentPlaceHolder> elements in a <CodeContentPlaceHolder>83\</CodeContentPlaceHolder> element.|  
|[Description Element](../vs140/code-snippets-schema-reference.md#description)|Optional element. A description of the code snippet. There may be zero or one <CodeContentPlaceHolder>84\</CodeContentPlaceHolder> elements in a <CodeContentPlaceHolder>85\</CodeContentPlaceHolder> element.|  
|[HelpUrl Element](../vs140/code-snippets-schema-reference.md#helpurl)|Optional element. A URL that contains more information about the code snippet. There may be zero or one <CodeContentPlaceHolder>86\</CodeContentPlaceHolder> elements in a Header element. **Note:**  Visual Studio does not use the <CodeContentPlaceHolder>87\</CodeContentPlaceHolder> element. The element is part of the IntelliSense Code Snippet XML schema and any code snippet containing the element will validate, but the value of the element is never used.|  
|[Keywords Element](../vs140/code-snippets-schema-reference.md#keywords)|Optional element. Groups <CodeContentPlaceHolder>88\</CodeContentPlaceHolder> elements. There may be zero or one <CodeContentPlaceHolder>89\</CodeContentPlaceHolder> elements in a <CodeContentPlaceHolder>90\</CodeContentPlaceHolder> element.|  
|[Shortcut Element](../vs140/code-snippets-schema-reference.md#shortcut)|Optional element. Specifies the shortcut text that can be used to insert the snippet. There may be zero or one <CodeContentPlaceHolder>91\</CodeContentPlaceHolder> elements in a <CodeContentPlaceHolder>92\</CodeContentPlaceHolder> element.|  
|[SnippetTypes Element](../vs140/code-snippets-schema-reference.md#snippettypes)|Optional element. Groups <CodeContentPlaceHolder>93\</CodeContentPlaceHolder> elements. There may be zero or one <CodeContentPlaceHolder>94\</CodeContentPlaceHolder> elements in a <CodeContentPlaceHolder>95\</CodeContentPlaceHolder> element. If there are no <CodeContentPlaceHolder>96\</CodeContentPlaceHolder> elements, the code snippet is always valid.|  
|[Title Element](../vs140/code-snippets-schema-reference.md#title)|Required element. The friendly name of the code snippet. There must be exactly one <CodeContentPlaceHolder>97\</CodeContentPlaceHolder> element in a <CodeContentPlaceHolder>98\</CodeContentPlaceHolder> element.|  
  
|Parent Element|Description|  
|--------------------|-----------------|  
|[CodeSnippet Element](../vs140/code-snippets-schema-reference.md#codesnippet)|Parent element for all code snippet data.|  
  
##  \<a name="helpurl">\</a> HelpUrl Element  
 Specifies a URL that provides more information about a code snippet.  
  
> [!NOTE]
>  Visual Studio does not use the <CodeContentPlaceHolder>99\</CodeContentPlaceHolder> element. The element is part of the IntelliSense Code Snippet XML schema and any code snippet containing the element will validate, but the value of the element is never used.  
  
<CodeContentPlaceHolder>14\</CodeContentPlaceHolder>  
|Parent Element|Description|  
|--------------------|-----------------|  
|[Header Element](../vs140/code-snippets-schema-reference.md#header)|Contains general information about the code snippet.|  
  
 A text value is optional. This text specifies the URL to visit for more information about a code snippet.  
  
##  \<a name="id">\</a> ID Element  
 Specifies a unique identifier for a <CodeContentPlaceHolder>100\</CodeContentPlaceHolder> or <CodeContentPlaceHolder>101\</CodeContentPlaceHolder> element. No two literals or objects in the same code snippet can have the same text value in their <CodeContentPlaceHolder>102\</CodeContentPlaceHolder> elements.Literals and objects cannot contain an <CodeContentPlaceHolder>103\</CodeContentPlaceHolder> element with a value of end. The value <CodeContentPlaceHolder>104\</CodeContentPlaceHolder> is reserved, and is used to mark the location to place the cursor after the code snippet is inserted.  
  
<CodeContentPlaceHolder>15\</CodeContentPlaceHolder>  
|Parent Element|Description|  
|--------------------|-----------------|  
|[Literal Element](../vs140/code-snippets-schema-reference.md#literal)|Defines the literal fields of the code snippet that you can edit.|  
|[Object Element](../vs140/code-snippets-schema-reference.md#object)|Defines the object fields of the code snippet that you can edit.|  
  
 A text value is required. This text specifies the unique identifier for the object or literal.  
  
##  \<a name="import">\</a> Import Element  
 Specifies the imported namespaces used by an IntelliSense Code Snippet.  
  
> [!NOTE]
>  The <CodeContentPlaceHolder>105\</CodeContentPlaceHolder> element is only supported for Visual Basic projects.  
  
<CodeContentPlaceHolder>16\</CodeContentPlaceHolder>  
|Child Element|Description|  
|-------------------|-----------------|  
|[Namespace Element](../vs140/code-snippets-schema-reference.md#namespace)|Required element. Specifies the namespace used by the code snippet. There must be exactly one <CodeContentPlaceHolder>106\</CodeContentPlaceHolder> element in an <CodeContentPlaceHolder>107\</CodeContentPlaceHolder> element.|  
  
|Parent Element|Description|  
|--------------------|-----------------|  
|[Imports Element](../vs140/code-snippets-schema-reference.md#imports)|Grouping element for **Import** elements.|  
  
##  \<a name="imports">\</a> Imports Element  
 Groups individual <CodeContentPlaceHolder>108\</CodeContentPlaceHolder> elements.  
  
> [!NOTE]
>  The <CodeContentPlaceHolder>109\</CodeContentPlaceHolder> element is only supported for Visual Basic projects.  
  
<CodeContentPlaceHolder>17\</CodeContentPlaceHolder>  
|Child Element|Description|  
|-------------------|-----------------|  
|[Import Element](../vs140/code-snippets-schema-reference.md#import)|Optional element. Contains the imported namespaces for the code snippet. There may be zero or more **Import** elements in an <CodeContentPlaceHolder>110\</CodeContentPlaceHolder> element.|  
  
|Parent Element|Description|  
|--------------------|-----------------|  
|[Snippet Element](../vs140/code-snippets-schema-reference.md#snippet)|Contains the references, imports, declarations, and code for the code snippet.|  
  
##  \<a name="keyword">\</a> Keyword Element  
 Specifies a custom keyword for the code snippet. The code snippet keywords are used by Visual Studio and represent a standard way for online content providers to add custom keywords for searching or categorization.  
  
<CodeContentPlaceHolder>18\</CodeContentPlaceHolder>  
|Parent Element|Description|  
|--------------------|-----------------|  
|[Keywords Element](../vs140/code-snippets-schema-reference.md#keywords)|Groups individual <CodeContentPlaceHolder>111\</CodeContentPlaceHolder> elements.|  
  
 A text value is required. The keyword for the code snippet.  
  
##  \<a name="keywords">\</a> Keywords Element  
 Groups individual <CodeContentPlaceHolder>112\</CodeContentPlaceHolder> elements. The code snippet keywords are used by Visual Studio and represent a standard way for online content providers to add custom keywords for searching or categorization  
  
<CodeContentPlaceHolder>19\</CodeContentPlaceHolder>  
|Child Element|Description|  
|-------------------|-----------------|  
|[Keyword Element](../vs140/code-snippets-schema-reference.md#keyword)|Optional element. Contains individual keywords for the code snippet. There may be zero or more <CodeContentPlaceHolder>113\</CodeContentPlaceHolder> elements in a <CodeContentPlaceHolder>114\</CodeContentPlaceHolder> element.|  
  
|Parent Element|Description|  
|--------------------|-----------------|  
|[Header Element](../vs140/code-snippets-schema-reference.md#header)|Contains general information about the code snippet.|  
  
##  \<a name="literal">\</a> Literal Element  
 Defines the literals of the code snippet that you can edit. The <CodeContentPlaceHolder>115\</CodeContentPlaceHolder> element is used to identify a replacement for a piece of code that is entirely contained within the snippet, but will likely be customized after it is inserted into the code. For example, literal strings, numeric values, and some variable names should be declared as literals.  
  
 Literals and objects cannot contain an **ID** element with a value of selected or end. The value <CodeContentPlaceHolder>116\</CodeContentPlaceHolder> represents text selected in the document that is to be inserted into the snippet when it is invoked. <CodeContentPlaceHolder>117\</CodeContentPlaceHolder> marks the location to place the cursor after the code snippet is inserted.  
  
<CodeContentPlaceHolder>20\</CodeContentPlaceHolder>  
|Attribute|Description|  
|---------------|-----------------|  
|<CodeContentPlaceHolder>118\</CodeContentPlaceHolder>|Optional <CodeContentPlaceHolder>119\</CodeContentPlaceHolder> attribute. Specifies whether or not you can edit the literal after the code snippet is inserted. The default value of this attribute is <CodeContentPlaceHolder>120\</CodeContentPlaceHolder>.|  
  
|Child Element|Description|  
|-------------------|-----------------|  
|[Default Element](../vs140/code-snippets-schema-reference.md#default)|Required element. Specifies the literal's default value when you insert the code snippet. There must be exactly one <CodeContentPlaceHolder>121\</CodeContentPlaceHolder> element in a <CodeContentPlaceHolder>122\</CodeContentPlaceHolder> element.|  
|[Function Element](../vs140/code-snippets-schema-reference.md#function)|Optional element. Specifies a function to execute when the literal receives focus in Visual Studio. There may be zero or one <CodeContentPlaceHolder>123\</CodeContentPlaceHolder> elements in a <CodeContentPlaceHolder>124\</CodeContentPlaceHolder> element.|  
|[ID Element](../vs140/code-snippets-schema-reference.md#id)|Required element. Specifies a unique identifier for the literal. There must be exactly one <CodeContentPlaceHolder>125\</CodeContentPlaceHolder> element in a <CodeContentPlaceHolder>126\</CodeContentPlaceHolder> element.|  
|[ToolTip Element](../vs140/code-snippets-schema-reference.md#tooltip)|Optional element. Describes the expected value and usage of the literal. There may be zero or one **Tooltip** elements in a <CodeContentPlaceHolder>127\</CodeContentPlaceHolder> element.|  
  
|Parent Element|Description|  
|--------------------|-----------------|  
|[Declarations Element](../vs140/code-snippets-schema-reference.md#declarations)|Contains the literals and objects of a code snippet that you can edit.|  
  
##  \<a name="namespace">\</a> Namespace Element  
 Specifies the namespace that must be imported for the code snippet to compile and run. The namespace specified in the <CodeContentPlaceHolder>128\</CodeContentPlaceHolder> element is automatically added to an <CodeContentPlaceHolder>129\</CodeContentPlaceHolder> statement at the beginning of the code, if it does not already exist.  
  
> [!NOTE]
>  The <CodeContentPlaceHolder>130\</CodeContentPlaceHolder> element is only supported for Visual Basic projects.  
  
<CodeContentPlaceHolder>21\</CodeContentPlaceHolder>  
|Parent Element|Description|  
|--------------------|-----------------|  
|[Import Element](../vs140/code-snippets-schema-reference.md#import)|Imports the specified namespace.|  
  
 A text value is required. This text specifies a namespace that the code snippet assumes is imported.  
  
##  \<a name="object">\</a> Object Element  
 Defines the objects of the code snippet that you can edit. The <CodeContentPlaceHolder>131\</CodeContentPlaceHolder> element is used to identify an item that is required by the code snippet but is likely to be defined outside of the snippet itself. For example, Windows Forms controls, ASP.NET controls, object instances, and type instances should be declared as objects. Object declarations require that a type be specified, which is done with the <CodeContentPlaceHolder>132\</CodeContentPlaceHolder> element.  
  
<CodeContentPlaceHolder>22\</CodeContentPlaceHolder>  
|Attribute|Description|  
|---------------|-----------------|  
|<CodeContentPlaceHolder>133\</CodeContentPlaceHolder>|Optional <CodeContentPlaceHolder>134\</CodeContentPlaceHolder> attribute. Specifies whether or not you can edit the literal after the code snippet is inserted. The default value of this attribute is <CodeContentPlaceHolder>135\</CodeContentPlaceHolder>.|  
  
|Child Element|Description|  
|-------------------|-----------------|  
|[Default Element](../vs140/code-snippets-schema-reference.md#default)|Required element. Specifies the literal's default value when you insert the code snippet. There must be exactly one <CodeContentPlaceHolder>136\</CodeContentPlaceHolder> element in a <CodeContentPlaceHolder>137\</CodeContentPlaceHolder> element.|  
|[Function Element](../vs140/code-snippets-schema-reference.md#function)|Optional element. Specifies a function to execute when the literal receives focus in Visual Studio. There may be zero or one <CodeContentPlaceHolder>138\</CodeContentPlaceHolder> elements in a <CodeContentPlaceHolder>139\</CodeContentPlaceHolder> element.|  
|[ID Element](../vs140/code-snippets-schema-reference.md#id)|Required element. Specifies a unique identifier for the literal. There must be exactly one <CodeContentPlaceHolder>140\</CodeContentPlaceHolder> element in a <CodeContentPlaceHolder>141\</CodeContentPlaceHolder> element.|  
|[ToolTip Element](../vs140/code-snippets-schema-reference.md#tooltip)|Optional element. Describes the expected value and usage of the literal. There may be zero or one **Tooltip** elements in a <CodeContentPlaceHolder>142\</CodeContentPlaceHolder> element.|  
|[Type Element](../vs140/code-snippets-schema-reference.md#type)|Required element. Specifies the type of the object. There must be exactly one <CodeContentPlaceHolder>143\</CodeContentPlaceHolder> element in an <CodeContentPlaceHolder>144\</CodeContentPlaceHolder> element.|  
  
|Parent Element|Description|  
|--------------------|-----------------|  
|[Declarations Element](../vs140/code-snippets-schema-reference.md#declarations)|Contains the literals and objects of a code snippet that you can edit.|  
  
##  \<a name="reference">\</a> Reference Element  
 Specifies information about the assembly references required by the code snippet.  
  
> [!NOTE]
>  The <CodeContentPlaceHolder>145\</CodeContentPlaceHolder> element is only supported for Visual Basic projects.  
  
<CodeContentPlaceHolder>23\</CodeContentPlaceHolder>  
|Child Element|Description|  
|-------------------|-----------------|  
|[Assembly Element](../vs140/code-snippets-schema-reference.md#assembly)|Required element. Contains the name of the assembly referenced by the code snippet. There must be exactly one <CodeContentPlaceHolder>146\</CodeContentPlaceHolder> element in a <CodeContentPlaceHolder>147\</CodeContentPlaceHolder> element.|  
|[Url Element](../vs140/code-snippets-schema-reference.md#url)|Optional element. Contains a URL that provides more information about the referenced assembly. There may be zero or one <CodeContentPlaceHolder>148\</CodeContentPlaceHolder> elements in a <CodeContentPlaceHolder>149\</CodeContentPlaceHolder> element.|  
  
|Parent Element|Description|  
|--------------------|-----------------|  
|[References Element](../vs140/code-snippets-schema-reference.md#references)|Grouping element for <CodeContentPlaceHolder>150\</CodeContentPlaceHolder> elements.|  
  
##  \<a name="references">\</a> References Element  
 Groups individual <CodeContentPlaceHolder>151\</CodeContentPlaceHolder> elements.  
  
> [!NOTE]
>  The <CodeContentPlaceHolder>152\</CodeContentPlaceHolder> element is only supported for Visual Basic projects.  
  
<CodeContentPlaceHolder>24\</CodeContentPlaceHolder>  
|Child Element|Description|  
|-------------------|-----------------|  
|[Reference Element](../vs140/code-snippets-schema-reference.md#reference)|Optional element. Contains information about assembly references for the code snippet. There may be zero or more <CodeContentPlaceHolder>153\</CodeContentPlaceHolder> elements in a <CodeContentPlaceHolder>154\</CodeContentPlaceHolder> element.|  
  
|Parent Element|Description|  
|--------------------|-----------------|  
|[Snippet Element](../vs140/code-snippets-schema-reference.md#snippet)|Contains the references, imports, declarations, and code for the code snippet.|  
  
##  \<a name="shortcut">\</a> Shortcut Element  
 Specifies the shortcut text used to insert the snippet. The text value of a <CodeContentPlaceHolder>155\</CodeContentPlaceHolder> element can only contain alphanumeric characters, hyphens ( - ), and underscores ( _ ).  
  
> [!CAUTION]
>  _ and – are not supported characters in C++ snippet shortcuts.  
  
<CodeContentPlaceHolder>25\</CodeContentPlaceHolder>  
|Parent Element|Description|  
|--------------------|-----------------|  
|[Header Element](../vs140/code-snippets-schema-reference.md#header)|Contains general information about the code snippet.|  
  
 A text value is optional. This text is used as a shortcut for inserting the code snippet.  
  
##  \<a name="snippet">\</a> Snippet Element  
 Specifies the references, imports, declarations, and code for the code snippet.  
  
<CodeContentPlaceHolder>26\</CodeContentPlaceHolder>  
|Child Element|Description|  
|-------------------|-----------------|  
|[Code Element](../vs140/code-snippets-schema-reference.md#code)|Required element. Specifies the code that you want to insert into a documentation file. There must be exactly one <CodeContentPlaceHolder>156\</CodeContentPlaceHolder> element in a <CodeContentPlaceHolder>157\</CodeContentPlaceHolder> element.|  
|[Declarations Element](../vs140/code-snippets-schema-reference.md#declarations)|Optional element. Specifies the literals and objects that make up the parts of a code snippet that you can edit. There may be zero or one <CodeContentPlaceHolder>158\</CodeContentPlaceHolder> elements in a <CodeContentPlaceHolder>159\</CodeContentPlaceHolder> element.|  
|[Imports Element](../vs140/code-snippets-schema-reference.md#imports)|Optional element. Groups individual <CodeContentPlaceHolder>160\</CodeContentPlaceHolder> elements. There may be zero or one <CodeContentPlaceHolder>161\</CodeContentPlaceHolder> elements in a <CodeContentPlaceHolder>162\</CodeContentPlaceHolder> element.|  
||Optional element. Groups individual <CodeContentPlaceHolder>163\</CodeContentPlaceHolder> elements. There may be zero or one <CodeContentPlaceHolder>164\</CodeContentPlaceHolder> elements in a <CodeContentPlaceHolder>165\</CodeContentPlaceHolder> element.|  
  
|Parent Element|Description|  
|--------------------|-----------------|  
|[CodeSnippet Element](../vs140/code-snippets-schema-reference.md#codesnippet)|Allows you to specify a heading and multiple IntelliSense Code Snippets, which you can insert into Visual Studio code files.|  
  
##  \<a name="snippettype">\</a> SnippetType Element  
 Specifies how Visual Studio inserts the code snippet.  
  
<CodeContentPlaceHolder>27\</CodeContentPlaceHolder>  
|Parent Element|Description|  
|--------------------|-----------------|  
|[SnippetTypes Element](../vs140/code-snippets-schema-reference.md#snippettypes)|Groups <CodeContentPlaceHolder>166\</CodeContentPlaceHolder> elements.|  
  
 The text value must be one of the following values:  
  
-   <CodeContentPlaceHolder>167\</CodeContentPlaceHolder>: allows the code snippet to be placed around a selected piece of code.  
  
-   <CodeContentPlaceHolder>168\</CodeContentPlaceHolder>: allows the code snippet to be inserted at the cursor.  
  
-   <CodeContentPlaceHolder>169\</CodeContentPlaceHolder>: specifies that the code snippet is used during Visual C# refactoring. <CodeContentPlaceHolder>170\</CodeContentPlaceHolder> cannot be used in custom code snippets.  
  
##  \<a name="snippettypes">\</a> SnippetTypes Element  
 Groups individual <CodeContentPlaceHolder>171\</CodeContentPlaceHolder> elements. If the <CodeContentPlaceHolder>172\</CodeContentPlaceHolder> element is not present, the code snippet can be inserted anywhere in the code.  
  
<CodeContentPlaceHolder>28\</CodeContentPlaceHolder>  
|Child Element|Description|  
|-------------------|-----------------|  
|[SnippetType Element](../vs140/code-snippets-schema-reference.md#snippettype)|Optional element. Specifies how Visual Studio inserts the code snippet into the code. There may be zero or more <CodeContentPlaceHolder>173\</CodeContentPlaceHolder> elements in a <CodeContentPlaceHolder>174\</CodeContentPlaceHolder> element.|  
  
|Parent Element|Description|  
|--------------------|-----------------|  
|[Header Element](../vs140/code-snippets-schema-reference.md#header)|Specifies general information about the code snippet.|  
  
##  \<a name="title">\</a> Title Element  
 Specifies the title for the code snippet. The title stored in the <CodeContentPlaceHolder>175\</CodeContentPlaceHolder> element of the code snippet appears in the **Code Snippet Picker** and in the code snippet's description in the **Code Snippets Manager**.  
  
<CodeContentPlaceHolder>29\</CodeContentPlaceHolder>  
|Parent Element|Description|  
|--------------------|-----------------|  
|[Header Element](../vs140/code-snippets-schema-reference.md#header)|Specifies general information about the code snippet.|  
  
 A text value is required. This text specifies the title of the code snippet.  
  
##  \<a name="tooltip">\</a> ToolTip Element  
 Describes the expected value and usage of a literal or object in a code snippet, which Visual Studio displays in a ToolTip when it inserts the code snippet into a project. The ToolTip text is displayed when the mouse hovers over the literal or object after the code snippet has been inserted.  
  
<CodeContentPlaceHolder>30\</CodeContentPlaceHolder>  
|Parent Element|Description|  
|--------------------|-----------------|  
|[Literal Element](../vs140/code-snippets-schema-reference.md#literal)|Defines the literal fields of the code snippet that you can edit.|  
|[Object Element](../vs140/code-snippets-schema-reference.md#object)|Defines the object fields of the code snippet that you can edit.|  
  
 A text value is required. This text specifies the ToolTip description to be associated with the object or literal in the code snippet.  
  
##  \<a name="type">\</a> Type Element  
 Specifies the type of the object. The <CodeContentPlaceHolder>176\</CodeContentPlaceHolder> element is used to identify an item that is required by the code snippet but is likely to be defined outside of the snippet itself. For example, Windows Forms controls, ASP.NET controls, object instances, and type instances should be declared as objects. Object declarations require that a type be specified, which is done with the <CodeContentPlaceHolder>177\</CodeContentPlaceHolder> element.  
  
<CodeContentPlaceHolder>31\</CodeContentPlaceHolder>  
|Parent Element|Description|  
|--------------------|-----------------|  
|[Object Element](../vs140/code-snippets-schema-reference.md#object)|Defines the object fields of the code snippet that you can edit.|  
  
 A text value is required. This text specifies the type of the object.  
  
##  \<a name="url">\</a> Url Element  
 Specifies a URL that provides more information about the referenced assembly.  
  
> [!NOTE]
>  The <CodeContentPlaceHolder>178\</CodeContentPlaceHolder> element is only supported for Visual Basic projects.  
  
<CodeContentPlaceHolder>32\</CodeContentPlaceHolder>  
|Parent Element|Description|  
|--------------------|-----------------|  
|[Reference Element](../vs140/code-snippets-schema-reference.md#reference)|Specifies the assembly references required by the code snippet.|  
  
 A text value is required. This text specifies a URL with more information about the referenced assembly. This URL is displayed when the reference cannot be added to the project.  
  
## See Also  
 [Code Snippets](../vs140/code-snippets.md)   
 [Walkthrough: Creating a Code Snippet](../vs140/walkthrough--creating-a-code-snippet.md)