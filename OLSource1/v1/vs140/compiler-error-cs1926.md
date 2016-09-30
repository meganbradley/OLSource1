---
title: "Compiler Error CS1926"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-csharp"
ms.tgt_pltfrm: na
ms.topic: "error-reference"
f1_keywords: 
  - "CS1926"
dev_langs: 
  - "CSharp"
helpviewer_keywords: 
  - "CS1926"
ms.assetid: 58cc8385-8d92-4cee-8941-d05e128e3674
caps.latest.revision: 9
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Compiler Error CS1926
Error reading Win32 manifest file 'filename' -- 'error'.  
  
 This error is generated when the following conditions are true:  
  
1.  The **/win32manifest** option is specified either on the command line or by right-clicking the **Project** icon in **Solution Explorer**, pointing to **Add**, clicking **New Item**, and then clicking **Application Manifest File**.  
  
2.  The file is either corrupted or missing.  
  
### To correct this error  
  
1.  Remove the option.  
  
2.  Replace, repair, or regenerate the file.  
  
## Example  
 The following example generates CS1926 when it is compiled with a corrupted for missing win32 manifest file:  
  
```  
// cs1926.cs  
// Compile with: /win32manifest: ../../app.manifest  
// CS1926  
class Test  
{  
    public static int Main()  
    {  
        return 1;  
    }  
}   
```  
  
## See Also  
 [/win32manifest (Import a Custom Win32 Manifest File) (C# Compiler Options)](../vs140/-win32manifest--csharp-compiler-options-.md)