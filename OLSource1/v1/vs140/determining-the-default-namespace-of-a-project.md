---
title: "Determining the Default Namespace of a Project"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-csharp"
ms.tgt_pltfrm: na
ms.topic: "article"
helpviewer_keywords: 
  - "custom tools, computing default namespace"
ms.assetid: 6d890676-7016-458c-8a6a-95cc0a068612
caps.latest.revision: 17
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Determining the Default Namespace of a Project
For [!INCLUDE[vbprvb](../vs140/includes/vbprvb_md.md)], if the <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> property is set on the input file, then the value of <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> becomes the value of the default namespace parameter passed to the \<xref:Microsoft.VisualStudio.Shell.Interop.IVsSingleFileGenerator.Generate*> method. Otherwise, the <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> parameter passed to <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> is always equal to the root namespace. For more information on namespaces, see [Namespace Keywords](../vs140/namespace-keywords--csharp-reference-.md).  
  
 [!INCLUDE[csprcs](../vs140/includes/csprcs_md.md)] uses folder-based namespaces. That is, the namespace consists of the root namespace, plus names of any folders containing the custom tool. Each folder name is converted into a valid identifier, and periods separate all names. For example, if the input file is FolderA\FolderB\FolderC\MyInput.txt, and the root namespace is CL9, then the computed default namespace would be **CL9.FolderA.FolderB.FolderC**.  
  
 An exception to this rule occurs when the hierarchy chain contains a Web reference folder. For example, if:  
  
-   FolderC were a Web reference folder, the namespace would be **CL9.FolderC**.  
  
-   FolderB were a Web reference folder, the namespace would be **CL9.FolderB.FolderC**.  
  
 That is, the namespace uses the following format:  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## See Also  
 [Implementing Custom Tools](../vs140/implementing-single-file-generators.md)   
 [Registering Single File Generators](../vs140/registering-single-file-generators.md)   
 [Exposing Types to Visual Designers](../vs140/exposing-types-to-visual-designers.md)