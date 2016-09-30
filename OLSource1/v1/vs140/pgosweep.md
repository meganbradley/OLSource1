---
title: "pgosweep"
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
helpviewer_keywords: 
  - "pgosweep program"
  - "profile-guided optimizations, pgosweep"
ms.assetid: f39dd3b7-1cd9-4c3b-8e8b-fb794744b757
caps.latest.revision: 26
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# pgosweep
Used in profile-guided optimization to write all profile data from a running program to the .pgc file.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 An optional parameter that can be left blank. The valid values for <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> are as follows:  
  
-   **/?** or **/help,** displays the help message.  
  
-   **/noreset,** preserves the count in the runtime data structures.  
  
 <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
 The full path of an .exe or .dll file that was created by using the compiler option /LTCG:PGINSTRUMENT.  
  
 <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
 The .pgc file where this command will write out the data counts.  
  
## Remarks  
 This command works on programs that were built with the /LTCG:PGINSTRUMENT compiler option. It interrupts a running program and writes the profile data to a new .pgc file. By default, the command resets counts after each write operation. If you specify the **/noreset** option, the command will record the values, but not reset them in the running program. This option will give you duplicate data if you retrieve the profile data later.  
  
 An alternative use for <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> is to retrieve profile information just for the runtime of the application. For example, you could run <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> shortly after you start the application and discard that file. This would remove profile data associated with startup costs. Then, you can run <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> before ending the application. Now the collected data has profile information only from runtime.  
  
 When you name a .pgc file (<CodeContentPlaceHolder>9\</CodeContentPlaceHolder>) you can use the standard format, which is *appname!n*.pgc. If you use this format, the compiler will find this data in the /LTCG:PGO phase. If you do not use the standard format, you must use [pgomgr](../vs140/pgomgr.md) to merge the .pgc files.  
  
## Example  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 In this example, <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> writes the current profile information for myapp.exe to myapp!1.pgc.  
  
## See Also  
 [Tools for Manual Profile-Guided Optimization](../vs140/tools-for-manual-profile-guided-optimization.md)