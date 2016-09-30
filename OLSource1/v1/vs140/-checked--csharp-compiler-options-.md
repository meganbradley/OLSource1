---
title: "-checked (C# Compiler Options)"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-csharp"
ms.tgt_pltfrm: na
ms.topic: "article"
H1: "/checked (C# Compiler Options)"
f1_keywords: 
  - "/checked"
dev_langs: 
  - "CSharp"
helpviewer_keywords: 
  - "checked compiler option [C#]"
  - "-checked compiler option [C#]"
  - "/checked compiler option [C#]"
ms.assetid: fb7475d3-e6a6-4e6d-b86c-69e7a74c854b
caps.latest.revision: 24
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# -checked (C# Compiler Options)
The **/checked** option specifies whether an integer arithmetic statement that results in a value that is outside the range of the data type, and that is not in the scope of a [checked](../vs140/checked--csharp-reference-.md) or [unchecked](../vs140/unchecked--csharp-reference-.md) keyword, causes a run-time exception.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Remarks  
 An integer arithmetic statement that is in the scope of a <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> or <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> keyword is not subject to the effect of the **/checked** option.  
  
 If an integer arithmetic statement that is not in the scope of a <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> or <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> keyword results in a value outside the range of the data type, and **/checked+** (**/checked**) is used in the compilation, that statement causes an exception at run time. If **/checked-** is used in the compilation, that statement does not cause an exception at run time.  
  
 The default value for this option is **/checked-**. One scenario for using **/checked-** is in building large applications. Sometimes automated tools are used to build such applications, and such a tool might automatically set **/checked** to +. You can override the tool's global default by specifying **/checked-**.  
  
### To set this compiler option in the Visual Studio development environment  
  
1.  Open the project's **Properties** page. For more information, see [Build Page, Project Designer (C#)](../vs140/build-page--project-designer--csharp-.md).  
  
2.  Click the **Build** property page.  
  
3.  Click the **Advanced** button.  
  
4.  Modify the **Check for arithmetic overflow/underflow** property.  
  
 To access this compiler option programmatically, see \<xref:VSLangProj80.CSharpProjectConfigurationProperties3.CheckForOverflowUnderflow*>.  
  
## Example  
 The following command compiles <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>. The use of <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> in the command specifies that any integer arithmetic statement in the file that is not in the scope of a <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> or <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> keyword, and that results in a value that is outside the range of the data type, causes an exception at run time.  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
## See Also  
 [C# Compiler Options](../vs140/csharp-compiler-options.md)   
 [NIB How to: Modify Project Properties and Configuration Settings](assetId:///e7184bc5-2f2b-4b4f-aa9a-3ecfcbc48b67)   
 [Introduction to the Project Designer](assetId:///898dd854-c98d-430c-ba1b-a913ce3c73d7)