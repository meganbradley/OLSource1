---
title: "Error: Debugging Isn&#39;t Possible Because a Kernel Debugger is Enabled on the System"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "vs-ide-debug"
ms.tgt_pltfrm: na
ms.topic: "article"
f1_keywords: 
  - "vs.debug.error.kernel_dbg_enabled"
dev_langs: 
  - "FSharp"
  - "VB"
  - "CSharp"
  - "C++"
  - "VB"
  - "CSharp"
  - "C++"
helpviewer_keywords: 
  - "kernel debugger"
ms.assetid: 630a7abd-3303-4aaa-888a-6de3de14bc01
caps.latest.revision: 27
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Error: Debugging Isn&#39;t Possible Because a Kernel Debugger is Enabled on the System
When you debug managed code, you might receive the following error message:  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
 This message occurs when you try to debug managed code:  
  
-   on a [!INCLUDE[win7](../vs140/includes/win7_md.md)] or [!INCLUDE[wiprlhext](../vs140/includes/wiprlhext_md.md)]system that has been started in debug mode.  
  
-   the application uses the CLR version CLR 2.0, 3.0, or 3.5.  
  
## Solution  
  
#### To fix this problem  
  
-   Upgrade your application to use CLR version 4.0 or 4.5  
  
     —or—  
  
-   Disable kernel debugging and debug in [!INCLUDE[vsprvs](../vs140/includes/vsprvs_md.md)].  
  
     —or—  
  
-   Debug using the Kernel Debugger instead of [!INCLUDE[vsprvs](../vs140/includes/vsprvs_md.md)].  
  
     —or—  
  
-   In the Kernel Debugger, disable user-mode exceptions.  
  
#### To disable kernel debugging in the current session  
  
-   At the command prompt, type:  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
#### To disable kernel debugging for all sessions (Windows Vista and Windows 7)  
  
1.  At the command prompt, type:  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
2.  Restart the computer.  
  
#### To disable kernel debugging for all sessions (other Windows operating systems)  
  
1.  Locate boot.ini on your system drive (usually C:\\). The boot.ini file might be hidden and read-only. Therefore, you must use the following command to see it:  
  
<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
2.  Open boot.ini using Notepad and remove the following options:  
  
<CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
3.  Restart the computer.  
  
#### To debug with the Kernel Debugger  
  
1.  If the Kernel Debugger is hooked up, you will see a message that asks whether you want to continue to debug. Click the button to continue.  
  
2.  You might get a <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> If this occurs, type the following Kernel Debugger command to continue to debug:  
  
     <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>  
  
## See Also  
 [Debugger Security](../vs140/debugger-security.md)   
 [Debugging Managed Code](../vs140/debugging-managed-code.md)