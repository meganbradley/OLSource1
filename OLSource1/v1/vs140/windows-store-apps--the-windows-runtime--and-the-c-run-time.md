---
title: "Windows Store Apps, the Windows Runtime, and the C Run-Time"
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
ms.assetid: 356d6d8d-76ee-4181-9ad0-6f24b2fede38
caps.latest.revision: 13
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Windows Store Apps, the Windows Runtime, and the C Run-Time
[!INCLUDE[win8_appname_long](../vs140/includes/win8_appname_long_md.md)] apps are programs that run in the [!INCLUDE[wrt](../vs140/includes/wrt_md.md)] that executes on [!INCLUDE[win8](../vs140/includes/win8_md.md)].  The [!INCLUDE[wrt](../vs140/includes/wrt_md.md)] is a trustworthy environment that controls the functions, variables, and resources that are available to a [!INCLUDE[win8_appname_long](../vs140/includes/win8_appname_long_md.md)] app. However, by design, [!INCLUDE[wrt](../vs140/includes/wrt_md.md)] restrictions prevent the use of most C Run-Time Library (CRT) features in [!INCLUDE[win8_appname_long](../vs140/includes/win8_appname_long_md.md)] apps.  
  
 The [!INCLUDE[wrt](../vs140/includes/wrt_md.md)] does not support the following CRT features:  
  
-   Most CRT functions that are related to unsupported functionality.  
  
     For example, a [!INCLUDE[win8_appname_long](../vs140/includes/win8_appname_long_md.md)] app cannot create a process by using the <CodeContentPlaceHolder>0\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> families of routines.  
  
     When a CRT function is not supported in a [!INCLUDE[win8_appname_long](../vs140/includes/win8_appname_long_md.md)] app, that fact is noted in its reference article.  
  
-   Most multibyte character and string functions.  
  
     However, both Unicode and ANSI text are supported.  
  
-   Console apps and command-line arguments.  
  
     However, traditional desktop apps still support the console and command-line arguments.  
  
-   Environment variables.  
  
-   The concept of a current working directory.  
  
-   [!INCLUDE[win8_appname_long](../vs140/includes/win8_appname_long_md.md)] apps and DLLs that are statically linked to the CRT and built by using the [/MT](../vs140/-md---mt---ld--use-run-time-library-.md) or <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> compiler options.  
  
     That is, an app that uses a multithread, static version of the CRT.  
  
-   An app that's built by using the [/MDd](../vs140/-md---mt---ld--use-run-time-library-.md) compiler option.  
  
     That is, a debug, multithread, and DLL-specific version of the CRT. Such an app is not supported on the [!INCLUDE[win8_appstore_long](../vs140/includes/win8_appstore_long_md.md)].  
  
 For a complete list of CRT functions that are not available in a [!INCLUDE[win8_appname_long](../vs140/includes/win8_appname_long_md.md)] app and suggestions for alternative functions, see [CRT functions not supported with /ZW](http://msdn.microsoft.com/library/windows/apps/jj606124.aspx).  
  
## See Also  
 [Compatibility](../vs140/compatibility.md)   
 [Windows Runtime Unsupported CRT Functions](../vs140/windows-runtime-unsupported-crt-functions.md)   
 [Run-Time Routines by Category](../vs140/run-time-routines-by-category.md)