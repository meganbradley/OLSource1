---
title: "How to: Create a Resource Script File"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-cpp"
ms.tgt_pltfrm: na
ms.topic: "article"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "rc files, creating"
  - ".rc files, creating"
  - "resource script files, creating"
ms.assetid: 82be732a-cdcd-4a58-8de7-976d1418f86b
caps.latest.revision: 16
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# How to: Create a Resource Script File
> [!NOTE]
>  The Resource Editor is not available in Express editions.  
>   
>  This material applies to Windows desktop applications. Projects in .NET languages do not use resource script files. See [Resource Files](../vs140/resource-files--visual-studio-.md), for more information.  
  
### To create a new resource script (.rc) file  
  
1.  Put focus on your existing project folder in `Solution Explorer`, for example, "MyProject."  
  
    > [!NOTE]
    >  Don't confuse the project folder with the Solution folder in Solution Explorer. If you put focus on the Solution folder, your choices in the **Add New Item** dialog box (in Step 3) will be different.  
  
2.  On the **Project** menu click **Add New Item**.  
  
3.  In the **Add New Item** dialog box, click the **Visual C++** folder then choose **Resource File (.rc)** in the right pane.  
  
4.  Provide a name for your resource script file in the **Name** text box, then click **Open**.  
  
 You can now [create](../vs140/how-to--create-a-resource.md) and add new resources to your .rc file.  
  
> [!NOTE]
>  You can only add a resource script (.rc file) to an existing project that is loaded into the Visual Studio IDE. You cannot create a standalone .rc file (one outside the project). [Resource templates](../vs140/how-to--use-resource-templates.md) (.rct files) can be created anytime.  
  
 RRequirements  
  
 Win32  
  
## See Also  
 [Resource Files](../vs140/resource-files--visual-studio-.md)   
 [Resource Editors](../vs140/resource-editors.md)