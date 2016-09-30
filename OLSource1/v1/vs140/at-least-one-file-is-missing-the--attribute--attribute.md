---
title: "At least one file is missing the &#39;attribute&#39; attribute"
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
  - "vs.tasklisterror.projfile_missing_file_attrib"
ms.assetid: 2627974b-c9cd-4d85-9af4-dd3811214ea4
caps.latest.revision: 11
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# At least one file is missing the &#39;attribute&#39; attribute
A file node that has been read from the .vbproj or .csproj file is missing certain attributes that the project system requires. Currently the only such attribute is the <CodeContentPlaceHolder>0\</CodeContentPlaceHolder> attribute, which specifies where under the project folder the file is located.  
  
 This error is most likely caused by editing the project file by hand.  
  
 **To correct this error**  
  
-   Remove the affected file node from the project file. Also, if the file is still on disk, you could switch to show **Show All Files** mode (by clicking that button in the Solution Explorer toolbar), right-click the affected file, and select **Include In Project**.  
  
     Any file for which the <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> attribute is missing will not be added to the project.  
  
## See Also  
 [Project Files](../vs140/project-files.md)   
 [NIB: Project Properties (Visual Studio)](assetId:///eb4c97ed-f667-4850-98d0-6e2a4d21bbca)