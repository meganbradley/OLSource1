---
title: "Text Template Utility Methods"
ms.custom: na
ms.date: "09/21/2016"
ms.prod: "visual-studio-tfs-dev14"
ms.reviewer: na
ms.suite: na
ms.tgt_pltfrm: na
ms.topic: "article"
helpviewer_keywords: 
  - "text templates, utility methods"
ms.assetid: 8c11f9f7-678b-4f0c-b634-dc78fda699d1
caps.latest.revision: 54
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Text Template Utility Methods
There are several methods that are always available to you when you write code in a [!INCLUDE[vsprvs](../vs140/includes/vsprvs_md.md)] text template. These methods are defined in \<xref:Microsoft.VisualStudio.TextTemplating.TextTransformation*>.  
  
> [!TIP]
>  You can also use other methods and services provided by the host environment in a regular (not preprocessed) text template. For example, you can resolve file paths, log errors, and get services provided by [!INCLUDE[vsprvs](../vs140/includes/vsprvs_md.md)] and any loaded packages.  For more information, see [Accessing Visual Studio from a Text Template](assetId:///0556f20c-fef4-41a9-9597-53afab4ab9e4).  
  
## Write methods  
 You can use the <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> methods to append text inside a standard code block, instead of using an expression code block. The following two code blocks are functionally equivalent.  
  
##### Code block with an expression block  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
##### Code block using WriteLine()  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 You may find it helpful to use one of these utility methods instead of an expression block inside a long code block with nested control structures.  
  
 The <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>11\</CodeContentPlaceHolder> methods have two overloads, one that takes a single string parameter and one that takes a composite format string plus an array of objects to include in the string (like the <CodeContentPlaceHolder>12\</CodeContentPlaceHolder> method). The following two uses of <CodeContentPlaceHolder>13\</CodeContentPlaceHolder> are functionally equivalent:  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
## Indentation methods  
 You can use indentation methods to format the output of your text template. The \<xref:Microsoft.VisualStudio.TextTemplating.TextTransformation*> class has a <CodeContentPlaceHolder>14\</CodeContentPlaceHolder> string property that shows the current indentation in the text template and an <CodeContentPlaceHolder>15\</CodeContentPlaceHolder> field that is a list of the indentations that have been added. You can add an indentation with the <CodeContentPlaceHolder>16\</CodeContentPlaceHolder> method and subtract an indentation with the <CodeContentPlaceHolder>17\</CodeContentPlaceHolder> method. If you want to remove all indentations, use the <CodeContentPlaceHolder>18\</CodeContentPlaceHolder> method. The following code block shows the use of these methods:  
  
<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 This code block produces the following output:  
  
<CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
## Error and warning methods  
 You can use error and warning utility methods to add messages to the [!INCLUDE[vsprvs](../vs140/includes/vsprvs_md.md)] Error List. For example, the following code will add an error message to the Error List.  
  
<CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
## Access to Host and Service Provider  
 The property <CodeContentPlaceHolder>19\</CodeContentPlaceHolder> can provide access to properties exposed by the host that is executing the template. To use <CodeContentPlaceHolder>20\</CodeContentPlaceHolder>, you must set <CodeContentPlaceHolder>21\</CodeContentPlaceHolder> attribute in the <CodeContentPlaceHolder>22\</CodeContentPlaceHolder> directive:  
  
 <CodeContentPlaceHolder>23\</CodeContentPlaceHolder>  
  
 The type of <CodeContentPlaceHolder>24\</CodeContentPlaceHolder> depends on the type of host in which the template is executing. In a template that is running in [!INCLUDE[vsprvs](../vs140/includes/vsprvs_md.md)], you can cast <CodeContentPlaceHolder>25\</CodeContentPlaceHolder> to <CodeContentPlaceHolder>26\</CodeContentPlaceHolder> to gain access to services such as the IDE. For example:  
  
<CodeContentPlaceHolder>6\</CodeContentPlaceHolder>  
## Using a different set of utility methods  
 As part of the text generation process, your template file is transformed into a class, which is always named <CodeContentPlaceHolder>27\</CodeContentPlaceHolder>and inherits from \<xref:Microsoft.VisualStudio.TextTemplating.TextTransformation*>. If you want to use a different set of methods instead, you can write your own class and specify it in the template directive. Your class must inherit from \<xref:Microsoft.VisualStudio.TextTemplating.TextTransformation*>.  
  
<CodeContentPlaceHolder>7\</CodeContentPlaceHolder>  
 Use the <CodeContentPlaceHolder>28\</CodeContentPlaceHolder> directive to reference the assembly where the compiled class can be found.