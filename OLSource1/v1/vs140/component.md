---
title: "component"
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
  - "vc-pragma.component"
  - "component_CPP"
dev_langs: 
  - "C++"
  - "C"
helpviewer_keywords: 
  - "component pragma"
  - "pragmas, component"
ms.assetid: 7b66355e-3201-4c14-8190-f4a2a81a604a
caps.latest.revision: 10
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# component
Controls the collecting of browse information or dependency information from within source files.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Remarks  
  
## Browser  
 You can turn collecting on or off, and you can specify particular names to be ignored as information is collected.  
  
 Using on or off controls the collection of browse information from the pragma forward. For example:  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 stops the compiler from collecting browse information.  
  
> [!NOTE]
>  To turn on the collecting of browse information with this pragma, [browse information must first be enabled](../vs140/building-browse-information-files--overview.md).  
  
 The **references** option can be used with or without the *name* argument. Using **references** without *name* turns on or off the collecting of references (other browse information continues to be collected, however). For example:  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 stops the compiler from collecting reference information.  
  
 Using **references** with *name* and **off** prevents references to *name* from appearing in the browse information window. Use this syntax to ignore names and types you are not interested in and to reduce the size of browse information files. For example:  
  
<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 ignores references to **DWORD** from that point forward. You can turn collecting of references to <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> back on by using **on**:  
  
<CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
 This is the only way to resume collecting references to *name*; you must explicitly turn on any *name* that you have turned off.  
  
 To prevent the preprocessor from expanding *name* (such as expanding **NULL** to **0**), put quotes around it:  
  
<CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
## Minimal Rebuild  
 The Visual C++ minimal rebuild feature requires that the compiler create and store C++ class dependency information, which takes disk space. To save disk space, you can use <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> whenever you don't need to collect dependency information, for instance, in unchanging header files. Insert <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> after unchanging classes to turn dependency collection back on.  
  
## Reduce Type Information  
 The **mintypeinfo** option reduces the debugging information for the region specified. The volume of this information is considerable, impacting .pdb and .obj files. You cannot debug classes and structures in the mintypeinfo region. Use of the mintypeinfo option can be helpful to avoid the following warning:  
  
<CodeContentPlaceHolder>6\</CodeContentPlaceHolder>  
 For more information, see the [Enable Minimal Rebuild](../vs140/-gm--enable-minimal-rebuild-.md) (/Gm) compiler option.  
  
## See Also  
 [Pragma Directives and the __Pragma Keyword](../vs140/pragma-directives-and-the-__pragma-keyword.md)