---
title: "Code Snippet Functions"
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
  - "code snippets [Visual Studio], functions"
  - "snippets [Visual Studio], functions"
  - "IntelliSense code snippets, functions"
ms.assetid: c0a2bf21-8fa5-4457-9281-f599beb53e7d
caps.latest.revision: 15
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Code Snippet Functions
There are three functions available to use with [!INCLUDE[csprcs](../vs140/includes/csprcs_md.md)] code snippets. Functions are specified in the [Function](assetId:///572c5549-5821-4e15-8ecd-0fa86c1c65df) element of the code snippet. For information on creating code snippets, see [Creating and Using Intellisense Code Snippets](../vs140/code-snippets.md).  
  
## Functions  
 The following table describes the functions available for use with the <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> element in code snippets.  
  
|Function|Description|Language|  
|--------------|-----------------|--------------|  
|<CodeContentPlaceHolder>4\</CodeContentPlaceHolder> <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>|Generates a switch statement and a set of case statements for the members of the enumeration specified by the <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> parameter. The <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> parameter must be either a reference to an enumeration literal or an enumeration type.|[!INCLUDE[csprcs](../vs140/includes/csprcs_md.md)]|  
|<CodeContentPlaceHolder>9\</CodeContentPlaceHolder>|Returns the name of the class that contains the inserted snippet.|[!INCLUDE[csprcs](../vs140/includes/csprcs_md.md)]|  
|<CodeContentPlaceHolder>10\</CodeContentPlaceHolder> <CodeContentPlaceHolder>11\</CodeContentPlaceHolder> <CodeContentPlaceHolder>12\</CodeContentPlaceHolder>|Reduces the *TypeName* parameter to its simplest form in the context in which the snippet was invoked.|[!INCLUDE[csprcs](../vs140/includes/csprcs_md.md)]|  
  
## Example  
 The following example shows how to use the <CodeContentPlaceHolder>13\</CodeContentPlaceHolder> function. When this snippet is inserted and an enumeration is entered into the <CodeContentPlaceHolder>14\</CodeContentPlaceHolder> literal, the <CodeContentPlaceHolder>15\</CodeContentPlaceHolder> literal generates a <CodeContentPlaceHolder>16\</CodeContentPlaceHolder> statement for every value in the enumeration.  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Example  
 The following example shows how to use the <CodeContentPlaceHolder>17\</CodeContentPlaceHolder> function. When this snippet is inserted, the <CodeContentPlaceHolder>18\</CodeContentPlaceHolder> literal is replaced with the name of the enclosing class at that location in the code file.  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
## Example  
 This example shows how to use the <CodeContentPlaceHolder>19\</CodeContentPlaceHolder> function. When this snippet is inserted into a code file, the <CodeContentPlaceHolder>20\</CodeContentPlaceHolder> literal will be replaced with the simplest form of the \<xref:System.Console*> type in the context in which the snippet was invoked.  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
## See Also  
 [Function Element (Intellisense Code Snippets)](assetId:///572c5549-5821-4e15-8ecd-0fa86c1c65df)   
 [Code Snippets Schema Reference](../vs140/code-snippets-schema-reference.md)