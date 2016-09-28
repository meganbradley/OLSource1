---
title: "Resource Editors"
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
  - "vs.editors.resource"
  - "vc.resvw.resource.editors"
  - "vs.resvw.resource.editors"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "editors [C++], resource"
  - "editors [C++]"
  - "resource editors"
  - "Windows [C++], application resource editing"
ms.assetid: e20a29ec-d6fb-4ead-98f3-431a0e23aaaf
caps.latest.revision: 18
author: ""
ms.author: ""
manager: ""
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Resource Editors
A Resource editor is a specialized environment for creating or modifying resources that are included in a Visual Studio project. The Visual Studio resource editors share techniques and interfaces to help you create and modify application resources quickly and easily. Resource editors enable you to [view and edit resources in the appropriate editor](../vs140/viewing-and-editing-resources-in-a-resource-editor.md) and [preview resources](../vs140/previewing-resources.md).  
  
 The appropriate editor opens automatically when you create or open a resource.  
  
 **Note** Because managed projects do not use resource script files, you must open your resources from **Solution Explorer**. You can use the [Image editor](../vs140/image-editor-for-icons.md) and the [Binary editor](../vs140/binary-editor.md) to work with resource files in managed projects. Any managed resources you want to edit must be linked resources. The Visual Studio resource editors do not support editing embedded resources.  
  
 For information on adding resources to managed projects, please see [Resources in Applications](assetId:///8ad495d4-2941-40cf-bf64-e82e85825890) in the *.NET Framework Developer's Guide.* For information on manually adding resource files to managed projects, accessing resources, displaying static resources, and assigning resources strings to properties, see [Walkthrough: Localizing Windows Forms](assetId:///9a96220d-a19b-4de0-9f48-01e5d82679e5) and [Walkthrough: Using Resources for Localization with ASP.NET](assetId:///bb4e5b44-e2b0-48ab-bbe9-609fb33900b6).  
  
|Use the...|To edit...|  
|----------------|----------------|  
|[Accelerator Editor](../vs140/accelerator-editor.md)|Accelerator tables in Visual C++ projects.|  
|[Binary Editor](../vs140/binary-editor.md)|Binary data information and custom resources in Visual C++, Visual Basic, or Visual C# projects.|  
|[Dialog Editor](../vs140/dialog-editor.md)|Dialog boxes in Visual C++ projects.|  
|[HTML Designer](assetId:///640043cc-3657-4677-a091-bc315e636477)|HTML pages in both Design view and HTML view. Caveat: You cannot make changes to HTML pages that are in EXEs or DLLs because the changes are not imported back into the EXE or DLL.|  
|[Image Editor](../vs140/image-editor-for-icons.md)|Bitmaps, icons, cursors, and other image files in Visual C++, Visual Basic, or Visual C# projects.|  
|[Menu Editor](../vs140/menu-editor.md)|Menu resources in Visual C++ projects.|  
|[Ribbon Editor](../vs140/ribbon-designer--mfc-.md)|Ribbon resources in MFC projects.|  
|[String Editor](../vs140/string-editor.md)|String tables in Visual C++ projects.|  
|[Toolbar Editor](../vs140/toolbar-editor.md)|Toolbar resources in Visual C++ projects. The Toolbar editor is part of the Image editor.|  
|[Version Information Editor](../vs140/version-information-editor.md)|Version information in Visual C++ projects.|  
  
## Requirements  
 None  
  
## See Also  
 [Working with Resource Files](../vs140/working-with-resource-files.md)   
 [Resource Files](../vs140/resource-files--visual-studio-.md)   
 [Symbols: Resource Identifiers](../vs140/symbols--resource-identifiers.md)   
 [Menus and Other Resources](https://msdn.microsoft.com/library/windows/desktop/ms632583.aspx)