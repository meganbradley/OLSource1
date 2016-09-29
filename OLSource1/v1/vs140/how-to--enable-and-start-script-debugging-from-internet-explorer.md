---
title: "How to: Enable and Start Script Debugging from Internet Explorer"
ms.custom: na
ms.date: "09/22/2016"
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
  - "debugging [Visual Studio], client-side scripts"
  - "client-side scripts, debugging"
ms.assetid: fc026306-53ae-4ee5-8725-ac01d6492253
caps.latest.revision: 32
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# How to: Enable and Start Script Debugging from Internet Explorer
This topic describes procedures performed within Internet Explorer when you debug client-side code with Visual Studio.  
  
> [!TIP]
>  The following procedures use the **Tools** and **View** menus on the **Menu bar**, which might not be visible. To display the **Menu bar** in Internet Explorer 9 right-click the title bar and select **Menu bar**. To display the **Menu bar** in Internet Explorer 7 or Internet Explorer 8, click the **Tools** button, click **Toolbars**, and then select **Menu Bar**.  
  
### To enable script debugging in Internet Explorer  
  
1.  On the **Tools** menu, click **Internet Options**.  
  
2.  In the **Internet Options** dialog box, click the **Advanced** tab.  
  
3.  In the **Browsing** category, clear the **Disable script debugging** check box.  
  
4.  Click **OK**.  
  
5.  Exit and restart Internet Explorer.  
  
### To begin script debugging in Visual Studio from Internet Explorer  
  
1.  Script debugging must be enabled as described in the previous procedure.  
  
2.  On the **View** menu in Internet Explorer, select **Script Debugger** or (**External script debugger**), and then click **Open**.  
  
     The **Visual Studio Just-In-Time Debugger** dialog box opens.  
  
3.  On the **Possible Debuggers** list, select **New Instance of Visual Studio**.  
  
4.  Click **Yes**.  
  
     A new instance of Visual Studio appears and debugging begins. In Visual Studio, you can now open script documents from **Solution Explorer**, place breakpoints in script, step through script code, and view variables and properties in variable windows or the **Immediate** window.  
  
### To begin script debugging in Visual Studio at the next script statement  
  
1.  Script debugging must be enabled as described in the previous procedure.  
  
2.  On the **View** menu in Internet Explorer, select **Script Debugger**, and then click **Break at Next Statement**.  
  
     The **Visual Studio Just-In-Time Debugger** dialog box opens.  
  
3.  On the **Possible Debuggers** list in the **Visual Studio Just-In-Time Debugger** dialog box, select **New Instance of Visual Studio**.  
  
4.  Click **Yes**.  
  
     A new instance of Visual Studio appears, but debugging does not begin until the next script statement executes. You can now open script documents from **Solution Explorer** immediately but you cannot control execution until debugging begins.  
  
## See Also  
 [Client-Side Script Debugging](../vs140/client-side-script-debugging.md)