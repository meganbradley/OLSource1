---
title: "How to: Display an Item List Separated with Commas"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "vs-ide-sdk"
ms.tgt_pltfrm: na
ms.topic: "article"
helpviewer_keywords: 
  - "MSBuild, separating items with semicolons"
  - "MSBuild, formatting item collections"
ms.assetid: 3cae844c-7c6d-4144-82dc-efad10ba458f
caps.latest.revision: 16
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# How to: Display an Item List Separated with Commas
When you work with item lists in [!INCLUDE[vstecmsbuildengine](../vs140/includes/vstecmsbuildengine_md.md)] ([!INCLUDE[vstecmsbuild](../vs140/includes/vstecmsbuild_md.md)]), it is sometimes useful to display the contents of those item lists in a way that is easy to read. Or, you might have a task that takes a list of items separated with a special separator string. In both of these cases, you can specify a separator string for an item list.  
  
## Separating Items in a List with Commas  
 By default, [!INCLUDE[vstecmsbuild](../vs140/includes/vstecmsbuild_md.md)] uses semicolons to separate items in a list. For example, consider a <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> element with the following value:  
  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
  
 When the <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> item list contains the items App1.txt, App2.txt, and App3.txt, the message is:  
  
 <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
  
 If you want to change the default behavior, you can specify your own separator. The syntax for specifying an item list separator is:  
  
 <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
  
 The separator can be either a single character or a string and must be enclosed in single quotes.  
  
#### To insert a comma and a space between items  
  
-   Use item notation similar to the following:  
  
     <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>  
  
## Example  
 In this example, [Exec](../vs140/exec-task.md) task runs the findstr tool to find specified text strings in the file, Phrases.txt. In the findstr command, literal search strings are indicated by the **/c:** switch, so the item separator, <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> is inserted between items in the <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> item list.  
  
 For this example, the equivalent command-line command is:  
  
 <CodeContentPlaceHolder>9\</CodeContentPlaceHolder>  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## See Also  
 [MSBuild Reference](../vs140/msbuild-reference.md)   
 [MSBuild Items](../vs140/msbuild-items.md)