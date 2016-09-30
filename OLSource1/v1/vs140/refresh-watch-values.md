---
title: "Refresh Watch Values"
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
  - "JScript"
  - "VB"
  - "CSharp"
  - "C++"
helpviewer_keywords: 
  - "debugger, refreshing watch values"
  - "side effects in debugging"
  - "expression evaluation, side effects"
  - "debugging [Visual Studio], side effects"
  - "Watch window"
ms.assetid: 819febae-1994-4210-a2d1-6d9002c8c984
caps.latest.revision: 30
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Refresh Watch Values
When you evaluate an expression in the debugger, one of two refresh icons might appear in the **Value** column. One refresh icon is a circle that contains two arrows, which circle in opposite directions. The other is a circle that contains two wavy lines that resemble threads.  
  
 These icons indicate that the value that appears in the debugger is not current. The value might be correct, but it is out of date. To reinforce this fact, the value also appears in gray. You can force evaluation by clicking the icon, but you should understand the reasons for the icon and the possible consequences.  
  
 If you point to the icon, a tooltip provides information about why the expression was not evaluated.  
  
 If the circling arrows appear, the expression was not evaluated for one of the following reasons:  
  
-   An error occurred as the expression was being evaluated. For example, a time-out might have occurred, or a variable might have been out of scope.  
  
-   Evaluating the expression would have required evaluating a property or making an implicit function call. Evaluation of properties and implicit function calls can have side effects that affect the state of your program. Because these effects can make debugging more difficult, automatic evaluation of properties and implicit functions calls by the debugger is often turned off. Occasionally, a programmer might unintentionally turn off automatic evaluation. For more information about side effects, see [Side Effects and Expressions](../vs140/side-effects-and-expressions.md).  
  
 If the two threads appear, the expression was not evaluated because of a potential cross-thread dependency. A cross-thread dependency means that evaluating the code requires other threads in your application to run temporarily. When you are in break mode, all threads in your application are typically stopped. Allowing other threads to run temporarily can have unexpected effects on the state of your program and causes the debugger to ignore events such as breakpoints.  
  
### To update a value that is out of date  
  
-   Perform one of the following steps:  
  
    -   Click the refresh icon.  
  
    -   Select the value, then press the SPACEBAR.  
  
     The debugger tries to reevaluate the expression. If the refresh icon appeared because automatic evaluation of properties and implicit side effects was turned off, the expression will now be evaluated.  
  
### To turn automatic property evaluation on or off  
  
1.  On the **Tools** menu, click **Options**.  
  
2.  In the **Options** dialog box, open the **Debugging** node, and click **General**.  
  
     If the **Debugging** node does not appear, click **Show all settings**.  
  
3.  Select or clear the **Enable property evaluation and other implicit function calls** check box, and then click **OK**.  
  
## See Also  
 [Side Effects and Expressions](../vs140/side-effects-and-expressions.md)