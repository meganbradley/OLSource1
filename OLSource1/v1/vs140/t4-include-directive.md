---
title: "T4 Include Directive"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-tfs-dev14"
ms.reviewer: na
ms.suite: na
ms.tgt_pltfrm: na
ms.topic: "article"
ms.assetid: 8c3de9f3-755a-47c5-a30a-65717dcaaac2
caps.latest.revision: 10
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# T4 Include Directive
In a text template in [!INCLUDE[vsprvs](../vs140/includes/vsprvs_md.md)], you can include text from another file by using an <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> directive. You can place <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> directives anywhere in a text template before the first class feature block <CodeContentPlaceHolder>10\</CodeContentPlaceHolder>. The included files can also contain <CodeContentPlaceHolder>11\</CodeContentPlaceHolder> directives, and other directives. This allows you to share template code and boilerplate text between templates.  
  
## Using Include Directives  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
-   <CodeContentPlaceHolder>12\</CodeContentPlaceHolder> can be absolute, or relative to the current template file.  
  
     In addition, specific [!INCLUDE[vsprvs](../vs140/includes/vsprvs_md.md)] extensions can specify their own directories to search for include files. For example, when you have installed the Visualization and Modeling SDK (DSL Tools), the following folder is added to the include list: <CodeContentPlaceHolder>13\</CodeContentPlaceHolder>.  
  
     These additional include folders might depend on the file extension of the including file. For example, the DSL Tools include folder is only accessible to including files that have the file extension <CodeContentPlaceHolder>14\</CodeContentPlaceHolder>  
  
-   <CodeContentPlaceHolder>15\</CodeContentPlaceHolder> can include environment variables delimited with "%". For example:  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
-   The name of an included file does not have to use the extension <CodeContentPlaceHolder>16\</CodeContentPlaceHolder>.  
  
     You might want to use another extension such as <CodeContentPlaceHolder>17\</CodeContentPlaceHolder> for included files. This is because, when you add a <CodeContentPlaceHolder>18\</CodeContentPlaceHolder> file to a project, [!INCLUDE[vsprvs](../vs140/includes/vsprvs_md.md)] automatically sets its **Custom Tool** property to <CodeContentPlaceHolder>19\</CodeContentPlaceHolder>. You do not usually want included files to be transformed individually.  
  
     On the other hand, you should be aware that in some cases, the file extension affects which additional folders will be searched for include files. This might be important when you have an included file that includes other files.  
  
-   The included content is processed almost as if it were part of the including text template. However, you can include a file that contains a class feature block <CodeContentPlaceHolder>20\</CodeContentPlaceHolder> even if the <CodeContentPlaceHolder>21\</CodeContentPlaceHolder> directive is followed by ordinary text and standard control blocks.  
  
-   Use <CodeContentPlaceHolder>22\</CodeContentPlaceHolder> to ensure that a template is included only once, even if it’s invoked from more than one other include file.  
  
     This feature makes it easy to build up a library of reusable T4 snippets that you can include at will without worrying that some other snippet has already included them.  For example, suppose you have a library of very fine-grained snippets that deal with template processing and C# generation.  In turn, these are used by some more task-specific utilities such as generating exceptions, which you can then use from any more application-specific template. If you draw the dependency graph, you see that some snippets would be included several times. But the <CodeContentPlaceHolder>23\</CodeContentPlaceHolder> parameter prevents the subsequent inclusions.  
  
 **MyTextTemplate.tt:**  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 **TextFile1.t4:**  
  
<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 **TextFile2.t4:**  
  
<CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
 **The resulting generated file, MyTextTemplate.txt:**  
  
<CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
##  \<a name="msbuild">\</a> Using project properties in MSBuild and Visual Studio  
 Although you can use Visual Studio macros like $(SolutionDir) in an include directive, they don’t work in MSBuild. If you want to transform templates in your build machine, you have to use project properties instead.  
  
 Edit your .csproj or .vbproj file to define a project property. This example defines a property named <CodeContentPlaceHolder>24\</CodeContentPlaceHolder>:  
  
<CodeContentPlaceHolder>6\</CodeContentPlaceHolder>  
 Now you can use your project property in text templates, which transform correctly in both Visual Studio and MSBuild:  
  
<CodeContentPlaceHolder>7\</CodeContentPlaceHolder>