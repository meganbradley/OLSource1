---
title: "Accessing Version Information from Within Your Program"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-cpp"
ms.tgt_pltfrm: na
ms.topic: "article"
f1_keywords: 
  - "vc.editors.version"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "VerQueryValue"
  - "version information, accessing from within programs"
  - "GetFileVersionInfo"
  - "version information"
ms.assetid: 18622333-d9e8-4309-9465-677cd10c79b1
caps.latest.revision: 14
author: ""
ms.author: ""
manager: ""
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Accessing Version Information from Within Your Program
### To access version information from within your program  
  
1.  If you want to access the version information from within your program, use the [GetFileVersionInfo](http://msdn.microsoft.com/library/windows/desktop/ms647003.aspx) function and the [VerQueryValue](http://msdn.microsoft.com/library/windows/desktop/ms647464.aspx) function.  
  
 For information on adding resources to managed projects, please see [Resources in Applications](assetId:///8ad495d4-2941-40cf-bf64-e82e85825890) in the *.NET Framework Developer's Guide.* For information on manually adding resource files to managed projects, accessing resources, displaying static resources, and assigning resources strings to properties, see [Walkthrough: Localizing Windows Forms](assetId:///9a96220d-a19b-4de0-9f48-01e5d82679e5) and [Walkthrough: Using Resources for Localization with ASP.NET](assetId:///bb4e5b44-e2b0-48ab-bbe9-609fb33900b6).  
  
 **Requirements**  
  
 Win32  
  
## See Also  
 [Version Information Editor](../vs140/version-information-editor.md)   
 [Version Information (Windows)](https://msdn.microsoft.com/library/windows/desktop/ms646981.aspx)