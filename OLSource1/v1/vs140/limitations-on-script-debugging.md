---
title: "Limitations on Script Debugging"
ms.custom: na
ms.date: "09/21/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "vs-ide-debug"
ms.tgt_pltfrm: na
ms.topic: "article"
dev_langs: 
  - "FSharp"
  - "VB"
  - "CSharp"
  - "C++"
helpviewer_keywords: 
  - "ASPX breakpoint mapping, limitations"
  - "script debugging, limitations"
  - "breakpoint mapping, limitations"
ms.assetid: 280eead5-693c-47af-967f-dfe9d23f84db
caps.latest.revision: 26
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Limitations on Script Debugging
[!INCLUDE[vsprvs](../vs140/includes/vsprvs_md.md)] supports the debugging of client-side script, subject to the limitations in this topic.  
  
## Limitations on Breakpoint Mapping with Client-Side Script  
 [!INCLUDE[vsprvs](../vs140/includes/vsprvs_md.md)] enables you to set a breakpoint in a server-side ASPX or HTML file that is transformed to a client-side file at run time. [!INCLUDE[vsprvs](../vs140/includes/vsprvs_md.md)] maps the breakpoint from the server-side file to a corresponding breakpoint in the client-side file, subject to the following limitations:  
  
-   Breakpoints must be set inside <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> blocks. Breakpoints in inline script or <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> blocks cannot be mapped.  
  
-   The browser URL for the page must contain the page name. For example, http://microsoft.com/default.apsx. Breakpoint mapping cannot recognize a redirection from an address such as http://microsoft.com to the default page.  
  
-   The breakpoint must be set in the page specified in the browser URL, not in an ASPX control (ascx) file, Master page, or other file included by that page. Breakpoints set in included pages cannot be mapped.  
  
-   Breakpoints set in <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> blocks cannot be mapped.  
  
-   For breakpoints set in <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> blocks, breakpoint mapping ignores the <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> attribute.  
  
## Breakpoint Mapping and Duplicate Lines  
 To find the corresponding location in server-side and client-side script, the breakpoint mapping algorithm examines the code on each line. The algorithm assumes that each line is unique. If two or more lines contain the same code, and you set a breakpoint on one of those duplicate lines, the breakpoint mapping algorithm might select the wrong duplicate in the client-side file. To prevent this, add a comment to the line where you have set the breakpoint. For example:  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>