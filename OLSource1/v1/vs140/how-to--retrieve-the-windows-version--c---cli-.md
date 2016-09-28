---
title: "How to: Retrieve the Windows Version (C++-CLI)"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-cpp"
ms.tgt_pltfrm: na
ms.topic: "article"
H1: "How to: Retrieve the Windows Version (C++/CLI)"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "Windows [C++], version"
  - "Windows [C++], retrieving version using Visual C++"
ms.assetid: 7e6f567b-d378-49bb-aa59-2240f69a022d
caps.latest.revision: 13
author: ""
ms.author: ""
manager: ""
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# How to: Retrieve the Windows Version (C++-CLI)
The following code example demonstrates how to retrieve the platform and version information of the current operating system. This information is stored in the <xref:System.Environment.OSVersion*?displayProperty=fullName> property and consists of an enumeration that describes the version of Windows in broad terms and a <xref:System.Environment.Version*> object that contains the exact build of the operating system.  
  
## Example  
  
```  
// os_ver.cpp  
// compile with: /clr  
using namespace System;  
  
int main()   
{  
   OperatingSystem^ osv = Environment::OSVersion;  
   PlatformID id = osv->Platform;  
   Console::Write("Operating system: ");  
  
   if (id == PlatformID::Win32NT)  
      Console::WriteLine("Win32NT");  
   else if (id == PlatformID::Win32S)  
      Console::WriteLine("Win32S");  
   else if (id == PlatformID::Win32Windows)  
      Console::WriteLine("Win32Windows");  
   else  
      Console::WriteLine("WinCE");  
  
   Version^ version = osv->Version;  
   if (version)  
   {  
      int build = version->Build;  
      int major = version->Major;  
      int minor = version->Minor;  
      int revision = Environment::Version->Revision;  
      Console::Write("OS Version: ");  
      Console::WriteLine("{0}.{1}.{2}.{3}",   
                   build, major, minor, revision);  
   }  
  
   return 0;  
}  
```  
  
## See Also  
 [Windows Operations in C++](../vs140/windows-operations--c---cli-.md)   
 [.NET Programming in C++](../vs140/.net-programming-with-c---cli--visual-c---.md)