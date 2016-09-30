---
title: "How to: Manage a Private Gallery By Using Registry Settings"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "vs-ide-sdk"
ms.tgt_pltfrm: na
ms.topic: "article"
helpviewer_keywords: 
  - "VSIX private galleries, managing"
  - "managing VSIX private galleries"
ms.assetid: 86b86442-4293-4cad-9fe2-876eef65f426
caps.latest.revision: 10
ms.author: "gregvanl"
translation.priority.mt: 
  - "de-de"
  - "ja-jp"
---
# How to: Manage a Private Gallery By Using Registry Settings
If you are an administrator or the developer of an Isolated Shell extension, you can control access to the controls, templates, and tools in the Visual Studio Gallery, the Samples Gallery, or private galleries. To make a gallery available or unavailable, create a .pkgdef file that describes the modified registry keys and their values.  
  
## Managing Private Galleries  
 You can create a .pkgdef file to control access to galleries on multiple computers. This file must have the following format.  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
 The <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> key refers to the gallery to be enabled or disabled. The Visual Studio Gallery and the Samples Gallery use the following repository GUIDs:  
  
-   Visual Studio Gallery : 0F45E408-7995-4375-9485-86B8DB553DC9  
  
-   Samples Gallery : AEB9CB40-D8E6-4615-B52C-27E307F8506C  
  
 The <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> value is optional. By default, a gallery is enabled.  
  
 The <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> value determines the order in which the galleries are listed in the Options dialog box. Visual Studio Gallery has priority 10 and the Samples Gallery has priority 20. Private galleries start at priority 100. If several galleries have the same priority value, the order in which they appear is determined by the values of their localized <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> attributes.  
  
 The <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> value is required for Atom-based or SharePoint-based galleries.  
  
 Either <CodeContentPlaceHolder>8\</CodeContentPlaceHolder>, or both <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>10\</CodeContentPlaceHolder>, must be specified. If all are specified, then the <CodeContentPlaceHolder>11\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>12\</CodeContentPlaceHolder> pair is used.  
  
## Disabling the Visual Studio Gallery Using a .pkgdef File  
 You can disable a gallery in a .pkgdef file. The following entry disables the Visual Studio Gallery:  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 The following entry disables the Samples Gallery:  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
## See Also  
 [Private Galleries](../vs140/private-galleries.md)