---
title: "The referenced component &#39;component&#39; could not be found. &lt;reason&gt;"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-csharp"
ms.tgt_pltfrm: na
ms.topic: "article"
f1_keywords: 
  - "vs.tasklisterror.referencenotfound"
ms.assetid: 35491b4d-e3e4-4e7c-8ac1-3adb09c1ef58
caps.latest.revision: 13
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# The referenced component &#39;component&#39; could not be found. &lt;reason&gt;
The project system could not resolve a particular reference. Double-clicking this Task List item will set focus to Solution Explorer and select the reference that could not be resolved.  
  
 Edit the [ReferencePaths](assetId:///8e549b39-7256-456a-8fd7-089b23facf9c) property such that appropriate directories are included in the path.  
  
 This error can occur if you move a project to another computer. The <CodeContentPlaceHolder>0\</CodeContentPlaceHolder> property is stored as an absolute path. If reference R1 resides in c:\R\R1.dll on computer A, the .vbproj.user or .csproj.user file will store c:\R as part of the <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> property. If, however, on computer B, R1 resides in d:\R\R1.dll, the project system will not be able to find R1 because d:\R is not on the reference path.  
  
 A similar scenario is the source-code-control scenario. If you enlist in a project, the .vbproj.user (or .csproj.user) file is not copied to your computer because it is not stored in source control. Therefore, the initial value of the <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> property will be blank, and any references that rely on <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> for resolution will be unresolved. For more information, see "Managing Dependencies" in *Team Development with Visual Studio .NET and Visual SourceSafe*.  
  
 This error can also be caused if a referenced project is not in the current solution.  
  
 When this error occurrs, the project may not build.  
  
 For more information on resolving assembly references, see [Troubleshooting Broken References](../vs140/troubleshooting-broken-references.md).  
  
## See Also  
 [Managing references in a project](../vs140/managing-references-in-a-project.md)