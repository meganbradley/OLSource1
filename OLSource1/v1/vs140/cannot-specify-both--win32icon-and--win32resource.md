---
title: "Cannot specify both -win32icon and -win32resource"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-csharp"
ms.tgt_pltfrm: na
ms.topic: "article"
H1: "Cannot specify both /win32icon and /win32resource"
f1_keywords: 
  - "vbc2023"
  - "bc2023"
helpviewer_keywords: 
  - "BC2023"
ms.assetid: 60914807-1fde-4fef-9c6f-6f4a62527eed
caps.latest.revision: 15
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Cannot specify both -win32icon and -win32resource
The <CodeContentPlaceHolder>0\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> options are mutually exclusive, because they both insert icons information into the output file.  
  
 **Error ID:** BC2023  
  
### To correct this error  
  
-   Use only the <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> option to insert an .ico file in the output file. This .ico file represents the output file in Windows Explorer.  
  
     — or —  
  
-   Use only the <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> option to insert a Win32 resource file in the output file. A Win32 resource can contain version or bitmap (icon) information that helps identify your application in Windows Explorer.  
  
## See Also  
 [/win32icon](../vs140/-win32icon.md)   
 [/win32resource](../vs140/-win32resource.md)