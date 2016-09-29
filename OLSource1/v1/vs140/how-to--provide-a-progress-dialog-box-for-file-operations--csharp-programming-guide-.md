---
title: "How to: Provide a Progress Dialog Box for File Operations (C# Programming Guide)"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-csharp"
ms.tgt_pltfrm: na
ms.topic: "article"
dev_langs: 
  - "CSharp"
helpviewer_keywords: 
  - "progress dialog [C#]"
ms.assetid: 01b71fe7-8178-4dc8-aeb1-12053be7b51c
caps.latest.revision: 19
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# How to: Provide a Progress Dialog Box for File Operations (C# Programming Guide)
You can provide a standard dialog box that shows progress on file operations in Windows if you use the <xref:Microsoft.VisualBasic.FileIO.FileSystem.CopyFile(System.String,System.String,Microsoft.VisualBasic.FileIO.UIOption)> method in the <xref:Microsoft.VisualBasic*?displayProperty=fullName> namespace.  
  
 [!INCLUDE[note_settings_general](../vs140/includes/note_settings_general_md.md)]  
  
### To add a reference in Visual Studio  
  
1.  On the menu bar, choose **Project**, **Add Reference**.  
  
     The **Reference Manager** dialog box appears.  
  
2.  In the **Assemblies** area, choose**Framework** if it isn’t already chosen.  
  
3.  In the list of names, select the **Microsoft.VisualBasic** check box, and then choose the **OK** button to close the dialog box.  
  
## Example  
 The following code copies the directory that `sourcePath` specifies into the directory that `destinationPath` specifies. This code also provides a standard dialog box that shows the estimated amount of time remaining before the operation finishes.  
  
 [!code[csFilesandFolders#11](../vs140/codesnippet/CSharp/how-to--provide-a-progress-dialog-box-for-file-operations--csharp-programming-guide-_1.cs)]  
  
## See Also  
 [File System and the Registry (C# Programming Guide)](../vs140/file-system-and-the-registry--csharp-programming-guide-.md)