---
title: "Specifying Custom Build Events in Visual Studio"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "vs-ide-general"
ms.tgt_pltfrm: na
ms.topic: "article"
helpviewer_keywords: 
  - "build events, customizing"
ms.assetid: 69e935a5-e208-4bcd-865c-3e5f9b047ca8
caps.latest.revision: 17
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Specifying Custom Build Events in Visual Studio
By specifying a custom build event, you can automatically run commands before a build starts or after it finishes. For example, you can run a .bat file before a build starts or copy new files to a folder after the build is complete. Build events run only if the build successfully reaches those points in the build process.  
  
 For specific information about the programming language that you’re using, see the following topics:  
  
-   Visual Basic--[How to: Specify Build Events](../vs140/how-to--specify-build-events--visual-basic-.md).  
  
-   Visual C# and F#--[How to: Specify Build Events (C#)](../vs140/how-to--specify-build-events--csharp-.md).  
  
-   Visual C++--[Specifying Build Events](../vs140/specifying-build-events.md).  
  
## Syntax  
 Build events follow the same syntax as DOS commands, but you can use macros to create build events more easily. For a list of available macros, see [Pre-build Event/Post-build Event Command Line Dialog Box](../vs140/pre-build-event-post-build-event-command-line-dialog-box.md).  
  
 For best results, follow these formatting tips:  
  
-   Add a <CodeContentPlaceHolder>0\</CodeContentPlaceHolder> statement before all build events that run .bat files.  
  
     Example: <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
  
     Example: <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
  
-   Enclose file paths in quotation marks.  
  
     Example (for [!INCLUDE[win8](../vs140/includes/win8_md.md)]): "%ProgramFiles(x86)%\Microsoft SDKs\Windows\v8.0A\Bin\NETFX 4.0 Tools\gacutil.exe" -if "$(TargetPath)"  
  
-   Separate multiple commands by using line breaks.  
  
-   Include wildcards as needed.  
  
     Example: <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>*mydirectory*<CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
  
    > [!NOTE]
    >  <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> in the code above should be <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> in batch scripts.  
  
## See Also  
 [Building in Visual Studio](../vs140/compiling-and-building-in-visual-studio.md)   
 [Pre-build Event/Post-build Event Command Line Dialog Box](../vs140/pre-build-event-post-build-event-command-line-dialog-box.md)   
 [MSBuild Special Characters](../vs140/msbuild-special-characters.md)   
 [Walkthrough: Building an Application](../vs140/walkthrough--building-an-application.md)