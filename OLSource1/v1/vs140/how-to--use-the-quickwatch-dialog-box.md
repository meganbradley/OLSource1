---
title: "How to: Use the QuickWatch Dialog Box"
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
  - "vs.debug.quickwatch"
dev_langs: 
  - "FSharp"
  - "VB"
  - "CSharp"
  - "C++"
helpviewer_keywords: 
  - "Quick Watch dialog box"
  - "registers, viewing"
  - "expressions [debugger], evaluating"
  - "variables [debugger], evaluating"
  - "debugging [Visual Studio], QuickWatch"
  - "debugging [Visual Studio], expression evaluation"
  - "expression evaluation, QuickWatch"
  - "debugging [Visual Studio], variable evaluation"
ms.assetid: ffaee1dd-e5ce-4ef2-9401-d28329398867
caps.latest.revision: 28
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# How to: Use the QuickWatch Dialog Box
The QuickWatch dialog box lets you examine and evaluate variables and expressions. Because QuickWatch is a modal dialog box, you have to close it before you can continue to debug. For more information, see [How to: Evaluate an Expression in the Debugger](../vs140/watch-and-quickwatch-windows.md). You can also edit the value of a variable in **QuickWatch**. For more information, see [How to: Edit a Value in a Variable Window or QuickWatch](../vs140/how-to--edit-a-value-in-a-variable-window.md).  
  
 Some users might wonder why QuickWatch is useful. Why not add the variable or expression to the Watch window? That is possible, but if you just want to do a quick scratch calculation that involves one or more variables, you do not want to clutter the Watch window with such calculations. That is when the QuickWatch dialog box is especially useful.  
  
 Another feature of the QuickWatch dialog box is that it is resizable. If you want to examine the members of a large object, it is frequently easier to expand and examine the tree QuickWatch than it is in the Watch, Locals, or Autos window.  
  
 The **QuickWatch** dialog box does not allow you to view more than one variable or expression at a time. Also, because **QuickWatch** is a modal dialog box, you cannot perform operations such as stepping through your code while **QuickWatch** is open. If you want to do these things, use the **Watch** window instead.  
  
 Some expressions have side effects that change the value of a variable or otherwise change the state of your program when they are executed. Evaluating an expression in the QuickWatch dialog box will have the same effect as executed the expression in your code. This can produce unexpected results if you do not consider the side effects of the expression.  
  
> [!TIP]
>  In Visual Studio, you can view a variable's value by placing the cursor over the variable. A small box called a DataTip appears and shows the value.  
  
 The dialog boxes and menu commands that you see might differ from those that are described in Help, depending on your active settings or edition. To change your settings, choose Import and Export Settings on the Tools menu. For more information, see [Customizing Development Settings in Visual Studio](assetId:///22c4debb-4e31-47a8-8f19-16f328d7dcd3).  
  
### To open the QuickWatch dialog box  
  
-   While in break mode, choose **QuickWatch** on the **Debug** menu.  
  
### To open the QuickWatch dialog box with a variable added  
  
-   While in break mode, right-click a variable name in the source window name and choose **QuickWatch**. This automatically places the variable into the **QuickWatch** dialog box.  
  
### To add a QuickWatch expression to the Watch window  
  
-   In the **QuickWatch** dialog box, click **Add Watch**.  
  
     Whatever expression was displayed in the **QuickWatch** dialog box is added to the list of expressions the **Watch** window.  
  
     If you are using a Visual Studio edition that supports multiple Watch windows, the expression is added to the **Watch1** window.  
  
## See Also  
 [How to: Use Debugger Variable Windows](../vs140/autos-and-locals-windows.md)   
 [Debugger Variable Windows](../vs140/variable-windows.md)