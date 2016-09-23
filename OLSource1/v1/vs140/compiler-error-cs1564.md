---
title: "Compiler Error CS1564"
ms.custom: na
ms.date: 09/22/2016
ms.prod: visual-studio-dev14
ms.reviewer: na
ms.suite: na
ms.technology: 
  - devlang-csharp
ms.tgt_pltfrm: na
ms.topic: error-reference
f1_keywords: 
  - CS1564
dev_langs: 
  - CSharp
helpviewer_keywords: 
  - CS1564
ms.assetid: 32206075-a14b-4c24-bd78-257104078f83
caps.latest.revision: 10
translation.priority.ht: 
  - de-de
  - ja-jp
---
# Compiler Error CS1564
Conflicting options specified: Win32 resource file; Win32 manifest.  
  
 If you use the **/Win32res** compiler option, you must include the custom Win32 manifest (if it is required) in the resource file. You cannot provide a custom Win32 manifest separately from a Win32 resource file. Use the **/win32manifest** option only if you are not specifying a win32 resource file.  
  
### To correct this error  
  
1.  Add the win32 manifest to the win32 resource file and remove the **/win32manifest** compiler option.  
  
## Example  
 The following example produces CS1564 if it is compiled with the **/Win32res** option and no manifest is included in the resource file.  
  
```  
// cs1564.cs  
// Compile with: /Win32res  
public class Test  
{  
    static int Main(string[] args)  
    {  
        return 1;  
    }  
}  
```  
  
 The C# 3.0 compiler adds a default win32Manifest to all binaries.  
  
## See Also  
 [/win32manifest](../vs140/-win32manifest--csharp-compiler-options-.md)   
 [/win32res (Import a Win32 Resource File) (C# Compiler Options)](../vs140/-win32res--csharp-compiler-options-.md)