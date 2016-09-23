---
title: "Changing the Names of Symbol Header Files"
ms.custom: na
ms.date: 09/22/2016
ms.prod: visual-studio-dev14
ms.reviewer: na
ms.suite: na
ms.technology: 
  - devlang-cpp
ms.tgt_pltfrm: na
ms.topic: article
f1_keywords: 
  - vc.editors.symbol.changing.header
dev_langs: 
  - C++
helpviewer_keywords: 
  - resource files, multiple
  - Resource Includes dialog box
  - symbol header files, changing names
  - symbol header files
  - header files, changing names
  - names [C++], symbol header files
  - symbols, symbol header files
  - Resource.h
ms.assetid: b948284a-7899-402e-ab12-9f2c8480ca9d
caps.latest.revision: 11
translation.priority.ht: 
  - de-de
  - ja-jp
---
# Changing the Names of Symbol Header Files
Normally all symbol definitions are saved in Resource.h. However, you may need to change this include filename so that you can, for example, work with more than one resource file in the same directory.  
  
### To change the name of the resource symbol header file  
  
1.  In [Resource View](../vs140/resource-view-window.md), right-click your .rc file and choose [Resource Includes](../vs140/resource-includes-dialog-box.md) from the shortcut menu.  
  
    > [!NOTE]
    >  If your project doesn't already contain an .rc file, please see [Creating a New Resource Script File](../vs140/how-to--create-a-resource-script-file.md).  
  
2.  In the **Symbol header file** box, type the new name for the include file.  
  
 For information on adding resources to managed projects, please see [Resources in Applications](assetId:///8ad495d4-2941-40cf-bf64-e82e85825890) in the *.NET Framework Developer's Guide.*  
  
 Requirements  
  
 Win32  
  
## See Also  
 [Viewing Resource Symbols](../vs140/viewing-resource-symbols.md)   
 [Predefined Symbol IDs](../vs140/predefined-symbol-ids.md)